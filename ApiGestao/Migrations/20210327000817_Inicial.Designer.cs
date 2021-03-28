﻿// <auto-generated />
using System;
using ApiGestao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiGestao.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210327000817_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ApiGestao.Models.Agendamento", b =>
                {
                    b.Property<int>("IDAGENDAMENTO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DT_FIM")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DT_INICIO")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("IDSALA")
                        .HasColumnType("bigint");

                    b.Property<int?>("SalaIDSALA")
                        .HasColumnType("int");

                    b.Property<string>("TITULO")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4");

                    b.HasKey("IDAGENDAMENTO");

                    b.HasIndex("SalaIDSALA");

                    b.ToTable("Agendamentos");

                    b.HasData(
                        new
                        {
                            IDAGENDAMENTO = 1,
                            DT_FIM = new DateTime(2021, 3, 24, 11, 20, 0, 0, DateTimeKind.Unspecified),
                            DT_INICIO = new DateTime(2021, 3, 24, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            IDSALA = 1L,
                            TITULO = "Definir Scrum com Equipe"
                        },
                        new
                        {
                            IDAGENDAMENTO = 2,
                            DT_FIM = new DateTime(2021, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            DT_INICIO = new DateTime(2021, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            IDSALA = 2L,
                            TITULO = "Homologação dos requisitos com o cliente"
                        },
                        new
                        {
                            IDAGENDAMENTO = 3,
                            DT_FIM = new DateTime(2021, 3, 26, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            DT_INICIO = new DateTime(2021, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            IDSALA = 3L,
                            TITULO = "contratação candidato"
                        });
                });

            modelBuilder.Entity("ApiGestao.Models.Sala", b =>
                {
                    b.Property<int>("IDSALA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NOME")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4");

                    b.HasKey("IDSALA");

                    b.ToTable("Sala");

                    b.HasData(
                        new
                        {
                            IDSALA = 1,
                            NOME = "Reuniao Equipe Dev"
                        },
                        new
                        {
                            IDSALA = 2,
                            NOME = "Departamento Pessoal"
                        },
                        new
                        {
                            IDSALA = 3,
                            NOME = "Entrevistas"
                        });
                });

            modelBuilder.Entity("ApiGestao.Models.Agendamento", b =>
                {
                    b.HasOne("ApiGestao.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaIDSALA");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}
