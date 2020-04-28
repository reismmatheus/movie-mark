using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Serie>().HasKey(x => x.Id);

            builder.Entity<Temporada>().HasKey(x => x.Id);

            builder.Entity<Episodio>().HasKey(x => x.Id);

            builder.Entity<UserTemporadaEpisodio>().HasKey(x => x.Id);

            builder.Entity<UserSerie>().HasMany(x => x.ListaTemporadaEpisodio).WithOne(x => x.UserSerie);
        }
    }
}
