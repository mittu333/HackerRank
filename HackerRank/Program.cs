using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day8();
            //FindCommonStrings();
            Console.ReadLine();
        }

        #region Dictionary

        /// <summary>
        /// Dictionary
        /// </summary>
        public static void Day8()
        {
            //Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            string Name;
            int PhoneNum;
            string[] x = new string[2];
            Dictionary<string, Int32> PhoneBook = new Dictionary<string, Int32>();
            string[] nums = new string[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = Console.ReadLine();
                x = nums[i].Split(' ');
                Name = x[0].ToUpper();
                PhoneNum = int.Parse(x[1]);
                PhoneBook.Add(Name, PhoneNum);
            }
            //foreach(var k in PhoneBook)
            //{
            //    Console.WriteLine(k.Key + ' ' + k.Value);
            //}
            //Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();
                //try
                //{
                //    int result = PhoneBook[line.ToUpper()];
                //    Console.WriteLine(line + "=" + result.ToString());
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Not Found");
                //}

                //if( line.ToUpper() == "EXIT" || string.IsNullOrEmpty(line))
                //{
                //    break;
                //}

                if (PhoneBook.ContainsKey(line.ToUpper()))
                {
                    int result = PhoneBook[line.ToUpper()];
                    Console.WriteLine(line + "=" + result.ToString());
                }
                else
                {
                    Console.WriteLine("Not found");
                }

            }
            _ = Console.ReadLine();
        }
        #endregion
        /// <summary>
        /// Find Common Sub string from two string inputs using C# Hashsets.
        /// </summary>
        #region HashSets
        public static void FindCommonStrings()
        {
            string[] A1 = new string[] { "a", "b", "b", "c", "ac", "ca" };
            Console.WriteLine(string.Join(",", A1));
            Console.WriteLine("Below is using Hashset to remove diplicates");

            var h1 = new HashSet<string>(A1);
            string[] A2 = h1.ToArray();
            Console.WriteLine(string.Join(",", A2));

            string[] A3 = new string[] { "a", "b", "b" };
            var h2 = new HashSet<string>(A3);



        }
        #endregion
    }
}
