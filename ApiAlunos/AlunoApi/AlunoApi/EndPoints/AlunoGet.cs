using AlunoApi.Entities;
using AlunoApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlunoApi.EndPoints
{
    public class AlunoGet
    {
        //Propriedades static para não precisa instanciar para serem utilizadas
        public static string Template => "/aluno/{id:int}";

        //Criando vetor
        public static string[] Metodo => new string[] { HttpMethod.Get.ToString() };

        /*
         * Delegate é um tipo que guarda a referencia de um método
        */
        public static Delegate Func => Acao;

        public static IResult Acao([FromRoute] int id) 
        {    
            AlunoRepository alunoCarga = new AlunoRepository();
            alunoCarga.Carga();

            //Instanciando AlunoRepository
            Aluno alunoEncontrado = AlunoRepository.BancoDeDados.FirstOrDefault(a => a.Id.Equals(id));

            if (alunoEncontrado != null)
            {
                return Results.Ok(alunoEncontrado);
            }
            else
            {
                return Results.NotFound();
            }
        
        }
    }
}
