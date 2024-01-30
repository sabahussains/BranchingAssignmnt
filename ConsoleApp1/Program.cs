using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for package weight
        Console.Write("Please enter the package weight: ");
        double weight = double.Parse(Console.ReadLine());

        // Check if the weight is greater than 50
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt the user for package dimensions
        Console.Write("Please enter the package width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        double length = double.Parse(Console.ReadLine());

        // Calculate the total dimensions
        double dimensionsTotal = width + height + length;

        // Check if dimensions total is greater than 50
        if (dimensionsTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the quote
        double quote = (width * height * length * weight) / 100;

        // Display the quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}



