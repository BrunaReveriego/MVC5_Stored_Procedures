using SProcedure_EF6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SProcedure_EF6.Data
{
    public class SProcedure_EF6Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public SProcedure_EF6Context() : base("name=SProcedure_EF6Context")
        {
        }

        public DbSet<Medico> Medicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>().MapToStoredProcedures();

            //renomear SP no insert

            modelBuilder.Entity<Medico>().MapToStoredProcedures(
                x => x.Insert(i => i.HasName("AdicionarMedico")));

        }







    }
}
