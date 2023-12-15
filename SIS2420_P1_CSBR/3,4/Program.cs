using System;

public static class ConversorNumerico
{
    private static string[] Unidades =
    {
        "", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve"
    };

    private static string[] DiezAQuince =
    {
        "Diez", "Once", "Doce", "Trece", "Catorce", "Quince"
    };

    private static string[] Decenas =
    {
        "", "", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa"
    };

    private static string[] Centenas =
    {
        "", "Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos",
        "Ochocientos", "Novecientos"
    };

    public static string ConvertirNumeroALetras(int numero)
    {
        if (numero < 0 || numero > 999)
        {
            return "Número fuera de rango";
        }

        if (numero == 0)
        {
            return "Cero";
        }

        return Convertir(numero);
    }

    public static string Convertir(int numero)
    {
        if (numero < 10)
        {
            return Unidades[numero];
        }

        if (numero >= 10 && numero <= 15)
        {
            return DiezAQuince[numero - 10];
        }

        if (numero < 20)
        {
            return "Dieci" + Unidades[numero - 10];
        }

        if (numero < 100)
        {
            return Decenas[numero / 10] + (numero % 10 != 0 ? " y " + Unidades[numero % 10] : "");
        }

        if (numero < 1000)
        {
            return Centenas[numero / 100] + (numero % 100 != 0 ? " " + Convertir(numero % 100) : "");
        }

        return ""; // Si los numeros son mayores a 999 
    }
}

class Program
{
    static void Main()
    {
        int numero;
        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());
        string x = ConversorNumerico.ConvertirNumeroALetras(numero);
        Console.WriteLine("Representación literal: {0}",x);       
    }
}
