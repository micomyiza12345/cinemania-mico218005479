using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class add10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate" },
                values: new object[] { " a course of violent, riotous, or reckless action or behavior.  Other Words from rampage Synonyms Example Sentences Learn More About rampage.", "Sci-FI", "Ram.jpg", new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 8, "After his father's death, T'Challa returns home to Wakanda to inherit his throne. However, a powerful enemy related to his family threatens to attack his nation.", "Action", "images.jpg", new DateTime(2017, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "black panther" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 9, "Everything, Everything” tells the unlikely love story of Maddy, a smart,  curious and imaginative 18-year-old who due to an illness cannot leave the protection  of the hermetically sealed environment within her house,  and Olly, the boy next door who won't let that stop them.", "Romantic", "everything.jpg", new DateTime(2017, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everything" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 10, "F9 (also known as F9: The Fast Saga and Fast & Furious 9) is a 2021 American action  film directed by Justin Lin from a screenplay by Daniel Casey and Lin. ... In F9, Dominic Toretto and the team come together  to stop a world-shattering plot headed by Toretto's brother, Jakob.", "Action", "f9.jpg", new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and furious 9" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 11, "In No Time To Die, Bond has left active service and is enjoying a tranquil life in Jamaica. His peace is short-lived when his old friend Felix Leiter from the CIA turns up asking for help.", "Drama", "no.jpg", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Time To Die" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 12, "It is the first installment in a planned Sonic the Hedgehog film series.  The film follows Sonic the Hedgehog (voiced by Schwartz), who runs supersonic speeds,  as he teams up with local town sheriff Tom Wachowski  (Marsden) to find his lost rings and escape the mad scientist Dr. Robotnik (Carrey)", "Comedy", "sonic.jpg", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sonic" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 13, "The film depicts a princess who sets off on a journey alongside an iceman, his reindeer,  and a snowman to find her estranged sister,  whose icy powers have inadvertently trapped their kingdom in eternal winter.", "Comedy", "frozen.jpeg", new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frozen" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 14, "The narrator of Invisible Man is a nameless young black man who moves in a 20th-century  United States where reality is surreal and who can survive only through pretense.  Because the people he encounters ", "Comedy", "invi.jpg", new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The invisible Man" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 16, " The movie follows 17-year-old Daryn who finds out that his girlfriend is dying. He sets out to give her an entire life in the last year she has left.", "Romantic", "life.jpg", new DateTime(2010, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Life In Year" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 17, " The Joker, initially portrayed as a small-time crook, was disfigured and driven insane by an accident with toxic chemicals. He was depicted with chalk-white skin, ruby-red lips permanently fixed in a demonic grin, and bright green hair.", "Crime", "joker.jpg", new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 18, "An engineer installs himself in a prison he helped design, in order to save his falsely accused brother from a death sentence.", "Action", "priso.jpg", new DateTime(2009, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prison break" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate" },
                values: new object[] { " a course of violent, riotous, or reckless action or behavior. Other Words from rampage Synonyms Example Sentences Learn More About rampage.", "sci-fi", "ram.jpg", new DateTime(2017, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
