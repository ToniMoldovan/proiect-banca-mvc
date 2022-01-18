using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data.Entity; //Pt EntityFramework
using System.ComponentModel.DataAnnotations; //Pentru adnotari

namespace Banca.Models
{
    public class ContBancar
    {
        [Key]
        public int Id { get; set; }

        public string id_pers { get; set; }

        public string iban { get; set; }

        public int pin { get; set; }

        public double suma { get; set; }

        public string moneda { get; set; }
    }

    public class ContBancarDbContext : DbContext
    {
        public DbSet<ContBancar> ConturiBancare { get; set; }
    }
}