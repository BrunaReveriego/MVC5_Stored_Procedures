namespace SProcedure_EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        medicoID = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        celular = c.String(),
                        especialidade = c.String(),
                        rating = c.Int(nullable: false),
                        preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.medicoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicos");
        }
    }
}
