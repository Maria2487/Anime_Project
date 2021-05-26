using Anime_Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    public class Administrare_Anime_TXT : IStocareDate
    {
        private const int ID_ANIME = 1;
        private const int INCREMENT = 1;
        private string NumeFisier { get; set; }

        public Administrare_Anime_TXT(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        public void AddAnime(Anime a)
        {
            a.IdAnime = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(a.ConvertToStringFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

       
        public List<Anime> GetAnimeuri()
        {
            List<Anime> animeuri = new List<Anime>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Anime animeDinFisier = new Anime(line);
                        animeuri.Add(animeDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return animeuri;
        }
        public Anime GetAnime(string nume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Anime animeFisier = new Anime(line);
                        if (nume.ToUpper() == animeFisier.NumeAnime.ToUpper())
                            return animeFisier;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public Anime GetAnime(int IdAnime)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string linieDinFisier;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((linieDinFisier = sr.ReadLine()) != null)
                    {
                        Anime anime = new Anime(linieDinFisier);
                        if (anime.IdAnime == IdAnime)
                        {
                            return anime;
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool RewriteAnime(Anime animeUpdate)
        {
            List<Anime> anime = GetAnimeuri();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Anime animeCaut in anime)
                    {
                        Anime animeFisier = animeCaut;
                       
                        if (animeCaut.NumeAnime == animeUpdate.NumeAnime)
                        {
                            animeFisier = animeUpdate;
                        }
                        swFisierText.WriteLine(animeFisier.ConvertToStringFisier());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        public bool DeleteAnime(Anime animeUpdate)
        {
            List<Anime> anime = GetAnimeuri();
            Anime animeFisier;
            File.Delete(NumeFisier);
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    foreach(var animeCaut in anime)
                    {
                        animeFisier = animeCaut;
                        i++;
                        if (animeFisier.IdAnime == animeUpdate.IdAnime)
                        {
                            i--;
                            continue;
                        }
                        animeFisier.IdAnime = i;
                        
                        swFisierText.WriteLine(animeFisier.ConvertToStringFisier());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdAnime1 = ID_ANIME;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string LinieDinFisier;
                    Anime ultimulAnimeDinFisier = null;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((LinieDinFisier = sr.ReadLine()) != null)
                    {
                        ultimulAnimeDinFisier= new Anime(LinieDinFisier);
                    }

                    if (ultimulAnimeDinFisier != null)
                    {
                        IdAnime1 = ultimulAnimeDinFisier.IdAnime + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdAnime1;
        }

       
        #region ALTELE

        public static string ComparatieNote(Anime a1, Anime a2)
        {
            if (a1.NotaAnime > a2.NotaAnime)
                return "Anime-ul " + a1.NumeAnime + " este mai apreciat";
            else if (a1.NotaAnime < a2.NotaAnime)
                return "Anime-ul " + a2.NumeAnime + " este mai apreciat";
            else
                return "Anime-urile sunt la fel de apreciate";
        }

        #endregion ALTELE

    }
}