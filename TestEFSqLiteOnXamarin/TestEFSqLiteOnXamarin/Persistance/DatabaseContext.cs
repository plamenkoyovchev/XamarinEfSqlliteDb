using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using TestEFSqLiteOnXamarin.Persistance.Entities;

namespace TestEFSqLiteOnXamarin.Persistance
{
    public class DatabaseContext : DbContext
    {
        private readonly string dbPath;

        public DbSet<Person> Persons { get; set; }

        public DatabaseContext()
        {
            dbPath = GetDatabasePath();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
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
