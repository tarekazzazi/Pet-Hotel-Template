using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class get_Pet_owners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pets",
                table: "PetOwners",
                newName: "petCount");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "PetOwners",
                newName: "emailAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "petCount",
                table: "PetOwners",
                newName: "pets");

            migrationBuilder.RenameColumn(
                name: "emailAddress",
                table: "PetOwners",
                newName: "email");
        }
    }
}
