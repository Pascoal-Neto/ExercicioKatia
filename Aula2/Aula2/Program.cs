using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entrada en = new Entrada();
            Filme fi = new Filme();

            Console.Write("Filme:");
            string titulo = Console.ReadLine();
            Console.Write("Sinopse:");
            string sinopse = Console.ReadLine();
            Console.Write("Genero:");
            string genero = Console.ReadLine();
            Console.Write("Classificação:");
            string classificacao = Console.ReadLine();
            fi.receber(titulo, sinopse, genero, classificacao);

            Console.Write("Poltrona:");
            en.Setpoltrona(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Valor da Entrada: ");
            en.Setvalor(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Dia e Hora: ");
            en.Setdata(Convert.ToInt32(Console.ReadLine()));



            Console.WriteLine("\nPoltronas: " + en.Getpoltrona() + "\nValor da Entrada: " + en.Getvalor().ToString("c") + "\nDia e Hora:" + en.Gethora());
            Console.WriteLine(fi.mostrar());




            Console.ReadKey();

        }
    }
}
