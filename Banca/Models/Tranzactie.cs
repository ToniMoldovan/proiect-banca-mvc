using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data.Entity; //Pt EntityFramework
using System.ComponentModel.DataAnnotations; //Pentru adnotari

namespace Banca.Models
{
    public class Tranzactie
    {
        [Key]
        public int Id { get; set; }

        public string id_cont_exp { get; set; }

        public string id_cont_dest { get; set; }

        public double suma { get; set; }

        public string moneda { get; set; }

        public string detalii { get; set; }
    }

    public class TranzactieDbContext : DbContext
    {
        public DbSet<Tranzactie> Tranzactii { get; set; }
    }
}
