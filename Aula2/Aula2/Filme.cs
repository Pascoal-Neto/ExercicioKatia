using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        string classificacao;

        public void receber(string ti, string si, string ge, string cl)
        {
            this.titulo = ti;
            this.sinopse = si;
            this.genero = ge;
            this.classificacao = cl;

        }
        public string mostrar()
        {
            return "Titulo:" + this.titulo + "\nSinopse:" + this.sinopse + "\nGenero" + this.genero + "\nClassificação" + this.classificacao;
        }



    }
}
