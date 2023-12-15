using ClasePrincipal;
using System;
using System.Collections.Generic;

class Program
{

    public static decimal Prom_Celular(List<Celular_Nuevo> celulares, Func<Celular_Nuevo, decimal> selectorPrecio)
    {
        if (celulares.Count == 0)
            return 0;

        decimal sumaPrecios = celulares.Sum(selectorPrecio);
        return sumaPrecios / celulares.Count;
    }

    public static List<Celular_Nuevo> Cel_MarcaS(List<Celular_Nuevo> celulares, Func<Celular_Nuevo, bool> condicion)
    {
        return celulares.Where(condicion).ToList();
    }

    public static List<Celular_Nuevo> Celular_RSA(List<Celular_Nuevo> celulares)
    {
        var Filtro = from celular in celulares
                                 where celular.RAM == 8 && celular.SistemaOperativo == "Android" && celular.Almacenamiento == 128
                                 select celular;

        return Filtro.ToList();
    }

    public static List<Celular_Nuevo> Celular_Ingreso(List<Celular_Nuevo> celulares, int Ingreso)
    {
        var Filtro = from celular in celulares
                                 where celular.FechaIngreso.Year == Ingreso
                                 select celular;

        return Filtro.ToList();
    }

    public static void Lambda(List<Celular_Nuevo> celulares)
    {
        var apple = celulares.Where(celular => celular.Marca.Equals("APPLE", StringComparison.OrdinalIgnoreCase));

        foreach (var celular in apple)
        {
            Console.WriteLine($"Modelo: {celular.Modelo}, Precio: {celular.Precio:C}");
        }
    }

    public static void LinQ(List<Celular_Nuevo> celulares)
    {
        var apple = from celular in celulares
                             where celular.Marca.Equals("APPLE", StringComparison.OrdinalIgnoreCase)
                             select new { Modelo = celular.Modelo, Precio = celular.Precio };

        foreach (var celular in apple)
        {
            Console.WriteLine($"Modelo: {celular.Modelo}, Precio: {celular.Precio:C}");
        }
    }
    public static void Main()
    {
        List<Celular_Nuevo> celularesNuevos = new List<Celular_Nuevo>();
        //1
        Celular_Nuevo Celular1 = new Celular_Nuevo("XIOMI", "MI 12 LITE","Android",8,122, new DateTime(2022, 2, 12), 1500.0m);
        Celular_Nuevo Celular2 = new Celular_Nuevo("SAMSUNG", "A53", "Android", 12, 128, new DateTime(2022, 4, 11), 2000.0m);
        Celular_Nuevo Celular3 = new Celular_Nuevo("APPLE", "iPhone 13", "iOS", 6, 64, new DateTime(2022, 3, 20), 1800.0m);
        Celular_Nuevo Celular4 = new Celular_Nuevo("HUAWEI", "P40", "Android", 8, 256, new DateTime(2022, 5, 5), 1600.0m);
        Celular_Nuevo Celular5 = new Celular_Nuevo("LG", "G8", "Android", 6, 128, new DateTime(2022, 6, 15), 1700.0m);
        Celular_Nuevo Celular6 = new Celular_Nuevo("SONY", "Xperia 5", "Android", 8, 64, new DateTime(2022, 7, 10), 1900.0m);
        Celular_Nuevo Celular7 = new Celular_Nuevo("GOOGLE", "Pixel 6", "Android", 12, 128, new DateTime(2022, 8, 8), 2200.0m);
        Celular_Nuevo Celular8 = new Celular_Nuevo("ONEPLUS", "9 Pro", "Android", 12, 256, new DateTime(2022, 9, 25), 2500.0m);
        Celular_Nuevo Celular9 = new Celular_Nuevo("XIAOMI", "Redmi Note 10", "Android", 4, 64, new DateTime(2022, 10, 30), 1200.0m);
        Celular_Nuevo Celular10 = new Celular_Nuevo("NOKIA", "9 PureView", "Android", 6, 128, new DateTime(2022, 11, 12), 1400.0m);
        celularesNuevos.Add(Celular1);
        celularesNuevos.Add(Celular2);
        celularesNuevos.Add(Celular3);
        celularesNuevos.Add(Celular4);
        celularesNuevos.Add(Celular5);
        celularesNuevos.Add(Celular6);
        celularesNuevos.Add(Celular7);
        celularesNuevos.Add(Celular8);
        celularesNuevos.Add(Celular9);
        celularesNuevos.Add(Celular10);

        foreach(var celularNuevo in celularesNuevos)
        {
            celularNuevo.Mostrar();
            Console.WriteLine();
        }
        //2
        decimal prom = Prom_Celular(celularesNuevos, celular => celular.Precio);
        Console.WriteLine("El promedio de precios de los celulares es: {0}", prom);
        //3
        List<Celular_Nuevo> Samsung = Cel_MarcaS(celularesNuevos, celular => celular.Marca.Equals("SAMSUNG", StringComparison.OrdinalIgnoreCase));
        foreach (var celular in Samsung)
        {
            celular.Mostrar();
            Console.WriteLine();
        }
        //4
        List<Celular_Nuevo> cumple = Celular_RSA(celularesNuevos);
        foreach (var celular in cumple)
        {
            celular.Mostrar();
            Console.WriteLine();
        }
        //5
        List<Celular_Nuevo> ing2005 = Celular_Ingreso(celularesNuevos, 2005);
        foreach (var celular in ing2005)
        {
            celular.Mostrar();
            Console.WriteLine();
        }
        //6
        Lambda(celularesNuevos);
        LinQ(celularesNuevos);
    }

}



