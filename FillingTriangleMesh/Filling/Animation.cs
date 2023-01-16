using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FillingTriangleMesh
{
    public class Animation
    {
        private const int upMoveStep = 2;
        private const int straightMoveStep = 3;
        private const int downMoveStep = 4;
        private const float moveAngle = 0.2F;
        private const int xStartLocation = -500;
        private const int endLocation = 500;
        private int xLocation = xStartLocation;
        private int stepX = 2, stepY =-1, stepZ = 1;
        private (int x, int y, int z) distance;

        public bool isPlaying { get; set; } = false;
        public void moveObject(List<Triangle> triangles)
        {
            if (xLocation < -250)
            {
                xLocation += upMoveStep;
                stepX = upMoveStep;
                stepY = 0;
            }
            else if (xLocation < 200)
            {
                xLocation += straightMoveStep;
                stepX = straightMoveStep;
                stepY = -2;
            }
            else
            {
                xLocation += downMoveStep;
                stepX = downMoveStep;
                stepY = 0;
            }

            distance = (distance.x + stepX, distance.y + stepY, distance.z + stepZ);

            for (int i = 0; i < triangles.Count; ++i)
            {
                var t = triangles[i];
                triangles[i] = new Triangle(new Vertex(t.P0.X + stepX, t.P0.Y + stepY, t.P0.Z + stepZ),
                                            new Vertex(t.P1.X + stepX, t.P1.Y + stepY, t.P1.Z + stepZ),
                                            new Vertex(t.P2.X + stepX, t.P2.Y + stepY, t.P2.Z + stepZ));
            }
        }

        public float changeAngle(float planeAngleY)
        {
            if (xLocation < -250)
                return (float)((planeAngleY * 180) / Math.PI + moveAngle) % 360;
            if ( xLocation < 150) 
                return (float)((planeAngleY * 180) / Math.PI) % 360;
            if(xLocation < 250)
                return (float)((planeAngleY * 180) / Math.PI + 3 * moveAngle) % 360;
            return (float)((planeAngleY * 180) / Math.PI + 2 * moveAngle) % 360;
        }

        public bool end()
        {
            if (xLocation >= endLocation)
            {
                xLocation = xStartLocation;
                isPlaying = false;
                return true;
            }
            return false;
        }

        public Vector3 moveCameraTarget(Vector3 cameraTarget)
        {
            return new Vector3(cameraTarget.X + distance.x, cameraTarget.Y + distance.y, cameraTarget.Z + distance.z);
        }
    }
}
