namespace WeekendTaskLanguage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "DataTime", c => c.String());
            AddColumn("dbo.Portfolios", "Image", c => c.String());
            AddColumn("dbo.SecondBlogs", "DataTime", c => c.String());
            AlterColumn("dbo.Abilities", "Number", c => c.String());
            DropColumn("dbo.Blogs", "DateTime");
            DropColumn("dbo.SecondBlogs", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SecondBlogs", "DateTime", c => c.String());
            AddColumn("dbo.Blogs", "DateTime", c => c.String());
            AlterColumn("dbo.Abilities", "Number", c => c.Int(nullable: false));
            DropColumn("dbo.SecondBlogs", "DataTime");
            DropColumn("dbo.Portfolios", "Image");
            DropColumn("dbo.Blogs", "DataTime");
        }
    }
}
