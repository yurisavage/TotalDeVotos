namespace TotaldeVotos.Entities
{
    public class Votos
    {
        private const double TotalDeEleitores = 1000.0;
        private const double Validos = 800.0;
        private const double VotosBrancos = 150.0;
        private const double Nulos = 50.0;

        /// <summary>
        /// percentual de votos válidos em relação ao total de eleitores
        /// </summary>
        /// <returns></returns>
        public double PercentualVotosValidos()
        {
            double total = Validos / TotalDeEleitores;

            return total * 100;
        }

        /// <summary>
        /// precentual de brancos em relação ao total de eleitores
        /// </summary>
        /// <returns></returns>
        public double PercentualVotosBrancos()
        {
            double total = VotosBrancos / TotalDeEleitores;

            return total * 100;
        }

        /// <summary>
        /// percentual de nulos em relação ao total de eleitores
        /// </summary>
        /// <returns></returns>
        public double PercentualVotosNulos()
        {
            double total = Nulos / TotalDeEleitores;

            return total * 100;
        }


    }
}
