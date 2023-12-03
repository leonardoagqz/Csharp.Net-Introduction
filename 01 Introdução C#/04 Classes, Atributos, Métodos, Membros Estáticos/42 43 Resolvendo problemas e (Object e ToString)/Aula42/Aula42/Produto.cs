using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula42 {
    class Produto {

        // ATRIBUTOS
        public string Nome;
        public double Preco;
        public int Quantidade;

        //MÉTODOS
        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        
        }

        //Sobreposição
        public override string ToString() {
            return Nome 
                +", $ "+string.Format("{0:n2}",Preco)
                +", "
                +" unidades, Total: $ " 
                +string.Format("{0:n2}",ValorTotalEmEstoque());
        }

    }
}
