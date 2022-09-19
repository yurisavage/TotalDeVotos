using TotaldeVotos.Entities;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("     Votos em Relação ao Total de Eleitores");
            Console.WriteLine();

            Votos votos = new Votos();

            Console.WriteLine("  Percentual de votos válidos: " + votos.PercentualVotosValidos() + "%");
            Console.WriteLine("  Percentual de votos brancos: " + votos.PercentualVotosBrancos() + "%");
            Console.WriteLine("  Percentual de votos nulos: " + votos.PercentualVotosNulos() + "%");

            Console.ReadKey();


        }
    }
}