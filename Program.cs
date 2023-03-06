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
        while (numeroFibo.Count <= quantElementos)
        {
            var ultimoNumero = numeroFibo[numeroFibo.Count - 1];
            var numeroAnterior = numeroFibo[numeroFibo.Count - 2];
            var elemento = ultimoNumero + numeroAnterior;
            //formação da lista
            numeroFibo.Add(elemento);

            //nome mais adequado para facilar o proximo passo.
            var listaFibonacci = elemento;

            //Console.WriteLine(listaFibonacci);
        }
        //lista Fibonacci baseada no comando acima. Caso queira verificar, descomente-o. 
        var sequenciaFibonacci = new List<int> { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,
        610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811,
        514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169,
        63245986, 102334155, 165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903 };

        Console.WriteLine("Quer saber se um numero é Fibonacci?");
        Console.WriteLine("Mas vou logo avisando: ");
        Console.WriteLine("Só sei contar até 2 Bilhões! 2.000.000.000");
        EsteNumeroEfibonacci(sequenciaFibonacci);

    }

    private static void EsteNumeroEfibonacci(List<int> sequenciaFibonacci)
    {
        Console.WriteLine("Vamos lá, digite um numero.");
        int numeroDigitado = int.Parse(Console.ReadLine());

        //Caso o numero digitado seja fibonacci, retornará a posição do numero na lista (começando pelo zero).
        //Senão, retornará o valor -1 (menos um).
        //irei comentar o "WriteLine" para continuar. Caso queira verificar, decomente.
        var indexNumeroDigitado = sequenciaFibonacci.IndexOf(numeroDigitado);
        //Console.WriteLine(indexNumeroDigitado);

        //se for encontrada a posicao do numero na sequenciaFibonacci
        if (indexNumeroDigitado >= 0)
        {
            Console.WriteLine("Esse é um FIBONACCI !!!");
        }
        else
        {
            Console.WriteLine("Não, este Não é !");
            EsteNumeroEfibonacci(sequenciaFibonacci);
        }
    }
}