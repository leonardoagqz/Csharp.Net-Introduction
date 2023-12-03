using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_2 {
    class Funcionario {

        //Atrbutos
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //Métodos
        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * porcentagem)/100;
        
        }


        public override string ToString() {
            return  Nome + ", $ " + string.Format("{0:n2}",SalarioLiquido());
        
        
        }


    }
}
