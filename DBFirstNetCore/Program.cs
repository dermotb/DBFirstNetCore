using DBFirstNetCore.Models;

using System;

namespace EFCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album1 = new Album() {Title = "Hanx", Artist = "SLF" };
            Album album2 = new Album() {Title = "Rattlesnakes", Artist = "Lloyd Cole" };
            Album album3 = new Album() {Title = "OK Computer", Artist = "Radiohead" };


            AlbumContext ctx = new AlbumContext();
            ctx.Database.EnsureCreated();

            ctx.Albums.Add(album1);
            ctx.Albums.Add(album2);
            ctx.Albums.Add(album3);
            ctx.SaveChanges();

        }
    }
}

