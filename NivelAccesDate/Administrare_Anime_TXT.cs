using Anime_Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    public class Administrare_Anime_TXT : IStocareDate
    {
        private string NumeFisier { get; set; }

        public Administrare_Anime_TXT(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        public void AddAnime(Anime a)
        {
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

        public ArrayList GetAnimeuri()
        {
            ArrayList animeuri = new ArrayList();

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
                        if (nume == animeFisier.NumeAnime)
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

        public bool RewriteAnime(Anime animeUpdate)
        {
            ArrayList anime = GetAnimeuri();
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



        //public List<Anime> ModificareAnime(ArrayList animeuri)
        //{
        //    List<Anime> listaAnime = new List<Anime>();
        //    foreach (var elem in animeuri)
        //    {
        //        listaAnime.Add((Anime)elem);
        //    }

        //    string caut;
        //    Console.Write("Introduceti numele animeului: ");
        //    caut = Console.ReadLine().ToUpper().Trim();
        //    int i = -1;
        //    bool ok = false;
        //    foreach (var elem in listaAnime)
        //    {
        //        i++;
        //        if (caut == elem.NumeAnime)
        //        {
        //            ok = true;
        //            break;
        //        }
        //    }

        //    if (ok == false)
        //    {
        //        Console.WriteLine("Nu exista acest anime");
        //        return listaAnime;
        //    }

        //    bool modificaDate = false;
        //    bool isTrue = true;

        //    while (isTrue)
        //    {
        //        Console.WriteLine("Doriti sa modificati acest anime? [Y/N]");
        //        var key = Console.ReadKey(true).Key;
        //        switch (key)
        //        {
        //            case ConsoleKey.Y:
        //                modificaDate = true;
        //                isTrue = false;
        //                break;

        //            case ConsoleKey.N:
        //                modificaDate = false;
        //                isTrue = false;
        //                break;

        //            default:
        //                Console.WriteLine("Optiune incorecta.");
        //                break;
        //        }
        //        if (isTrue)
        //        {
        //            Console.WriteLine("\nApasati orice tasta pentru a continua...");
        //            Console.ReadKey();
        //        }
        //    }
        //    Console.Clear();

        //    if (modificaDate)
        //    {
        //        int intParseInput;
        //        Double doubleParseInput;
        //        while (true)
        //        {
        //            Console.Clear();
        //            Console.WriteLine(listaAnime[i].ConvertToStringAfisare());
        //            Console.WriteLine("Ce doriti sa modificati?\n ");
        //            Console.WriteLine("1 - Numarul de episoade\n");
        //            Console.WriteLine("2 - Numarul de sezoane\n");
        //            Console.WriteLine("3 - Starea animeului\n");
        //            Console.WriteLine("4 - Recenzia animeului\n");
        //            Console.WriteLine("X - Pentru a incheia aceata activitate\n\n");

        //            var key = Console.ReadKey(true).Key;
        //            switch (key)
        //            {
        //                case ConsoleKey.D1:
        //                    Console.Write("Introduceti numarul de episoade: ");
        //                    if (int.TryParse(Console.ReadLine(), out intParseInput))
        //                        listaAnime[i].EpisoadeAnime = intParseInput;
        //                    else
        //                        Console.WriteLine("Introducere incorecta");
        //                    break;

        //                case ConsoleKey.D2:
        //                    Console.Write("Introduceti numarul de sezoane: ");
        //                    if (int.TryParse(Console.ReadLine(), out intParseInput))
        //                        listaAnime[i].SezoaneAnime = intParseInput;
        //                    else
        //                        Console.WriteLine("Introducere incorecta");
        //                    break;

        //                case ConsoleKey.D3:
        //                    Console.WriteLine("Introduceti starea animeului: ");
        //                    listaAnime[i].OngoingAnime = Console.ReadLine().ToUpper().Trim();
        //                    break;

        //                case ConsoleKey.D4:
        //                    Console.Write("Introduceti nota: ");
        //                    if (double.TryParse(Console.ReadLine(), out doubleParseInput))
        //                        listaAnime[i].NotaAnime = doubleParseInput;
        //                    else
        //                        Console.WriteLine("Introducere incorecta");
        //                    break;

        //                case ConsoleKey.X:
        //                    return listaAnime;

        //                default:
        //                    break;
        //            }
        //        }
        //    }

        //    return listaAnime;
        //}



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