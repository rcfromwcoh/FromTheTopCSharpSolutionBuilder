
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

            
    }
}