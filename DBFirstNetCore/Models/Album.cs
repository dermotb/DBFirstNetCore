using System;
using System.ComponentModel.DataAnnotations;

namespace DBFirstNetCore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public String Title { get; set; }
        public String Artist { get; set; }
    }
}
