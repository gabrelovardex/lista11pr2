
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista11pr2
{
    internal class Program
    {
        
       

        public static class Programa
    {
        public static void ExecutarExercicio1()
        {
            int[] frutas = new int[1000];
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                frutas[i] = random.Next(1, 1000);
            }

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < 1000; i++)
            {
                if (numero == frutas[i])
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("O número digitado está no vetor de frutas.");
            }
            else
            {
                Console.WriteLine("O número digitado NÃO está no vetor de frutas.");
            }
        }

        public static void ExecutarExercicio2()
        {
            int[] frutas = new int[20000];
            Random random = new Random();

            for (int i = 0; i < 20000; i++)
            {
                frutas[i] = random.Next(1, 20000);
            }

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int contagem = 0;

            for (int i = 0; i < 20000; i++)
            {
                if (numero == frutas[i])
                {
                    contagem++;
                }
            }

            Console.WriteLine("O número " + numero + " aparece " + contagem + " vezes.");
        }

        public static void ExecutarExercicio3()
        {
            int[] frutas = new int[10];
            int[] frutasAlteradas = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                frutas[i] = random.Next(1, 10);

                if (i % 2 == 0)
                {
                    frutasAlteradas[i] = frutas[i] / 2;
                }
                else
                {
                    frutasAlteradas[i] = frutas[i] * 3;
                }
            }

            Console.WriteLine("Vetor de frutas original:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Posição [{0}] = {1}", i, frutas[i]);
            }

            Console.WriteLine("Vetor de frutas alterado:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Posição [{0}] = {1}", i, frutasAlteradas[i]);
            }
        }

        public static void ExecutarExercicio4()
        {
            int[] frutas = new int[5000];
            Random random = new Random();

            for (int i = 0; i < 5000; i++)
            {
                frutas[i] = random.Next(1, 5000);
            }

            Console.WriteLine("Números primos encontrados:");

            for (int i = 0; i < 5000; i++)
            {
                if (EhPrimo(frutas[i]))
                {
                    Console.WriteLine(frutas[i] + " é um número primo.");
                }
            }
        }

        public static bool EhPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("================== Menu ==================");
                Console.WriteLine("Digite 0 para sair");
                Console.WriteLine("Digite 1 para executar o exercício 1");
                Console.WriteLine("Digite 2 para executar o exercício 2");
                Console.WriteLine("Digite 3 para executar o exercício 3");
                Console.WriteLine("Digite 4 para executar o exercício 4");
                Console.WriteLine("=========================================");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ExecutarExercicio1();
                        break;
                    case 2:
                        ExecutarExercicio2();
                        break;
                    case 3:
                        ExecutarExercicio3();
                        break;
                    case 4:
                        ExecutarExercicio4();
                        break;
                    default:
                        Console.WriteLine("Número de exercício inválido");
                        break;
                }
            } while (opcao != 0);
        }
    }

    static void Main(string[] args)
        {



        }
    }
}
