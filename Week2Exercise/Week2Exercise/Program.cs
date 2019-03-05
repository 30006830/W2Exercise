using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of variables needed for the program, this will store the data for name, age, gender, address.
            string name;
            int age;
            string gender;
            string address;
            
            /*Requests the user input their name*/
            Console.WriteLine("Please enter your name here: ");
            //takes the users name and stores it in the variable, name.
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name); //prints "Hello" and then displays the users name.

            /*All these take the users input from the answers to each request and stores them all in specific variables*/
            Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please state your Gender: ");
            gender = Console.ReadLine();

            Console.WriteLine("Finally enter your Address: ");
            address = Console.ReadLine();

            Console.WriteLine("Outputting Results....");
            Console.ReadLine();

            //Outputs the variables stored in a listed format.
            Console.WriteLine("Outputs: \n Name: {0} \n Age: {1} \n Gender: {2} \n Address (Email or Street Address): {3} ",name, age, gender, address );

            

            Console.ReadLine();


        }
    }
}
