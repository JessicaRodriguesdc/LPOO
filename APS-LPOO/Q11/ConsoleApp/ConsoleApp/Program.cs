using System;

namespace ConsoleApp
{
    class Program
    {

            public static void Main(string[] args)
            {

                Juridica pj = new Juridica();
                Console.WriteLine("Informe seu Nome:");
                pj.escreverNome(Console.ReadLine());
                Console.WriteLine("Informe seu Cnpj:");
                pj.escreverCnpj(Console.ReadLine());
                Console.WriteLine("==========================");
                pj.imprimir();

                Console.ReadKey();

            }
    }
}

