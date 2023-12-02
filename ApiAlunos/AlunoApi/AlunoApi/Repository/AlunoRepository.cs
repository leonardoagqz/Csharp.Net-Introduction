using AlunoApi.Entities;

namespace AlunoApi.Repository
{
    public class AlunoRepository
    {

        //Banco de dados ficticio
        public static List<Aluno> BancoDeDados { get; set; } = new List<Aluno>();

        public void Carga()
        {
            Aluno aluno1 = new Aluno(1, "Rafael", "Matriculado", 12352);
            Aluno aluno2 = new Aluno(2, "Vitoria", "Matriculado", 4362);
            Aluno aluno3 = new Aluno(3, "Joao", "Cancelado", 3242);
            Aluno aluno4 = new Aluno(4, "maria", "Trancado", 1475);

            BancoDeDados.Add(aluno1);
            BancoDeDados.Add(aluno2);
            BancoDeDados.Add(aluno3);
            BancoDeDados.Add(aluno4);
        }


    }
}
