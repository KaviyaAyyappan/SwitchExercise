using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Enter the result:");
                int result = int.Parse(Console.ReadLine());
                switch (result)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("Excellent");
                        break;

                    case 8:
                    case 7:
                        Console.WriteLine("Notable");
                        break;
                    case 6:
                        Console.WriteLine("Good");
                        break;
                    case 5:
                        Console.WriteLine("pass");
                        break;
                    default:
                        Console.WriteLine("Fail");
                        break;
                }
                
                Console.Read();
            }
    }
}
