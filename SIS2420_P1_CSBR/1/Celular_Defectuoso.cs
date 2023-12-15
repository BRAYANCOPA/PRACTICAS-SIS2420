using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePrincipal
{
    public class Celular_Defectuoso : Celular
    {
        public DateTime FechaDefecto { get; set; }
        public string Motivo { get; set; }

        public Celular_Defectuoso(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento, DateTime fechaDefecto, string motivo)
            : base(marca, modelo, sistemaOperativo, ram, almacenamiento)
        {
            FechaDefecto = fechaDefecto;
            Motivo = motivo;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
            Console.WriteLine($"RAM: {RAM} GB");
            Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
            Console.WriteLine($"Fecha de Defecto: {FechaDefecto.ToShortDateString()}");
            Console.WriteLine($"Motivo: {Motivo}");
        }
    }
}
