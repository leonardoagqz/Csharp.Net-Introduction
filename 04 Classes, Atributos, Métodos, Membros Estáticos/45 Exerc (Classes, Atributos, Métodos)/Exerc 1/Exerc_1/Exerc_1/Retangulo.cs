using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exerc_1 {
    class Retangulo {

        //Atributos
        public double Largura;
        public double Altura;


        //Método Area
        public double Area() {
            return Largura * Altura;
        }

        //Método Perimetro
        public double Perimetro() {
            return 2*(Largura + Altura);
        }

        //Método Perimetro
        public double Diagonal() {
            return Math.Sqrt (Math.Sqrt(Largura)  + Math.Sqrt(Altura) );
        }


    }
}
