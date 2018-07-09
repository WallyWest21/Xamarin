using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ef_repo_sqlite_NET
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        private static bool created = false;
        private string DatabasePath { get; set; }

        public TaskContext(string databasePath)
        {
            DatabasePath = databasePath;
            if (!created)
            {
                created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();

            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //var dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            //var fileName = "Cats.db";
            //var dbFullPath = Path.Combine(dbFolder, fileName);
            //DatabasePath = dbFullPath;
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }

    public class TaskContext2 : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        private string DatabasePath { get; set; }

        //public TaskContext2(string databasePath)
        //{
        //    DatabasePath = databasePath;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var fileName = "Cats.db";
            var dbFullPath = Path.Combine(dbFolder, fileName);
            DatabasePath = dbFullPath;
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }

}

