using System;
using System.Globalization;
namespace Ponte_calcular_cordas {
    class Program {
        static void Main(string[] args) { 
                 
            
        Console.WriteLine("Qual o comprimento Total da Ponte em KM? ");
        double compr_ponteKM = double.Parse(Console.ReadLine());
         
        double compr_ponteM = compr_ponteKM * 1000;
        double altura_hastesInicial = compr_ponteM / 20;
        double metade_compr_ponteInicial = compr_ponteM /2 ;
        double metade_compr_ponte = metade_compr_ponteInicial;
        double altura_hastes = altura_hastesInicial;
        
        double a = Math.Pow (metade_compr_ponte,2) + Math.Pow(altura_hastes, 2);

            metade_compr_ponte = (metade_compr_ponte/ 100 * 80);
            altura_hastes= (altura_hastes/ 100 * 80);

            double b = Math.Pow(metade_compr_ponte, 2) + Math.Pow(altura_hastes, 2);
            
        metade_compr_ponte= metade_compr_ponteInicial;
        altura_hastes = altura_hastesInicial;

        metade_compr_ponte = (metade_compr_ponte / 100 * 60);
        altura_hastes= (altura_hastes / 100 * 60);
        
        double c = Math.Pow(metade_compr_ponte, 2) + Math.Pow(altura_hastes, 2);
        
        metade_compr_ponte= metade_compr_ponteInicial;
        altura_hastes= altura_hastesInicial;

        metade_compr_ponte = (metade_compr_ponte / 100 * 40);
        altura_hastes = (altura_hastes / 100 * 40);

        double d = Math.Pow(metade_compr_ponte, 2) + Math.Pow(altura_hastes, 2);
        
        metade_compr_ponte = metade_compr_ponteInicial;
        altura_hastes = altura_hastesInicial;

        metade_compr_ponte = (metade_compr_ponte / 100 * 20);
        altura_hastes = (altura_hastes / 100 * 20);
        
        double e = Math.Pow(metade_compr_ponte, 2) + Math.Pow(altura_hastes, 2);

            
        double raiz_a= Math.Sqrt(a);
        double raiz_b= Math.Sqrt(b);
        double raiz_c= Math.Sqrt(c);
        double raiz_d= Math.Sqrt(d);
        double raiz_e= Math.Sqrt(e);

        double cabo1= raiz_a;
        double cabo2= raiz_b;
        double cabo3= raiz_c;
        double cabo4= raiz_d;
        double cabo5= raiz_e;
        double compr_total_cabos= (cabo1 + cabo2 + cabo3 + cabo4 + cabo5);
         Console.WriteLine("Comprimento ponte: "+ string.Format("{0}", compr_ponteKM)+" Km  "+ "("+string.Format("{0:00,0.00}", compr_ponteM) + " m"+")");
         Console.WriteLine("Altura haste 1/20 Avos do comprimento total da ponte: "+ string.Format("{0}", altura_hastes ) + " m");
         Console.WriteLine("O Comprimento da primeira corda: "+ string.Format("{0:00,0.00}", cabo1 ) + " m");
         Console.WriteLine("O Comprimento da segunda corda: "+ string.Format("{0:00,0.00}", cabo2) + " m");
         Console.WriteLine("O Comprimento da terceira corda: "+ string.Format("{0:00,0.00}", cabo3)  + " m");
         Console.WriteLine("O Comprimento da quarta corda: "+ string.Format("{0:00,0.00}", cabo4)  + " m");
         Console.WriteLine("O Comprimento da quinta corda: "+ string.Format("{0:00,0.00}", cabo5)  + " m");
         Console.WriteLine("O Comprimento da total corda para metade de uma lado da ponte: " + string.Format("{0:00,0.00}", compr_total_cabos) +" m");
         compr_total_cabos = (compr_total_cabos * 4);
         Console.WriteLine("Comprimento total corda ponte (considerando os 4 lados): " + string.Format("{0:00,0.00}", compr_total_cabos)+" m");



        }
    }
}
