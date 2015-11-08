namespace Uranus.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Muster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(maxLength: 200),
                        CompanyType = c.String(maxLength: 100, unicode: false),
                        CompanyAddress = c.String(maxLength: 200, unicode: false),
                        EmaildId = c.String(maxLength: 50, unicode: false),
                        ContactNo = c.String(maxLength: 50, unicode: false),
                        BusinessHours = c.String(maxLength: 50, unicode: false),
                        FacebookLink = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 150, unicode: false),
                        Address = c.String(maxLength: 200, unicode: false),
                        EmailId = c.String(nullable: false, maxLength: 50, unicode: false),
                        PhoneNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Message = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(maxLength: 200, unicode: false),
                        EmailId = c.String(maxLength: 50, unicode: false),
                        ContactNo = c.String(maxLength: 50, unicode: false),
                        ImageUrl = c.String(maxLength: 50, unicode: false),
                        Order = c.Int(nullable: false),
                        About = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDemo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Designation = c.String(nullable: false, maxLength: 100, unicode: false),
                        OrganizationName = c.String(nullable: false, maxLength: 100, unicode: false),
                        OrganizationType = c.String(maxLength: 100, unicode: false),
                        NoOfBranch = c.Int(nullable: false),
                        ContactNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        EmailId = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(nullable: false, maxLength: 200, unicode: false),
                        Comments = c.String(maxLength: 300, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 100, unicode: false),
                        ProductDescription = c.String(maxLength: 4000),
                        ImageUrl = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamMember",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150, unicode: false),
                        Designation = c.String(nullable: false, maxLength: 50, unicode: false),
                        About = c.String(nullable: false, maxLength: 300),
                        SocialLink = c.String(maxLength: 50, unicode: false),
                        EmailId = c.String(maxLength: 50, unicode: false),
                        ImageUrl = c.String(maxLength: 50, unicode: false),
                        Active = c.Boolean(nullable: false),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        EmailId = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        Active = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.TeamMember");
            DropTable("dbo.Products");
            DropTable("dbo.OrderDemo");
            DropTable("dbo.Customers");
            DropTable("dbo.ContactUs");
            DropTable("dbo.Company");
        }
    }
}
