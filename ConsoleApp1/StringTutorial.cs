using System;

namespace ConsoleApp1
{
    class StringTutorial
    {
        public static void Main()
        {

            //Console.WriteLine(MakeLine(0, 5, ", "));
            // Console.WriteLine(MakeLine(1, 6, "  "));
            // Console.WriteLine(MakeLine(9, 9, ": "));
            // Console.WriteLine(MakeLine(4, 7, "< "));
            Console.WriteLine(JoinExample());

            Console.Read();
        }

        private static string MakeLine(int initVal, int multVal, string sep)
        {

            string[] sArr = new string[10];

            for (int i = initVal; i < initVal + 10; i++)
                sArr[i - initVal] = String.Format("{0,-3}", i * multVal);

            return String.Join(sep, sArr);
        }

        private static string JoinExample()
        {
            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 1105967, 1148203 };
            String s = String.Format("{0,-6} {1,-15}\n\n", "Year", "Population");
            for (int index = 0; index < years.Length; index++)
                s += String.Format("{0,-6} {1,-15:N0}\n",
                                   years[index], population[index]);
            return s;
        }
    }
}
