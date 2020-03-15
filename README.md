# CS-Interview-Questions
## Soluções de exercícios comuns em entrevistas para vaga de programador
## 1.Fatorial
Solução feita no Visual Studio com C# sobre como calcular um número 'n' natural e encontrar seu fatorial. Esse exemplo demonstra dois métodos para fazer o cálculo, por iteração e recursão.
```c#
using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número natural(inteiro e positivo) para definir o fatorial do mesmo(método recursão)");
            Console.WriteLine(FatorialRecursao(int.Parse(Console.ReadLine())).ToString());

            Console.WriteLine("Digite um número natural(inteiro e positivo) para definir o fatorial do mesmo(método iteração)");
            Console.WriteLine(FatorialIteracao(int.Parse(Console.ReadLine())).ToString());
        }

        public static int FatorialRecursao(int n)
        {
            //Se n for igual a 1 então retorne 1, senão multiplique n pela função Fatorial
            return n == 1 ? 1 : n * FatorialRecursao(n - 1);
        }

        public static int FatorialIteracao(int n)
        {            
            int fatorial = 1;
            //Para i igual ao valor de n, i maior ou igual a 1, subtraia i            
            for (int i = n; i >= 1; i--) 
            {
                //assim multiplique a variável fatorial por i e guarde o valor nela mesma
                fatorial *= i; 
            }
            //Se n for igual a 1 então retorne 1, senão retorne o valor da variável fatorial
            return n == 1 ? 1 : fatorial;                        
        }
    }
}
```
## 2.Fibonacci
Solução feita no Visual Studio com C# sobre como calcular a sequência de Fibonacci. Esse exemplo demonstra dois métodos para fazer o cálculo, por iteração e recursão.
```c#
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
