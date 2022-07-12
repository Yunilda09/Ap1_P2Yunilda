﻿// <auto-generated />
using System;
using AP2_Yunilda.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AP2_Yunilda.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220712010618_Modificado")]
    partial class Modificado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("AP2_Yunilda.Models.Verduras", b =>
                {
                    b.Property<int>("VerduraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VerduraId");

                    b.ToTable("Verduras");
                });

            modelBuilder.Entity("AP2_Yunilda.Models.VerdurasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<int>("VerduraId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VitaminaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VerduraId");

                    b.ToTable("VerdurasDetalle");
                });

            modelBuilder.Entity("AP2_Yunilda.Models.Vitaminas", b =>
                {
                    b.Property<int>("VitaminaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Existencia")
                        .HasColumnType("REAL");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VitaminaId");

                    b.ToTable("Vitaminas");

                    b.HasData(
                        new
                        {
                            VitaminaId = 1,
                            Descripcion = "Vitamina A ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 2,
                            Descripcion = "Vitamina B1 ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 3,
                            Descripcion = "Vitamina B2 ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 4,
                            Descripcion = "Vitamina B6 ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 5,
                            Descripcion = "Vitamina B12 ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 6,
                            Descripcion = "Vitamina C",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 7,
                            Descripcion = "Vitamina D ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 8,
                            Descripcion = "Vitamina E ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 9,
                            Descripcion = "Vitamina K ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        },
                        new
                        {
                            VitaminaId = 10,
                            Descripcion = "Vitamina B3 ",
                            Existencia = 0.0,
                            UnidadMedida = "mg"
                        });
                });

            modelBuilder.Entity("AP2_Yunilda.Models.VerdurasDetalle", b =>
                {
                    b.HasOne("AP2_Yunilda.Models.Verduras", null)
                        .WithMany("Detalle")
                        .HasForeignKey("VerduraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AP2_Yunilda.Models.Verduras", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
