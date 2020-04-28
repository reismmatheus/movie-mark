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
        void Insert(UserSerie userSerie);
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

        public void Insert(UserSerie userSerie)
        {
            contexto.Set<UserSerie>().Add(userSerie);
            contexto.SaveChanges();
        }
    }
}
