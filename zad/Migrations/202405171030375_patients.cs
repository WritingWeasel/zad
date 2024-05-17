namespace zad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patients : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Doctor_ID", c => c.Int());
            CreateIndex("dbo.Patients", "Doctor_ID");
            AddForeignKey("dbo.Patients", "Doctor_ID", "dbo.Doctors", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "Doctor_ID", "dbo.Doctors");
            DropIndex("dbo.Patients", new[] { "Doctor_ID" });
            DropColumn("dbo.Patients", "Doctor_ID");
        }
    }
}
