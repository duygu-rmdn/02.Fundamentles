using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());

            if (digit == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (num[0] == '0' )
            {
                num = num.Substring(1);
            }




            StringBuilder sb = new StringBuilder();
            int remainder = 0;
            for (int i = num.Length - 1; i > -1; i--)
            {
                int currresult = int.Parse(num[i].ToString()) * digit + remainder;
                remainder = 0;

                if (currresult >9)
                {
                    remainder = currresult / 10;
                    currresult %= 10;
                }


                sb.Append(currresult);


            }
            if (remainder != 0)
            {
                sb.Append(remainder);
            }



            StringBuilder result = new StringBuilder();
            for (int i = sb.Length-1; i >= 0; i--)
            {
                result.Append(sb[i]);
            }
            Console.WriteLine(result);
        }
    }
}
