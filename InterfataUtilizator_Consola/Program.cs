using Anime_Project;
using NivelAccesDate;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace InterfataUtilizator_Consola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        //    File.WriteAllText("Anime.txt", string.Empty);
        //    IStocareDate adminAnime = StocareFactory.GetAdministratorStocare();

        //    ArrayList animeuri = adminAnime.GetAnimeuri();
        //    //List<Anime> listaAnimeuri;
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("A - Afisare animeuri");
        //        Console.WriteLine("C - Citire si adaugare anime");
        //        Console.WriteLine("F - Cautare anime");
        //        Console.WriteLine("M - Actualizare anime");
        //        Console.WriteLine("X - Iesire din program");
        //        Console.WriteLine("Alegeti o optiune: ");
        //        var key = Console.ReadKey(true).Key;
        //        switch (key)
        //        {
        //            case ConsoleKey.A:
        //                AfisareAnimeuri(animeuri);
        //                break;

        //            case ConsoleKey.C:
        //                Anime a = CitireAnimeTastatura();
        //                animeuri.Add(a);
        //                adminAnime.AddAnime(a);
        //                break;

        //            case ConsoleKey.F:
        //                Anime animeCautat = CautareAnime();
        //                if (animeCautat != null)
        //                    Console.WriteLine(animeCautat.ConvertToStringAfisare());
        //                else
        //                    Console.WriteLine("Nu exista acest anime");
        //                break;

        //            case ConsoleKey.M:
        //                Console.WriteLine("Introduceti numele animeului");
        //                string nume = Console.ReadLine().ToUpper().Trim();

        //                Anime animeUpdate = adminAnime.GetAnime(nume);
        //                if (animeUpdate == null)
        //                {
        //                    Console.WriteLine(" Animeul cautat nu exista");
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Am gasit studentul {animeUpdate.ConvertToStringFisier()}");
        //                    //while (true)
        //                    //{
        //                    //    Console.Clear();
        //                    //    Console.WriteLine(animeUpdate);
        //                    //    Console.WriteLine("Ce doriti sa modificati?\n ");
        //                    //    Console.WriteLine("1 - Numarul de episoade\n");
        //                    //    Console.WriteLine("2 - Numarul de sezoane\n");
        //                    //    Console.WriteLine("3 - Starea animeului\n");
        //                    //    Console.WriteLine("4 - Recenzia animeului\n");
        //                    //    Console.WriteLine("X - Pentru a incheia aceata activitate\n\n");

        //                    //    var key = Console.ReadKey(true).Key;
        //                    //    switch (key)
        //                    //    {
        //                    //        case ConsoleKey.D1:
        //                    //            Console.Write("Introduceti numarul de episoade: ");
        //                    //            if (int.TryParse(Console.ReadLine(), out intParseInput))
        //                    //                listaAnime[i].EpisoadeAnime = intParseInput;
        //                    //            else
        //                    //                Console.WriteLine("Introducere incorecta");
        //                    //            break;

        //                    //        case ConsoleKey.D2:
        //                    //            Console.Write("Introduceti numarul de sezoane: ");
        //                    //            if (int.TryParse(Console.ReadLine(), out intParseInput))
        //                    //                listaAnime[i].SezoaneAnime = intParseInput;
        //                    //            else
        //                    //                Console.WriteLine("Introducere incorecta");
        //                    //            break;

        //                    //        case ConsoleKey.D3:
        //                    //            Console.WriteLine("Introduceti starea animeului: ");
        //                    //            listaAnime[i].OngoingAnime = Console.ReadLine().ToUpper().Trim();
        //                    //            break;

        //                    //        case ConsoleKey.D4:
        //                    //            Console.Write("Introduceti nota: ");
        //                    //            if (double.TryParse(Console.ReadLine(), out doubleParseInput))
        //                    //                listaAnime[i].NotaAnime = doubleParseInput;
        //                    //            else
        //                    //                Console.WriteLine("Introducere incorecta");

        //                    //                break;

        //                    //            case ConsoleKey.X:
        //                    //                return listaAnime;

        //                    //            default:
        //                    //                break;
        //                    //        }
        //                    //    }

        //                    //    bool updateResult = adminStudenti.UpdateStudent(studentPentruModificare);
        //                    //    if (updateResult == true)
        //                    //    {
        //                    //        studenti = adminStudenti.GetStudenti();
        //                    //    }
        //                    //}
        //                    Console.WriteLine("TERMIN SWITCH PENTRU CE DORESTI SA MODIFICI");
        //                }
        //                break;
        //            case ConsoleKey.X:
        //                Environment.Exit(0);
        //                break;

        //            default:
        //                Console.WriteLine("Nu exista aceasta optiune");
        //                break;
        //        }
        //        Console.WriteLine("Apasati orice tasta pentru a continua...");
        //        Console.ReadKey();
        //    }

        //}

        //public static Anime CitireAnimeTastatura()
        //{
        //    Console.WriteLine("Introduceti numele animeului");
        //    string nume = Console.ReadLine().ToUpper().Trim();

        //    Console.WriteLine("Introduceti numarul de sezoane: ");
        //    string sezoane = Console.ReadLine().ToUpper().Trim();

        //    Console.WriteLine("Introduceti numarul de episoade/sezon: ");
        //    string episoade = Console.ReadLine().ToUpper().Trim();
        //    ///////////////////////////////////////////////////////////////////////////
        //    //Console.WriteLine("Alegeti genurile animeului: (Separate prin virgula)");
        //    //Console.WriteLine(" Action = 1, Adventure = 2, Comedy = 3,Demons = 4,Drama = 5, Ecchi = 6, Fantasy = 7, Game = 8, Harem = 9, Historical = 10, Horror = 11, Josei = 12,\n" +
        //    //                   "Magic = 13, Martial = 14, Mecha = 15,  Military = 16, Music = 17, Mystery = 18, Psychological = 19, Romance = 20, Samurai = 21, Seinen = 22, Shoujo = 23,\n" +
        //    //                   "ShoujoAi = 24, Shounen = 25, ShounenAi = 26, SliceOfLife = 27, Sports = 28, Supernatural = 29, Thriller = 30, Yaoi = 31, Yuri = 32\n");
        //    //string op = Console.ReadLine().ToUpper();
        //    //string[] formatOp = op.Split(',');
        //    //for (int i = 0; i < formatOp.Length; i++)
        //    //    formatOp[i] = formatOp[i].Trim();

        //    //op = string.Empty;
        //    //op = string.Join(",", formatOp);

        //    Console.WriteLine("Introduceti starea animeului (complet sau airing): ");
        //    string ongoing = Console.ReadLine().ToUpper().Trim();

        //    Console.WriteLine("Introduceti nota animeului: ");
        //    string nota = Console.ReadLine().ToUpper().Trim();

        //    Anime a = new Anime();
        //    a.NumeAnime = nume;
        //    a.SezoaneAnime = int.Parse(sezoane);
        //    a.EpisoadeAnime = int.Parse(episoade);

        //    //if (op != string.Empty)
        //    //    a.GenAnime = op;
        //    //else
        //    //    a.GenAnime = "NESPECIFICAT";
        //    //////////////////////////////////////////////////////////
        //   // a.OngoingAnime = ongoing;
        //    a.NotaAnime = Double.Parse(nota);

        //    return a;
        //}

        //public static void AfisareAnimeuri(ArrayList animeuri)
        //{
        //    if (animeuri.Count == 0)
        //        Console.WriteLine("Nu exista animeuri in lista");
        //    else
        //    {
        //        Console.WriteLine("Animeurile sunt:");
        //        for (int i = 0; i < animeuri.Count; i++)
        //            Console.WriteLine(((Anime)animeuri[i]).ConvertToStringAfisare());
        //    }

        //}

        //public static Anime CautareAnime()
        //{
        //    IStocareDate adminAnime = StocareFactory.GetAdministratorStocare();
        //    Console.WriteLine("Introduceti numele animeului cautat: ");
        //    string nume = Console.ReadLine().ToUpper().Trim();

        //    Anime a = adminAnime.GetAnime(nume);
        //    return a;
        }
    }
}