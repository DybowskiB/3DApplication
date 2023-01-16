using ObjLoader.Loader.Loaders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using Windows.UI.Xaml.Media.Imaging;
using Point = System.Drawing.Point;

namespace FillingTriangleMesh
{
    // Class that represents the triangle mesh
    public class TriangleMesh
    {
        // List of triangles
        public List<Triangle> triangles { get; set; }
        public List<(Vector3 N0, Vector3 N1, Vector3 N2)> normals { get; set; }
        
        public int sizeUnits { get; set; }

        public LoadResult objData { get; }

        // Creating mesh
        public TriangleMesh(double width, double height, LoadResult objData, int scaleUnit = 10,
            double xShift = 0, double yShift = 0, double zShift = 0)
        {
            triangles = new List<Triangle>();
            normals = new List<(Vector3 N0, Vector3 N1, Vector3 N2)>();
            this.objData = objData;
            createMesh(width, height, scaleUnit, xShift, yShift, zShift);
        }

        /// <summary>
        /// Function that creats triangle mesh with specified width and height.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void createMesh(double width, double height, int unit, double xShift, double yShift, double zShift)
        {
            triangles.Clear();
            var vertices = objData.Vertices;
            var normals = objData.Normals;

            foreach (var group in objData.Groups)
            {
                var faces = group.Faces;
                Point centerPoint = new Point((int) width / 2, (int) height / 2);
                // resize triangle mesh to be 1/10 size of picturebox height
                int scaleUnit = unit * (int) height / 100;

                foreach (var face in faces)
                {
                    List<Vertex> triangleCoordinates = new List<Vertex>();
                    List<Vector3> normalsList = new List<Vector3>();
                    for (int i = 0; i < face.Count; ++i)
                    {
                        var vertex = vertices[face[i].VertexIndex - 1];
                        int x = (int) (centerPoint.X + xShift + vertex.X * scaleUnit);
                        int y = (int) (centerPoint.Y + yShift + vertex.Y * scaleUnit);
                        int z = (int) (zShift + vertex.Z * scaleUnit);
                        triangleCoordinates.Add(new Vertex(x, y, z));

                        var normal = normals[face[i].NormalIndex - 1];
                        normalsList.Add(new Vector3(normal.X, normal.Y, normal.Z));

                    }
                    triangles.Add(new Triangle(triangleCoordinates[0], triangleCoordinates[1], triangleCoordinates[2]));
                    this.normals.Add((normalsList[0], normalsList[1], normalsList[2]));
                }
            }
        }
    }
}
