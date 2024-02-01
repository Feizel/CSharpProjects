using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $"{beginning} there lived a family with a kid. {middle} and got the fruits for his family. {end}";

            // Print the story to the console 
            Console.WriteLine(story);


            /*
            You need to create the code to print a receipt for the customer purchasing shares of an investment product. 
            The shares are purchased automatically at the end of the year based on a series of payroll deductions, 
            so the number of shares purchased usually contains a decimal amount. 
            To print the receipt, you would likely need to combine data of different types, including fractional values, 
            currency, and percentages in precise ways.
            */

            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Shares: {productShares:N3} Product");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Billed: {total:C}");

            string paymentId = "769C";
            string payeeName = "Mr. Stephen Ortega";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);

            Console.WriteLine(formattedLine);

        }
    }
}
