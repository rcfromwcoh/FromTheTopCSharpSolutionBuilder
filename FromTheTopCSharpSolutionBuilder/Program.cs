
//First is the namespace declaration. The namespace is declared when naming the solution.
//For now, this will be a console application in a tutorial form of C#. 

//A namespace is a collection of classes and other programming items. 
//Namespaces allow for classes, delegates, interfaces, struts, enums and other namespaces. 
//Those other items, the 'static' and 'void' will be discussed later.

//The 'using' allows for use of the 'System' namespace classes.

//Please Note: C# is Case Sensitive. 


using System;


namespace FromTheTopCSharpSolutionBuilder
{
    class Program
    {

            //The 'Main' Method is the primary program method. The program execution begins
            //and ends in the Main method. 
        static void Main()
        {
            //the 'Console' class is a class inside the .NET framework that allows
            //various actions to or from the Console (Command) window

            //WriteLine writes a single line to the console.
            
            //ReadKey reads a user input single key, and keeps the program waiting 
            //until it receives the input from the user.  

            //Each element needs to have a semicolon at the end to separate it 
            //other program elements. 

            Console.WriteLine("Welcome to C# Training!");
            //Console.ReadKey();

            //You can add and call other methods in the 'Main'. Here is an example 
            //of using a method call to print a new line. 

            SecondLine();
            ThirdClass();
            Assignments();
        }

        static void SecondLine()
        {
            //Here is the code used to build the SecondLine class.

            //Here we talk a little about how to read and write from the console. 
            //You can do it with concatenation, as well as place holder syntax. 

            Console.WriteLine("What is your name? Please enter your First name:");

            //To read something from the console, use the ReadLine method.

            //string UserName = Console.ReadLine();
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name:");
            string LastName = Console.ReadLine();

            //This is a way to concatenate a string
            //Console.WriteLine("Hello " + UserName);

            //Or you can use placeholder syntax to show your string.
            //Put your placeholders in bracketed numbers starting with {0} and then 
            //add items after the end of the placeheld string.

            Console.WriteLine("Hello {0} {1}", FirstName, LastName);

            Console.ReadKey();

        }

        static void ThirdClass()
        {
            //C# has many different built-in types.

            //Boolean (true or false)

            bool firstBool = true;
            bool secondBool = false;

            Console.WriteLine("C# has a Boolean function, which allows users to set a {0} or {1} condition", 
                firstBool, secondBool);
            Console.WriteLine("Please press any key to continue.");

            //Integral Data Types
            //Go to MSDN (Microsoft Developer Network) to get value ranges, 
            //or let Visual Studio figure it for you
            //sbyte (signed byte)   
            //byte                  
            //short         
            //ushort
            //int
            //uint
            //long
            //ulong

            Console.WriteLine("C# offers many integral data types.");
            Console.WriteLine("The minimum and maximum int values are {0}, {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("The minimum and maximum uint values are {0}, {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("The minimum and maximum sbyte values are {0}, {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("The minimum and maximum byte values are {0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("The minimum and maximum short values are {0}, {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("The minimum and maximum ushort values are {0}, {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("The minimum and maximum long values are {0}, {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("The minimum and maximum ulong values are {0}, {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();

            //Float Data Types
            //float
            //double
            //decimal

            Console.WriteLine("There are also a few types of decimal placed numbers.");
            Console.WriteLine("The minimum and maximum float values are {0}, {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("The minimum and maximum double values are {0}, {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("The minimum and maximum decimal values are {0}, {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();

            //Strings and Escape Characters
            //Escape sequence/character is the \ backslash key
            //There are some non-printable characters
            //The entire list of escape sequences are available on MSDN at https://msdn.microsoft.com/en-us/library/h21280bw.aspx.

            Console.WriteLine("There are a number of characters that must be read with an escape character.\nFor example, the double quotes\"\" must be escaped to be seen on a screen."); 
            string word = "\"Word\"";
            Console.WriteLine(word);

            //C# also has a Verbatim Literal way to literally take items verbatim. 
            Console.WriteLine("You can also use the verbatim literal @ in a string to show the complete, as-typed string");
            string verbatimLiteral = @"C:\Programs\VisualStudio";
            Console.WriteLine("For example: " + verbatimLiteral);
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            
        }

        static void Assignments()
        {
            //Assignment Operator is the = sign
            //Aritmetic Operators, like +,-,*,/,%
            //% designates modulus, or the remainder 

            //Comparison operators: 
            //== (is equal to) 
            //!= (is not equal to)
            //> (greater than)
            //>= (greater than or equal to)
            //< (less than)
            //<= (less than or equal to)

            //Conditional Operators:
            //&& (and)
            //|| (or)

            double firstNum = 1;
            double secondNum = 1;
            string yesOrNo = null;

            do
            {
                Console.WriteLine("Please enter your first number:");
                firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Operation:");
                string operation = Console.ReadLine();
                Console.WriteLine("Enter your second number");
                secondNum = double.Parse(Console.ReadLine());
                //here put the string conversion to math
                double mathOutput = 1;

                if (operation == "+")
                {
                    mathOutput = firstNum + secondNum;
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + mathOutput);
                }

                else if (operation == "-")
                {
                    mathOutput = firstNum - secondNum;
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + mathOutput);
                }

                else if (operation == "*")
                {
                    mathOutput = firstNum * secondNum;
                    Console.WriteLine(firstNum + " * " + secondNum + " = " + mathOutput);

                }

                else if (operation == "/")
                {
                    mathOutput = firstNum / secondNum;
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + mathOutput);
                }

                else if (operation == "%")
                {
                    mathOutput = firstNum % secondNum;
                    Console.WriteLine(firstNum + " % " + secondNum + " = " + mathOutput);
                }

                else
                {
                    Console.WriteLine("I can't understand. Let's Try Again");
                }

                Console.WriteLine("Do you want to do another calculation? (Enter \"YES\" or \"NO\" )");
                yesOrNo = Console.ReadLine();
                yesOrNo = yesOrNo.ToUpper();
            }
            while (yesOrNo == "YES");

            Console.WriteLine("GoodBye! Hit any Key to continue...");
            Console.ReadKey();
        }

            
    }
}