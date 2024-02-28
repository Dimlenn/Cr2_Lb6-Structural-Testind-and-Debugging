using System;
using System.Collections.Generic;
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
            var firstPoint = vertices.Last();
            var secondPoint = vertices.First();

            for (int i = 0; i < vertices.Count - 1; i++)
            {
                if (!Check(firstPoint, secondPoint))
                    return false;

                firstPoint = vertices[i];
                secondPoint = vertices[i+1];
            }

            return true;
        }

        private bool Check(Point firstPoint, Point secondPoint)
        {
            // надо строить функцию и по ней проверять удовлетворяет прямой или нет
            // если частное x/y = коэф, то точка принадлежит прямой, если x/y > коэф, то точка с одной стороны, если x/y < коэф, то точка с другой
            List<Point> leftPoints = new List<Point>();
            List<Point> rightPoints = new List<Point>();

            foreach (Point p in vertices)
            {
                if (p.X == firstPoint.X && p.Y == firstPoint.Y
                   || p.X == secondPoint.X && p.Y == secondPoint.Y)
                    continue;

                if (p.X <= firstPoint.X && p.X <= secondPoint.X
                    || p.Y <= firstPoint.Y && p.Y <= secondPoint.Y)
                    leftPoints.Add(p);

                else
                if (p.X >= firstPoint.X && p.X >= secondPoint.X
                    || p.Y >= firstPoint.Y && p.Y >= secondPoint.Y)
                    rightPoints.Add(p);
            }
            if (leftPoints.Count == 0 || rightPoints.Count == 0)
                return true;
            else
                return false;
        }
    }
}
