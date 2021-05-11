using Anime_Project;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareDate
    {
        void AddAnime(Anime a);

        bool RewriteAnime(Anime animeUpdate);

        ArrayList GetAnimeuri();

        Anime GetAnime(string nume);

        //List<Anime> ModificareAnime(ArrayList animeuri);
    }
}