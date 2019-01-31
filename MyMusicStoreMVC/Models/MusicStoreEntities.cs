using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Data.Sql;

namespace MyMusicStore.Models
{
    public class MusicStoreEntities : DbContext
    {

        public DbSet<Album> Albums { get; set; }

        public DbSet<Genre> Genres { get; set; }

    }
}