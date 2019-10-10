﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registration.Infrastructure.Db;

namespace Registration.Infrastructure.Migrations
{
    [DbContext(typeof(RegistrationContext))]
    partial class RegistrationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Registration.Infrastructure.Entities.Dropdown", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId")
                        .IsUnique();

                    b.ToTable("tblMeta_Dropdown");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Reikia atlikti rangos darbus",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rangos darbos atliks",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Verslo klientas",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Skaiciavimo budas",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Svarbus Klientas",
                            QuestionId = 5
                        });
                });

            modelBuilder.Entity("Registration.Infrastructure.Entities.DropdownField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DropdownId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DropdownId");

                    b.ToTable("tblMeta_DropdownValue");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DropdownId = 1,
                            Name = "Taip"
                        },
                        new
                        {
                            Id = 2,
                            DropdownId = 1,
                            Name = "Ne"
                        },
                        new
                        {
                            Id = 3,
                            DropdownId = 2,
                            Name = "Metinis Rangovas"
                        },
                        new
                        {
                            Id = 4,
                            DropdownId = 2,
                            Name = "Kiti"
                        },
                        new
                        {
                            Id = 5,
                            DropdownId = 3,
                            Name = "Taip"
                        },
                        new
                        {
                            Id = 6,
                            DropdownId = 3,
                            Name = "Ne"
                        },
                        new
                        {
                            Id = 7,
                            DropdownId = 4,
                            Name = "Automatinis"
                        },
                        new
                        {
                            Id = 8,
                            DropdownId = 4,
                            Name = "Paprastas"
                        },
                        new
                        {
                            Id = 9,
                            DropdownId = 5,
                            Name = "Taip"
                        },
                        new
                        {
                            Id = 10,
                            DropdownId = 5,
                            Name = "Ne"
                        });
                });

            modelBuilder.Entity("Registration.Infrastructure.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("Value");

                    b.HasKey("Id");

                    b.ToTable("tblData_Question");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Reikia atlikti rangos darbus"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rangos darbos atliks"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Verslo klientas"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Skaiciavimo budas"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Svarbus Klientas"
                        });
                });

            modelBuilder.Entity("Registration.Infrastructure.Entities.Dropdown", b =>
                {
                    b.HasOne("Registration.Infrastructure.Entities.Question", "Question")
                        .WithOne("Dropdown")
                        .HasForeignKey("Registration.Infrastructure.Entities.Dropdown", "QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Registration.Infrastructure.Entities.DropdownField", b =>
                {
                    b.HasOne("Registration.Infrastructure.Entities.Dropdown", "Dropdown")
                        .WithMany("SelectFields")
                        .HasForeignKey("DropdownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
