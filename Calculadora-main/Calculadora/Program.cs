using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            // // Cria uma pilha para armazenar os resultados 
            Stack<decimal> pilhaResultados = new Stack<decimal>();


            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();  // Retira a próxima operação da fila
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // // Empilha o resultado na pilha
                pilhaResultados.Push(operacao.resultado);
            }

            Console.WriteLine("\nTodos os resultados armazenados na pilha:");

            // Enquanto a pilha não estiver vazia
            while (pilhaResultados.Count > 0)
            {
                // Remove e obtém o valor do topo da pilha
                decimal resultado = pilhaResultados.Pop();

                // Exibe o resultado removido
                Console.WriteLine(resultado);
            }

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
