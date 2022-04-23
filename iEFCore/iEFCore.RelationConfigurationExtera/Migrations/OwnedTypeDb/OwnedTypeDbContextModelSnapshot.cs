﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iEFCore.RelationConfigurationExtera.OwnedTypeSample;

#nullable disable

namespace iEFCore.RelationConfigurationExtera.Migrations.OwnedTypeDb
{
    [DbContext(typeof(OwnedTypeDbContext))]
    partial class OwnedTypeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iEFCore.RelationConfigurationExtera.OwnedTypeSample.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Yasser",
                            LastName = "Fereidouni"
                        });
                });

            modelBuilder.Entity("iEFCore.RelationConfigurationExtera.OwnedTypeSample.Person", b =>
                {
                    b.OwnsOne("iEFCore.RelationConfigurationExtera.OwnedTypeSample.Address", "Address", b1 =>
                        {
                            b1.Property<int>("PersonId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PersonId");

                            b1.ToTable("People");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");

                            b1.HasData(
                                new
                                {
                                    PersonId = 1,
                                    City = "Karaj",
                                    Street = "1st Dehghanvilla"
                                });
                        });

                    b.OwnsOne("iEFCore.RelationConfigurationExtera.OwnedTypeSample.Car", "Car", b1 =>
                        {
                            b1.Property<int>("PersonId")
                                .HasColumnType("int");

                            b1.Property<string>("CarName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PersonId");

                            b1.ToTable("Cars", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PersonId");

                            b1.HasData(
                                new
                                {
                                    PersonId = 1,
                                    CarName = "Persia"
                                });
                        });

                    b.OwnsMany("iEFCore.RelationConfigurationExtera.OwnedTypeSample.Money", "Money", b1 =>
                        {
                            b1.Property<int>("PersonId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("PersonId", "Id");

                            b1.ToTable("Money", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PersonId");

                            b1.HasData(
                                new
                                {
                                    PersonId = 1,
                                    Id = 1,
                                    Value = 1000
                                },
                                new
                                {
                                    PersonId = 1,
                                    Id = 2,
                                    Value = 5000
                                });
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Car")
                        .IsRequired();

                    b.Navigation("Money");
                });
#pragma warning restore 612, 618
        }
    }
}
