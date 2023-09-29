using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEfTools.Migrations
{
    /// <inheritdoc />
    public partial class createTableEditoriales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "TEXT", nullable: true),
                    SitioWeb = table.Column<string>(type: "TEXT", nullable: true),
                    Docimilio = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Editoriales");
        }
    }
}
