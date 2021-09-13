﻿// <auto-generated />
using System;
using CineMania.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CineMania.Migrations
{
    [DbContext(typeof(CinemaniaContext))]
    [Migration("20210910142829_add10")]
    partial class add10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CineMania.Models.ContactMe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CineMania.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.",
                            Genre = "Action",
                            ImageName = "black_widow.jpg",
                            ReleaseDate = new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Black Widow"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.",
                            Genre = "Sci-Fi",
                            ImageName = "the_tomorrow_war.jpg",
                            ReleaseDate = new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Tomorrow War"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition",
                            Genre = "Comedy",
                            ImageName = "black_widow.jpg",
                            ReleaseDate = new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pitch Perfect"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A family falls victim to a group of mutated cannibals in a desert far away from civilization.",
                            Genre = "Horror",
                            ImageName = "hills_have_eyes.jpg",
                            ReleaseDate = new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hills Have Eyes"
                        },
                        new
                        {
                            Id = 5,
                            Description = "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway",
                            Genre = "Animation",
                            ImageName = "up.jpg",
                            ReleaseDate = new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Up"
                        },
                        new
                        {
                            Id = 6,
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Genre = "Crime",
                            ImageName = "pulp_fiction.jpg",
                            ReleaseDate = new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                            Genre = "Drama",
                            ImageName = "rocky.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rocky"
                        },
                        new
                        {
                            Id = 8,
                            Description = "After his father's death, T'Challa returns home to Wakanda to inherit his throne. However, a powerful enemy related to his family threatens to attack his nation.",
                            Genre = "Action",
                            ImageName = "images.jpg",
                            ReleaseDate = new DateTime(2017, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "black panther"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Everything, Everything” tells the unlikely love story of Maddy, a smart,  curious and imaginative 18-year-old who due to an illness cannot leave the protection  of the hermetically sealed environment within her house,  and Olly, the boy next door who won't let that stop them.",
                            Genre = "Romantic",
                            ImageName = "everything.jpg",
                            ReleaseDate = new DateTime(2017, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Everything"
                        },
                        new
                        {
                            Id = 10,
                            Description = "F9 (also known as F9: The Fast Saga and Fast & Furious 9) is a 2021 American action  film directed by Justin Lin from a screenplay by Daniel Casey and Lin. ... In F9, Dominic Toretto and the team come together  to stop a world-shattering plot headed by Toretto's brother, Jakob.",
                            Genre = "Action",
                            ImageName = "f9.jpg",
                            ReleaseDate = new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Fast and furious 9"
                        },
                        new
                        {
                            Id = 11,
                            Description = "In No Time To Die, Bond has left active service and is enjoying a tranquil life in Jamaica. His peace is short-lived when his old friend Felix Leiter from the CIA turns up asking for help.",
                            Genre = "Drama",
                            ImageName = "no.jpg",
                            ReleaseDate = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "No Time To Die"
                        },
                        new
                        {
                            Id = 12,
                            Description = "It is the first installment in a planned Sonic the Hedgehog film series.  The film follows Sonic the Hedgehog (voiced by Schwartz), who runs supersonic speeds,  as he teams up with local town sheriff Tom Wachowski  (Marsden) to find his lost rings and escape the mad scientist Dr. Robotnik (Carrey)",
                            Genre = "Comedy",
                            ImageName = "sonic.jpg",
                            ReleaseDate = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sonic"
                        },
                        new
                        {
                            Id = 13,
                            Description = "The film depicts a princess who sets off on a journey alongside an iceman, his reindeer,  and a snowman to find her estranged sister,  whose icy powers have inadvertently trapped their kingdom in eternal winter.",
                            Genre = "Comedy",
                            ImageName = "frozen.jpeg",
                            ReleaseDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Frozen"
                        },
                        new
                        {
                            Id = 14,
                            Description = "The narrator of Invisible Man is a nameless young black man who moves in a 20th-century  United States where reality is surreal and who can survive only through pretense.  Because the people he encounters ",
                            Genre = "Comedy",
                            ImageName = "invi.jpg",
                            ReleaseDate = new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The invisible Man"
                        },
                        new
                        {
                            Id = 15,
                            Description = " a course of violent, riotous, or reckless action or behavior.  Other Words from rampage Synonyms Example Sentences Learn More About rampage.",
                            Genre = "Sci-FI",
                            ImageName = "Ram.jpg",
                            ReleaseDate = new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rampage"
                        },
                        new
                        {
                            Id = 16,
                            Description = " The movie follows 17-year-old Daryn who finds out that his girlfriend is dying. He sets out to give her an entire life in the last year she has left.",
                            Genre = "Romantic",
                            ImageName = "life.jpg",
                            ReleaseDate = new DateTime(2010, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Life In Year"
                        },
                        new
                        {
                            Id = 17,
                            Description = " The Joker, initially portrayed as a small-time crook, was disfigured and driven insane by an accident with toxic chemicals. He was depicted with chalk-white skin, ruby-red lips permanently fixed in a demonic grin, and bright green hair.",
                            Genre = "Crime",
                            ImageName = "joker.jpg",
                            ReleaseDate = new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Joker"
                        },
                        new
                        {
                            Id = 18,
                            Description = "An engineer installs himself in a prison he helped design, in order to save his falsely accused brother from a death sentence.",
                            Genre = "Action",
                            ImageName = "priso.jpg",
                            ReleaseDate = new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Prison break"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}