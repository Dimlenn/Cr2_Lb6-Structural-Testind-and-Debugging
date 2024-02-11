using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public struct Point
    {
        public double X { set; get; }
        public double Y { set; get; }
        public Point(double x, double y)
        {
            X = x; Y = y;
        }
    }
}
