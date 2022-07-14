using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia2
{
    public class Auto
    {
        private string marca = "";
        private string modelo = "";
        private string color = "";
        private int  peso = 0;
        private string combustible = "";

        public Auto(
            string _marca, 
            string _modelo, 
            string _color, 
            int _peso, 
            string _combustible)
        {
            this.marca = _marca;
            this.modelo = _modelo;
            this.color = _color;
            this.peso = _peso;
            this.combustible = _combustible;
        }
        public void GetMarca()
        {
            Console.WriteLine(marca);
        }
        public void GetModelo()
        {
            Console.WriteLine(modelo);
        }
        public void Datos()
        {
       
            string txt= "La marace es : " + marca
                + "\n el modelo es" + modelo
                + "\n El color es" + color 
                + "\nEl peso es " +  peso 
                + "\nel combustible es" + combustible;
            
            Console.WriteLine(txt);
        }
}
}