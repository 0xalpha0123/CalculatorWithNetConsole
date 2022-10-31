using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            start:
            arithmeticclass obj = new arithmeticclass();
            Console.Write("Please Provide 1st Number : ");
            try
            {
                obj.a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exp)
            {
                //This have to work completly.
                Console.WriteLine(exp.Message.ToString());
                goto start;
            }
            Console.Write("Please Provide 2nd Number : ");
            obj.b = Convert.ToInt32(Console.ReadLine());
            Console.Write("1 : For ADD\n2 : For Subtract\n3 : FOr Divide\n4 : For multiply\nPlease Provide OPtion to proceed : ");
            String inputs = Console.ReadLine();
            if (inputs == "1")
            {
                Console.WriteLine("Your Ans Is : " + obj.GetSum());
            }
            else if (inputs == "2")
            {
                Console.WriteLine("Your Ans Is : " + obj.GetSubtract());
            }
            else if (inputs == "3")
            {
                Console.WriteLine("Your Ans Is : " + obj.GetDivide());
            }
            else if (inputs == "4")
            {
                Console.WriteLine("Your Ans Is : " + obj.GetMultilply());
            }
            else
            {
                Console.Write("You Eneterd invalid OPtion. Press ANy Key to close");
            }
            Console.ReadLine();
        }
    }

    public class arithmeticclass
    {
        public int a, b;

        public int GetSum()
        {
            return a + b;
        }
        public int GetSubtract()
        {
            return a - b;
        }
        public int GetDivide()
        {
            return a / b;
        }
        public int GetMultilply()
        {
            return a * b;
        }
    }
}