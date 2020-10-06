namespace SProcedure_EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renomearSPInsert : DbMigration
    {
        public override void Up()
        {
            RenameStoredProcedure(name: "dbo.Medico_Insert", newName: "AdicionarMedico");
        }
        
        public override void Down()
        {
            RenameStoredProcedure(name: "dbo.AdicionarMedico", newName: "Medico_Insert");
        }
    }
}
