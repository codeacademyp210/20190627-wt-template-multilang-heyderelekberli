namespace WeekendTaskLanguage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AboutSpecs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title1 = c.String(),
                        Title2 = c.String(),
                        Name = c.String(),
                        DateTime = c.String(),
                        News = c.String(),
                        Text = c.String(),
                        Reading = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HomeImages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Portfolios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SecondBlogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Name = c.String(),
                        DateTime = c.String(),
                        News = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Email = c.String(),
                        Feature = c.String(),
                        Hire = c.String(),
                        AbautUsText = c.String(),
                        AboutUs = c.String(),
                        Services = c.String(),
                        Testimonials = c.String(),
                        ContactUS = c.String(),
                        FacebookIcon = c.String(),
                        TwitterIcon = c.String(),
                        InstagramIcon = c.String(),
                        LinkedinIcon = c.String(),
                        ContactAddress = c.String(),
                        ContactPhone = c.String(),
                        ContactEmail = c.String(),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Name = c.String(),
                        Position = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Image = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
            DropTable("dbo.Teams");
            DropTable("dbo.Specialities");
            DropTable("dbo.Settings");
            DropTable("dbo.Services");
            DropTable("dbo.SecondBlogs");
            DropTable("dbo.Posts");
            DropTable("dbo.Positions");
            DropTable("dbo.Portfolios");
            DropTable("dbo.HomeImages");
            DropTable("dbo.Comments");
            DropTable("dbo.Blogs");
            DropTable("dbo.AboutSpecs");
            DropTable("dbo.Abilities");
        }
    }
}
