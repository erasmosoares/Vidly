namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, NumberInStock, GenreId, ReleaseDate) VALUES (1, 'Hangover',14/02/2018,10,5,14/02/2018)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, NumberInStock, GenreId, ReleaseDate) VALUES (2, 'Die Hard',14/02/2018,10,1,14/02/2018)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, NumberInStock, GenreId, ReleaseDate) VALUES (3, 'The Terminator',14/02/2018,10,1,14/02/2018)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, NumberInStock, GenreId, ReleaseDate) VALUES (4, 'Toy Story',14/02/2018,10,3,14/02/2018)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, NumberInStock, GenreId, ReleaseDate) VALUES (5, 'Titanic',14/02/2018,10,4,14/02/2018)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
