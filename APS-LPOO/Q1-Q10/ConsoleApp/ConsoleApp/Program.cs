using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno nvaluno = new Aluno("JESSICA", "123456");
            nvaluno.imprimirNomeCompleto();
            nvaluno.imprimirMatricula();
            nvaluno.imprimirCpf();



            Moto nvmoto = new Moto("fusca", "leno", "vermelho", 4, 0, 5, true);
            nvmoto.subirMacha();
            nvmoto.desligar();
            //nvmoto.descerMacha();
            nvmoto.imprimir();

            Console.ReadKey();


        }
    }
}
