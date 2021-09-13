using System;
using CineMania.Models;
using Microsoft.EntityFrameworkCore;

namespace CineMania.Data
{
    public class CinemaniaContext : DbContext
    {
        

        public CinemaniaContext(DbContextOptions<CinemaniaContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<ContactMe> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             var movies = new Movie[]
            {
                new Movie
                {
                    Id = 1,
                    Title = "Black Widow",
                    Description = "A film about Natasha Romanoff in her quests " +
                                  "between the films Civil War and Infinity War.",
                    ImageName = "black_widow.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2021-07-09")
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Tomorrow War",
                    Description = "A family man is drafted to fight in a future war where " +
                                  "the fate of humanity relies on his ability to confront the past.",
                    ImageName = "the_tomorrow_war.jpg",
                    Genre = "Sci-Fi",
                    ReleaseDate = DateTime.Parse("2021-07-02")
                },
                new Movie
                {
                    Id = 3,
                    Title = "Pitch Perfect",
                    Description = "Beca, a freshman at Barden University, is cajoled into joining The Bellas, " +
                                  "her school's all-girls singing group. Injecting some much needed energy into " +
                                  "their repertoire, The Bellas take on their male rivals in a campus competition",
                    ImageName = "black_widow.jpg",
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2013-09-24")
                },
                new Movie
                {
                    Id = 4,
                    Title = "The Hills Have Eyes",
                    Description = "A family falls victim to a group of mutated cannibals " +
                                  "in a desert far away from civilization.",
                    ImageName = "hills_have_eyes.jpg",
                    Genre = "Horror",
                    ReleaseDate = DateTime.Parse("2006-11-11")
                },
                new Movie
                {
                    Id = 5,
                    Title = "Up",
                    Description = "78-year-old Carl Fredricksen travels to Paradise Falls in his house " +
                                  "equipped with balloons, inadvertently taking a young stowaway",
                    ImageName = "up.jpg",
                    Genre = "Animation",
                    ReleaseDate = DateTime.Parse("2009-03-01")
                },
                new Movie
                {
                    Id = 6,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of " +
                                  "diner bandits intertwine in four tales of violence and redemption.",
                    ImageName = "pulp_fiction.jpg",
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("1994-12-05")
                },
                new Movie
                {
                    Id = 7,
                    Title = "Rocky",
                    Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion " +
                                  "in a bout in which he strives to go the distance for his self-respect.",
                    ImageName = "rocky.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                
                //that are the new records
                new Movie
                {
                    Id = 8,
                    Title = "black panther",
                    Description = "After his father's death, T'Challa returns home to Wakanda to inherit his throne." +
                                  " However, a powerful enemy related to his family threatens to attack his nation.",
                    ImageName = "images.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2017-08-05")
                },
                new Movie
                {
                    Id = 9,
                    Title = "Everything",
                    Description = "Everything, Everything” tells the unlikely love story of Maddy, a smart,  curious and imaginative 18-year-old who" +
                                  " due to an illness cannot leave the protection  of the hermetically sealed environment within her house,  " +
                                  "and Olly, the boy next door who won't let that stop them.",
                    ImageName = "everything.jpg",
                    Genre = "Romantic",
                    ReleaseDate = DateTime.Parse("2017-08-05")
                },
                new Movie
                {
                    Id = 10,
                    Title = "Fast and furious 9",
                    Description = "F9 (also known as F9: The Fast Saga and Fast & Furious 9) is a 2021 American action  film directed by Justin " +
                                  "Lin from a screenplay by Daniel Casey and Lin. ... In F9, Dominic Toretto and the team come together " +
                                  " to stop a world-shattering plot headed by Toretto's brother, Jakob.",
                    ImageName = "f9.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2021-08-03")
                },
                new Movie
                {
                    Id = 11,
                    Title = "No Time To Die",
                    Description = "In No Time To Die, Bond has left active service and is enjoying a tranquil life " +
                                  "in Jamaica. His peace is short-lived when his old friend Felix Leiter from the CIA turns up asking for help.",
                    ImageName = "no.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("2020-04-01")
                },
                new Movie
                {
                    Id = 12,
                    Title = "Sonic",
                    Description = "It is the first installment in a planned Sonic the Hedgehog film series. " +
                                  " The film follows Sonic the Hedgehog (voiced by Schwartz), who runs supersonic " +
                                  "speeds,  as he teams up with local town sheriff Tom Wachowski  (Marsden) to find his lost rings and escape" +
                                  " the mad scientist Dr. Robotnik (Carrey)",
                    ImageName = "sonic.jpg",
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2020-04-01")
                },
                new Movie
                {
                    Id = 13,
                    Title = "Frozen",
                    Description = "The film depicts a princess who sets off on a journey alongside an iceman, his reindeer," +
                                  "  and a snowman to find her estranged sister,  whose icy powers have inadvertently trapped " +
                                  "their kingdom in eternal winter.",
                    ImageName = "frozen.jpeg",
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2019-12-01")
                },
                new Movie
                {
                    Id = 14,
                    Title = "The invisible Man",
                    Description = "The narrator of Invisible Man is a nameless young black man who moves in a 20th-century  United States where" +
                                  " reality is surreal and who can survive only through pretense.  Because the people he encounters ", 
                    ImageName = "invi.jpg",
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2018-03-12")
                },
                
                new Movie
                {
                    Id = 15,
                    Title = "Rampage",
                    Description = " a course of violent, riotous, or reckless action or behavior.  Other Words from rampage Synonyms Example Sentences Learn More About rampage.",
                    ImageName = "Ram.jpg",
                    Genre = "Sci-FI",
                    ReleaseDate = DateTime.Parse("2018-03-12")
                },
                new Movie
                {
                    Id = 16,
                    Title = "Life In Year",
                    Description = " The movie follows 17-year-old Daryn who finds out that his girlfriend is dying. He sets out to give her an entire life in the last year she has left.",
                    ImageName = "life.jpg",
                    Genre = "Romantic",
                    ReleaseDate = DateTime.Parse("2010-04-07")
                },
                new Movie
                {
                    Id = 17,
                    Title = "Joker",
                    Description = " The Joker, initially portrayed as a small-time crook, was disfigured and driven insane by an accident with toxic chemicals. He was depicted with chalk-white skin, ruby-red lips permanently fixed in a demonic grin, and bright green hair.",
                    ImageName = "joker.jpg",
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("2019-03-29")
                },

                new Movie
                {
                    Id = 18,
                    Title = "Prison break",
                    Description = "An engineer installs himself in a prison he helped design, in order to save his falsely accused brother from a death sentence.",
                    ImageName = "priso.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2009-05-29")
                }

            };
          
            modelBuilder.Entity<Movie>().HasData(movies);
            base.OnModelCreating(modelBuilder);
        }
    }
}