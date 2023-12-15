using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePrincipal
{
    public class Celular_Nuevo : Celular
    {
        public DateTime FechaIngreso { get; set; }
        public decimal Precio { get; set; }

        public Celular_Nuevo(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento, DateTime fechaIngreso, decimal precio)
            : base(marca, modelo, sistemaOperativo, ram, almacenamiento)
        {
            FechaIngreso = fechaIngreso;
            Precio = precio;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
            Console.WriteLine($"RAM: {RAM} GB");
            Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Precio: ${Precio}");
        }
    }
}
