namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdressColumnToCompany : DbMigration
    {
        public override void Up()
        {
            //AddColumn("db.Companies", "Adress", p => p.String());
        }
        
        public override void Down()
        {
            //DropColumn("db.Companies", "Adress");
        }
    }
}
