using System;
using System.Collections.Generic;
using System.Text;

namespace Iniciando_Struct {
    struct Point {

        //Atributos do Struct
        public double X;
        public double Y;

        public override string ToString() {
            return "("+ X+ ", "+Y+")";
        }

    }
}
