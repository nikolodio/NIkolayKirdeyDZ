Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int digit = 1; digit <= number; digit++)
    if (digit % 2 == 0)
        Console.Write(digit + " ");