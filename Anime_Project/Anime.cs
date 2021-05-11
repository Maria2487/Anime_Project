using System;
using System.Collections;
using System.Collections.Generic;

namespace Anime_Project
{
    public class Anime
    {
        #region CONSTANTE ANIME

        private const int NUMEANIME = 0;
        private const int SEZOANE = 1;
        private const int EPISOADEANIME = 2;
        private const int NOTA = 3;
        private const int ONGOING = 4;
        private const int GENANIME = 5;

        #endregion CONSTANTE ANIME

        #region CONSTANTE AFISARE

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_SECUNDAR_FISIER = ',';
        private const int FORMAT_TABEL_STANGA = -25;
        private const int FORMAT_TABEL_DREAPTA = -10;

        #endregion CONSTANTE AFISARE

        #region PROPRIETATI

        public string NumeAnime
        { get; set; }

        public int SezoaneAnime
        { get; set; }

        public int EpisoadeAnime
        { get; set; }

        public double NotaAnime
        { get; set; }

        public TypeAnime TipulAnime
        { get; set; }

        public Status OngoingAnime
        { get; set; }
        public ArrayList GenAnime { get; set; }

        public string GenAnimeAsString
        {
            get
            {
                string animeString = string.Empty;

                foreach (string ani in Discipline)
                {
                    if (animeString != string.Empty)
                    {
                        animeString += SEPARATOR_SECUNDAR_FISIER;
                    }
                    animeString += ani;
                }

                return animeString;
            }
        }
        #endregion PROPRIETATI

        #region CONSTRUCTORI

        public Anime()
        {
        }

        public Anime(string info)
        {
            string[] detalii = info.Split(SEPARATOR_PRINCIPAL_FISIER);
            NumeAnime = detalii[NUMEANIME];
            SezoaneAnime = int.Parse(detalii[SEZOANE]);
            EpisoadeAnime = int.Parse(detalii[EPISOADEANIME]);
            GenAnime = detalii[GENANIME];
            OngoingAnime = detalii[ONGOING];
            NotaAnime = Double.Parse(detalii[NOTA]);
        }

        public Anime()


        #endregion CONSTRUCTORI

        #region AFISARI

        //public void Print()
        //{
        //    Console.WriteLine("Anime: " + this.NumeAnime);
        //    Console.WriteLine("Sezone: " + this.SezoaneAnime);
        //    Console.WriteLine("Numar episoade: " + this.EpisoadeAnime);
        //    Console.WriteLine("Genul animelui: " + this.GenAnime);
        //    Console.WriteLine("Status: " + this.OngoingAnime);
        //}

        public string ConvertToStringAfisare()
        {
            return "\nNume anime: " + this.NumeAnime + "\nNumar sezoane: " + this.SezoaneAnime.ToString() + "\nNumar episoade: " + this.EpisoadeAnime.ToString() + "\nGenul: " + this.GenAnime + "\nStatus:" + this.OngoingAnime + "\nRecenzie: " + this.NotaAnime.ToString();
        }

        public string ConvertToStringFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", SEPARATOR_PRINCIPAL_FISIER, (NumeAnime ?? " NECUNOSCUT "), (SezoaneAnime.ToString() ?? " NECUNOSCUT "), (EpisoadeAnime.ToString() ?? " NECUNOSCUT "), (GenAnime ?? " NECUNOSCUT "), (OngoingAnime ?? " NECUNOSCUT "), (NotaAnime.ToString() ?? " NECUNOSCUT "));

            return s;
        }

        #endregion AFISARI


    }
}