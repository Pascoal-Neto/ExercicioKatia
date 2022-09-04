using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Entrada
    {
        int valor;
        int poltrona;
        double data;
        double hora;

        public void Setvalor(int valor)
        {
            this.valor = valor;
        }
        public int Getvalor()
        {
            return this.valor;
        }
        public void Setpoltrona(int poltrona)
        {
            this.poltrona = poltrona;
        }
        public int Getpoltrona()
        {
            return this.poltrona;
        }
        public void Setdata(double data)
        {
            this.data = data;
        }
        public double Getdata()
        {
            return this.data;
        }
        public void Sethora(double hora)
        {
            this.hora = hora;
        }
        public double Gethora()
        {
            return this.hora;
        }
    }
}
