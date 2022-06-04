using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Aifr
{
    class Secundaria : estudiante, ICalcular
    {
        private int nivel, precio;
        public Secundaria(string nombres, string apellidos, string Institución, string cedula, int nivel, int precio) : base(nombres, apellidos, Institución, cedula, nivel, precio)
        {
            this.precio = precio;
            this.nivel = nivel;
        }
        public void Calcular()
        {
            int Total = precio * nivel;
            Console.WriteLine("El valor a total a pagar es: " + Total);
        }
    }
