namespace Pidev.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.rapports", "libelle", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.rapports", "libelle");
        }
    }
}
