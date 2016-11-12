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
            listAusgabe = Bubbelsort(listeEins,listeEins.Length);
            Console.WriteLine("Bubbelsort:");
            foreach (var item in listAusgabe)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Insertionsort:");
            int[] listeZwei = new int[] { 11, 8, 9, 6, 2, 1, 50 };
            Insertionsort(ref listeZwei);
             foreach (var item in listeZwei)
             {
                 Console.Write(item + " ");
             }
            Console.WriteLine();
            int[] listeDrei = new int[] { 5, 9, 71, 5, 1, 6, 15 };
            Selectionsort(listeDrei);
            Console.WriteLine("Selectionsort:");
            foreach (var item in listeDrei)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
        public static int[] Bubbelsort(int[] feld,int n)
        {            
            int tmp, counter = 0;
            if(n> 0)
            { 
                for (int i = 0; i < feld.Length - 1; i++)
                {
                    if (feld[i] > feld[i + 1])
                    {
                        tmp = feld[i];
                        feld[i] = feld[i + 1];
                        feld[i + 1] = tmp;                        
                    }
                    else
                    {
                        counter++;
                    }
                    if (counter == feld.Length-1)
                    {
                        return feld;
                    }
                }
                return Bubbelsort(feld, feld.Length - 1);
            } 
            return feld;
        }
        public static void Insertionsort(ref int[] feld)
        {
            int temp, j;
            for (int i = 1; i < feld.Length; i++)
            {
                temp = feld[i];
                j = i - 1;
                while (j >= 0 && feld[j] > temp)
                {
                    feld[j + 1] = feld[j];
                    j--;
                }
                feld[j + 1] = temp;
            }
        }
        public static void Selectionsort<T>(T[] feld) where T : IComparable
        {
            int min = 0;
            for (int i = 0; i < feld.Length; i++)
            {
                min = i;
                for (int j = 0; j < feld.Length; j++)
                {
                    if (feld[j].CompareTo(feld[min]) > 0)
                     {
                        T tmp = feld[j];
                        feld[j] = feld[min];
                        feld[min] = tmp;
                    }
                }
            }
        }
           
    }
}
