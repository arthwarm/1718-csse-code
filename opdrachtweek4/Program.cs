using System;

class Program
{
    public static int Fibonacci(int n)
    {
        
        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Geef een getal in: ");
        int Getal =  Convert.ToInt32(Console.ReadLine());
        



        for (int i = 0; i < Getal+1; i++)
        {
            Console.WriteLine(i);
        }
        
        int k ;
            Console.WriteLine("0 is geen priem getal");
            Console.WriteLine("1 is geen priem getal");


        
        for (int i=2; i<Getal+1; i++)
          {
            bool kip = true;
            for(k = 2; k<i; k++)
            {
            if(i%k == 0){
              kip = false; 
              break;
            }
            }
             if(kip == true){
               Console.WriteLine(i + " is een priem getal");
             } else {
               Console.WriteLine(i + " is geen priem getal");
             }
            }
        for (int i = 0; i < Getal; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}