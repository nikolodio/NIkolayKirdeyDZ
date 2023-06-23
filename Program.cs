Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    Console.Write("max number: " + b);
}
else
{
    Console.Write("max number: " + a);
}