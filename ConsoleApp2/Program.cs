Console.WriteLine("Enter the x value: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y value: ");
int y = Convert.ToInt32(Console.ReadLine());

double res1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
double res2 = Math.Abs(x) * Math.Sin(x);
double res3 = 2 * Math.PI * x;
double res4 = Math.Max(x, y);
Console.WriteLine($"First number is {res1}, second one is {res2}, third is {res3} and the last one is {res4}");