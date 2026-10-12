

// What is the exception handling mechism in C# and how does it will be work?



// An Exception is an  error that occurs during the execution of the a program.

// in C#, Exception handing is the mechnism that allows to the devloper to handle

// gracefully the error and prevent the progan and applicaiton for crashing

//it means it allows to the developer to write code and handle the exception

// it maintain the normal flow of application even when an error will occurs


// in Exception handling we have 4 keywords

// 1: Try: here we write the code that may throw an exception that we can place

// inside the try block.

//2. Catch : If an exception occurs in the try block , the controll is tranferred to the

//Catch Block.

//3. Finally: the code inside the finally blcok will always execute
//regardless of whether an exception will throw or not

// 4. Throw: it is used mannually throw an exception when certain
// condition is not met.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exception Handling in C#");



        try
        {
            Console.WriteLine("Enter a number :");

            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter another number :");

            int num2 = Convert.ToInt32(Console.ReadLine());


            // mannually throwing an expception if num is zero
            // divion by zero error


            if (num2 == 0)
            {
                throw new DivideByZeroException("Second number" +
                    "can not be zero");
            }


            int result = num1 / num2;

            Console.WriteLine($" Result of {num1}/ {num2}= {result}");
        }

        catch (FormatException ex)
        {

            Console.WriteLine("Input was not in correct format" +
                "please enter a valid number");

            Console.WriteLine($"Error details:  {ex.Message}");
        }

        catch (DivideByZeroException ex)
        {

            Console.WriteLine("Cannot divide by zero" +
                "please enter a non-zero number ");

            Console.WriteLine($"Error details:  {ex.Message}");
        }
        catch (Exception ex)
        {

            Console.WriteLine("An unexpected error occured");
            Console.WriteLine($"Error details:  {ex.Message}");

        }

        finally {

            Console.WriteLine("This Block will always execute");
        
        }
    }
}