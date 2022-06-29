using System;

namespace CountSubString
{
    class CountSubstrings
    {
        static void Main(string[] args)
        {
            string[] eingabe = {"xhixhix", "xhixhix", "mic", "haha", "xxxxyz"};
            string[] suche = {"x", "hi", "mic", "ho", "xx"};
            CountSubstring(eingabe, suche);
            Console.ReadKey();
        }

        static void CountSubstring(string[] words, string[] toCounts)
        {
            int i = 0;
            foreach(string w in words)
            {
                int gezaehlt = w.Split(toCounts[i]).Length - 1;
                Console.WriteLine("'" + toCounts[i]+ "'" + " ist " + gezaehlt + " mal im Wort " + "'" + w + "'");
                Console.WriteLine("");
                i++;
            }
        }
    }
}
