/***************************** Intro Lecture - Namespace and Main() method 
// namespace declaration, basically this line tells the program that we are going to make use of code inside of system (namespace)
// A namespace is used to organize your code and is collection of classes, interfaces, structs, enums, and delegates
using System; 
    class Program
    {
        // Main method is the entry point into your application 
        // As seen below, starts at Main(), in order to call Main1() it has to be called in Main()
        static void Main1()
        {
            Console.WriteLine("Welcome to C# training! 1");
        }
        static void Main()
        {
            Console.WriteLine("Welcome to C# training!");
            Main1();
        }
    }
**************************************************************/

/******************************* Reading and Writing to a console **********************************/
/* @@ Key Points: 
 1. Writing and reading in the console
 2. Concatenating vs Placeholder syntax
*/

/*
using System;
    class Program
    {
        static void Main()
        {
            // This writes to the console
            Console.WriteLine("Please enter your FIRST name");
            // This reads from console line : Console.ReadLine();
            // should store in a variable for printing in the future
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your LAST name");
            string LastName = Console.ReadLine();
            //  This is the method is concatenating, not common way of combining 
            // Console.WriteLine("Hello " + UserName);
            // Placeholder syntax method, much more preferred
            Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        }
    }
**********************************************************************/

/******************* Buolt-in Types in C# **********************/
/* @@ Keypoints:
 1. Built-in C# Types
*/

/* Built-in types in C#
Boolean Types -  only true or false
Integral Types - sbyte, byte, short, ushort, int, unit, long, ulong, char
Floating Types - float and double
Decimal Types
String Types
*/

/*
using System;
    class Program
    {
        static void Main()
        {
            // Boolean Type
            bool b = true;
            
            int i = 0;
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
         //Integral Types reference https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/integral-types-table
            // Float types - more precision/decimals numbers (up to 7 digits) : float d = something;
            // Double Types - same just 15-16 digits : double d = something;
            // Decimal Types - same just 28-29 digits : decimal d = something;
    }
}
*******************************************************************/

/*********************** Built-in String Type *********************/
/* @@ Keypoints:
 1. Escape Sequence - being able to use quotes inside of a string : string Name = "\"Erick\"";
    whatever precedes me (\) treat that as a regular printable character
 2. Other Escape Sequence characters : https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2017
 3. Verbatim Literal - adding @ cancels escape sequences : string Numbers = @"One\nTwo\nThree"; cancels the \n new lines escape sequence input
 */

/*
using System;
    class Program
        {
            static void Main()
            {
                string Name = "\"Erick\"";
                Console.WriteLine(Name);
                string Numbers = @"One\nTwo\nThree";
                Console.WriteLine(Numbers);
            }
        }
*******************************************************************************************/

/********************** Common Operators in C# ****************************************************/
/* @@ Keypoints:
 1. Understanding differetn operators
 2. Focusing on how to use ternary operators :  bool IsNumber10 = Number == 10 ? true : false;
 */
/*
 1. Assignment Operator : =
 2. Arithmetic Operators : + , - , * , / , %
 3. Comparison Operators : == , != , > , >= , < , <=
 4. Conditional Operators : && , ||
 5. Ternary Operator : ?
 6. Null Coalescing Operator : ??
 */

/*
using System;
       class Program
       {
           static void Main()
           {
               // assignment operator
               int i = 10;
               // This is the quotient using / to get the whole and not remainder : 10/2 = 5 (quotient)
               int Numerator = 10;
               int Denominator = 2;
               int Result = Numerator / Denominator;
               Console.WriteLine("Result = {0}", Result);
               // This is the remainder : 10 /2 = 5 with 0 and remainder
               int Result1 = Numerator % Denominator;
               Console.WriteLine("Result = {0}", Result1);
               // == is equal to ,  != is not equal to
               // Using conditional operators
               int Test1 = 10;
               int Test2 = 20;
               if (Test1 == 10 && Test2 == 20)
               {
                   Console.WriteLine("These numbers are correct!");
               }
               // Ternary Operator - below is the same and the commmented code below this 
               int Number = 10;
               bool IsNumber10 = Number == 10 ? true : false;
               // Measuring  IsNumber10, if condition (Number == 10) is true we're return true (b/c it's right after the ? and before :
               // If the condition fails, then it's false (after : )
               Console.WriteLine("Number == 10 is {0}", IsNumber10);
               // Long verison instead of using ternary below
               bool Isnumber
               int Number = 10;
               bool IsNumber10;
               if(Number == 10)
               {
                   IsNumber10 = true;
               }
               else
               {
                   IsNumber10 = false;
               }
               Console.WriteLine("Number == 10 is {0}", IsNumber10);
           }
       }
************************************************************************************************************/

/************************************ Nullable Types ****************************************************/
/* @@ Keypoints:
 1. C# divided into 2 braod categories:
    -Value Types - int, float, double, structs, enums, etc. ** cannot have null values**
    -Reference Types - Interface, Class, delegates, strings, arrays, etc. **can have null values**
 2. By default value types are non nullable. To make them nullable use a ?
    - int i = 0 (i is non nullable, so i cannot be set to null, i = null will generate compiler error)
    - int? j = 0 (j is nullable int, so j=null is legal)
    Nullable types bridge the difference between C# types and Database Types
 */
/*
using System;

        class Program
        {
            static void Main()
            {
                // does not work because is a value type, below is incorrect 
                //int i = null;
                // adding a ? makes values types become nullable 
                //int? i = null;

                /* Why would we need a nullable value for a value type?
                -- Let's say we ask a question that requries a yes or no answer, but the user does not answer either. Then null (not providing an answer) is the third option
                 

                bool? AreyouMajor = null;

                if (AreyouMajor == true)
                {
                    Console.WriteLine("User is Major!");
                }
                else if (AreyouMajor == false) // This is another way of saying !AreyouMajor.Value. Taking the value of AreYouMajor and putting ! in front to make it the opposite. 
                {
                    Console.WriteLine("User is NOT Major");
                }
                else
                {
                    Console.WriteLine("User did not answer the question");
                }
            }
        }

*/

/*
using System;

        class Program
        {
            static void Main()
            {
                int? TicketsOnSale = null;

                int AvailableTickets;

                if(TicketsOnSale == null)
                {
                    AvailableTickets = 0;
                }
                else
                {
                     
                }
            }
        }



***************************************************************************************/

/*********************************** DataTypes Conversion ******************/

using System;

class Program
{
    static void Main()
    {
        // Implicit Conversion 
        // This works
        int i = 100;
        float f = i;
        Console.WriteLine(f); //since float > int, it works 


        // Explicit Conversion - 2 ways - 1. Typecast operator 2. Convert class
        // This isn't necessarily an overflow exception, but rather loss of information, mainly in the fractional portion, this can matter in certain circumstances
        float k = 123.45f;
        int j = (int) k; // since float is larger, int can't contain it
        // This is called type cast, I want variable k to be an int
        // now j = 123, since it was turned to int the .45 from original k is lost 

        // Can also do Convert class
        int p = Convert.ToInt32(k); // same thing happens

        // Typecast won't throw an error if number is larger than data type (flotat, int, etc.) - will just present highest/lowest data number
        // Convert class will throw exception, and Overflow Exception

        // Convert between data types (string -> int for exmaple)
        string strNumber = "100"; // If there are letters in the variable "100TG" will throw FormatException 
        int l = int.Parse(strNumber);

        //TryParse
        // Take this string, convert to int, and store it in the variable located in the second arguement within the parameter
        int Result = 0;
        bool IsConversionSuccessful = int.TryParse(strNumber, out Result);// it's lead by a boolean, if true gives the variable conversion successfully, if format incorrect doesn't work

        if(IsConversionSuccessful)
        {
            Console.WriteLine(Result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}


