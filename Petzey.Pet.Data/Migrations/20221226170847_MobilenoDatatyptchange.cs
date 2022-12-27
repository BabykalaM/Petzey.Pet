using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petzey.Pet.Data.Migrations
{
    /// <inheritdoc />
    public partial class MobilenoDatatyptchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetOwner",
                table: "PetOwner");

            migrationBuilder.RenameTable(
                name: "PetOwner",
                newName: "PetOwners");

            migrationBuilder.AlterColumn<long>(
                name: "Mobile",
                table: "PetOwners",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetOwners",
                table: "PetOwners",
                column: "PetOwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PetOwners",
                table: "PetOwners");

            migrationBuilder.RenameTable(
                name: "PetOwners",
                newName: "PetOwner");

            migrationBuilder.AlterColumn<int>(
                name: "Mobile",
                table: "PetOwner",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetOwner",
                table: "PetOwner",
                column: "PetOwnerId");
        }
    }
}
