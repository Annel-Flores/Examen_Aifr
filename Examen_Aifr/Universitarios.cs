using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Aifr
{
    class Universitarios : estudiante
    {
        private int creditos, precio;

        public Universitarios(string nombres, string apellidos, string Institución, string cedula, int creditos, int precio) : base(nombres, apellidos, Institución, cedula, creditos, precio)
        {
            this.creditos = creditos;
            this.precio = precio;
        }
    }
}