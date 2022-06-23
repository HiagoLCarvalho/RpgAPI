using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgApi.Migrations
{
    public partial class MigracaoPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Jogador");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 102, 178, 89, 231, 81, 66, 229, 216, 115, 154, 140, 13, 151, 174, 239, 29, 53, 58, 17, 118, 112, 238, 126, 121, 245, 114, 242, 25, 237, 115, 181, 135, 242, 174, 187, 50, 153, 205, 146, 2, 254, 37, 73, 57, 127, 124, 20, 186, 55, 36, 189, 113, 126, 147, 163, 115, 89, 251, 64, 46, 68, 222, 38, 66 }, new byte[] { 122, 140, 42, 174, 223, 161, 84, 162, 209, 107, 46, 190, 219, 177, 253, 97, 204, 126, 164, 23, 52, 101, 58, 104, 2, 246, 195, 25, 203, 253, 90, 40, 21, 3, 22, 133, 103, 17, 44, 215, 207, 32, 79, 209, 154, 104, 64, 201, 68, 16, 143, 173, 76, 38, 112, 107, 27, 219, 111, 190, 153, 44, 8, 111, 89, 232, 95, 159, 79, 205, 211, 137, 191, 132, 167, 89, 175, 31, 232, 143, 228, 69, 50, 179, 23, 252, 87, 142, 98, 183, 184, 50, 106, 19, 74, 116, 144, 230, 179, 90, 153, 211, 247, 116, 91, 191, 81, 207, 67, 187, 31, 111, 217, 44, 185, 153, 135, 83, 241, 144, 237, 82, 245, 187, 69, 49, 208, 46 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 18, 75, 60, 175, 40, 41, 33, 73, 203, 194, 147, 35, 46, 54, 166, 6, 92, 224, 33, 214, 248, 223, 116, 80, 124, 234, 142, 94, 112, 170, 81, 129, 73, 151, 41, 128, 255, 93, 197, 121, 233, 166, 239, 178, 81, 240, 71, 161, 26, 220, 167, 115, 195, 206, 30, 208, 169, 167, 57, 100, 43, 210, 162 }, new byte[] { 114, 172, 237, 103, 162, 249, 16, 81, 41, 209, 123, 185, 76, 139, 192, 71, 12, 215, 243, 197, 55, 107, 111, 195, 215, 251, 52, 178, 139, 180, 201, 63, 76, 202, 161, 29, 78, 22, 191, 135, 65, 104, 138, 41, 17, 250, 230, 127, 105, 232, 244, 204, 41, 26, 223, 112, 108, 13, 68, 222, 132, 145, 28, 240, 188, 165, 15, 115, 50, 57, 238, 123, 97, 153, 197, 89, 117, 23, 198, 206, 59, 86, 226, 22, 247, 244, 144, 199, 214, 49, 230, 98, 11, 223, 232, 202, 160, 211, 76, 229, 80, 221, 174, 110, 153, 156, 11, 88, 204, 72, 48, 24, 99, 142, 98, 35, 98, 66, 240, 9, 253, 245, 101, 240, 36, 35, 234, 172 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId");
        }
    }
}
