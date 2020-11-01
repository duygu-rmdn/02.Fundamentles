using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studenstCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initionalBonus = int.Parse(Console.ReadLine());
            double maxBonusPoints = 0;
            int studentAttendances = 0;
            for (int i = 0; i < studenstCount; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double totalBonus = attendances * 1.0 / lecturesCount * (5 + initionalBonus);

                if (totalBonus > maxBonusPoints)
                {
                    maxBonusPoints = totalBonus;
                    studentAttendances = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonusPoints)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");


        }
    }
}
