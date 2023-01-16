using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingTriangleMesh
{
    public class Triangle
    {
        public Vertex P0 { get; set; }
        public Vertex P1 { get; set; }
        public Vertex P2 { get; set; }

        public Triangle(Vertex P0, Vertex P1, Vertex P2)
        {
            this.P0 = P0;
            this.P1 = P1;
            this.P2 = P2;
        }
    }
}
