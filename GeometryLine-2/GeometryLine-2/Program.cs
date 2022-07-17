Console.WriteLine("Enter points for first line");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
double l1 = Math.Pow((x2 - x1), 2);
double l2 = Math.Pow((y2 - y1), 2);
double length = l1 + l2;
double line_lenght1 = Math.Sqrt(length);
//Console.WriteLine("Length of line 1 is " + line_lenght1);
Console.WriteLine("Enter points for second line");
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
double m1 = Math.Pow((a2 - a1), 2);
double m2 = Math.Pow((b2 - b1), 2);
double length2 = m1 + m2;
double line_lenght2 = Math.Sqrt(length2);
//Console.WriteLine("Length of line 2 is " + line_lenght2);
if (line_lenght1 == line_lenght2)
    Console.WriteLine("Two Lines are of Equal Length");
else
    Console.WriteLine("Lines are Not Equal");
