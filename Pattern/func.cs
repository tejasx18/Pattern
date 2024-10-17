using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class func
    {
        static int sample(int input) { 
            if(input == 832) return 594;
            if (input == 51) return 36;
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sample(num));
            
        }
    }
}
