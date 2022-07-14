using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2
{
    public class Capitales
    {
        private string pais = "";
        private string capital = "";
        private int fundacion = 0;

        public Capitales(string _pais, string _capital, int _fundacion)
        {
            pais = _pais;
            capital = _capital;
            fundacion = _fundacion;
        }
    }
}
