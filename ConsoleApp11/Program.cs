using System;
//using System.Collections.Generic;
//using System.Linq;


class Program
{
    static void Main()
    {
        //HashSet<int> uniqueNumbers = new HashSet<int>(); // Set to store unique numbers
        //string input;

        //Console.WriteLine("Enter numbers (type 'exit' to stop):");

        //while (true)
        //{
        //    Console.Write("Enter a number: ");
        //    input = Console.ReadLine();

        //    if (input.ToLower() == "exit") // Exit condition
        //        break;

        //    if (int.TryParse(input, out int number))
        //    {
        //        uniqueNumbers.Add(number); // Add number to the set (duplicates are ignored)
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //    }
        //}

        //Console.WriteLine($"Total unique numbers entered: {uniqueNumbers.Count}"); // Display count


        //Console.Write("Enter a binary string: ");
        //string binaryString = Console.ReadLine(); // Read user input

        //int gapCount = 0; // Counter for binary gaps
        //bool insideGap = false; // Flag to track if we are inside a gap

        //foreach (char bit in binaryString)
        //{
        //    if (bit == '1') // If we encounter '1'
        //    {
        //        if (insideGap) // If we were in a gap, it means the gap just ended
        //        {
        //            gapCount++; // Increase gap counter
        //            insideGap = false; // Reset flag
        //        }
        //    }
        //    else if (bit == '0' && binaryString.Contains("1")) // If we encounter '0'
        //    {
        //        if (!insideGap && binaryString.IndexOf('1') != binaryString.LastIndexOf('1'))
        //        {
        //            insideGap = true; // Start counting a new gap
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid binary string.");
        //        return;
        //    }
        //}

        //Console.WriteLine($"Number of binary gaps: {gapCount}"); // Output result


        // Read first set from user input
        //    Console.Write("Enter elements of Set A (comma separated): ");
        //    HashSet<int> setA = ReadSetFromInput();

        //    // Read second set from user input
        //    Console.Write("Enter elements of Set B (comma separated): ");
        //    HashSet<int> setB = ReadSetFromInput();

        //    // Perform set operations
        //    HashSet<int> union = new HashSet<int>(setA.Union(setB)); // Union of sets
        //    HashSet<int> differenceAB = new HashSet<int>(setA.Except(setB)); // A - B
        //    HashSet<int> intersection = new HashSet<int>(setA.Intersect(setB)); // Intersection
        //    HashSet<int> symmetricDifference = new HashSet<int>(setA);
        //    symmetricDifference.SymmetricExceptWith(setB); // Perform symmetric difference

        //    // Display results
        //    Console.WriteLine($"Union: {string.Join(", ", union)}");
        //    Console.WriteLine($"Difference A - B: {string.Join(", ", differenceAB)}");
        //    Console.WriteLine($"Intersection: {string.Join(", ", intersection)}");
        //    Console.WriteLine($"Symmetric Difference: {string.Join(", ", symmetricDifference)}");
        //}

        //// Method to read and parse user input into a set
        //static HashSet<int> ReadSetFromInput()
        //{
        //    string input = Console.ReadLine();
        //    HashSet<int> set = new HashSet<int>();

        //    if (!string.IsNullOrWhiteSpace(input))
        //    {
        //        string[] elements = input.Split(','); // Split input by commas

        //        foreach (string element in elements)
        //        {
        //            if (int.TryParse(element.Trim(), out int number)) // Validate integer input
        //            {
        //                set.Add(number); // Add valid numbers to the set
        //            }
        //        }
        //    }
        //    return set;





        //        Console.Write("Enter a number: ");

        //        if (int.TryParse(Console.ReadLine(), out int number))
        //        {
        //            if (IsPrime(number))
        //            {
        //                Console.WriteLine($"{number} is a prime number.");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{number} is not a prime number.");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid integer.");
        //        }
        //    }

        //    static bool IsPrime(int num)
        //    {
        //        if (num < 2) return false; // Numbers less than 2 are not prime

        //        for (int i = 2; i * i <= num; i++) // Check divisibility up to sqrt(num)
        //        {
        //            if (num % i == 0)
        //            {
        //                return false; // Found a divisor, not prime
        //            }
        //        }
        //        return true; // No divisors found, number is prime
        //    }
        //}



        Console.Write("Podaj liczbę całkowitą: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} jest liczbą parzystą.");
            }
            else
            {
                Console.WriteLine($"{number} jest liczbą nieparzystą.");
            }
        }
        else
        {
            Console.WriteLine("To nie jest poprawna liczba całkowita.");
        }
    }
}