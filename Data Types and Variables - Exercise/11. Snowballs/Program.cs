using System;

namespace _11._Snowballs
{
    class Program
    {
        //not true doesn't work with bim nums you must change somethings in BigInteger


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double highestValue = double.MinValue;
            int hS = 0;
            int hT = 0;
            int hQ = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);


                if (highestValue < snowballValue)
                {
                    highestValue = snowballValue;
                    hS = snowballSnow;
                    hT = snowballTime;
                    hQ = snowballQuality;
                }
            }
            Console.WriteLine($"{hS} : {hT} = {highestValue} ({hQ})");

        }
    }
}
