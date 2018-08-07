﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestEFSqLiteOnXamarin.Persistance;

namespace TestEFSqLiteOnXamarin.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("TestEFSqLiteOnXamarin.Persistance.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("No");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Address");

                    b.HasData(
                        new { Id = 2, No = 9, Street = "Braziliano" },
                        new { Id = 3, No = 10, Street = "Senegaliano" }
                    );
                });

            modelBuilder.Entity("TestEFSqLiteOnXamarin.Persistance.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new { Id = 1, Make = "Audi", Model = "RS3" }
                    );
                });

            modelBuilder.Entity("TestEFSqLiteOnXamarin.Persistance.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<uint>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Persons");

                    b.HasData(
                        new { Id = 2, AddressId = 2, Age = 23u, Name = "Robert Firmino" },
                        new { Id = 3, AddressId = 3, Age = 25u, Name = "Sadio Mane" }
                    );
                });

            modelBuilder.Entity("TestEFSqLiteOnXamarin.Persistance.Entities.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("Location");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Storages");

                    b.HasData(
                        new { Id = 1, AddressId = 2, Location = "Bulgaria", Size = 1000 }
                    );
                });

            modelBuilder.Entity("TestEFSqLiteOnXamarin.Persistance.Entities.Person", b =>
                {
                    b.HasOne("TestEFSqLiteOnXamarin.Persistance.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestEFSqLiteOnXamarin.Persistance.Entities.Storage", b =>
                {
                    b.HasOne("TestEFSqLiteOnXamarin.Persistance.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}