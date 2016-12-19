
//First is the namespace declaration. The namespace is declared when naming the solution.
//For now, this will be a console application in a tutorial form of C#. 

//A namespace is a collection of classes and other programming items. 

//The 'using' allows for use of the 'System' namespace classes.

//Namespaces allow for classes, delegates, other namespaces
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
            Console.ReadKey();

            //You can add and call other methods in the 'Main'. Here is an example 
            //of using a method call to print a new line. 

            SecondLine();
        }

        static void SecondLine()
        {
            Console.WriteLine("This is the second line of the program!");
            Console.ReadKey();

        }

            
    }
}