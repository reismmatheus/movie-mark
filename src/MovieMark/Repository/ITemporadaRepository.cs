using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    interface ITemporadaRepository
    {
        void Insert();
        List<Temporada> GetAll();
    }
}
