namespace SProcedure_EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criaSPs : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Medico_Insert",
                p => new
                    {
                        nome = p.String(),
                        celular = p.String(),
                        especialidade = p.String(),
                        rating = p.Int(),
                        preco = p.Decimal(precision: 18, scale: 2),
                    },
                body:
                    @"INSERT [dbo].[Medicos]([nome], [celular], [especialidade], [rating], [preco])
                      VALUES (@nome, @celular, @especialidade, @rating, @preco)
                      
                      DECLARE @medicoID int
                      SELECT @medicoID = [medicoID]
                      FROM [dbo].[Medicos]
                      WHERE @@ROWCOUNT > 0 AND [medicoID] = scope_identity()
                      
                      SELECT t0.[medicoID]
                      FROM [dbo].[Medicos] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[medicoID] = @medicoID"
            );
            
            CreateStoredProcedure(
                "dbo.Medico_Update",
                p => new
                    {
                        medicoID = p.Int(),
                        nome = p.String(),
                        celular = p.String(),
                        especialidade = p.String(),
                        rating = p.Int(),
                        preco = p.Decimal(precision: 18, scale: 2),
                    },
                body:
                    @"UPDATE [dbo].[Medicos]
                      SET [nome] = @nome, [celular] = @celular, [especialidade] = @especialidade, [rating] = @rating, [preco] = @preco
                      WHERE ([medicoID] = @medicoID)"
            );
            
            CreateStoredProcedure(
                "dbo.Medico_Delete",
                p => new
                    {
                        medicoID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Medicos]
                      WHERE ([medicoID] = @medicoID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Medico_Delete");
            DropStoredProcedure("dbo.Medico_Update");
            DropStoredProcedure("dbo.Medico_Insert");
        }
    }
}
