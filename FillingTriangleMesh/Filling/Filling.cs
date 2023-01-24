using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace FillingTriangleMesh
{
    // Class responsible for filling triangles
    public class Filling
    {
        public LambertModel lambertModel { get; set; }
        public TriangleMesh planeTriangleMesh { get; set; }
        public TriangleMesh sphereTriangleMesh { get; set; }
        public TriangleMesh cloud1TriangleMesh { get; set; }
        public TriangleMesh cloud2TriangleMesh { get; set; }
        public TriangleMesh cloud3TriangleMesh { get; set; }
        public Animation animation { get; set; }
        private PictureBox pictureBox { get; set; }
        private List<Triangle> resultTriangles { get; set; }
        private List<(Vector3 N0, Vector3 N1, Vector3 N2)> resultNormals { get; set; }
        private List<Triangle> staticObjectsTriangles { get; set; }
        private List<(Vector3 N0, Vector3 N1, Vector3 N2)> staticObjectsNormals { get; set; }
        private float[,] ZBuffer { get; set; }
        private const int maxZbufferWidth = 2000;
        private const int maxZbufferHeight = 1500;

        public Filling(LambertModel lambertModel, TriangleMesh planeTriangleMesh, TriangleMesh sphereTriangleMesh,
            TriangleMesh cloud1TriangleMesh, TriangleMesh cloud2TriangleMesh, TriangleMesh cloud3TriangleMesh, 
            PictureBox pictureBox)
        {
            this.lambertModel = lambertModel;
            this.planeTriangleMesh = planeTriangleMesh;
            this.sphereTriangleMesh = sphereTriangleMesh;
            this.cloud1TriangleMesh = cloud1TriangleMesh;
            this.cloud2TriangleMesh = cloud2TriangleMesh;
            this.cloud3TriangleMesh = cloud3TriangleMesh;
            this.animation = new Animation();
            this.pictureBox = pictureBox;

            cameraPosition = new Vector3(0, 0, 0);
            cameraTarget = new Vector3(0.1F, 0.1F, 0.1F);
            cameraUpVector = new Vector3(0, 0, 1);
            aspectRatio = 1;
            nearPlaneDistance = 1;
            farPlaneDistance = 100;
            FOV = 75;
            planeAngleY = 0;
            planeModelMatrixY = Matrix4x4.CreateRotationY(planeAngleY);
            lookMatrix = Matrix4x4.CreateLookAt(cameraPosition, cameraTarget, cameraUpVector);
            perspectiveMatrix = Matrix4x4.CreatePerspectiveFieldOfView(fov, aspectRatio, nearPlaneDistance, farPlaneDistance);

            InitializeZBuffer();
        }

        public void InitializeZBuffer()
        {
            ZBuffer = new float[maxZbufferWidth, maxZbufferHeight];
            for (int i = 0; i < maxZbufferWidth; ++i)
                for (int j = 0; j < maxZbufferHeight; ++j)
                    ZBuffer[i, j] = float.MaxValue;
        }

        // Drawing

        private Triangle currentTriangle = null;
        private (Vector3 N0, Vector3 N1, Vector3 N2) currentNormals;

        public void redraw(PictureBox pictureBox)
        {
            InitializeZBuffer();
            // Transformation
            planeAngleY = animation.changeAngle(planeAngleY);
            transformTriangles();
            resultTriangles.AddRange(staticObjectsTriangles);
            resultNormals.AddRange(staticObjectsNormals);

            if (cameraIndex == 1)
                moveCameraPosition();

            Bitmap bitmap;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics gfx = Graphics.FromImage(bitmap))
            {
                using (SolidBrush brush = new SolidBrush(Color.SkyBlue))
                {
                    gfx.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
                }
            }

            // Filling triangles
            fillTriangles(bitmap);

            pictureBox.Image.Dispose();
            pictureBox.Image = bitmap;
        }

        // Animation

        // Transformation matrices
        private Matrix4x4 planeModelMatrixY;
        private Matrix4x4 lookMatrix;
        private Matrix4x4 perspectiveMatrix;


        // Camera variables

        private Vector3 cameraPosition;
        public Vector3 CameraPosition
        {
            get => cameraPosition;
            set
            {
                cameraPosition = value;
                lookMatrix = Matrix4x4.CreateLookAt(cameraPosition, cameraTarget, cameraUpVector);
            }
        }

        private Vector3 cameraTarget;
        public Vector3 CameraTarget
        {
            get => cameraTarget;
            set
            {
                cameraTarget = value;
                lookMatrix = Matrix4x4.CreateLookAt(cameraPosition, cameraTarget, cameraUpVector);
            }
        }

        private Vector3 cameraUpVector;
        public Vector3 CameraUpVector
        {
            get => cameraUpVector;
            set
            {
                cameraUpVector = value;
                lookMatrix = Matrix4x4.CreateLookAt(cameraPosition, cameraTarget, cameraUpVector);
            }
        }

        private float fov;
        public float FOV
        {
            get => fov;
            set
            {
                fov = (float)(value * Math.PI / 180);
                perspectiveMatrix = Matrix4x4.CreatePerspectiveFieldOfView(fov, aspectRatio, nearPlaneDistance, farPlaneDistance);
            }
        }


        private float angleY;
        public float planeAngleY
        {
            get => angleY;
            set
            {
                angleY = (float)(value * Math.PI / 180);
                planeModelMatrixY = Matrix4x4.CreateRotationZ(angleY);
            }
        }

        private float aspectRatio;
        public float AspectRatio
        {
            get => aspectRatio;
            set
            {
                aspectRatio = value;
                perspectiveMatrix = Matrix4x4.CreatePerspectiveFieldOfView(fov, aspectRatio, nearPlaneDistance, farPlaneDistance);
            }
        }

        private float nearPlaneDistance;
        public float NearPlaneDistance
        {
            get => nearPlaneDistance;
            set
            {
                nearPlaneDistance = value;
                perspectiveMatrix = Matrix4x4.CreatePerspectiveFieldOfView(fov, aspectRatio, nearPlaneDistance, farPlaneDistance);
            }
        }

        private float farPlaneDistance;
        public float FarPlaneDistance
        {
            get => farPlaneDistance;
            set
            {
                farPlaneDistance = value;
                perspectiveMatrix = Matrix4x4.CreatePerspectiveFieldOfView(fov, aspectRatio, nearPlaneDistance, farPlaneDistance);
            }
        }

        // Shading

        public enum Shading{
            Constant = 0,
            Phong = 1,
            Gouraud = 2
        }

        private Color constantShadingColor;
        private Color gouraudVertex0Color;
        private Color gouraudVertex1Color;
        private Color gouraudVertex2Color;
        public Shading shading { get; set; } = Shading.Phong;

        /// <summary>
        /// Function that draws mesh.
        /// </summary>
        /// <param name = "pictureBox" ></ param >
        public void drawMesh(PictureBox pictureBox)
        {
            using (Graphics graphics = Graphics.FromImage(pictureBox.Image))
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Black, 1))
                {
                    foreach (var triangle in resultTriangles)
                    {
                        Point p0 = new Point((int)triangle.P0.X, (int)triangle.P0.Y);
                        Point p1 = new Point((int)triangle.P1.X, (int)triangle.P1.Y);
                        Point p2 = new Point((int)triangle.P2.X, (int)triangle.P2.Y);

                        graphics.DrawLine(pen, p0, p1);
                        graphics.DrawLine(pen, p1, p2);
                        graphics.DrawLine(pen, p2, p0);
                    }
                }
            }
        }


        // Filling triangles

        public void fillTriangles(Bitmap bitmap)
        {
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            for (int i = 0; i < resultTriangles.Count; ++i)
            {
                currentTriangle = resultTriangles[i];
                currentNormals = resultNormals[i];
                fillTriangle(data);
            }
            bitmap.UnlockBits(data);
        }


        private void fillTriangle(BitmapData bitmap)
        {
            if (shading == Shading.Constant)
                calculateConstantFillColor();
            else if (shading == Shading.Gouraud)
                calculateColorInVertices();
            ScanLineAlgorithm scanLineAlgorithm = new ScanLineAlgorithm(ScanLineAlgorithm.convertTriangleToPointsList(currentTriangle));
            foreach (var (xRange, y) in scanLineAlgorithm.getPoints())
            {
                fillRow(bitmap, xRange, y);
            }
        }

        private void fillRow(BitmapData bitmap, List<int> xRange, int y)
        {
            if (xRange.Count == 0) return;
            for (int i = xRange[0]; i <= xRange[xRange.Count - 1]; i++)
            {
                if (i > 0 && i < bitmap.Width && y > 0 && y < bitmap.Height)
                {
                    var point = new Point(i, y);
                    (double b0, double b1, double b2) barycentric = getBarycentricCoordinates(point, currentTriangle.P0,
                        currentTriangle.P1, currentTriangle.P2);
                    var z = (float)(barycentric.b0 * currentTriangle.P0.Z + barycentric.b1 * currentTriangle.P1.Z +
                        barycentric.b2 * currentTriangle.P2.Z);

                    if (z <= ZBuffer[i, y])
                    {
                        Color color = constantShadingColor;
                        if(shading == Shading.Phong)
                            color = calculatePhongFillColor(new Point(i, y), lambertModel.objectColor, barycentric);
                        else if(shading == Shading.Gouraud)
                            color = calculateGouraudFillColor(barycentric);

                        unsafe
                        {
                            byte* ptr = (byte*)bitmap.Scan0;
                            ptr[(i * 3) + y * bitmap.Stride] = color.B;
                            ptr[(i * 3) + y * bitmap.Stride + 1] = color.G;
                            ptr[(i * 3) + y * bitmap.Stride + 2] = color.R;
                        }
                        //bitmap.SetPixel(i, y, color);
                        ZBuffer[i, y] =  z;
                    }
                }
            }
        }

        /// <summary>
        /// Function calculates color using lambert model
        /// </summary>
        /// <param name="point"></param>
        /// <param name="color"></param>
        /// <returns>Calculated color in point with constant shading</returns>
        public void calculateConstantFillColor()
        {
            Point point0 = new Point((int) currentTriangle.P0.X, (int) currentTriangle.P0.Y);
            Point point1 = new Point((int) currentTriangle.P1.X, (int) currentTriangle.P1.Y);
            Point point2 = new Point((int) currentTriangle.P2.X, (int) currentTriangle.P2.Y);
            (double b0, double b1, double b2) barycentric0 = getBarycentricCoordinates(point0, currentTriangle.P0,
                        currentTriangle.P1, currentTriangle.P2);
            (double b0, double b1, double b2) barycentric1 = getBarycentricCoordinates(point1, currentTriangle.P0,
                        currentTriangle.P1, currentTriangle.P2);
            (double b0, double b1, double b2) barycentric2 = getBarycentricCoordinates(point2, currentTriangle.P0,
                        currentTriangle.P1, currentTriangle.P2);
            var color0 = calculatePhongFillColor(point0, lambertModel.objectColor, barycentric0);
            var color1 = calculatePhongFillColor(point1, lambertModel.objectColor, barycentric1);
            var color2 = calculatePhongFillColor(point2, lambertModel.objectColor, barycentric2);

            byte R = (byte)Math.Min(((double)color0.R + (double)color1.R + (double)color2.R) / 3, 255);
            byte G = (byte)Math.Min(((double)color0.G + (double)color1.G + (double)color2.G) / 3, 255);
            byte B = (byte)Math.Min(((double)color0.B + (double)color1.B + (double)color2.B) / 3, 255);

            constantShadingColor = Color.FromArgb(R, G, B);
        }

        /// <summary>
        /// Function calculates color using lambert model
        /// </summary>
        /// <param name="point"></param>
        /// <param name="color"></param>
        /// <returns>Calculated color in point with Phong shading</returns>
        public Color calculatePhongFillColor(Point point, Color color, (double b0, double b1, double b2) barycentric)
        {
            double r = ((double)color.R / 255) * ((double)lambertModel.lightColor.R / 255);
            double g = ((double)color.G / 255) * ((double)lambertModel.lightColor.G / 255);
            double b = ((double)color.B / 255) * ((double)lambertModel.lightColor.B / 255);

            Vector3 N = getNormalVector(barycentric);
            Vector3 L = Vector3.Normalize(new Vector3((float) lambertModel.lightPosition.x - point.X, (float) lambertModel.lightPosition.y - point.Y,
                (float) lambertModel.lightPosition.z));

            Vector3 RVector = 2 * Vector3.Dot(N, L) * N - L; 

            double cosNL = Math.Max(Vector3.Dot(N, L), 0);
            double cosmVR = Math.Pow(Math.Max(Vector3.Dot(lambertModel.V, RVector), 0), lambertModel.m);

            // Spotlight
            double ISpotlight1 = getSpotlightIntensity(lambertModel.spotlight1Position, lambertModel.spotlight1D, point);
            double ISpotlight2 = getSpotlightIntensity(lambertModel.spotlight2Position, lambertModel.spotlight2D, point);

            double R = lambertModel.kd * r * cosNL + lambertModel.ks * r * cosmVR + r * ISpotlight1 + r * ISpotlight2;
            double G = lambertModel.kd * g * cosNL + lambertModel.ks * g * cosmVR + g * ISpotlight1 + g * ISpotlight2;
            double B = lambertModel.kd * b * cosNL + lambertModel.ks * b * cosmVR + b * ISpotlight1 + b * ISpotlight2;

            byte Rb = (byte)Math.Min(R * 255, 255);
            byte Gb = (byte)Math.Min(G * 255, 255);
            byte Bb = (byte)Math.Min(B * 255, 255);

            return Color.FromArgb(Rb, Gb, Bb);
        }

        public double getSpotlightIntensity((double x, double y, double z) spotlightPosition, Vector3 D, Point point)
        {
            Vector3 LStaticSpotlight = Vector3.Normalize(new Vector3(
                (float)spotlightPosition.x - point.X,
                (float)spotlightPosition.y - point.Y,
                (float)spotlightPosition.z));
            return Math.Pow(Math.Max(Vector3.Dot(-D, LStaticSpotlight), 0), lambertModel.m);
        }

        /// <summary>
        /// Function calculates color using lambert model
        /// </summary>
        /// <param name="point"></param>
        /// <param name="color"></param>
        /// <returns>Calculated color in point with Gouraud shading</returns>
        public Color calculateGouraudFillColor((double b0, double b1, double b2) barycentric)
        {

            double R = (Math.Min(barycentric.b0 * ((double)gouraudVertex0Color.R / 255) +
                barycentric.b1 * ((double)gouraudVertex1Color.R / 255) + barycentric.b2 * ((double)gouraudVertex2Color.R / 255), 1));
            double G = (Math.Min(barycentric.b0 * ((double)gouraudVertex0Color.G / 255)+ 
                barycentric.b1 * ((double)gouraudVertex1Color.G / 255) + barycentric.b2 * ((double)gouraudVertex2Color.G / 255), 1));
            double B = (Math.Min(barycentric.b0 * ((double)gouraudVertex0Color.B / 255)+
                barycentric.b1 * ((double)gouraudVertex1Color.B / 255) + barycentric.b2 * ((double)gouraudVertex2Color.B / 255), 1));

            return Color.FromArgb((byte) (R * 255), (byte) (G * 255), (byte) (B * 255));
        }

        private void calculateColorInVertices()
        {
            Point point0 = new Point((int)currentTriangle.P0.X, (int)currentTriangle.P0.Y);
            Point point1 = new Point((int)currentTriangle.P1.X, (int)currentTriangle.P1.Y);
            Point point2 = new Point((int)currentTriangle.P2.X, (int)currentTriangle.P2.Y);
            (double b0, double b1, double b2) barycentric0 = getBarycentricCoordinates(point0, currentTriangle.P0,
                        currentTriangle.P1, currentTriangle.P2);
            (double b0, double b1, double b2) barycentric1 = getBarycentricCoordinates(point1, currentTriangle.P0,
                        currentTriangle.P1, currentTriangle.P2);
            (double b0, double b1, double b2) barycentric2 = getBarycentricCoordinates(point2, currentTriangle.P0,
                        currentTriangle.P1, currentTriangle.P2);
            gouraudVertex0Color = calculatePhongFillColor(point0, lambertModel.objectColor, barycentric0);
            gouraudVertex1Color = calculatePhongFillColor(point1, lambertModel.objectColor, barycentric1);
            gouraudVertex2Color = calculatePhongFillColor(point2, lambertModel.objectColor, barycentric2);
        }

        /// <summary>
        /// Function determine normal vector for point. Returns the default normal vector or
        /// interpolated vector from normal map's normal vector using triangle barycentric coordinates
        /// </summary>
        /// <param name="point"></param>
        /// <returns>Normal vector in point</returns>
        public Vector3 getNormalVector((double b0, double b1, double b2) barycentric)
        {
            double x = currentNormals.N0.X * barycentric.b0 + currentNormals.N1.X * barycentric.b1 + currentNormals.N2.X * barycentric.b2;
            double y = currentNormals.N0.Y * barycentric.b0 + currentNormals.N1.Y * barycentric.b1 + currentNormals.N2.Y * barycentric.b2;
            double z = currentNormals.N0.Z * barycentric.b0 + currentNormals.N1.Z * barycentric.b1 + currentNormals.N2.Z * barycentric.b2;

            return Vector3.Normalize(new Vector3((float)x, (float)y, (float)z));
        }

        /// <summary>
        /// Function calculates barycentric coordinates for point p and triangle specified by coordinates p0, p1
        /// and p2.
        /// </summary>
        /// <param name="p">For this point coordinates are calculated</param>
        /// <param name="p0">Triangle vertex</param>
        /// <param name="p1">Triangle vertex</param>
        /// <param name="p2">triangle vertex</param>
        /// <returns>Barycentric coordinates for p in triangle 'p0-p1-p2'</returns>
        private (double b0, double b1, double b2) getBarycentricCoordinates(Point p, Vertex p0, Vertex p1,
            Vertex p2)
        {
            Vector2 v0 = new Vector2(p1.X - p0.X, p1.Y - p0.Y);
            Vector2 v1 = new Vector2(p2.X - p0.X, p2.Y - p0.Y);
            Vector2 v2 = new Vector2(p.X - p0.X, p.Y - p0.Y);

            double d00 = Vector2.Dot(v0, v0);
            double d01 = Vector2.Dot(v0, v1);
            double d11 = Vector2.Dot(v1, v1);
            double d20 = Vector2.Dot(v2, v0);
            double d21 = Vector2.Dot(v2, v1);

            double invdenom = 1.0f / (d00 * d11 - d01 * d01);
            double b0 = Math.Max((d11 * d20 - d01 * d21) * invdenom, 0);
            double b1 = Math.Max((d00 * d21 - d01 * d20) * invdenom, 0);
            double b2 = Math.Max(1.0f - (b0 + b1), 0);

            return (Math.Min(b2, 1), Math.Min(b0, 1), Math.Min(b1, 1));
        }

        // Transformations 


        /// <summary>
        /// Function transform vertex
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns>Transformed vertex</returns>
        private Vertex transfromVertex(Vertex vertex, Matrix4x4 modelMatrix)
        {
            var vertexVector = new Vector4(vertex.X - pictureBox.Width / 2, vertex.Y - pictureBox.Height / 2, vertex.Z, 1);
            var result = Vector4.Transform(vertexVector, perspectiveMatrix * lookMatrix * modelMatrix);
            var newVertex = new Vertex(pictureBox.Width / 2 + result.X,
                                       pictureBox.Height / 2 + result.Y,
                                       result.Z);
            return newVertex;
        }

        private Vector3 transformNormal(Vector3 normal, Matrix4x4 modelMatrix)
        {
            var newNormal = Vector3.TransformNormal(normal, perspectiveMatrix * lookMatrix * modelMatrix);

            return newNormal;
        }

        public void transformStaticObjects()
        {
            staticObjectsTriangles = new List<Triangle>();
            staticObjectsNormals = new List<(Vector3 N0, Vector3 N1, Vector3 N2)>();

            for (int i = 0; i < sphereTriangleMesh.triangles.Count; ++i)
            {
                Vertex P0 = transfromVertex(sphereTriangleMesh.triangles[i].P0, Matrix4x4.Identity);
                Vertex P1 = transfromVertex(sphereTriangleMesh.triangles[i].P1, Matrix4x4.Identity);
                Vertex P2 = transfromVertex(sphereTriangleMesh.triangles[i].P2, Matrix4x4.Identity);

                Vector3 N0 = transformNormal(sphereTriangleMesh.normals[i].N0, Matrix4x4.Identity);
                Vector3 N1 = transformNormal(sphereTriangleMesh.normals[i].N1, Matrix4x4.Identity);
                Vector3 N2 = transformNormal(sphereTriangleMesh.normals[i].N2, Matrix4x4.Identity);

                staticObjectsTriangles.Add(new Triangle(P0, P1, P2));
                staticObjectsNormals.Add((N0, N1, N2));
            }

            for (int i = 0; i < cloud1TriangleMesh.triangles.Count; ++i)
            {
                Vertex P0 = transfromVertex(cloud1TriangleMesh.triangles[i].P0, Matrix4x4.Identity);
                Vertex P1 = transfromVertex(cloud1TriangleMesh.triangles[i].P1, Matrix4x4.Identity);
                Vertex P2 = transfromVertex(cloud1TriangleMesh.triangles[i].P2, Matrix4x4.Identity);

                Vector3 N0 = transformNormal(cloud1TriangleMesh.normals[i].N0, Matrix4x4.Identity);
                Vector3 N1 = transformNormal(cloud1TriangleMesh.normals[i].N1, Matrix4x4.Identity);
                Vector3 N2 = transformNormal(cloud1TriangleMesh.normals[i].N2, Matrix4x4.Identity);

                staticObjectsTriangles.Add(new Triangle(P0, P1, P2));
                staticObjectsNormals.Add((N0, N1, N2));
            }

            for (int i = 0; i < cloud2TriangleMesh.triangles.Count; ++i)
            {
                Vertex P0 = transfromVertex(cloud2TriangleMesh.triangles[i].P0, Matrix4x4.Identity);
                Vertex P1 = transfromVertex(cloud2TriangleMesh.triangles[i].P1, Matrix4x4.Identity);
                Vertex P2 = transfromVertex(cloud2TriangleMesh.triangles[i].P2, Matrix4x4.Identity);

                Vector3 N0 = transformNormal(cloud2TriangleMesh.normals[i].N0, Matrix4x4.Identity);
                Vector3 N1 = transformNormal(cloud2TriangleMesh.normals[i].N1, Matrix4x4.Identity);
                Vector3 N2 = transformNormal(cloud2TriangleMesh.normals[i].N2, Matrix4x4.Identity);

                staticObjectsTriangles.Add(new Triangle(P0, P1, P2));
                staticObjectsNormals.Add((N0, N1, N2));
            }

            for (int i = 0; i < cloud3TriangleMesh.triangles.Count; ++i)
            {
                Vertex P0 = transfromVertex(cloud3TriangleMesh.triangles[i].P0, Matrix4x4.Identity);
                Vertex P1 = transfromVertex(cloud3TriangleMesh.triangles[i].P1, Matrix4x4.Identity);
                Vertex P2 = transfromVertex(cloud3TriangleMesh.triangles[i].P2, Matrix4x4.Identity);

                Vector3 N0 = transformNormal(cloud3TriangleMesh.normals[i].N0, Matrix4x4.Identity);
                Vector3 N1 = transformNormal(cloud3TriangleMesh.normals[i].N1, Matrix4x4.Identity);
                Vector3 N2 = transformNormal(cloud3TriangleMesh.normals[i].N2, Matrix4x4.Identity);

                staticObjectsTriangles.Add(new Triangle(P0, P1, P2));
                staticObjectsNormals.Add((N0, N1, N2));
            }
        }

        public void transformTriangles()
        {
            resultTriangles = new List<Triangle>();
            resultNormals = new List<(Vector3 N0, Vector3 N1, Vector3 N2)>();

            Matrix4x4 modelMatrix = Matrix4x4.Identity;
            if (animation.isPlaying)
                modelMatrix = planeModelMatrixY;

            for (int i = 0; i < planeTriangleMesh.triangles.Count; ++i)
            {
                Vertex P0 = transfromVertex(planeTriangleMesh.triangles[i].P0, modelMatrix);
                Vertex P1 = transfromVertex(planeTriangleMesh.triangles[i].P1, modelMatrix);
                Vertex P2 = transfromVertex(planeTriangleMesh.triangles[i].P2, modelMatrix);

                Vector3 N0 = transformNormal(planeTriangleMesh.normals[i].N0, modelMatrix);
                Vector3 N1 = transformNormal(planeTriangleMesh.normals[i].N1, modelMatrix);
                Vector3 N2 = transformNormal(planeTriangleMesh.normals[i].N2, modelMatrix);

                resultTriangles.Add(new Triangle(P0, P1, P2));
                resultNormals.Add((N0, N1, N2));
            }

            lambertModel.spotlight1Position = (resultTriangles[0].P0.X, resultTriangles[0].P0.Y, resultTriangles[0].P0.Z);
           // lambertModel.spotlight2Position = (resultTriangles[0].P0.X, resultTriangles[0].P0.Y, resultTriangles[0].P0.Z);
        }


        private int cameraIndex = 0;
        public void switchCameraType()
        {
            cameraIndex = (++cameraIndex) % 3;
            if(cameraIndex == 1)
            {
                moveCameraPosition();
            }
            else if(cameraIndex == 2)
            {
                savedCameraTarget = new Vector3(0, 200, 0);
                moveCameraTarget();
            }
            else
            {
                CameraPosition = new Vector3(0, 0, 0);
                CameraTarget = new Vector3(0.1F, 0.1F, 0.1F);
            }
            transformStaticObjects();
        }

        private void moveCameraPosition()
        {
            var p = resultTriangles[0].P0;
            var xShift = pictureBox.Width / 2 - p.X;
            var yShift = pictureBox.Height / 2 - p.Y;

            for(int i = 0; i < resultTriangles.Count; ++i)
            {
                var t = resultTriangles[i];
                resultTriangles[i] = new Triangle(new Vertex(t.P0.X + xShift, t.P0.Y + yShift, t.P0.Z),
                                                  new Vertex(t.P1.X + xShift, t.P1.Y + yShift, t.P1.Z),
                                                  new Vertex(t.P2.X + xShift, t.P2.Y + yShift, t.P2.Z));
            }
        }

        private Vector3 savedCameraTarget;
        public void moveCameraTarget()
        {
            if (cameraIndex != 2) return;
            CameraTarget = animation.moveCameraTarget(savedCameraTarget);
            transformStaticObjects();
        }

        // Vibrations
        public void turnOnVibrations()
        {
            animation.vibrations = true;
        }

        public void turnOffVibrations()
        {
            animation.vibrations = false;
        }
    }
}
