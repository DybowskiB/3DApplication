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
        private const int endLocation = 400;
        private int xLocation = xStartLocation;
        private int stepX = 2, stepY =-1, stepZ = 1;
        private (int x, int y, int z) distance;

        private int vibrationsStep = 0;

        public bool vibrations { get; set; } = false;
        public bool isPlaying { get; set; } = false;
        public void moveObject(List<Triangle> triangles)
        {
            if (xLocation < -250 )
            {
                if (vibrations)
                {
                    if (vibrationsStep == 0)
                    {
                        stepX = 3 * upMoveStep;
                        stepY = 0;
                        stepZ = 1;
                        vibrationsStep = 1;
                    }
                    else
                    {
                        stepX = -upMoveStep;
                        stepY = 0;
                        stepZ = 0;
                        vibrationsStep = 0;
                    }
                    xLocation += stepX;
                }
                else
                {
                    xLocation += upMoveStep;
                    stepX = upMoveStep;
                    stepY = 0;
                    stepZ = 1;
                }
            }
            else if (xLocation < 200)
            {
                if (vibrations)
                {
                    if (vibrationsStep == 0)
                    {
                        stepX = 3 * straightMoveStep;
                        stepY = -2;
                        stepZ = 1;
                        vibrationsStep = 1;
                    }
                    else
                    {
                        stepX = -straightMoveStep;
                        stepY = 0;
                        stepZ = 0;
                        vibrationsStep = 0;
                    }
                    xLocation += stepX;
                }
                else
                {
                    xLocation += straightMoveStep;
                    stepX = straightMoveStep;
                    stepY = -2;
                    stepZ = 1;
                }
            }
            else
            {
                if (vibrations)
                {
                    if (vibrationsStep == 0)
                    {
                        stepX = 3 * downMoveStep;
                        stepY = 0;
                        stepZ = 1;
                        vibrationsStep = 1;
                    }
                    else
                    {
                        stepX = -downMoveStep;
                        stepY = 0;
                        stepZ = 0;
                        vibrationsStep = 0;
                    }
                    xLocation += stepX;
                }
                else
                {
                    xLocation += downMoveStep;
                    stepX = downMoveStep;
                    stepY = 0;
                    stepZ = 1;
                }
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
            return new Vector3(cameraTarget.X + distance.x, cameraTarget.Y + distance.y, 0);
        }
    }
}
