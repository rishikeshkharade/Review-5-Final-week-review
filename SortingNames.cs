using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5__Final_week_Review_
{
    class SortingNames
    {
        public static void SortingNamesMain()
        {

            List<string> names = new List<string>();

            GetNames(names);

            if (names.Count == 0)
            {
                Console.WriteLine("No names were found");
                return;
            }

            Console.WriteLine("Unsorted Names: ");
            DisplayNames(names);

            BubbleSort(names);

            Console.WriteLine("\nSorted Names: ");
            DisplayNames(names);

            Console.ReadKey();

        }

        static void GetNames(List<string> names)
        {
            Console.WriteLine("Enter names (one per line), or press Enter to finish:");

            while (true)
            {

                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                names.Add(input);
            }
        }

        static void DisplayNames(List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
            }
        }

        static void BubbleSort(List<string> names)
        {
            int n = names.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
