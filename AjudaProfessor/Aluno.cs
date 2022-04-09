namespace AjudaProfessor
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Media { get; set; }
        public bool? Aprovado { get; set; }

        public Aluno(string nome, string matricula, double nota1, double nota2)
        {
            Nome = nome;
            Matricula = matricula;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public double CalculaMedia(Aluno aluno)
        {
            Media = (aluno.Nota1 + aluno.Nota2) / 2;
            return Media;
        }

        public string ValidaMedia(double result)
        {
            if (result > 6)
            {
                Aprovado = true;
                return "Parabéns, você foi aprovado!";
                
            }
            else if (result > 4 && result < 6)
            {
                Aprovado = null;
                return "Atenção, você está de recuperação!";
            }
            else
            {
                Aprovado = false;
                return "Você foi reprovado.";
            }
            
        }
    }
}
