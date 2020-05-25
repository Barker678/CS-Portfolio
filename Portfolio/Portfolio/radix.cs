using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio
{
    //this Doesn't really work
    class Radix
    {
        private int[] data;
        private IList<IList<int>> digits = new List<IList<int>>();
        private int maxLength = 0;
        public Radix()
        {
            for (int i = 0; i < 10; i++)
            {
                digits.Add(new List<int>());
            }
            Console.WriteLine("Enter the amount to be sorted: ");
            int count = int.Parse(Console.ReadLine());
            data = new int[count];
            Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter amount {0} : ", i + 1);

                data[i] = int.Parse(Console.ReadLine());

                if (maxLength < data[i].ToString().Length)
                    maxLength = data[i].ToString().Length;
            }
        }

        public void Radixsort()
        {
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; i < maxLength; j++)
                {
                    //Gets stuck here with an exception
                    int digit = (int) ((data[j] % Math.Pow(10, i + 1)) / Math.Pow(10, i));

                    digits[digit].Add(data[j]);
                }

                int index = 0;
                for (int k = 0; k < digits.Count; k++)
                {
                IList<int> selDigit = digits[k];

                    for(int l = 0; l < selDigit.Count; l++)
                    {
                        data[index++] = selDigit[l];
                    }
                }
                ClearDigits();
            }
            PrintSortedData();
        }

        private void ClearDigits()
        {
            for (int k = 0; k < digits.Count; k++)
            {
                digits[k].Clear();
            }
        }
        public void PrintSortedData()
        {
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

    }
}
