
//From the Top C# Builder
//Robert Horrocks
//December, 2016

//This is a build of methods to describe fundamentals of the C# programming language. 

//While I try to represent the concepts correctly, if 
//there are errors, please let me know via GitHub at rcfromwcoh. 

//I would be happy to accept any feedback as well via Twitter @rhorro. Thanks in advance for your feedback.

//C# Tutorial

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

            //SecondLine();
            //ThirdClass();
            //Assignments();
            //MoreOnTypes();
            ImplicitAndExplicitCasting();
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

            Console.WriteLine("Hello {0} {1}, please press any key to continue.", FirstName, LastName);

            Console.ReadKey();
            Console.Clear();

        }

        static void ThirdClass()
        {
            //C# has many different built-in types.

            //Value types are held in stack memory. All numeric data types, bool, char, date, structures, enumerations.

            //Reference types contains a pointer reference to a place on the heap. 
            //Strings, arrays, class types (e.g., form), interface, delegates are reference type examples.

            //Boolean (true or false)

            bool firstBool = true;
            bool secondBool = false;

            Console.WriteLine("C# has a Boolean function, which allows users to set a {0} or {1} condition", 
                firstBool, secondBool);
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            Console.Clear();

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
            Console.Clear();

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
            Console.Clear();

            //Strings and Escape Characters
            //Escape sequence/character is the \ backslash key
            //There are some non-printable characters
            //The entire list of escape sequences are available on MSDN at https://msdn.microsoft.com/en-us/library/h21280bw.aspx.

            Console.WriteLine("There are a number of characters that must be read with an escape character.\nFor example, the double quotes\"\" must be escaped to be seen on a screen.");
            string word = @"Word";
            Console.WriteLine(word);

            //C# also has a Verbatim Literal way to literally take items verbatim. 
            Console.WriteLine("You can also use the verbatim literal @ in a string to show the complete, as-typed string");
            string verbatimLiteral = @"@C:\Programs\VisualStudio";
            Console.WriteLine("For example: " + verbatimLiteral);
            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
            Console.Clear();

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
                Console.Clear();
                Console.WriteLine("Welcome to the C# Calculator!" +
                    " Please enter your first number:");
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
            Console.Clear();

            //Ternary operator ?: is if the first is correct, do what is called; otherwise, do what is called after

            Console.WriteLine("A ternary operator is expressed with a ?: used in a pattern.");
            Console.WriteLine("For example, if condition a is true, then the first; if not, then go to the second.");
            Console.WriteLine("If int TernaryNumber = 12; and bool IsTernaryNumber = TernaryNumber == 12 ? true : false;");

            int TernaryNumber = 12;

            bool IsTernaryNumber = TernaryNumber == 12 ? true : false;

            Console.WriteLine("TernaryNumber == 12 is {0}", IsTernaryNumber);
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }

            static void MoreOnTypes()
        {
            //As stated above, 
            //Value types are held in stack memory. All numeric data types, bool, char, date, structures, enumerations.

            //Reference types contains a pointer reference to a place on the heap. 
            //Strings, arrays, class types (e.g., form), interface, delegates are reference type examples.

            //Reference types are nullable

            //Value types are by default non-nullable. But if you need to make it nullable, preceed with a "?"

            //just using this int declaration as an example
            int? UserAge = null;

            //setting the DeclaredMajor to null as a default, assuming the user enters no answer
            //to the question we will ask. 

            bool? DeclaredMajor = null;

            string majorYesOrNo = null;

            //The ? allows the fields to be nullable, and are largely helpful for database field applications. 

            Console.WriteLine("Have you declared a major? Type YES or NO: ");
            majorYesOrNo = Console.ReadLine();
            majorYesOrNo = majorYesOrNo.ToUpper();

            //if (MajorYesOrNo == "YES")
            //{
            //    DeclaredMajor = true;
            //}

            //else
            //{
            //    DeclaredMajor = false;
            //}

            //if (DeclaredMajor == true)
            //{
            //    Console.WriteLine("You have declared a major");
            //}
            //else if (!DeclaredMajor.Value)
            //{
            //    Console.WriteLine("You have not declared a major");
            //}

            //The code above was a little repetitious. It also did not allow for a user to leave the question blank,
            //or put in an answer other than yes or no.

            if (majorYesOrNo == "YES")
            {
                DeclaredMajor = true;
                Console.WriteLine("You have declared a major");
            }

            else if(majorYesOrNo == "NO")
            {
                DeclaredMajor = false;
                Console.WriteLine("You have not declared a major");
            }

            else 
            {
                Console.WriteLine("We did not understand or get an answer to your question.");
            }



            Console.WriteLine("Thanks for letting us know if you have declared a major!");
            Console.WriteLine("Press any key to continue...");

            //Another theme in types are implicit and explicit casting. 
            //You will generate an error if you try to assign the value of a nullable variable with
            //an unnullable variable. 

            //The way to avoid this error is to explicitly cast your nullable variable into a unnullable value.
            //Also, You can use the .value property to match the types.

            //int? CannedGoodsForSale = null;

            int? availableCannedGoods = null;

            Console.WriteLine("How many canned goods do you wish to sell? Please enter your value:");

            string CustomerInput = Console.ReadLine();

            try
            {
                availableCannedGoods = Convert.ToInt32(CustomerInput);
                
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(OverflowException f)
            {
                Console.WriteLine(f.Message);
            }
            finally
            {
                if (availableCannedGoods >= 0)
                {


                    if (availableCannedGoods < Int32.MaxValue)
                    {
                        Console.WriteLine("There are {0} canned goods available for sale.", availableCannedGoods);
                    }

                    else
                    {
                        Console.WriteLine("The amount is outside the field parameters.");
                    }
                }

                else if (availableCannedGoods < 0)
                {
                    Console.WriteLine("There cannot be less than 0 canned goods available for sale.");
                }

                else
                {
                    Console.WriteLine("We did not understand your input.");
                }
            }

            
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }
        static void ImplicitAndExplicitCasting()
        {

            //Another theme in types are implicit and explicit casting. 
            //Implicit casting can change a data type when there is 
            //1. no loss of information if the conversion is done.
            //2. no possibility of an exception being thrown. 

            //this is converted by the compiler with no problem. 

            int b = 27;
            float c = b;

            Console.WriteLine(c);

            //If you need to smoosh information into a degraded data type, it needs to be explicitly cast. 
            //Explicit casting is done by the ConvertTo method 
            float f = 123.456f;
            
            //The simple way to convert is to explicitly cast in parentheses prior to the value
            //int i = (int)f;
            //A type cast runs the risk of an overflow

            //Or use the Convert.To class

            int i = Convert.ToInt32(f);



            Console.WriteLine(i);

            //What about user input? All user input must be converted from string format.

            Console.WriteLine("What is your favorite number?");
            string userNumber = Console.ReadLine();
            int result = -1;
            bool isConversionSuccessful = int.TryParse(userNumber, out result);

            if (isConversionSuccessful)
            {
                Console.WriteLine("Your favorite number is {0}", result);
            }
            else
            {
                Console.WriteLine("We did not understand a valid number");
            }
            

            //TryParse gives us an opportunity to have an "out" in case the user messes up on the input and
            //would otherwise cause an exception. 

            

            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }

        static void ArrayDiscussion()
        {


        }

    }
}