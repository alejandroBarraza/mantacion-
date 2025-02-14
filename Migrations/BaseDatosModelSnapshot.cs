﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mantencion.Data;

namespace mantencion.Migrations
{
    [DbContext(typeof(BaseDatos))]
    partial class BaseDatosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mantencion.Data.Mantencion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Mantencions");
                });

            modelBuilder.Entity("mantencion.Data.MantencionMaterial", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("id_mantencion")
                        .HasColumnType("int");

                    b.Property<int>("id_material")
                        .HasColumnType("int");

                    b.Property<int?>("mantencionid")
                        .HasColumnType("int");

                    b.Property<int?>("materialid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("mantencionid");

                    b.HasIndex("materialid");

                    b.ToTable("MantencionMaterials");
                });

            modelBuilder.Entity("mantencion.Data.MantencionMecanico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("horas")
                        .HasColumnType("real");

                    b.Property<int>("id_mantencion")
                        .HasColumnType("int");

                    b.Property<int>("id_mecanico")
                        .HasColumnType("int");

                    b.Property<int?>("mantencionid")
                        .HasColumnType("int");

                    b.Property<int?>("mecanicoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("mantencionid");

                    b.HasIndex("mecanicoid");

                    b.ToTable("MantencionMecanicos");
                });

            modelBuilder.Entity("mantencion.Data.Material", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<string>("nombreMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Matarials");
                });

            modelBuilder.Entity("mantencion.Data.Mecanico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rut")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Mecanicos");
                });

            modelBuilder.Entity("mantencion.Data.MantencionMaterial", b =>
                {
                    b.HasOne("mantencion.Data.Mantencion", "mantencion")
                        .WithMany("MantencionMaterials")
                        .HasForeignKey("mantencionid");

                    b.HasOne("mantencion.Data.Material", "material")
                        .WithMany("MantencionMaterials")
                        .HasForeignKey("materialid");

                    b.Navigation("mantencion");

                    b.Navigation("material");
                });

            modelBuilder.Entity("mantencion.Data.MantencionMecanico", b =>
                {
                    b.HasOne("mantencion.Data.Mantencion", "mantencion")
                        .WithMany("MantencionMecanicos")
                        .HasForeignKey("mantencionid");

                    b.HasOne("mantencion.Data.Mecanico", "mecanico")
                        .WithMany("MantencionMecanicos")
                        .HasForeignKey("mecanicoid");

                    b.Navigation("mantencion");

                    b.Navigation("mecanico");
                });

            modelBuilder.Entity("mantencion.Data.Mantencion", b =>
                {
                    b.Navigation("MantencionMaterials");

                    b.Navigation("MantencionMecanicos");
                });

            modelBuilder.Entity("mantencion.Data.Material", b =>
                {
                    b.Navigation("MantencionMaterials");
                });

            modelBuilder.Entity("mantencion.Data.Mecanico", b =>
                {
                    b.Navigation("MantencionMecanicos");
                });
#pragma warning restore 612, 618
        }
    }
}
