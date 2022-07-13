namespace Aula_28.Models
{
    public class Alunos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string status { get; set; }

        int count = 1;

      /*  public void RegistrarAluno(string nome, string sobrenome, int status)
        {
            id = count;
            Nome = nome;
            Sobrenome = sobrenome;
            Status = status;

            count++;
        }*/

    }
}
