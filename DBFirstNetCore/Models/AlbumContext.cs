using Microsoft.EntityFrameworkCore;

namespace DBFirstNetCore.Models
{
    class AlbumContext : DbContext
    {
        //private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=False;";
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCorey; AttachDbFileName=c:\\temp\\EFCore;Trusted_Connection=False;";
        //private const string connectionString = @"Server=(localdb)\\mssqllocaldb;Integrated Security = true; AttachDbFileName= C:\temp\MyData.mdf;";
        //Server=(localdb)\v11.0;Integrated Security = true; AttachDbFileName=C:\MyFolder\MyData.mdf;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
        public DbSet<Album> Albums { get; set; }
    }
}
