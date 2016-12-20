using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    class TwelveDaysOfChristmas
    {

        static void Main(string[] args)
        {
            List<string> days = new List<string>();
            days.Add("first");
            days.Add("second");
            days.Add("third");
            days.Add("fourth");
            days.Add("fifth");
            days.Add("sixth");
            days.Add("seventh");
            days.Add("eigth");
            days.Add("ninth");
            days.Add("tenth");
            days.Add("eleventh");
            days.Add("twelfth");

            List<string> gifts = new List<string>();
            gifts.Add("A Partridge in a pear tree");
            gifts.Add("Turtle Doves");
            gifts.Add("French Hens");
            gifts.Add("Calling Birds");
            gifts.Add("Golden Rings");
            gifts.Add("Geese a Laying");
            gifts.Add("Swans a Swimming");
            gifts.Add("Maids a Milking");
            gifts.Add("Ladies Dancing");
            gifts.Add("Lords a Leaping");
            gifts.Add("Pipers Piping");
            gifts.Add("Drummers Drumming");

            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine("On the {0} day of Christmas\nmy true love gave to me:", days[i]);

                int j = i + 1;
                foreach (string item in gifts.Take(i + 1).Reverse())
                {
                    if (i != 0 && item == "Partridge in a Pear Tree")
                        Console.WriteLine("and 1 {0}", item);
                    else
                        Console.WriteLine("{0} {1}", j, item);
                    j--;
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(5000);
            }

            Console.WriteLine("Ding song is done");
            Console.ReadKey();
        }
    }
}
    

