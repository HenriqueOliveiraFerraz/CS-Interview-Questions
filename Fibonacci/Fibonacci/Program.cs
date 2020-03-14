using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da sequêncida de Fibonacci(método recursão): ");
            int tamanho1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < tamanho1; i++)
            {
                Console.Write("{0} ", FibonacciRecursao(i));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite o tamanho da sequêncida de Fibonacci(método iteração): ");
            int tamanho2 = int.Parse(Console.ReadLine());
            for (int j = 0; j < tamanho2; j++)
            {
                Console.Write("{0} ", FibonacciIteracao(j));
            }
            Console.WriteLine();
        }

        public static int FibonacciIteracao(int n)
        {
            int num1 = 0, num2 = 1, resultado = 0;
            if (n == 0) return 0; //Retorna o primeiro número da sequência 
            if (n == 1) return 1; //Retorna o segundo número da sequência
            for(int i = 2; i <= n; i++)
            {
                resultado = num1 + num2;
                num1 = num2;
                num2 = resultado;
            }
            return resultado;
        }

        public static int FibonacciRecursao(int n)
        {
            if (n == 0) return 0; //Retorna o primeiro número da sequência 
            if (n == 1) return 1; //Retorna o segundo número da sequência  
            return FibonacciRecursao(n - 1) + FibonacciRecursao(n - 2);
        }
    }
}
