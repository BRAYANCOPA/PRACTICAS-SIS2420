using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePrincipal
{
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperativo { get; set; }
        public int RAM { get; set; }
        public int Almacenamiento { get; set; }

        public Celular(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento)
        {
            Marca = marca;
            Modelo = modelo;
            SistemaOperativo = sistemaOperativo;
            RAM = ram;
            Almacenamiento = almacenamiento;
        }
        public abstract void Mostrar();
    }
}
