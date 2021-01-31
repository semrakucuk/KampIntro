using System;

namespace HomeworkMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Semra");
            dictionary.Add(2, "Sema");
         //    Console.WriteLine(dictionary.key[0].ToString());

            for (int i = 0; i < dictionary.key.Length; i++)
            {
                Console.WriteLine(dictionary.key[i] + "- " + dictionary.value[i]);
            }
        }
    }

}
