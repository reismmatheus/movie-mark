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
            builder.Entity<Serie>().HasMany(x => x.ListaTemporada).WithOne(x => x.Serie).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Temporada>().HasKey(x => x.Id);
            builder.Entity<Temporada>().HasMany(x => x.ListaEpisodio).WithOne(x => x.Temporada).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Episodio>().HasKey(x => x.Id);

            builder.Entity<UserTemporadaEpisodio>().HasKey(x => x.Id);
            builder.Entity<UserTemporadaEpisodio>().HasOne(x => x.Temporada).WithOne().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<UserTemporadaEpisodio>().HasOne(x => x.Episodio).WithOne().OnDelete(DeleteBehavior.NoAction);
            builder.Entity<UserTemporadaEpisodio>().HasOne(x => x.UserSerie).WithMany(x => x.ListaTemporadaEpisodio);
            builder.Entity<UserTemporadaEpisodio>().HasIndex(x => new { x.TemporadaId, x.EpisodioId, x.UserSerieId }).IsUnique();

            builder.Entity<UserSerie>().HasKey(x => x.Id);
            builder.Entity<UserSerie>().HasIndex(x => new { x.AspNetUsersId, x.SerieId }).IsUnique();
            builder.Entity<UserSerie>().HasMany(x => x.ListaTemporadaEpisodio).WithOne(x => x.UserSerie).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
