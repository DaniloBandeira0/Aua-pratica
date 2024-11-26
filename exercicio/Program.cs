using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.

            int numero = 0;
            Console.Write("Digite um numero");

            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {

                Console.WriteLine(" NUMERO E POSITIVO");

            }
            else if (numero < 0)
            {
                Console.WriteLine(" NUMERO E NEGATIVO");

            }
            else if (numero == 0)
            {
                Console.WriteLine("NUMERO IGUAL A  0");
            }


            //Escreva um programa que leia um mês do ano e informe quantos dias ele tem.
            {
                Console.WriteLine("Digite o número do mês (1-12): ");
                int mes = int.Parse(Console.ReadLine());

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    Console.WriteLine("O mês tem 31 dias.");
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    Console.WriteLine("O mês tem 30 dias.");
                }
                else if (mes == 2)
                {
                    Console.WriteLine("O mês de fevereiro pode ter 28 ou 29 dias (dependendo se é ano bissexto).");
                }
                else
                {
                    Console.WriteLine("Número inválido. Por favor, insira um número entre 1 e 12.");
                }

                //Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5)
                float nota = 0;

                Console.WriteLine("Digite a nota");
                nota = float.Parse(Console.ReadLine());

               

                if (nota >= 7)
                {
                    Console.WriteLine("Voce esta aprovado!");

                }
                else if (nota <= 4)
                {
                    Console.WriteLine("Voce está reprovado!");
                }
                else if (nota >= 5 && nota <= 6)
                {
                    Console.WriteLine("Voce está de recuperação");
                }
                else if (nota > 10)
                {
                    Console.WriteLine("Escolha uma nota entre 1 e 10");

                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
                //Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição. //5050

                int soma = 0;
                for (int i = 1; i <= 100; i++)
                {
                    soma += i;
                }
                Console.WriteLine("A SOMA DE TODOS OS NUMEROS DE 1 A 100 É :" +soma + ".");


                //Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.

                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }

                //Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e informe se ele
                //está aprovado (média maior ou igual a 7) ou reprovado.

                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a primeira nota: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                float nota3 = float.Parse(Console.ReadLine());

                float media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine($"A média do aluno {nome} é {media:F2}.");

                if (media >= 7)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }





            }
        }
    }
}






