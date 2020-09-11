﻿// <auto-generated />
using KonusarakOgrenWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KonusarakOgrenWebApp.Migrations.ExamDb
{
    [DbContext(typeof(ExamDbContext))]
    partial class ExamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("KonusarakOgrenWebApp.Models.ExamModel", b =>
                {
                    b.Property<int>("SınavId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DogruCevap")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoruAciklama")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoruBaslik")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoruBir")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoruDort")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoruIki")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoruUc")
                        .HasColumnType("TEXT");

                    b.HasKey("SınavId");

                    b.ToTable("ExamModels");
                });
#pragma warning restore 612, 618
        }
    }
}
