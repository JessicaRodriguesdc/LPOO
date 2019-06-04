using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Fisica : Pessoa
    {
        private string cpf;

        public void escreverCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public override bool validarDocumento()
        {
            if (this.cpf != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void imprimir()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("cpf: " + cpf);
            Console.WriteLine("Documento Validado: " + validarDocumento());
        }
    }
}
