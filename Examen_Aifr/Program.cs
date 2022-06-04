using System;
using Examen_Aifr;
namespace Examen_Aifr
{
    public class Program
    {
        private static int length;

        public static int Length { get => length; set => length = value; }

        private static void Main(string[] args)
        {
            Primaria primaria = new Primaria("Annel", "Flores", " Ruperto Mena", "1351214497", 500);
            Secundaria secundaria = new Secundaria("Annel", "Flores", " Cinco de Junio ", "1351214497", 6, 200);
            Universitarios U = new Universitarios("Annel", "Flores", " Eloy Alfaro de Manabí", "1351214497", 300, 20);
            for (int i = Length + 1; i >= 0; i++)
            {
                primaria.ImprimirDatos();
                primaria.Calcular();
                Console.WriteLine("");
                secundaria.Calcular();
                Console.WriteLine("");
                U.ImprimirDatos();
                U.Calcular();
            }
        }
    }
}