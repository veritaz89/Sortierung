using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortierung
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void CallFunction()
        {
            int[] listeEins = new int[] { 1, 5, 8, 6, 7, 9, 2, 10 };

            foreach (var item in listeEins)
            {
                Console.Write(item + " ");
            }

            int[] listeZwei = new int[] { 11, 8, 9, 6, 2, 1, 50 };

            foreach (var item in listeZwei)
            {
                Console.Write(item + " ");
            }
        }
    }
}
