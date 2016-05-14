using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_amigos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum1 = 0;
            int sum2 = 0;

            Console.WriteLine("ingrese el primer numero ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {

                if (a % i == 0 )
                {
                    Console.WriteLine(i);
                    sum1 += i;


                }
            }
            Console.WriteLine("la suma es : " + sum1);
            Console.WriteLine();
            Console.WriteLine("ingrese el segundo numero ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < b; i++)
            {

                if (b % i == 0)
                {
                    Console.WriteLine(i);
                    sum2 += i;

                }
            }
            Console.WriteLine("la suma es : " + sum2);
            if (a == sum2 && b == sum1)
            {
                Console.WriteLine();
                Console.WriteLine("Los numero son amigos");
            }
            else
            {
                Console.WriteLine("Los numero no son amigos");
            }
            Console.ReadKey();
        }
    }
}


//int i = 1;

//while (true)
//{
//    a = Convert.ToInt32(Console.ReadLine());
//    if (a % i ==0 )
//    {

//        Console.WriteLine(i);
//        sum1 += i;
//        i++;
//    }

//}
//Console.ReadKey();
