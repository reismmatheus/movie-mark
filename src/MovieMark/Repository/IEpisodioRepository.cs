using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    interface IEpisodioRepository
    {
        void Insert(Episodio episodio);
        Episodio Get(int id);
        List<Episodio> GetAll();
        List<Episodio> GetByIdTemporada(int id);
    }
}
