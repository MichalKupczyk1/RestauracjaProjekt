﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektTaiib.Models;

namespace ProjektTaiib.Migrations
{
    [DbContext(typeof(Restauracja))]
    partial class RestauracjaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjektTaiib.Models.KartaDan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("cena")
                        .HasColumnType("real");

                    b.Property<int>("id_typDania")
                        .HasColumnType("int");

                    b.Property<string>("nazwaDania")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("id_typDania");

                    b.ToTable("kartaDan");
                });

            modelBuilder.Entity("ProjektTaiib.Models.Kelner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("kelner");
                });

            modelBuilder.Entity("ProjektTaiib.Models.Stolik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("czyObsluzony")
                        .HasColumnType("bit");

                    b.Property<bool>("czyZajety")
                        .HasColumnType("bit");

                    b.Property<int>("ileMiejsc")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("stolik");
                });

            modelBuilder.Entity("ProjektTaiib.Models.TypDania", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nazwaTypu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("typDania");
                });

            modelBuilder.Entity("ProjektTaiib.Models.Zamowienie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("data_zam")
                        .HasColumnType("Date");

                    b.Property<int>("id_kartaDan")
                        .HasColumnType("int");

                    b.Property<int>("id_kelner")
                        .HasColumnType("int");

                    b.Property<int>("id_stolik")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("id_kartaDan");

                    b.HasIndex("id_kelner");

                    b.HasIndex("id_stolik");

                    b.ToTable("zamowienie");
                });

            modelBuilder.Entity("ProjektTaiib.Models.KartaDan", b =>
                {
                    b.HasOne("ProjektTaiib.Models.TypDania", "typDania")
                        .WithMany("Dania")
                        .HasForeignKey("id_typDania")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("typDania");
                });

            modelBuilder.Entity("ProjektTaiib.Models.Zamowienie", b =>
                {
                    b.HasOne("ProjektTaiib.Models.KartaDan", "kartaDan")
                        .WithMany("zamowienia")
                        .HasForeignKey("id_kartaDan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjektTaiib.Models.Kelner", "kelner")
                        .WithMany("zamowienia")
                        .HasForeignKey("id_kelner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjektTaiib.Models.Stolik", "Stolik")
                        .WithMany("zamowienia")
                        .HasForeignKey("id_stolik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kartaDan");

                    b.Navigation("kelner");

                    b.Navigation("Stolik");
                });

            modelBuilder.Entity("ProjektTaiib.Models.KartaDan", b =>
                {
                    b.Navigation("zamowienia");
                });

            modelBuilder.Entity("ProjektTaiib.Models.Kelner", b =>
                {
                    b.Navigation("zamowienia");
                });

            modelBuilder.Entity("ProjektTaiib.Models.Stolik", b =>
                {
                    b.Navigation("zamowienia");
                });

            modelBuilder.Entity("ProjektTaiib.Models.TypDania", b =>
                {
                    b.Navigation("Dania");
                });
#pragma warning restore 612, 618
        }
    }
}
