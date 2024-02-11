using Lab6;

Polygon polygon = new Polygon(new Point[] { 
    new Point(4,4),
    new Point(4,4),
    new Point(4,4),
    new Point(4,4)
    });

if (polygon.IsConvex())
    Console.WriteLine("Выпуклый");
else Console.WriteLine("Впуклый");