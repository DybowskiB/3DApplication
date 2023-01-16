using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingTriangleMesh
{
    public class Vertex
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Vertex(float X, float Y, float Z) 
        { 
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
