using System;
using System.Collections;

namespace CSSE
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Geef een getal in: ");
          int Getal =  Convert.ToInt32(Console.ReadLine());
          int Getal2 = 0;
          string[] arr = new string[11];
        List<string> list = new List<string>();
        Hashtable hashtable = new Hashtable();

          for (int i=0; i<11; i++)
          {
              Getal2 = i*Getal;
              string resultaat = i +" X " + Getal + " = " + Getal2;
                list.add(resultaat);
                hashtable[i] = resultaat; 
              arr[i] = resultaat;
            Console.WriteLine(resultaat);
          }
            
            for (int i=0; i<arr.Length; i++)
            {
            Console.WriteLine(arr[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
            Console.WriteLine(list[i]);
            }
            foreach (string value in hashtable.Values)            {
            Console.WriteLine(value);
        }
            }
        }
    }

