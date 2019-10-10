using Microsoft.EntityFrameworkCore;
using Registration.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Infrastructure.Db
{
    public class RegistrationContext : DbContext
    {

        public DbSet<Question> Questions { get; set; }
        public DbSet<Dropdown> Dropdowns { get; set; }
        public DbSet<DropdownField> DropdownFields { get; set; }

        public RegistrationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(new Question()
            {
                Id = 1,
                Name = "Reikia atlikti rangos darbus"
            },
            new Question()
            {
                Id = 2,
                Name = "Rangos darbos atliks"
            },
            new Question()
            {
                Id = 3,
                Name = "Verslo klientas"
            },
            new Question()
            {
                Id = 4,
                Name = "Skaiciavimo budas"
            },
            new Question()
            {
                Id = 5,
                Name = "Svarbus Klientas"
            });

            modelBuilder.Entity<Dropdown>().HasData(new Dropdown
            {
                Id = 1,
                Name = "Reikia atlikti rangos darbus",
                QuestionId = 1
            },new Dropdown
            {
                Id = 2,
                Name = "Rangos darbos atliks",
                QuestionId = 2
            },new Dropdown
            {
                Id = 3,
                Name = "Verslo klientas",
                QuestionId = 3
            },new Dropdown
            {
                Id = 4,
                Name = "Skaiciavimo budas",
                QuestionId = 4
            }, new Dropdown
            {
                Id = 5,
                Name = "Svarbus Klientas",
                QuestionId = 5
            });

            modelBuilder.Entity<DropdownField>().HasData(new List<DropdownField>()
            {
                new DropdownField()
                {
                Id = 1,
                Name = "Taip",
                DropdownId = 1
                },
                 new DropdownField()
                {
                Id = 2,
                Name = "Ne",
                DropdownId = 1
                },
                   new DropdownField()
                {
                Id = 3,
                Name = "Metinis Rangovas",
                DropdownId = 2
                },
                 new DropdownField()
                {
                Id = 4,
                Name = "Kiti",
                DropdownId = 2
                },
                 new DropdownField()
                {
                Id = 5,
                Name = "Taip",
                DropdownId = 3
                },
                 new DropdownField()
                {
                Id = 6,
                Name = "Ne",
                DropdownId = 3
                },
                    new DropdownField()
                {
                Id = 7,
                Name = "Automatinis",
                DropdownId = 4
                },
                 new DropdownField()
                {
                Id = 8,
                Name = "Paprastas",
                DropdownId = 4
                },
                 new DropdownField()
                {
                Id = 9,
                Name = "Taip",
                DropdownId = 5
                },
                 new DropdownField()
                {
                Id = 10,
                Name = "Ne",
                DropdownId = 5
                }
            });
        }
    }
}
