namespace Pidev.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.depenses", "Justificatif", c => c.String(unicode: false));
            DropColumn("dbo.depenses", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.depenses", "ImageUrl", c => c.String(unicode: false));
            DropColumn("dbo.depenses", "Justificatif");
        }
    }
}
