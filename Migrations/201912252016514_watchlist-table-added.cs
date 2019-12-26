namespace Movie_Recommendation_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class watchlisttableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Watchlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userId = c.String(),
                        movieId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.movieId)
                .Index(t => t.movieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Watchlists", "movieId", "dbo.Movies");
            DropIndex("dbo.Watchlists", new[] { "movieId" });
            DropTable("dbo.Watchlists");
        }
    }
}
