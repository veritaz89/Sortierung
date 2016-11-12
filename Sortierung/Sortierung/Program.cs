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
            CallFunction();
        }
        public static void CallFunction()
        {
            int[] listeEins = new int[] { 1, 5, 8, 6, 7, 9, 2, 10 };
            int[] listAusgabe = new int[listeEins.Length];
            listAusgabe = Bubbelsort(listeEins);
            foreach (var item in listAusgabe)
            {
                Console.Write(item + " ");
            }

            int[] listeZwei = new int[] { 11, 8, 9, 6, 2, 1, 50 };

            /* foreach (var item in listeZwei)
             {
                 Console.Write(item + " ");
             }*/
            Console.ReadLine();
        }
        public static int[] Bubbelsort(int[] feld)
        {
            bool finshedsort;
            int tmp, counter = 0;
            do
            {
                finshedsort = true;
                for (int i = 0; i < feld.Length - 1; i++)
                {
                    if (feld[i] > feld[i + 1])
                    {
                        tmp = feld[i];
                        feld[i] = feld[i + 1];
                        feld[i + 1] = tmp;
                        finshedsort = false;
                    }
                    else
                    {
                        counter++;
                    }
                    if (counter == feld.Length-1)
                    {
                        finshedsort = true;
                    }
                }
            } while (!finshedsort);
            return feld;
        }
    }
}
