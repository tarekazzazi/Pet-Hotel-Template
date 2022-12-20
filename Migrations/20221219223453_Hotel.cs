using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class Hotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "PetOwners",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pet_id",
                table: "PetOwners",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "PetOwners");

            migrationBuilder.DropColumn(
                name: "pet_id",
                table: "PetOwners");
        }
    }
}
