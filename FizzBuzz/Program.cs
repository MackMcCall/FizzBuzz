using FizzBuzz;

while (true)
{
    Console.Write("What number would you like to enter into the FizzBuzz?: ");
    if (!int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Invalid Input, Try Again");
    }
    else
        Console.WriteLine(Fizzing.FizzBuzz(number));
        return;
}