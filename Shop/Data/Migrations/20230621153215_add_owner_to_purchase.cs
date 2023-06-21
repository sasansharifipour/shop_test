using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Data.Migrations
{
    public partial class add_owner_to_purchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Purchases",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_OwnerId",
                table: "Purchases",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_AspNetUsers_OwnerId",
                table: "Purchases",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_AspNetUsers_OwnerId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_OwnerId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Purchases");
        }
    }
}
