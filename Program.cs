Console.WriteLine("Enter the first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a < b)
{
    Console.Write("max number: " + b);
}
else
{
    Console.Write("max number: " + a);
}
