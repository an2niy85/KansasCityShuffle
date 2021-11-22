using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KansasCityShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Shuffle(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
            
        }

        public static void Shuffle(int[] array)
        {
            if (array.Length < 1) return;
            Random random = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                int key = array[i];
                int rnd = random.Next(i, array.Length);
                array[i] = array[rnd];
                array[rnd] = key;
            }
        }
    }
}
