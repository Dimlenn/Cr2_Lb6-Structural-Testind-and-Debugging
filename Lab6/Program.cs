using Lab6;

Polygon polygon = new Polygon(new Point[] { 
    new Point(1,1),
    new Point(1,4),
    new Point(4,4),
    new Point(4,1),
    new Point(2,2)
    });

if (polygon.IsConvex())
    Console.WriteLine("Выпуклый");
else Console.WriteLine("Впуклый");