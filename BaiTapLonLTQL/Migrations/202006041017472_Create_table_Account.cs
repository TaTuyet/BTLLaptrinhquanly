namespace BaiTapLonLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
