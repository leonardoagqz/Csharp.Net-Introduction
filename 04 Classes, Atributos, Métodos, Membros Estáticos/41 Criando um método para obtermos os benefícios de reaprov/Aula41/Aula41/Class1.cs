using System; //Importação de Dependências
using System.Collections.Generic;
using System.Text;

namespace Aula41 {

     //Nome da Classe: Triangulo
    class Triangulo {

        //Atributos (Lados do Triangulo) A,B,C
        public double A;
        public double B;
        public double C;

        //Método Calcular a Area
        //Função Area
        public double Area() {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;

            //OU

         /*
        public double Area() {
            double p = (A + B + C) / 2;
            return raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
         */

        }

    }
}

/*
 Benefícios de se calcular a área de um triângulo por meio de MÉTODO dentro da CLASSE Triangulo:

    1)Reaproveitamento de código: eleiminamos o código repetido no programa principal.

    2)Delegação de responsabilidades: quem deve ser responsável por saber como calcular a área de um triângulo é o proprio triângulo.
      A lógica do cálculo da área não deve estar em outro lugar.
     
*/