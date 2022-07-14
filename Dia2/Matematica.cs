using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2
{  /// <summary>
   ///Esta clase maneja numeros matematicos
   /// </summary>
    public class Matematica
    {
        /// <summary>
        ///Esta clase maneja la suma
        /// </summary>
        /// 
        public static string MensajeInicial() {
            
            string texto = "Elija el tipo de operacion \n	1 SUMA \n	2 RESTA\n	3 MULTIPLICACION\n	4 DIVISION";
            return texto;
           
            
        }
           
        public static string formulas()
        {
            int opcion = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de a");
            double _a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b");
            double _b = Convert.ToDouble(Console.ReadLine());
           
            //1,2,3,4 (suma,resta,multiplicacion y divicion)
            double resultado = 0;
            if (opcion == 1) {
                resultado = _a + _b;
                Console.WriteLine("El resultado de  la suma es " + resultado);
            }
            if (opcion == 2)
            {
                resultado = _a - _b;
                Console.WriteLine("El resultado de la resta es " + resultado);
            }
            if (opcion == 3)
            {
                resultado = _a * _b;
                Console.WriteLine("El resultado de la multiplicacion es " + resultado);
            }
            if (opcion == 4)
            {
                resultado = _a / _b;
                Console.WriteLine("El resultado de la division es " + resultado);
            }
            
            return "";
                

        }
        /*
        public static int suma(int _a, int _b)
        {
            return _a + _b;
        }

        /// <summary>
        ///Esta clase envia mensajes
        /// </summary>
        
        public static string Mensaje(String _nombre)
        {
        //nombre=_nombre;
            return "Hola " + _nombre+" desde la clase matematica";
        }*/

        ///
        /*
        public static int resta(int _a, int _b)
        {
            return _a - _b;
        }
        public static int multiplicar(int _a, int _b)
        {
            return _a * _b;
        }
        public static int division(int _a, int _b)
        {
            return _a * _b;
        }
        */
    }
}
