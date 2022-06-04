using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Aifr
{
    class Primaria : estudiante, ICalcular
    {
        private int valor;
        public Primaria(string nombres, string apellidos, string Institución, string cedula, int valor) : base(nombres, apellidos, Institución, cedula)
        {
            this.valor = valor;
        }
        public void Calcular()
        {
            Console.WriteLine("valor anual a pagar: " + valor);
        }
    }
}