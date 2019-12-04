using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_NateWint
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double answer;
            Random r1 = new Random();
            int Random1 = r1.Next(1, 50);
            int Random2 = r1.Next(1, 50);
            Console.WriteLine($"{Random1.ToString()}+{Random2.ToString()}=?");
            answer = Convert.ToDouble(Console.ReadLine());
            while (answer != (Random1 + Random2))
            {
                Console.WriteLine($"Sorry!{answer} is not a correct answer");
                Console.WriteLine("Please try again");
                answer = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Congrats!!! You really are genius!!!");

            Console.ReadKey();
        }      
    }
}
