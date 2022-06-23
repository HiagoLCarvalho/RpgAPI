using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoDisputas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Disputas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDisputa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtacanteId = table.Column<int>(type: "int", nullable: false),
                    OponenteId = table.Column<int>(type: "int", nullable: false),
                    Narracao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disputas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 41, 218, 156, 56, 170, 119, 147, 236, 76, 99, 210, 88, 44, 237, 142, 149, 72, 129, 240, 200, 207, 153, 234, 147, 183, 220, 2, 249, 4, 4, 87, 220, 174, 51, 58, 247, 145, 216, 39, 92, 248, 84, 108, 16, 184, 235, 86, 94, 17, 160, 174, 212, 171, 1, 93, 132, 113, 110, 243, 61, 165, 115, 50, 63 }, new byte[] { 196, 202, 14, 163, 233, 86, 48, 165, 67, 148, 11, 246, 232, 140, 148, 22, 130, 175, 234, 218, 139, 14, 1, 40, 31, 65, 218, 139, 102, 35, 182, 143, 9, 125, 66, 127, 238, 228, 64, 117, 194, 41, 73, 51, 166, 250, 196, 154, 20, 94, 214, 248, 177, 77, 241, 217, 119, 189, 10, 60, 228, 223, 115, 64, 251, 35, 156, 234, 92, 48, 158, 57, 112, 76, 174, 143, 224, 2, 24, 51, 86, 124, 83, 21, 111, 17, 100, 7, 197, 153, 112, 197, 2, 51, 208, 135, 65, 249, 52, 100, 137, 147, 48, 182, 249, 69, 116, 192, 193, 11, 10, 134, 204, 209, 113, 65, 51, 164, 187, 77, 219, 165, 44, 131, 167, 76, 144, 100 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disputas");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 102, 178, 89, 231, 81, 66, 229, 216, 115, 154, 140, 13, 151, 174, 239, 29, 53, 58, 17, 118, 112, 238, 126, 121, 245, 114, 242, 25, 237, 115, 181, 135, 242, 174, 187, 50, 153, 205, 146, 2, 254, 37, 73, 57, 127, 124, 20, 186, 55, 36, 189, 113, 126, 147, 163, 115, 89, 251, 64, 46, 68, 222, 38, 66 }, new byte[] { 122, 140, 42, 174, 223, 161, 84, 162, 209, 107, 46, 190, 219, 177, 253, 97, 204, 126, 164, 23, 52, 101, 58, 104, 2, 246, 195, 25, 203, 253, 90, 40, 21, 3, 22, 133, 103, 17, 44, 215, 207, 32, 79, 209, 154, 104, 64, 201, 68, 16, 143, 173, 76, 38, 112, 107, 27, 219, 111, 190, 153, 44, 8, 111, 89, 232, 95, 159, 79, 205, 211, 137, 191, 132, 167, 89, 175, 31, 232, 143, 228, 69, 50, 179, 23, 252, 87, 142, 98, 183, 184, 50, 106, 19, 74, 116, 144, 230, 179, 90, 153, 211, 247, 116, 91, 191, 81, 207, 67, 187, 31, 111, 217, 44, 185, 153, 135, 83, 241, 144, 237, 82, 245, 187, 69, 49, 208, 46 } });
        }
    }
}
