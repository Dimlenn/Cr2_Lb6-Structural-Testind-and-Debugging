using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Polygon
    {
        private List<Point> vertices = new List<Point>();
        public Polygon(Point[] points)
        {
            foreach (Point p in points)
            {
                vertices.Add(p);
            }
        }

        public bool IsConvex()
        {
            var firstPoint = vertices.Last();
            var secondPoint = vertices.First();

            for (int i = 0; i < vertices.Count; i++)
            {
                if (!Check(firstPoint, secondPoint))
                    return false;

                if (i == (vertices.Count - 1))
                    break;

                firstPoint = vertices[i];
                secondPoint = vertices[i+1];
            }

            return true;
        }

        private bool Check(Point firstPoint, Point secondPoint)
        {
            foreach (Point p in vertices)
            {
                if (p.X <= firstPoint.X && p.X <= secondPoint.X)
                    continue;

                if (p.X >= firstPoint.X && p.X >= secondPoint.X)
                    continue;

                if (p.Y <= firstPoint.Y && p.Y <= secondPoint.Y)
                    continue;

                if (p.Y >= firstPoint.Y && p.Y >= secondPoint.Y)
                    continue;

                return false;
            }

            return true;
        }
    }
}
