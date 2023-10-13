using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Week
{
    internal class Exercises
    {
        public string[] BubbleSort(string[] names)
        {
            //List<int> list = new List<int>();
            //foreach(string name in names)
            //{
            //    int ascii = (int)name[0];
            //    list.Add(ascii);
            //}
            //int[] letters = list.ToArray();

            for (int i = names.Length - 1; i >= 0; i--)
            {
                // Console.WriteLine(String.Join(" ",array));
                for (int j = 0; j < i; j++)
                {
                    int ascii1 = (int)names[j][0];
                    int ascii2 = (int)names[j+1][0];
                    if (ascii1 > ascii2)
                    {
                        string b = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = b;
                    }
                }
            }

            return names;
        }
        public void BucketSort(string[] names)
        {

        }
        
    }
}
