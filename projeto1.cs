using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
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
            int pos1 = 0;
            int pos2 = 0;

            Console.Write("Vetor: ");
            Imprime(vetor);
            Console.WriteLine(" ");

            Console.WriteLine("Escreva as posições que deseja trocar");

            do
            {
                Console.Write("1ª Posição:");
                pos1 = int.Parse(Console.ReadLine());

            } while (pos1 < 0 || pos1 > vetor.Length);

            do
            {
                Console.Write("2ª Posição:");
                pos2 = int.Parse(Console.ReadLine());

            } while (pos2 < 0 || pos2 > vetor.Length);

            Troca(vetor, pos1, pos2);

            Console.WriteLine("Trocando de posições:");
            Imprime(vetor);
            Console.WriteLine(" ");
        }
    }
}
