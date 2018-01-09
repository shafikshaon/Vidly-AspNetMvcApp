namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameToMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (GenreId, Name) VALUES (5, 'Hangover')");
            Sql("INSERT INTO Movies (GenreId, Name) VALUES (1, 'Die Hard')");
            Sql("INSERT INTO Movies (GenreId, Name) VALUES (1, 'The Terminator')");
            Sql("INSERT INTO Movies (GenreId, Name) VALUES (3, 'Troy Story')");
            Sql("INSERT INTO Movies (GenreId, Name) VALUES (4, 'Titanic')");
        }
        
        public override void Down()
        {
        }
    }
}
