using MovieMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public interface IUserSerieRepository
    {
        UserSerie Get(int id);
        List<UserSerie> GetByIdUser(string idUser);
        UserSerie GetByIdUserSerieId(string idUser, int serieId);
        void Insert(UserSerie userSerie);
        bool DeleteByIdSerieIdUser(int idSerie, string idUser);
    }
    public class UserSerieRepository : IUserSerieRepository
    {
        private readonly ApplicationDbContext contexto;
        public UserSerieRepository(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public UserSerie Get(int id)
        {
            return contexto.Set<UserSerie>().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<UserSerie> GetByIdUser(string idUser)
        {
            return contexto.Set<UserSerie>().Where(x => x.AspNetUsersId == idUser).ToList();
        }

        public UserSerie GetByIdUserSerieId(string idUser, int serieId)
        {
            return contexto.Set<UserSerie>().Where(x => x.AspNetUsersId == idUser && x.SerieId == serieId).FirstOrDefault();
        }

        public void Insert(UserSerie userSerie)
        {
            contexto.Set<UserSerie>().Add(userSerie);
            contexto.SaveChanges();
        }

        public bool DeleteByIdSerieIdUser(int idSerie, string idUser)
        {
            contexto.Set<UserSerie>().Remove(GetByIdUserSerieId(idUser, idSerie));
            return contexto.SaveChanges() == 1 ? true : false;
        }
    }
}
