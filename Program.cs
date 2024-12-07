// easy

// using System;
 
// class GFG {
//     static void Main(string[] args)
//     {
//         try
//         {
//             int[] numbers = { 1, 2, 3 };
//             Console.WriteLine(numbers[5]);
//         }
//         catch (IndexOutOfRangeException ex)
//         {
//             Console.WriteLine($"Caught an exception: {ex.Message}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Generic exception: {ex.Message}");
//         }
//         finally
//         {
//             Console.WriteLine("This code runs no matter what.");
//         }
//     }
// }


// medium

// using System;
 
// class GFG {
//     public static void MethodA()
//     {
//         throw new InvalidOperationException("An error occurred in MethodA.");
//     }
//     public static void Main(string[] args)
//     {
//         try
//         {
//             int[] numbers = { 1, 2, 3 };
//             Console.WriteLine(numbers[5]);
//         }
//         catch (IndexOutOfRangeException ex)
//         {
//             MethodA();
//             // Console.WriteLine($"Caught an exception: {ex.Message}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Generic exception: {ex.Message}");
//         }
//         finally
//         {
//             Console.WriteLine("This code runs no matter what.");
//         }
//     }
// }

// hard

using System;
 
class GFG {
    public static void MethodA()
    {
        throw new InvalidOperationException("An error occurred in MethodA.");
    }
    public static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            MethodA();
            // Console.WriteLine($"Caught an exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Generic exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This code runs no matter what.");
        }
    }
}