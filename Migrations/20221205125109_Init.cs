using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JediNotes.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JediNotes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JediRank = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JediNotes", x => x.ID);
                });
            migrationBuilder.Sql(@"INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('To Do List', 'Things must I do hmm.', GETDATE(), GETDATE(), 'Yoda', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Well Hello There', 'I have the high ground.', GETDATE(), GETDATE(), 'Obi Wan Kenobi', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Order 66', 'Execute Order 66', GETDATE(), GETDATE(), 'Anakin Skywalker', 'Padawan')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('What was I doing again', 'I forgot...', GETDATE(), GETDATE(), 'Mace Windu', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('How to become a Master', '1. Build lightsaber', GETDATE(), GETDATE(), 'Bardan Dahn', 'Knight')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('How to build a lightsaber', '1. Find crystal', GETDATE(), GETDATE(), 'Icarus Aldan', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Where did Alderaan go?', 'It was there a moment ago.', GETDATE(), GETDATE(), 'Tenal Ran', 'Padawan')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Top 10 Reasons to go to Alderaan', 'Princess Leia', GETDATE(), GETDATE(), 'Obi Wan Kenobi', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Where did I leave my robe?', 'Seriously, I am so forgetful', GETDATE(), GETDATE(), 'Rylekar Hurgreg', 'Knight')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('My Shopping List', 'Colo Claw Fish', GETDATE(), GETDATE(), 'Rylimer Lerfee', 'Master')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JediNotes");
        }
    }
}
