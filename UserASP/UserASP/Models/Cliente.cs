using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UserASP.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public DateTime fechaAlta { get; set; }
        public int edad { get; set; }

    }

    public class EmpDbContext : DbContext
    {
        public EmpDbContext() { }

        public DbSet<Cliente> clientes { get; set; }
    }
}