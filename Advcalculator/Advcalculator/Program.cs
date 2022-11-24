using System;
using System.Diagnostics;

namespace Advcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int num1, num2,  choice;
                bool isCondition=false;
                char op;
                
                Console.WriteLine("Calculator"+"\n");
                Console.Write("Enter Number:");
                num1 = Convert.ToInt32(Console.ReadLine());
            do
            {
              
                Console.Write("Enter Operator:");
                op = Convert.ToChar(Console.ReadLine());
                
                
                if (op == '+')
                {
                    Console.Write("Enter Number:");
                    num2 = int.Parse(Console.ReadLine());
                    num1= num1+num2;
                    Console.WriteLine("Result is: " + num1);

                }
                else if (op == '-')
                {
                    Console.Write("Enter Number:");
                    num2 = int.Parse(Console.ReadLine());
                    num1 = num1 - num2;
                    Console.WriteLine("Result is: " + num1);
                }
                else if (op == '*')
                {
                    Console.Write("Enter Number:");
                    num2 = int.Parse(Console.ReadLine());
                    num1 = num1 * num2;
                    Console.WriteLine("Result is: " + num1);
                }
                else if (op == '/')
                {
                    Console.Write("Enter Number:");
                    num2 = int.Parse(Console.ReadLine());
                    num1 = num1 / num2;
                    Console.WriteLine("Result is: " + num1);

                }
                Console.Write("Do you want to proceed (Yes:1/No:2) :");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    isCondition = true;
                }
                else
                    if (choice == 2)
                {
                    isCondition = false;
                    
                }
 
            } while (isCondition);
            
        }
    } 
    
}
       