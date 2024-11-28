double pi = 3.141592653;
double r = double.Parse(Console.ReadLine());
double area = pi * r * r;
double areaRounded = Math.Round(area, 9);
Console.WriteLine(areaRounded);