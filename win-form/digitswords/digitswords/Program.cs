using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitswords
{
    class Program
    {
        enum digits //تعریف نوع داده شمارشی برای نمایش رقم ها
        {
            zero, one, two, three, four, five, six, seven, eight, nine
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter an integer number:");
            int n = int.Parse(Console.ReadLine());// دریافت ورودی
            string s = ""; // تعریف یک متغیر رشته ای برای نمایش خروجی

            do
            {
                s = ((digits)(n % 10)).ToString() + " " + s;
                n /= 10;
            } while (n != 0);

            Console.WriteLine(s);
        }
    }
}
