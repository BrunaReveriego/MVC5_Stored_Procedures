namespace SProcedure_EF6.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SProcedure_EF6.Data.SProcedure_EF6Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SProcedure_EF6.Data.SProcedure_EF6Context";
        }

        protected override void Seed(SProcedure_EF6.Data.SProcedure_EF6Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
