using System;
namespace AjudaProfessor

{
    class Professor
    {
        public string Nome { get; set; }
        public string Salario { get; set; }
        public string ListaMateriais { get; set; }
        public string item1 { get; set; }
        public string item2 { get; set; }
        public string item3 { get; set; }


        public Professor(string nome, string salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public String CadastraProfessor ()
        {
            Console.WriteLine("Digite o nome do professor");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do professor");
            Salario = Console.ReadLine();
            
            return "Professor cadastrado com sucesso!";
        }

        public String ListadeMateriais()
        {
            Console.WriteLine("Digite o item 1 da lista de materiais");
            item1 = Console.ReadLine();
            Console.WriteLine("Digite o item 2 da lista de materiais");
            item2 = Console.ReadLine();
            Console.WriteLine("Digite o item 3 da lista de materiais");
            item3 = Console.ReadLine();

            return "Lista cadastrada com sucesso!";
        }
    }
}
