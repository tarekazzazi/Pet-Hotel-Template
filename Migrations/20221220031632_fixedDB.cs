using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class fixedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_petOwnerid",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_petOwnerid",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "petOwnerid",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "pet_id",
                table: "PetOwners",
                newName: "pets");

            migrationBuilder.AddColumn<string>(
                name: "petOwner",
                table: "Pets",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "petOwner",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "pets",
                table: "PetOwners",
                newName: "pet_id");

            migrationBuilder.AddColumn<int>(
                name: "petOwnerid",
                table: "Pets",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_petOwnerid",
                table: "Pets",
                column: "petOwnerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_petOwnerid",
                table: "Pets",
                column: "petOwnerid",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
