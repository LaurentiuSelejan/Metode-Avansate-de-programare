using System;
using System.Data;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                // Prompt the user for an expression
                Console.WriteLine("Enter a mathematical expression (or type 'exit' to quit):");
                string input = Console.ReadLine().Trim();

                // Exit condition
                if (input.ToLower() == "exit")
                {
                    break;
                }

                // Create a DataTable object to evaluate the expression
                DataTable table = new DataTable();

                // Use Compute to evaluate the expression
                var result = table.Compute(input, string.Empty);

                // Output the result
                Console.WriteLine("Result: " + result);
            }
            catch (SyntaxErrorException)
            {
                // Catch invalid syntax or expression errors
                Console.WriteLine("Invalid expression! Please enter a valid mathematical expression.");
            }
            catch (Exception ex)
            {
                // Catch any other unexpected errors
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
