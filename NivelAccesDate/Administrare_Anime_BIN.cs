using Anime_Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelAccesDate
{
    public class Administrare_Anime_BIN : IStocareDate
    {
        private const int ID_PRIMUL_ANIME = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public Administrare_Anime_BIN(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();
        }

        public void AddAnime(Anime s)
        {
            s.IdAnime = GetId();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializare unui obiect
                    b.Serialize(sBinFile, s);
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
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        animeuri.Add((Anime)b.Deserialize(sBinFile));
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
        public Anime GetAnime(int idAnime)
        {

            try
            {
                BinaryFormatter b = new BinaryFormatter();
                // instructiunea 'using' va apela sr.Close()
                using (Stream sr_bin = File.Open(NumeFisier, FileMode.Open))
                {
                    while (sr_bin.Position < sr_bin.Length)
                    {
                        //Observati conversia!!!
                        Anime a = (Anime)b.Deserialize(sr_bin);
                        if (idAnime == a.IdAnime)
                            return a;
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

        public Anime GetAnime(string nume)
        {
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                // instructiunea 'using' va apela sr.Close()
                using (Stream sr_bin = File.Open(NumeFisier, FileMode.Open))
                {
                    while (sr_bin.Position < sr_bin.Length)
                    {
                        //Observati conversia!!!
                        Anime a = (Anime)b.Deserialize(sr_bin);
                        //if (nume == a.Nume)
                        return a;
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

        public bool RewriteAnime(Anime anim)
        {
            List<Anime> animeuri = new List<Anime>();
            animeuri = GetAnimeuri();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                //instructiunea 'using' va apela sBinFile.Close();
                Stream sBinFile = File.Open(NumeFisier, FileMode.Create, FileAccess.Write);
                sBinFile.Close();
                foreach (Anime anime in animeuri)
                {
                    if (anime.IdAnime == anim.IdAnime)
                        AddAnime(anim);
                    else
                        AddAnime(anime);
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
            return false;
        }

        public bool DeleteAnime(Anime anim)
        {

            List<Anime> animeuri = new List<Anime>();
            Anime animeDinFisier;
            animeuri = GetAnimeuri();
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                //instructiunea 'using' va apela sBinFile.Close();
                Stream sBinFile = File.Open(NumeFisier, FileMode.Create, FileAccess.Write);
                sBinFile.Close();
                foreach (Anime anime in animeuri)
                {
                    animeDinFisier = anime;
                    i++;
                    if (animeDinFisier.IdAnime == anim.IdAnime)
                    {
                        i--;
                        continue;
                    }
                    animeDinFisier.IdAnime = i;
                    AddAnime(animeDinFisier);
                }
                actualizareCuSucces = true;

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

        public List<Anime> GetAnimeL(string nume)
        {
            //List<Anime> animeuri = new List<Anime>();

            //try
            //{
            //    // instructiunea 'using' va apela sr.Close()
            //    using (StreamReader sr = new StreamReader(NumeFisier))
            //    {
            //        string line;

            //        //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Anime animeDinFisier = new Anime(line);
            //            if (nume.ToUpper() == animeDinFisier.NumeAnime.ToUpper())
            //            {
            //                animeuri.Add(animeDinFisier);
            //                return animeuri;
            //            }
            //        }
            //    }
            //}
            //catch (IOException eIO)
            //{
            //    throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            //}
            //catch (Exception eGen)
            //{
            //    throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            //}

            return null;
        }

        private int GetId()
        {
            int IdAnime = ID_PRIMUL_ANIME;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Anime a = (Anime)b.Deserialize(sBinFile);
                        IdAnime = a.IdAnime + INCREMENT;
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
            return IdAnime;
        }
    }
}
