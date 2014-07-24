namespace Chirpster2.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chirps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cheeps = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chirps");
        }
    }
}
