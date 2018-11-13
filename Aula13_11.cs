using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13_11
{
    class Program
    {
        static void Troca(int[] vetor, int posicao1, int posicao2)
        {
            int aux = 0;
            aux = vetor[posicao1];
            vetor[posicao1] = vetor[posicao2];
            vetor[posicao2] = aux;
        }


        static void Imprime(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] vetor = new int[] { 12, 7, 15, 11, 27 };

            Console.WriteLine("Vetor");
            Imprime(vetor);
            Console.WriteLine(" ");

            Console.WriteLine("Escreva as posições que deseja trocar");

            Console.Write("1ª Posição:");
            int pos1 = int.Parse(Console.ReadLine());

            Console.Write("2ª Posição:");
            int pos2 = int.Parse(Console.ReadLine());

            Troca(vetor, pos1, pos2);

            Console.WriteLine("Trocando de posições:");
            Imprime(vetor);
            Console.WriteLine(" ");

        }
    }
}
