using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.IO;
using TestEFSqLiteOnXamarin.Persistance.Entities;

namespace TestEFSqLiteOnXamarin.Persistance
{
    public class DatabaseContext : DbContext
    {
        private readonly string dbPath;

        public DbSet<Person> Persons { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Storage> Storages { get; set; }

        public DatabaseContext()
        {
            dbPath = GetDatabasePath();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedInitialData(modelBuilder);
        }

        private void SeedInitialData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                    new Address()
                    {
                        Id = 2,
                        Street = "Braziliano",
                        No = 9
                    },
                     new Address()
                     {
                         Id = 3,
                         Street = "Senegaliano",
                         No = 10
                     });

            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 2,
                    Name = "Robert Firmino",
                    Age = 23,
                    AddressId = 2
                },
                new Person()
                {
                    Id = 3,
                    Name = "Sadio Mane",
                    Age = 25,
                    AddressId = 3
                });

            modelBuilder.Entity<Car>().HasData(new Car() { Id = 1, Make = "Audi", Model = "RS3" });
            modelBuilder.Entity<Storage>().HasData(new Storage() { Id = 1, Location = "Bulgaria", Size = 1000, AddressId = 2 });
        }

        private string GetDatabasePath()
        {
            var sqlLiteFilename = "XamarinEFSqliteDb.db";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqlLiteFilename);

            return path;
        }
    }
}
