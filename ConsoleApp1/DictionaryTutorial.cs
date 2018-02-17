using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class DictionaryTutorial
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Honda";
            car.Vin = "B2";
            car.Year = 1988;
            Console.WriteLine(car);

            IDictionary<int, string> dicc = new Dictionary<int, string>();
            IDictionary<string, Car> dict = new Dictionary<string, Car>();
            IDictionary<string, int> dictt = new Dictionary<string, int>();
            IList<string> exe = new List<string>();
            ISet<string> eee = new SortedSet<string>();
            exe.Add("taiwo");
            eee.Add("florence");

            dictt.Add("one", 1);
            dictt.Add("two", 2);


            dicc.Add(1, "Abake");
            dicc.Add(2, "Oluokun");
            dicc.Add(3, "Yomi");
            dicc.Add(4, "Oyewole");
            dict.Add(car.Vin, car);
            dicc.Remove(3);

            Console.WriteLine(dicc[1]);
            Console.WriteLine(dict["B2"].Year);
            try
            {
                Console.WriteLine(dicc[3]);
                //Console.WriteLine(dict["B2"].Year);
            }
            catch (Exception)
            {
                Console.WriteLine("The given key " + "{dicc[3]}" + " was not present in the dictionary");

            }



            /* for (int item = 0; item < dicc.Count; item++)
             {

                 Console.WriteLine(dicc.Values.ElementAt(item));
                 //Console.ReadLine();
             }
             int size = dicc.Count();
             Console.WriteLine(size);*/
            foreach (var item in dicc)
            {


                Console.WriteLine("Key:{0}, Value:{1} ", item.Key, item.Value);
                //Console.WriteLine(item);

            }
            Console.ReadLine();
        }
        class Car
        {
            public string Make { get; set; }
            public string Vin { get; set; }
            public int Year { get; set; }
        }
    }
}
