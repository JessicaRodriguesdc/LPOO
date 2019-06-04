using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Moto
    {
        private string marca;
        private string modelo;
        private string cor;
        

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void setcor(string cor)
        {
            this.cor = cor;
        }

        public string getMarca()
        {
            return marca;
        }

        public string getModelo()
        {
            return modelo;
        }

        public string getCor()
        {
            return cor;
        }


    }
}
        
        
    

