using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_class_project_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList to store mixed data types
            ArrayList mixedList = new ArrayList();

            // Add different types of data to the ArrayList (boxing occurs automatically)
            mixedList.Add(42);
            mixedList.Add("Hello World");
            mixedList.Add(3.14159);
            mixedList.Add(true);
            mixedList.Add(DateTime.Now);
            mixedList.Add(100m);

            Console.WriteLine("ArrayList contains the following values:");
            for (int i = 0; i < mixedList.Count; i++)
            {
                Console.WriteLine($"Index {i}: {mixedList[i]} ({mixedList[i].GetType()})");
            }

            Console.WriteLine("\nRetrieving and unboxing values:");

            // Safely retrieve and unbox values with proper type checking
            try
            {
                // Unboxing an int
                if (mixedList[0] is int)
                {
                    int intValue = (int)mixedList[0];
                    Console.WriteLine($"Unboxed int: {intValue}");
                }

                // Unboxing a string
                string stringValue = mixedList[1] as string;
                if (stringValue != null)
                {
                    Console.WriteLine($"Unboxed string: {stringValue}");
                }

                // Unboxing a double
                if (mixedList[2] is double)
                {
                    double doubleValue = (double)mixedList[2];
                    Console.WriteLine($"Unboxed double: {doubleValue}");
                }

                // Unboxing a bool
                if (mixedList[3] is bool)
                {
                    bool boolValue = (bool)mixedList[3];
                    Console.WriteLine($"Unboxed bool: {boolValue}");
                }

                // Attempt to unbox a DateTime as int (invalid cast)
                if (mixedList[4] is int)
                {
                    int invalidInt = (int)mixedList[4];
                    Console.WriteLine($"This won't be printed: {invalidInt}");
                }
                else
                {
                    Console.WriteLine($"Index 4 is not an int, it's a {mixedList[4].GetType()}");
                }

                // Unboxing a decimal
                if (mixedList[5] is decimal)
                {
                    decimal decimalValue = (decimal)mixedList[5];
                    Console.WriteLine($"Unboxed decimal: {decimalValue}");
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Invalid cast error: {ex.Message}");
            }

            // Wait for key press before closing
            Console.ReadKey();
        }
    }
}