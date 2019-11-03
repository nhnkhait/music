namespace MusicViet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class music2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Song", "PathMusic", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Song", "PathMusic", c => c.String());
        }
    }
}
