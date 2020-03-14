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
