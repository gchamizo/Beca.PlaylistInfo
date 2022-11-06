﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PlaylistInfo.API.DbContexts;

#nullable disable

namespace Beca.PlaylistInfo.API.Migrations
{
    [DbContext(typeof(PlaylistInfoContext))]
    partial class PlaylistInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Beca.PlaylistInfo.API.Entities.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Así suena internet.",
                            Title = "Viral España"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Abba are back! All their essential tracks in one.",
                            Title = "This is ABBA"
                        },
                        new
                        {
                            Id = 3,
                            Description = "¡Mora, Paulo Londra & Feid, Quevedo, Rels B y más!",
                            Title = "Novedades Viernes"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Lo mejor del rock de aquí (y de allá), como Andrés Calamaro.",
                            Title = "Rock Español"
                        });
                });

            modelBuilder.Entity("Beca.PlaylistInfo.API.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "La Joaqui, Alan Gomez, ELNOBA",
                            Name = "Butakera",
                            PlaylistId = 1
                        },
                        new
                        {
                            Id = 2,
                            Artist = "Kaydy Cain, La Zowi, Kabasaki",
                            Name = "Ping Pong",
                            PlaylistId = 1
                        },
                        new
                        {
                            Id = 3,
                            Artist = "Rauw Alejandro, Baby Rasta",
                            Name = "PUNTO 40",
                            PlaylistId = 1
                        },
                        new
                        {
                            Id = 4,
                            Artist = "ABBA",
                            Name = "Waterloo",
                            PlaylistId = 2
                        },
                        new
                        {
                            Id = 5,
                            Artist = "ABBA",
                            Name = "Lay all your love on me",
                            PlaylistId = 2
                        },
                        new
                        {
                            Id = 6,
                            Artist = "Mora, Quevedo",
                            Name = "APA",
                            PlaylistId = 3
                        },
                        new
                        {
                            Id = 7,
                            Artist = "Paulo Londra, Feid",
                            Name = "A veces",
                            PlaylistId = 3
                        },
                        new
                        {
                            Id = 8,
                            Artist = "Rels B",
                            Name = "pa quererte",
                            PlaylistId = 3
                        },
                        new
                        {
                            Id = 9,
                            Artist = "Estopa",
                            Name = "Como Camarón",
                            PlaylistId = 4
                        },
                        new
                        {
                            Id = 10,
                            Artist = "Extremoduro",
                            Name = "Si te vas",
                            PlaylistId = 4
                        },
                        new
                        {
                            Id = 11,
                            Artist = "Loquillo",
                            Name = "Cadillac Solitario",
                            PlaylistId = 4
                        },
                        new
                        {
                            Id = 12,
                            Artist = "Celtas Cortos",
                            Name = "20 de abril",
                            PlaylistId = 4
                        });
                });

            modelBuilder.Entity("Beca.PlaylistInfo.API.Entities.Song", b =>
                {
                    b.HasOne("Beca.PlaylistInfo.API.Entities.Playlist", "Playlist")
                        .WithMany("Songs")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("Beca.PlaylistInfo.API.Entities.Playlist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
