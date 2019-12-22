using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace UserASP.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        
        [StringLength (60,MinimumLength = 3)]
        public string nombre { get; set; }

        [Display (Name = "Fecha de Alta")]
        [DataType (DataType.Date)]
        [DisplayFormat (DataFormatString = "{0:YYYY-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime fechaAlta { get; set; }

        [Range (18,75)]
        public int edad { get; set; }

    }

    public class EmpDbContext : DbContext
    {
        public EmpDbContext() { }

        public DbSet<Cliente> clientes { get; set; }
    }
}