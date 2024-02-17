using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//methods or function
namespace CSharpTutorials
{
    class Program
    {
        //How to create a method
        static void welcome()
        {
            Console.WriteLine("Hello, Welcome!");
        }
        //create a function with parameters
        static void welcomeBack(string name)
        {
            Console.WriteLine($"Hello, Welcome!  {name}");
        }
        static void welcomeBack(string name,int age)
        {
            Console.WriteLine($"Hello, Welcome! {name} and you are {age} years old,is that correct?");
        }
        static void add(double a,double b)
        {
            Console.WriteLine(a + b);
        }
        static void sub(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void mul(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        static void div(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
           //How to call or use the function
           welcome();
            welcomeBack("john");
            welcomeBack("sandy", 12);
            Console.WriteLine("---------------------------------------------------------------");

            // simple calculator

            Console.WriteLine("Enter 1st number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please make your choice: \n  1 for + \n 2 for - \n 3 for * \n 4 for /");

            Console.WriteLine("Enter the number between 1 and 4: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                   add(n1, n2);
                    break;
                case 2:
                    sub(n1, n2);
                    break;
                case 3:
                    mul(n1, n2);
                    break;
                case 4:
                    div(n1, n2);
                    break;
                default:
                    Console.WriteLine("Bad input");
                    break;
            }
        }
    }
}