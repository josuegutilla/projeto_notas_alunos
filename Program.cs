using System.Globalization;

namespace ex_Nota_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno(); //criando a variavel da classe e instanciando.

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno (1 a 10): ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine()); 
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Nota final = " + aluno.SomaNota().ToString("F1", CultureInfo.InvariantCulture));

            Console.WriteLine();
            if(aluno.SomaNota() > 6) 
            {
                Console.WriteLine("ALUNO APROVADO");
            }
            else
            {
                Console.WriteLine("ALUNO REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.FaltaNota().ToString("F1", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
