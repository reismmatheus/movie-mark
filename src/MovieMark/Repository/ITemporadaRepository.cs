using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public interface ITemporadaRepository
    {
        void Insert(Temporada temporada);
        List<Temporada> GetAll(int id = 0);
        Temporada Get(int id);
    }
}
