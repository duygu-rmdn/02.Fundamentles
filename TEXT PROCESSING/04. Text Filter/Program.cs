using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToReplace = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var item in wordsToReplace)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
