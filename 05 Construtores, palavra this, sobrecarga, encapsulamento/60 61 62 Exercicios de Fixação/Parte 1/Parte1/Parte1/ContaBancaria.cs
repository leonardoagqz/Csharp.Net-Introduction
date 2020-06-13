using System;
using System.Collections.Generic;
using System.Text;

namespace Parte1 {
    class ContaBancaria {
        //Atributos
        public int Numero { get; private set; }
        public string Titular { get; set; }

        public Double Saldo { get; private set; }


        //Construtores

        //Contrutor com dois argumentos
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
           
        }

        //Contrutor com três argumentos e utilizando o "this" para receber o "numero" e "titular"
        public ContaBancaria(int numero, string titular, double depositoinicial) :this(numero,titular) {
            
            Deposito(depositoinicial);
                
        }

        //Métodos

        //será void pq não terá retorno, apenas irá no Saldo e alteraro valor do mesmo. 
        public void Deposito(double quantia) {

            Saldo = Saldo + quantia; 
            //ou Saldo += quantida;
        }

        public void Saque(double quantia) {
            Saldo -= quantia; //desconta a quantia
            Saldo -= 5.0; //desconta a taxa
        }


        //Texto que exibe os dados no final
        public override string ToString() {
            return "Conta: " + Numero 
                + " , Titular: " 
                + Titular + ", Saldo: $ " 
                + string.Format("{0:n2}",Saldo);
        }




    }
}
