using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    internal class Roda
    {
        public int aro;
        public string material;
        public string posicao;

        public void cadastro()
        {
            Console.WriteLine("Digite o material: ");
            this.material = Console.ReadLine();
            Console.WriteLine("Digite o Aro: ");
            this.aro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a posição da roda");
            this.posicao = Console.ReadLine();
        }

        public void exibir()
        {
            Console.WriteLine("Material {0}", this.material);
            Console.WriteLine("Aro {0}", this.aro);
            Console.WriteLine("Posição {0}", this.posicao);
        }
    }
}
