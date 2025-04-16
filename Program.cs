using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            int tamanho = 5;
            int i;
            int[] lista = new int[5];
            lista[0] = 10;
            lista[1] = 20;
            lista[2] = 30;
            lista[3] = 2;
            lista[4] = 4;

            for (i = 0; i < tamanho; i++)
            {
            Console.WriteLine("Valor: {0}", lista[0]);
            }*/

            /*int i;
            int tamanho = 5;
            int[] lista = new int[tamanho];

            for (i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor: ");
                lista[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Valor: {0}", lista[0]);
            }*/

            /*
            Console.WriteLine("Digitie um valor: ");
            i = int.Parse(Console.ReadLine());

            if (i == lista.Length)
            {
                Console.WriteLine("O valor está na posição: " + lista);
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Valor inválido");
                Console.ReadLine();

            }*/

            Carro fusca = new Carro();


            fusca.rodas[0] = new Roda();
            
            /*fusca.fd.aro = 17;
            fusca.fe.aro = 17;
            fusca.fe.material = "aluminio";
            fusca.fd.material = "aluminio";*/

        }
    }
}
