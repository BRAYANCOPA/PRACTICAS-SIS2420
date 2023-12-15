using System;
using System.Collections.Generic;
public static class Funciones
{
    public static bool EsMultiploDe(int num, int divisor)
    {
        return num % divisor == 0;
    }

    public static bool EsPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool EsNumeroPerfecto(int num)
    {
        if (num < 2)
        {
            return false;
        }

        int sumaDivisores = 1;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sumaDivisores += i;
            }
        }

        return sumaDivisores == num;
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Cuantos numeros deseas añadir");
        int c = int.Parse(Console.ReadLine());
        List<int> numeros = new List<int>();
        Console.WriteLine("Introduce los numeros");
        int aux;
            for (int i = 0 ; i < c; i++)
            {
                aux = int.Parse(Console.ReadLine());
                numeros.Add(aux);
            }
            List<int> lista_Dos = new List<int>();
            List<int> lista_Primos = new List<int>();
            List<int> lista_Cinco = new List<int>();
            List<int> lista_Perfectos = new List<int>();

            foreach (var num in numeros)
            {
                if (Funciones.EsMultiploDe(num, 2))
                    lista_Dos.Add(num);

                if (Funciones.EsPrimo(num))
                    lista_Primos.Add(num);

                if (Funciones.EsMultiploDe(num, 5))
                    lista_Cinco.Add(num);

                if (Funciones.EsNumeroPerfecto(num))
                {
                    lista_Perfectos.Add(num);
                }
            }

            Console.WriteLine($"Lista 1 (Múltiplos de 2): {string.Join(", ", lista_Dos)}");
            Console.WriteLine($"Lista 2 (Primos): {string.Join(", ", lista_Primos)}");
            Console.WriteLine($"Lista 3 (Múltiplos de 5): {string.Join(", ", lista_Cinco)}");
            Console.WriteLine($"Lista 4 (Perfectos): {string.Join(", ", lista_Perfectos)}");
        
    }

}
