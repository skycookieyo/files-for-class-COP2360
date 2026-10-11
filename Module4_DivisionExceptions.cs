
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        Divide(input1, input2);
    }

    static void Divide(string first, string second)
    {
        try
        {
            int num1 = Convert.ToInt32(first);
            int num2 = Convert.ToInt32(second);

            int result = num1 / num2;

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Error: Please enter valid whole numbers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine(
                "Error: You cannot divide by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine(
                "Error: The number is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "Unexpected error: " + ex.Message);
        }
    }
}
