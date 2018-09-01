using System;

namespace EXERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 1
            //Escreva um aplicativo que apresente os números de 1 a 40 separados por um espaço em branco, da seguinte maneira:
            // a. Use uma única instrução ​Console.Write
            {
                Console.WriteLine("Exercicio 1");
                Console.ReadLine();
                Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40.");
                Console.ReadLine();

                //b. Use quatro instruções ​Console.Write

                Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10;");
                Console.WriteLine("11, 12, 13, 14, 15, 16, 17, 18, 19, 20");
                Console.WriteLine("21, 22, 23, 24, 25, 26, 27, 28, 29, 30");
                Console.WriteLine("31, 32, 33, 34, 35, 36, 37, 38, 39, 40");
                Console.ReadLine();

                Console.Clear();

                // EXERCICIO 2
                // O que aparece na janela do console, quando cada uma das instruções C# abaixo são executadas, para ​x = 2​ e ​y = 3 ​?   

                //a. Console.WriteLine(“x = ” + x);
                //b. Console.WriteLine(“O valor de x + x é ” + (x + x)); 
                //c. Console.WriteLine(“x = ”); 
                //d.Console.WriteLine((x + y) + “ = “ +(y + x));

                Console.WriteLine("Exercicio 2");
                Console.ReadLine();

                var y = 3;
                var x = 2;
                Console.WriteLine("x=" + x);
                Console.ReadLine();
                Console.WriteLine("O valor de X+X é: {0}", x + x);
                Console.ReadLine();
                Console.WriteLine("x = {0}", x);
                Console.ReadLine();
                Console.WriteLine((x + y) + " = " + (y + x));
                Console.ReadLine();

                Console.Clear();

                //EXERCICIO 3
                Console.WriteLine("Exercicio 3");
                Console.ReadLine();
                Console.WriteLine("*\n * *\n * **\n * ***\n * ****");
                Console.ReadLine();

                Console.Clear();

                //EXERCICIO 4 
                Console.WriteLine("Exercicio 4");
                Console.ReadLine();
                Console.Write("*");
                Console.Write("***");
                Console.WriteLine("*****");
                Console.Write("****");
                Console.WriteLine("**");
                Console.ReadLine();

                Console.Clear();

                //EXERCICIO 5
                /*Escreva um programa que leia o nome, o sobrenome e o número de matrícula de um
                 *estudante. Em seguida, formate e imprima os dados lidos da seguinte forma: 
                 * 99999 nome sobrenome​, onde, o número de matrícula e nome deverão ter cores de fonte 
                 * diferentes à sua escolha. Dica: pesquise pela propriedade ​Console.ForegroundColor */

                Console.WriteLine("Exercicio 5");
                Console.ReadLine();

                Console.Write("Escreva seu nome:");
                //Preferi usar o Write do que o WriteLine
                var Nome = Console.ReadLine();
                Console.Write("Escreva seu sobrenome:");
                var sobrenome = Console.ReadLine();
                Console.Write("Escreva seu RA:");
                var RA = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" {RA} - {Nome} {sobrenome}");
                //Pra que serve o $??
                Console.ReadLine();

                //EXERCICIO 6
                /*Escreva um programa que solicite do usuário dois números, e imprima o resultado da 
                 *soma, subtração, multiplicação e divisão.  */

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Exercicio 6");
                Console.ReadLine();

                Console.Write("Digite o primeiro numero:");
                int numero1 = Int32.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero:");
                int numero2 = Int32.Parse(Console.ReadLine());

                int soma = numero1 + numero2;
                Console.WriteLine("{0} + {1} = {2}", numero1, numero2, soma);

                int subtração = numero1 - numero2;
                Console.WriteLine("{0} - {1} = {2}", numero1, numero2, subtração);

                int multiplica = numero1 * numero2;
                Console.WriteLine("{0} * {1} = {2}", numero1, numero2, multiplica);

                int dividi = numero1 / numero2;
                Console.WriteLine("{0} / {1} = {2}", numero1, numero2, dividi);

                Console.ReadLine();

                //EXERCICIO 7
                /* Escreva um programa que receba como entrada o raio de um círculo e imprima o diâmetro, a circunferência e a área. 
                 * Para isso, utilize as fórmulas: diâmetro = 2r; circunferência = 2πr, área = πr²*/

                Console.WriteLine("Exercicio 7");
                Console.ReadLine();

                Console.Write("Digite o valor do raio:");
                double raio = Int32.Parse(Console.ReadLine());

                double diametro = 2 * raio;
                double circunferencia = (2 * Math.PI * raio);
                double area = (Math.PI * Math.Pow(raio, 2));

                Console.WriteLine("Diametro ={0}", diametro);
                Console.WriteLine("Circunferência ={0}", circunferencia);
                Console.WriteLine("Área ={0}", area);

                Console.ReadLine();

                //EXERCICIO 8
                /*Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro é um múltiplo do segundo. 
                 * Por exemplo: se o usuário digitar 15 e 3, o primeiro número será múltiplo do segundo; 
                 * se o usuário digitar 2 e 4, o primeiro número não será múltiplo do segundo. ​
                 * Dica: use o operador módulo para obter o resto da divisão.*/

                Console.WriteLine("Exercicio 8");
                Console.ReadLine();

                Console.WriteLine("Digite um numero inteiro e diferente de 0");
                Console.Write("Digite o primeiro numero:");
                int numerointeiro1 = Int32.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero:");
                int numerointeiro2 = Int32.Parse(Console.ReadLine());
                int restodiv = numerointeiro1 % numerointeiro2;

                if (restodiv>0)
                Console.WriteLine("{0} não é multiplo de {1}", numerointeiro1, numerointeiro2);
                else
                    Console.WriteLine("{0} não é multiplo de {1}", numerointeiro1, numerointeiro2);
                Console.ReadLine();

                
                //EXERCICIO 9
                /*Escrevaumprogramaquerecebacomoentradaumnúmerode5dígitos,separeonúmero em dígitos individuais e os imprima separados por 3 espaços cada um.
                 *Dica: utilize as operações de divisão e módulo para extrair cada dígito do número.*/

                Console.WriteLine("Exercicio 9");
                Console.ReadLine();

                int unidade = 0;
                int dezena = 0;
                int centena = 0;
                int unidademilhar = 0;
                int dezmilhar = 0;
                int quociente = 0;

                const int DECIMAL = 10;

                Console.Write("Escreva um numero de 5 digitos: ");
                int numero5digitos = Int32.Parse(Console.ReadLine());

                //Digito da unidade
                restodiv = numero5digitos % DECIMAL;
                quociente = numero5digitos / DECIMAL;
                unidade = restodiv;

                //Digito da dezena
                restodiv = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                dezena = restodiv;

                //Digito da centena
                restodiv = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                centena = restodiv;

                //Digito da unidademilhar
                restodiv = quociente % DECIMAL;
                quociente = quociente / DECIMAL;
                unidademilhar = restodiv;

                //Digito da dezmilhar
                dezmilhar = quociente;

                Console.WriteLine("Número Espaçado: {0}   {1}   {2}   {3}   {4}", dezmilhar, unidademilhar, centena, dezena, unidade);
                Console.ReadLine();

                //EXERCICIO 10
                /*Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10, e imprima os valores em forma de tabela.*/

                Console.WriteLine("Exercicio 10");             
                Console.ReadLine();


                int numero = 0;
                double quadrado = 0.0;
                double cubo = 0.0;

                Console.WriteLine("\nNumero\t\tQuadrado\tCubo");

                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                numero = numero + 1;
                quadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

                Console.ReadLine();


            }
        }
    }
}


