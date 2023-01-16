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

        public (double x, double y, double z) lightPosition = (1250, 200, 300);

        // V vector

        public readonly Vector3 V = new Vector3(0, 0, 1);

        // Object color
        public Color objectColor { get; set; } = Color.White;

        // Create Lambert model
        public LambertModel(double kd, double ks, double m)
        {
            this.kd = kd;
            this.ks = ks;
            this.m = m;
        }
    }
}
