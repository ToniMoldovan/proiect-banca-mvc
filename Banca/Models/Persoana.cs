using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data.Entity; //Pt EntityFramework
using System.ComponentModel.DataAnnotations; //Pentru adnotari

namespace Banca.Models
{
    public class Persoana
    {
        [Key]
        public int Id { get; set; }


    }
}
