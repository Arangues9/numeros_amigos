using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_amigos_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int cont = 1;
            int a = 0;
            int b = 0;
            Console.WriteLine("ingrese el primer numero ");
            n1 = Convert.ToInt32(Console.ReadLine());
            while (cont < n1)
            {
                
                if (n1 % cont == 0)
                {
                    Console.WriteLine(cont);
                    a += cont;
                }
                cont++;
            }
            Console.WriteLine("la suma es : " + a);
            Console.WriteLine();

            Console.WriteLine("ingrese el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            cont = 1;
            while (cont < n2)
            {

                if (n2 % cont == 0)
                {
                    Console.WriteLine(cont);
                   b += cont;
                }
                cont++;
            }
            Console.WriteLine("la suma es : " + b);
            Console.WriteLine();



            if (n1 == b && n2 == a) 
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
//////////////////////////////////////////////////////////////////////////

//        static void Main(string[] args)
//        {
//            int n1;
//            int n2;
//            int cont = 1;
//            int a = 0;
//            int b = 0;
//            Console.WriteLine("ingrese el primer numero ");
//            n1 = Convert.ToInt32(Console.ReadLine());
//            while (cont < n1)
//            {
                
//                if (n1 % cont == 0)
//                {
//                    Console.WriteLine(cont);
//                    a += cont;
//                }
//                cont++;
//            }
//            Console.WriteLine("la suma es : " + a);
//            Console.WriteLine();

//            Console.WriteLine("ingrese el segundo numero");
//            n2 = Convert.ToInt32(Console.ReadLine());
//            cont = 1;
//            while (cont < n2)
//            {

//                if (n2 % cont == 0)
//                {
//                    Console.WriteLine(cont);
//                   b += cont;
//                }
//                cont++;
//            }
//            Console.WriteLine("la suma es : " + b);
//            Console.WriteLine();



//            if (n1 == b && n2 == a) 
//            {
//                Console.WriteLine();
//                Console.WriteLine("Los numero son amigos");
//            }
//            else
//            {
//                Console.WriteLine("Los numero no son amigos");
//            }

//            Console.ReadKey();
//        }
   
//    }

//}



