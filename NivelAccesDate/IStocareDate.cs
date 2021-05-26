using Anime_Project;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareDate
    {
        void AddAnime(Anime a);

        bool RewriteAnime(Anime animeUpdate);

        List<Anime> GetAnimeuri();

        Anime GetAnime(string nume);
        Anime GetAnime(int IdAnime);

        List<Anime> GetAnimeL(string nume);

        bool DeleteAnime(Anime animeUpdate);

        //List<Anime> ModificareAnime(ArrayList animeuri);
    }
}