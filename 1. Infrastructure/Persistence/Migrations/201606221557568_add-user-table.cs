namespace LogiGear.Infrastructure.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
