using System;

namespace Pegunta2Fibonacci;

class program
{
    /*Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
    (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
    ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
    IMPORTANTE:
    Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/

    static void Main(string[] args)
    {
        //acima de 46 ultrapassa a capacidade numerica do tipo int
        int quantElementos = 46;

        //cada numero fibonacci é formado tendo 2 valores como parametro 
        var numeroFibo = new List<int> { 0, 1 };

        //criação de numeros fibonacci e adição de cada elemento à lista
        //de acordo com a quantidade maxima estipulada
        while(numeroFibo.Count <= quantElementos)
        {
            var ultimoNumero = numeroFibo[numeroFibo.Count - 1];
            var numeroAnterior = numeroFibo[numeroFibo.Count - 2];
            var elemento = ultimoNumero + numeroAnterior;
            //formação da lista
            numeroFibo.Add(elemento);

            //nome mais adequado para facilar o proximo passo.
            var listaFibonacci = elemento;

            Console.WriteLine(listaFibonacci);
        }
    }

}