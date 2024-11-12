using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            PerformOperation(input, calculator);

            static void PerformOperation(string operation, Calculator calculator)
            {
                Console.WriteLine("Enter 2 integers");

                string number1 = Console.ReadLine();    
                string number2 = Console.ReadLine();


                if (int.TryParse(number1, out int NumOne) && int.TryParse(number2, out int NumTwo))
                {
                    switch (operation)
                    {
                        case "1":
                            Console.WriteLine($"{NumOne} + {NumTwo} = {calculator.Add(NumOne, NumTwo)}");
                            break;
                        case "2":
                            Console.WriteLine($"{NumOne} + {NumTwo} = {calculator.Subtract(NumOne, NumTwo)}");
                            break;
                        case "3":
                            Console.WriteLine($"{NumOne} + {NumTwo} = {calculator.Multiply(NumOne, NumTwo)}");
                            break;
                        case "4":
                            Console.WriteLine($"{NumOne} + {NumTwo} = {calculator.Divide(NumOne, NumTwo)}");
                            break;
                        default:
                            Console.WriteLine("Unknown input");
                            break;
                    }
                }
            }
        }
    }
}