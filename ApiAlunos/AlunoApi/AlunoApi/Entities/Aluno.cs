namespace AlunoApi.Entities
{
    public class Aluno
    {
        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Situacao { get; set; }

        public int Matricula { get; set; }


        //Construtor
        public Aluno(int id, string nome, string situacao, int matricula) 
        {
            Id = id;
            Nome = nome;
            Situacao = situacao;
            Matricula = matricula;
        }
    }
}
