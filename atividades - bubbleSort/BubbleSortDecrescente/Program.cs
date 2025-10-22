using System;
using System.Linq;

public class AlgoritmosDeOrdenacao
{
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] < array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;

                    Console.WriteLine($"Troca: {string.Join(",",array)}");
                }
            }
            Console.WriteLine($"---Fim da Passagem {i + 1}---");
        }
    }
    public static void ImprimirArray(int[]array)
    {
        Console.WriteLine(string.Join(",",array));
    }

    public static void Main(string[]args)
    {
        //Lista 1 
        int[] lista1 = {5,1,4,2,8};
        Console.WriteLine("Lista Original 1: ");
        ImprimirArray(lista1);

        BubbleSort(lista1);

        Console.WriteLine("\nLista Ordenada 1 (Crescente): ");
        ImprimirArray(lista1);

        Console.WriteLine("----------------------");

        //Lista 2
        int[] lista2 = {77,4,1,15,4,9,23};
        Console.WriteLine("Lista Original 2: ");
        ImprimirArray(lista2);

        BubbleSort(lista2);

        Console.WriteLine("\nLista Ordenada 2 (Crescente): ");
        ImprimirArray(lista2);
    }
}
