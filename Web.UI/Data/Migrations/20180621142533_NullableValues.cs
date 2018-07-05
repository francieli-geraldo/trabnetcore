using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.UI.Data.Migrations
{
    public partial class NullableValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Loja_LojaId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<long>(
                name: "Telefone",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<long>(
                name: "LojaId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "CPF",
                table: "AspNetUsers",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(long),
                oldMaxLength: 11);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Loja_LojaId",
                table: "AspNetUsers",
                column: "LojaId",
                principalTable: "Loja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Loja_LojaId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<long>(
                name: "Telefone",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "AspNetUsers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "LojaId",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CPF",
                table: "AspNetUsers",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(long),
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Loja_LojaId",
                table: "AspNetUsers",
                column: "LojaId",
                principalTable: "Loja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
