using NivelAccesDate;
using System.Configuration;

namespace InterfataUtilizator_WindowsForms
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";

        public static IStocareDate GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        ///return new AdministrareStudenti_FisierBinar(numeFisier + "." + formatSalvare);
                        return null;

                    case "txt":
                        return new Administrare_Anime_TXT(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}