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
            int temp = input;
            int reverse = 0;
            while (temp > 0) { 
                int r = temp%10;
                reverse= reverse*10+r;
                temp = temp/10;
            }
            return input-reverse;
            //double result = (input * 71.4) / 100;
            //return (int)result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sample(num));
            
        }
    }
}
