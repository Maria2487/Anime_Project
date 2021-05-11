using System;
using System.Collections;
using System.Collections.Generic;

namespace Anime_Project
{
    public class Anime
    {

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

                foreach (string ani in GenAnime)
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
            
            NumeAnime = detalii[(int)Campuri.NUMEANIME];
            SezoaneAnime = Convert.ToInt32(Campuri.SEZOANE);
            EpisoadeAnime = Convert.ToInt32(Campuri.EPISOADEANIME);
            NotaAnime = Convert.ToDouble(Campuri.NOTA);
            OngoingAnime = (Status)int.Parse(detalii[(int)Campuri.ONGOING]);
            TipulAnime = (TypeAnime)int.Parse(detalii[(int)Campuri.TIP]);

            GenAnime = new ArrayList();
            
            GenAnime.AddRange(detalii[(int)Campuri.GENANIME].Split(SEPARATOR_SECUNDAR_FISIER));
        }

       // public Anime()


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
            string s = $"Animeul: \"{NumeAnime ?? " NECUNOSCUT "}\" are: Sezoane: {SezoaneAnime}, Episoade: {EpisoadeAnime} si o nota de {NotaAnime} \n Statusul:  {OngoingAnime}, Tipul: {TipulAnime}, Gen/Genuri: {GenAnimeAsString}";
            return s;
        }

        public string ConvertToStringFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}", 
                SEPARATOR_PRINCIPAL_FISIER, (NumeAnime ?? " NECUNOSCUT "), (SezoaneAnime.ToString() ?? " NECUNOSCUT "), (EpisoadeAnime.ToString() ?? " NECUNOSCUT "), (int)OngoingAnime, (int)TipulAnime, GenAnime);

            return s;
        }

        #endregion AFISARI


    }
}