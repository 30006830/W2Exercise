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
            string name;
            int age;
            string gender;
            string address;

            Console.WriteLine("Please enter your name here: ");
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please state your Gender: ");
            gender = Console.ReadLine();

            Console.WriteLine("Finally enter your Address: ");
            address = Console.ReadLine();

            Console.WriteLine("Outputting Results....");
            Console.ReadLine();

            Console.WriteLine("Outputs: \n Name: {0} \n Age: {1} \n Gender: {2} \n Address (Email or Street Address): {3} ",name, age, gender, address );

            

            Console.ReadLine();


        }
    }
}
