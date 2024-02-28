using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Polygon
    {
        private List<Point> vertices;
        public Polygon(Point[] points)
        {
            vertices = new List<Point>();
            foreach (Point p in points)
            {
                vertices.Add(p);
            }
        }

        public bool IsConvex()
        {
            // для первой точки массива
            var firstPoint = vertices.Last();
            var secondPoint = vertices[0];
            var thirdPoint = vertices[1];

            for (int i = 1; i <= vertices.Count; i++)
            {
                Point ab = new Point(
                    secondPoint.X - firstPoint.X,
                    secondPoint.Y - firstPoint.Y
                    );
                Point bc = new Point(
                    thirdPoint.X - secondPoint.X,
                    thirdPoint.Y - secondPoint.Y
                    );

                if (ab.X * bc.Y - ab.Y * bc.X > 0)
                    return false;

                if (i < vertices.Count - 1)
                {
                    firstPoint = vertices[i - 1];
                    secondPoint = vertices[i];
                    thirdPoint = vertices[i + 1];
                }
                // для баланса вселенной
                else
                {
                    firstPoint = vertices[i - 1];
                    if (i  == vertices.Count) break;
                    secondPoint = vertices[i];
                    thirdPoint = vertices.First();
                }
            }

            return true;
        }
    }
}
