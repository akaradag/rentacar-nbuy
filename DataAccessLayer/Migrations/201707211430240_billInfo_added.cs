namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class billInfo_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillInfo",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        Country = c.String(),
                        Address = c.String(),
                        CompanyName = c.String(maxLength: 30),
                        TaxOffice = c.String(maxLength: 30),
                        TaxNo = c.Int(),
                        isPersonelBill = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bill", t => t.ID)
                .Index(t => t.ID);
            
            AddColumn("dbo.Customer", "SocialNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BillInfo", "ID", "dbo.Bill");
            DropIndex("dbo.BillInfo", new[] { "ID" });
            DropColumn("dbo.Customer", "SocialNumber");
            DropTable("dbo.BillInfo");
        }
    }
}
