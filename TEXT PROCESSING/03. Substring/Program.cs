using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(textToRemove);

            while (index != -1)
            {
                text = text.Remove(index, textToRemove.Length);
                index = text.IndexOf(textToRemove);
            }
            Console.WriteLine(text);
        }
    }
}
