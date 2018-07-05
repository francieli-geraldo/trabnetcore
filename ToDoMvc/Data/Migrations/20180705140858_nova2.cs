using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoMvc.Data.Migrations
{
    public partial class nova2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Venda",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ApplicationUserId",
                table: "Venda",
                column: "ApplicationUserId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Venda_AspNetUsers_ApplicationUserId",
            //    table: "Venda",
            //    column: "ApplicationUserId",
            //    principalTable: "AspNetUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Venda_AspNetUsers_ApplicationUserId",
            //    table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ApplicationUserId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Venda");
        }
    }
}
