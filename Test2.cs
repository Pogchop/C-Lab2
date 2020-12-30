using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Test2
    {
        static void Main(string[] args)
        {
            int grade;
            Console.WriteLine("What is your grade?");
            grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 40)
            {
                Console.WriteLine("U pass");
            }
            else
            {
                Console.WriteLine("U failed");
            }
            if (grade >= 75 && grade < 80)
            {
                Console.WriteLine("$1000");
            }
            else if (90 > grade && grade >= 80 )
            {
                Console.WriteLine("1500");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("$2000");
            }
            Console.ReadLine();
        }
    }
}
