using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ttriangle : IShape
    {
        //private double A;
        //private double B;
        //private double C;
        private double[] sides = new double[3];
        private double maxSide
        {
            get
            {
                double res = sides[0];
                if (sides[1] > res) res = sides[1];
                if (sides[2] > res) res = sides[2];
                return res;
                //Math.Max(Math.Max(A, B), Math.Max(B, C)); 
            }
        }
        public Ttriangle(double A, double B, double C)
        {
            if (A <= 0) { throw new ArgumentException("Sides of triangel must have positive values", "A"); }
            if (B <= 0) { throw new ArgumentException("Sides of triangel must have positive values", "B"); }
            if (C <= 0) { throw new ArgumentException("Sides of triangel must have positive values", "C"); }
            sides[0] = A; sides[1] = B; sides[2] = C;
            if ((maxSide * 2) >= (A + B + C))
            {
                throw new ArgumentException("None of sides of the triangle can be greater than sum of others");
            }
            //this.A = A; this.B = B; this.C = C;
        }
        public double GetArea()
        {
            //            double p = (A + B + C) / 2;
            //return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            double p = 0;
            foreach (double s in sides) p += s;
            p /= 2;
            double r = p;
            foreach (double s in sides) r *= p - s;
            return Math.Sqrt(r);
        }
        public bool IsRight()
        {
            double m = maxSide;
            int maxSideIdx = -1;
            double othersQS = 0;
            for (int i = 0; i < 3; i++) if (sides[i] == maxSide) maxSideIdx = i;
            for (int i = 0; i < 3; i++)
            {
                if (i== maxSideIdx) continue;
                othersQS += sides[i] * sides[i];
            }

            return Math.Abs(1-maxSide*maxSide/othersQS)<0.0000001;
        }
    }
}
