namespace MvcMusicStore.Infrastructure.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1Migration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Albums", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Albums", new[] { "Genre_Id" });
            RenameColumn(table: "dbo.Albums", name: "Genre_Id", newName: "GenreId");
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Genres", "Description", c => c.String());
            AddColumn("dbo.Albums", "AlbumId", c => c.Int(nullable: false));
            AddColumn("dbo.Albums", "ArtistId", c => c.Int(nullable: false));
            AddColumn("dbo.Albums", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Albums", "AlbumArtUrl", c => c.String());
            AlterColumn("dbo.Albums", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Albums", "GenreId");
            CreateIndex("dbo.Albums", "ArtistId");
            AddForeignKey("dbo.Albums", "ArtistId", "dbo.Artists", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Albums", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            DropIndex("dbo.Albums", new[] { "GenreId" });
            AlterColumn("dbo.Albums", "GenreId", c => c.Int());
            DropColumn("dbo.Albums", "AlbumArtUrl");
            DropColumn("dbo.Albums", "Price");
            DropColumn("dbo.Albums", "ArtistId");
            DropColumn("dbo.Albums", "AlbumId");
            DropColumn("dbo.Genres", "Description");
            DropTable("dbo.Artists");
            RenameColumn(table: "dbo.Albums", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Albums", "Genre_Id");
            AddForeignKey("dbo.Albums", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
