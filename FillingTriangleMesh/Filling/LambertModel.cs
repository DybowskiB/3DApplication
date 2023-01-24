using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Drawing.Imaging;
using Windows.UI.Xaml.Media.Imaging;
using ObjLoader.Loader.Loaders;
using System.Numerics;

namespace FillingTriangleMesh
{
    public class LambertModel
    {
        // Coefficients
        public double kd { get; set; }
        public double ks { get; set; }
        public double m { get; set; }


        // Light color
        public Color lightColor { get; set; } = Color.White;

        public (double x, double y, double z) lightPosition = (1000, 50, 800);

        // Spotlights

        public int directionIndex { get; set; } = 0;

        public (double x, double y, double z) spotlight1Position = (0, 0, 0);
        public Vector3 spotlight1D = new Vector3(0, 1, 0);

        public (double x, double y, double z) spotlight2Position = (0, 800, 0);
        public Vector3 spotlight2D = new Vector3(0, 1, 0);

        // V vector

        public readonly Vector3 V = new Vector3(0, 0, 1);

        // Object color
        public Color objectColor { get; set; } = Color.LightGray;

        // Create Lambert model
        public LambertModel(double kd, double ks, double m)
        {
            this.kd = kd;
            this.ks = ks;
            this.m = m;
        }
    }
}
