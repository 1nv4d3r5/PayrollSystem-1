namespace PayrollSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HolidayLists",
                c => new
                    {
                        HolidayListID = c.Int(nullable: false, identity: true),
                        HolidayDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.HolidayListID);
            
            CreateTable(
                "dbo.Allowances",
                c => new
                    {
                        AllowanceID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.AllowanceID);
            
            AddColumn("dbo.Employees", "NoDependnt", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "NoDependnt");
            DropTable("dbo.Allowances");
            DropTable("dbo.HolidayLists");
        }
    }
}
