using System;
using System.Collections.Generic;
namespace C_Sharp_Collections_Practice
{
    class Program
    {
        // 1) Create an array to hold integer values 0 through 9
        public static void create_arr_0_9()
        {   
            int[] new_array = new int[10];
            int start = 0;
            int end = 9;
            int count = 0;
            for(int i = start; i <= end; i++)
                {
                    new_array[i] = count;
                    count = count + 1;
                }
            foreach (int x in new_array)
            {
            Console.Write($"{x} ");
            }

        }

        // 2) Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
        public static string[] create_array_str()
        {
            string[] myFriends = new string[] { "Tim", "Martin", "Nikki", "Sara"};
            for (int idx = 0; idx < myFriends.Length; idx++)
            {
                Console.WriteLine($"I own a {myFriends[idx]}");
            }
            return myFriends;
        }
        //    3) Create an array of length 10 that alternates between true and false values, starting with true
        public static void create_arr_true_false()
        {   
            bool[] new_array = new bool[10];
            int start = 0;
            int end = new_array.Length;
            for(int i = start; i < end; i+=2)
                {
                    new_array[i] = true;
                    new_array[i+1] = false;
                }
            foreach (bool x in new_array)
            {
            Console.Write($"{x} ");
            }

        }
        // 4) - ??????????? Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!) - ???????????
        public static List<string> create_list()
        {
            List<string> ice_cream = new List<string>();
            ice_cream.Add("Vanilla");
            ice_cream.Add("Blueberry");
            ice_cream.Add("Cherry");
            ice_cream.Add("Coffe");
            foreach (string icecream in ice_cream)
            {
            Console.WriteLine("-" + icecream);
            }
            Console.WriteLine(ice_cream.Count);
            Console.WriteLine(ice_cream[3]);
            return ice_cream;
            // remove:
            // ice_cream.Remove("Cherry");
            // foreach (string icecream in ice_cream)
            // {
            // Console.WriteLine("-" + icecream);
            // }
            // Console.WriteLine(ice_cream.Count);
        }

        // 5) Create a dictionary that will store both string keys as well as string values
        public static void creat_dict()
        {
            string[] myFriends = new string[] { "Tim", "Martin", "Nikki", "Sara"};            
            List<string> ice_cream = new List<string>();
            ice_cream.Add("Vanilla");
            ice_cream.Add("Blueberry");
            ice_cream.Add("Cherry");
            ice_cream.Add("Coffe");
            Dictionary<string,string> profile = new Dictionary<string,string>();
             foreach (var name in myFriends)
            {
                profile.Add(name, null);
            }
            Random rand = new Random();
            foreach (var name in myFriends)
            {
                int randInx = rand.Next(ice_cream.Count);
                profile[name] = ice_cream[randInx];
                ice_cream.RemoveAt(randInx);
            }

            foreach (var entry in profile)
            {
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }
        }





        public static void Main(string[] args)
        {
            string place = "World!";
            Console.WriteLine($"Hello {place}");
            create_arr_0_9();
            create_array_str();
            create_arr_true_false();
            Console.WriteLine();
            create_list();
            Console.WriteLine();
            creat_dict();



        }
        
        
    }
}
