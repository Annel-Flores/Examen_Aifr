using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Aifr
{
    class estudiante
    {
        private string nombres, apellidos, institución, cedula;
        private int nivel;
        private int precio;

        public estudiante(string nombres, string apellidos, string institución, string cedula)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.institución = institución;
            this.cedula = cedula;

        }

        public estudiante(string nombres, string apellidos, string institución, string cedula, int nivel, int precio) : this(nombres, apellidos, institución, cedula)
        {
            this.nivel = nivel;
            this.precio = precio;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre del estudiante: " + nombres);
            Console.WriteLine("Apellidos del estudiante: " + apellidos);
            Console.WriteLine("Institución educativa: " + institución);
            Console.WriteLine("La cedula del estudiante es: " + cedula);
        }
    }
}