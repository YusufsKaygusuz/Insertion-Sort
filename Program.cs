using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 12,8,27,2,6,19,10};

            for (int i=0; i<Numbers.Length; i++)
            {
                int temp = Numbers[i];
                int j = i;

                while (j > 0 && Numbers[j-1]>temp)
                {
                    Numbers[j] = Numbers[j - 1];
                    j--;
                }
                Numbers[j] = temp;
            }

            for(int i = 0; i< Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.ReadLine();
        
        }


    }
}
