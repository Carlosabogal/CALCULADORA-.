using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2
{
    internal class segundaClase
    {
        public static string opciones()
        {
            return "seleccionar una opcion \n 1.Perro \n2.Gato";

        }
        public static string Accion()
        {
            Console.WriteLine(opciones());
            int opcion =Int32.Parse(Console.ReadLine());
            string animal = "";
            string accion = ""; 
            if(opcion == 1)
            {
                animal = "perro";
               accion = "ladra";

            }
            if (opcion == 2)
            {
                animal = "gato";
                accion = "maulla";

            }
            if (opcion == 3)
            {
                animal = "gallina";
                accion = "cacarea";

            }

            return "el animal es"+animal+" y" + accion;
        }
    }
}
