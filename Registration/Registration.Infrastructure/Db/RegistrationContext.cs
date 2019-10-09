using Microsoft.EntityFrameworkCore;
using Registration.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Infrastructure.Db
{
    public class RegistrationContext : DbContext
    {
        public DbSet<RegistrationEntity> Registrations { get; set; }

        public DbSet<QuestionEntity> Questions { get; set; }
        public DbSet<DropdownEntity> Dropdowns { get; set; }
        public DbSet<DropdownFieldEntity> DropdownFields { get; set; }

        public RegistrationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionEntity>().HasData(new QuestionEntity()
            {
                Id = 1,
                Name = "Reikia atlikti rangos darbus"
            });

            modelBuilder.Entity<DropdownEntity>().HasData(new DropdownEntity
            {
                Id = 1,
                Name = "Reikia atlikti rangos darbus",
                QuestionId = 1
            });

            modelBuilder.Entity<DropdownFieldEntity>().HasData(new List<DropdownFieldEntity>()
            {
                new DropdownFieldEntity()
                {
                Id = 1,
                Name = "Taip",
                DropdownId = 1
                },
                 new DropdownFieldEntity()
                {
                Id = 2,
                Name = "Ne",
                DropdownId = 1
                }
            });

            modelBuilder.Entity<QuestionEntity>().HasData(new QuestionEntity()
            {
                Id = 2,
                Name = "Rangos darbos atliks"
            });

            modelBuilder.Entity<DropdownEntity>().HasData(new DropdownEntity
            {
                Id = 2,
                Name = "Rangos darbos atliks",
                QuestionId = 2
            });

            modelBuilder.Entity<DropdownFieldEntity>().HasData(new List<DropdownFieldEntity>()
            {
                new DropdownFieldEntity()
                {
                Id = 3,
                Name = "Metinis Rangovas",
                DropdownId = 2
                },
                 new DropdownFieldEntity()
                {
                Id = 4,
                Name = "Kiti",
                DropdownId = 2
                }
            });

            modelBuilder.Entity<QuestionEntity>().HasData(new QuestionEntity()
            {
                Id = 3,
                Name = "Verslo klientas"
            });

            modelBuilder.Entity<DropdownEntity>().HasData(new DropdownEntity
            {
                Id = 3,
                Name = "Verslo klientas",
                QuestionId = 3
            });

            modelBuilder.Entity<DropdownFieldEntity>().HasData(new List<DropdownFieldEntity>()
            {
                new DropdownFieldEntity()
                {
                Id = 5,
                Name = "Taip",
                DropdownId = 3
                },
                 new DropdownFieldEntity()
                {
                Id = 6,
                Name = "Ne",
                DropdownId = 3
                }
            });
            
            modelBuilder.Entity<QuestionEntity>().HasData(new QuestionEntity()
            {
                Id = 4,
                Name = "Skaiciavimo budas"
            });

            modelBuilder.Entity<DropdownEntity>().HasData(new DropdownEntity
            {
                Id = 4,
                Name = "Skaiciavimo budas",
                QuestionId = 4
            });

            modelBuilder.Entity<DropdownFieldEntity>().HasData(new List<DropdownFieldEntity>()
            {
                new DropdownFieldEntity()
                {
                Id = 7,
                Name = "Automatinis",
                DropdownId = 4
                },
                 new DropdownFieldEntity()
                {
                Id = 8,
                Name = "Paprastas",
                DropdownId = 4
                }
            });

            modelBuilder.Entity<QuestionEntity>().HasData(new QuestionEntity()
            {
                Id = 5,
                Name = "Skaiciavimo budas"
            });

            modelBuilder.Entity<DropdownEntity>().HasData(new DropdownEntity
            {
                Id = 5,
                Name = "Svarbus Klientas",
                QuestionId = 5
            });

            modelBuilder.Entity<DropdownFieldEntity>().HasData(new List<DropdownFieldEntity>()
            {
                new DropdownFieldEntity()
                {
                Id = 9,
                Name = "Taip",
                DropdownId = 5
                },
                 new DropdownFieldEntity()
                {
                Id = 10,
                Name = "Ne",
                DropdownId = 5
                }
            });
        }
    }
}
