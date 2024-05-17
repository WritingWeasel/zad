namespace zad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "HospitalName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "HospitalName");
        }
    }
}
