using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2
{
    public class Perro
    {

        private string nombre = "";
        private string raza = "";
        private string color = "";
        private int edadPerro = 0;
        private int edadHumana = 0;
        private bool isVivo = true;
        public Perro(string _nombre,
            string _raza,
            string _color,
            int _edadPerro,
            bool _isVivo)
        {
            nombre = _nombre;
            raza = _raza;
            color = _color;
            edadPerro = _edadPerro;
            isVivo = _isVivo;
            edadHumana = (_edadPerro * 7) + 7;
        }
        public void setIsVivo(bool _isVivo)
        {
            isVivo = _isVivo;


        }

        public void setEdadPerro(int _sumatoria)
        {
            edadPerro += _sumatoria;
            edadHumana = (edadPerro * 7) + 7;


        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
           


        }
        public void Datos()
        {
            string txt = "El nombre del perro es : " + nombre;
            txt += "\n la raza del perro es : " + raza;
            txt += "\n la raza del perro es : " + color;
            txt += "\n la raza del perro es : " + edadHumana;
            txt += "\n la raza del perro es : " + edadPerro;
            if(isVivo)
            {
                txt += "\n el perro esta vivo";
        }
            else
            {
                txt += "\n el perro esta murio";
            }

            Console.WriteLine(txt);
        }
    }
}
