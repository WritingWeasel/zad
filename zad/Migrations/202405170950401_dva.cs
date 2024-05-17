namespace zad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "HospitalName", c => c.String());
            AddColumn("dbo.Hospitals", "Doctor_ID", c => c.Int());
            CreateIndex("dbo.Hospitals", "Doctor_ID");
            AddForeignKey("dbo.Hospitals", "Doctor_ID", "dbo.Doctors", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hospitals", "Doctor_ID", "dbo.Doctors");
            DropIndex("dbo.Hospitals", new[] { "Doctor_ID" });
            DropColumn("dbo.Hospitals", "Doctor_ID");
            DropColumn("dbo.Doctors", "HospitalName");
        }
    }
}
