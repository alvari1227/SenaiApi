﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1.Contexto;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(SenaiContext))]
    [Migration("20250621140221_alterado tipo cidade")]
    partial class alteradotipocidade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Entidades.Aluno", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ClasseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Classe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProfessorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Serie")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId");

                    b.HasIndex("ProfessorId")
                        .IsUnique();

                    b.ToTable("Classe");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Endereço", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Cidade")
                        .HasMaxLength(60)
                        .HasColumnType("integer");

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId")
                        .IsUnique();

                    b.ToTable("Endereço");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Escola", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Professor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Aluno", b =>
                {
                    b.HasOne("WebApplication1.Entidades.Classe", "classe")
                        .WithMany()
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("classe");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Classe", b =>
                {
                    b.HasOne("WebApplication1.Entidades.Escola", "Escola")
                        .WithMany("Classes")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Entidades.Professor", "Professor")
                        .WithOne("Classe")
                        .HasForeignKey("WebApplication1.Entidades.Classe", "ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Endereço", b =>
                {
                    b.HasOne("WebApplication1.Entidades.Escola", "Escola")
                        .WithOne("Endereço")
                        .HasForeignKey("WebApplication1.Entidades.Endereço", "EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Professor", b =>
                {
                    b.HasOne("WebApplication1.Entidades.Escola", "Escola")
                        .WithMany("Professores")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Escola", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Endereço")
                        .IsRequired();

                    b.Navigation("Professores");
                });

            modelBuilder.Entity("WebApplication1.Entidades.Professor", b =>
                {
                    b.Navigation("Classe")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
