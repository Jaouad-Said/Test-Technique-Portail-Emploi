using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortailEmploi.Migrations
{
    /// <inheritdoc />
    public partial class Initiali : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidats",
                columns: table => new
                {
                    IDCandidat = table.Column<int>(name: "ID_Candidat", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NEtude = table.Column<string>(name: "N_Etude", type: "nvarchar(max)", nullable: false),
                    NExperience = table.Column<int>(name: "N_Experience", type: "int", nullable: false),
                    DEmployeur = table.Column<string>(name: "D_Employeur", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidats", x => x.IDCandidat);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    IDResume = table.Column<int>(name: "ID_Resume", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVurl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDCandidat = table.Column<int>(name: "ID_Candidat", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.IDResume);
                    table.ForeignKey(
                        name: "FK_Resumes_Candidats_ID_Candidat",
                        column: x => x.IDCandidat,
                        principalTable: "Candidats",
                        principalColumn: "ID_Candidat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_ID_Candidat",
                table: "Resumes",
                column: "ID_Candidat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Candidats");
        }
    }
}
