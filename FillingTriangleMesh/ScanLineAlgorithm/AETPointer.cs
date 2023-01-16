using System;
using System.Collections.Generic;
using System.Text;

namespace FillingTriangleMesh
{
    /// <summary>
    /// Class that represents the values stored in active edge table (AET table).
    /// </summary>
    public class AETPointer
    {
        public int yMax { get; set; }
        public double x { get; set; }
        private double inverseM { get; set; }

        // Get rounded value of x
        public int intX { get => (int) Math.Round(x); }

        // Minimum value of m
        public const double minM = 1e-9;

        public AETPointer(double yMax = 0, double x = 0, double m = 0)
        {
            this.yMax = (int) yMax;
            this.x = x;
            this.inverseM = 1 / m;
        }

        public void move()
        {
            x = inverseM == double.PositiveInfinity ? double.PositiveInfinity : x + inverseM;
        }
    }
} 