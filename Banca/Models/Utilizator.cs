using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data.Entity; //Pt EntityFramework
using System.ComponentModel.DataAnnotations; //Pentru adnotari

namespace Banca.Models
{
    public class Utilizator
    {
        [Key]
        public int Id { get; set; }

        public string id_cont { get; set; }

        public string nume { get; set; }

        public string prenume { get; set; }

        public string username { get; set; }

        public string parola { get; set; }

        public string email { get; set; }
    }

    public class UtilizatorDbContext : DbContext
    {
        public DbSet <Utilizator> Utilizatori { get; set; }
    }
}