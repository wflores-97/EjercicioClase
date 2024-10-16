using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperHeroe
    { 

        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set;}
        public string Ciudad {  get; set; }
        public bool PuedeVolar {  get; set; }
        public string SuperPoder { get; set; }

        public SuperPoder poder;

        //constructor
        public SuperHeroe()
        {
            poder = new SuperPoder();
        }

        public void imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            
            if (PuedeVolar==true)
            {
                Console.WriteLine($"¿Puede Volar?: Si");
            }
            else
            {
                Console.WriteLine($"¿Puede Volar?: No");
            }

            Console.WriteLine($"Super Poder: {poder.Nombre}");
            Console.WriteLine($"Descripción: {poder.Descripcion}");
            Console.WriteLine($"Nivel: {poder.Nivel}");
            Console.WriteLine();
        }


    }
}
