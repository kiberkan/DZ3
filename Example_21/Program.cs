// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceXYZ(double ax, double bx, double zx, double ay, double by, double zy)
{
    double distanse = Math.Pow(ax-ay, 2)+Math.Pow(bx-by, 2)+Math.Pow(zx-zy,2);
    distanse = Math.Sqrt(distanse);

    return distanse;
}

System.Console.Write("Ведите кординату первой точки по оси X: ");
double ax = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите кординату первой точки по оси Y: ");
double bx = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите кординату первой точки по оси Z: ");
double zx = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите кординату второй точки по оси X: ");
double ay = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите кординату второй точки по оси Y: ");
double by = double.Parse(Console.ReadLine()!);
System.Console.Write("Ведите кординату второй точки по оси Z: ");
double zy = double.Parse(Console.ReadLine()!);


double result = DistanceXYZ(ax,bx,zx,ay,by,zy);
Console.WriteLine("Растояние между точками в 3D пространстве = " +string.Format("{0:0.00}", result));