using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class combines related variables (fields) and functions (methods)

            int number;
            //Person person = new Person(); // instead of name of the class you can use
            //operator var:
            var person = new Person(); // creating an object from class
            person.Name = "Abe";
            person.Introduce();

            int result = Calculator.Add(1, 2); // accessing method directly from class
            Console.WriteLine(result);
            
        }
    }
    public class Person
    {
        public string Name;
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }
    }
    public class Calculator
    {
        public static int Add(int a, int b) // static allows to access the method directly
                                            // from Calculator class
        {
            return a + b;
        }
    }
}