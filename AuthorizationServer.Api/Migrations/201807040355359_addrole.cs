namespace AuthorizationServer.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RoleId", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Active", c => c.Boolean(nullable: false));
            CreateIndex("dbo.AspNetUsers", "RoleId");
            AddForeignKey("dbo.AspNetUsers", "RoleId", "dbo.AspNetRoles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUsers", new[] { "RoleId" });
            DropColumn("dbo.AspNetUsers", "Active");
            DropColumn("dbo.AspNetUsers", "RoleId");
        }
    }
}
