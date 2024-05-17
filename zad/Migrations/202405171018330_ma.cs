namespace zad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ma : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Doctors", "HospitalName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "HospitalName", c => c.String());
        }
    }
}
