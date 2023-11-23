﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nsc.Context;

#nullable disable

namespace Nsc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231123012009_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nsc.Models.Cadastro", b =>
                {
                    b.Property<int>("CadastroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("DataCadastro")
                        .HasMaxLength(300)
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<int>("IdCPF")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.Property<int>("IdRG")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ReservaId")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.HasKey("CadastroId");

                    b.HasIndex("ReservaId");

                    b.ToTable("Cadastros");
                });

            modelBuilder.Entity("Nsc.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CadastroId")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEscolhidaId")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataReservaId")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<int>("ReservaId")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.Property<int>("ValorId")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.Property<int>("ValorPagoId")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.Property<int>("ValorRestanteId")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.HasKey("PagamentoId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("Nsc.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEscolhidaId")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataReservaId")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<int>("QtdePessoas")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.Property<int>("ValorId")
                        .HasMaxLength(80)
                        .HasColumnType("int");

                    b.HasKey("ReservaId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Nsc.Models.Cadastro", b =>
                {
                    b.HasOne("Nsc.Models.Reserva", null)
                        .WithMany("Cadastros")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nsc.Models.Reserva", b =>
                {
                    b.Navigation("Cadastros");
                });
#pragma warning restore 612, 618
        }
    }
}
