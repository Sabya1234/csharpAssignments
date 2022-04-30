using System;
using System.Collections.Generic;

namespace CollectionExercise
{
    class Program
    {
       public static  List<string> citynames = new List<string>();


        public static void PrintCityNames()
        {
            foreach (string city in citynames)
            {
                Console.WriteLine(" " + city);
            }

        }
        public static void ReplaceCityName(string city,string newCity)
        {
           for (int i=0;i<citynames.Count;i++)
            {
                if(citynames[i].Equals(city))
                {
                    citynames[i] = newCity;
                }
            }
        }


        public static void FindCityName(string citytoBeFind)
        {
            bool cityPresent = false;
            for (int i = 0; i < citynames.Count; i++)
            {
                if (citynames[i].Equals(citytoBeFind))
                {
                    cityPresent = true;
                    break;
                }
            }
            if(cityPresent)
            {
                Console.WriteLine("City name is present ? {0}", cityPresent);
            }
           
        }
        static void Main(string[] args)
        {
            
            citynames.Add("Bangalore");
            citynames.Add("Chennai");
            citynames.Add("Delhi");
            citynames.Add("Mumbai");

            Console.WriteLine("==========The City Names are==========");
            PrintCityNames();

            //Removing an Item from List
            citynames.Remove("Bangalore");
            Console.WriteLine("==========The City Names are after removal of one item==========");
            PrintCityNames();

            citynames.Add("Hyderabad");
            ReplaceCityName("Chennai","Pune");
            Console.WriteLine("==========The City Names are after Adding  of one new item and replacing one of the exiting item with new item==========");
            PrintCityNames();
            Console.WriteLine("Kindly enter a city Name you want to find in list:");
            string cityToBeFind = Console.ReadLine().ToString();
            FindCityName(cityToBeFind);

        }
    }
}
