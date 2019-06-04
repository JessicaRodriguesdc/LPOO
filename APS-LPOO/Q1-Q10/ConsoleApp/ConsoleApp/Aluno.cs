using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Aluno
    {
        private string nomeCompleto;
        private int matricula;
        private string cpf;

        //construtores
        public Aluno(string nomeCompleto, int matricula)
        {
            this.nomeCompleto = nomeCompleto;
            this.matricula = matricula;
        }

        public Aluno(string nomeCompleto, string cpf)
        {
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
        }

        //metodos
        public void imprimirNomeCompleto()
        {
            Console.WriteLine("Nome Completo: " + nomeCompleto);
        }

        public void imprimirMatricula()
        {
            Console.WriteLine("Matricula: " + matricula);
        }

        public void imprimirCpf()
        {
            Console.WriteLine("CPF: " + cpf);
        }
    }

}
