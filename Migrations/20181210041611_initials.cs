using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Project.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Particpant",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumb = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CoName = table.Column<string>(nullable: true),
                    Mjr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Particpant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjName = table.Column<string>(nullable: true),
                    ProjDescript = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjInfo",
                columns: table => new
                {
                    ParticipantID = table.Column<string>(nullable: false),
                    ProjID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjInfo", x => new { x.ProjID, x.ParticipantID });
                    table.ForeignKey(
                        name: "FK_ProjInfo_Particpant_ParticipantID",
                        column: x => x.ParticipantID,
                        principalTable: "Particpant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjInfo_Project_ProjID",
                        column: x => x.ProjID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjInfo_ParticipantID",
                table: "ProjInfo",
                column: "ParticipantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjInfo");

            migrationBuilder.DropTable(
                name: "Particpant");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
