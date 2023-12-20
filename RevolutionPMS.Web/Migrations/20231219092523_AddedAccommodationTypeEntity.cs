using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevolutionPMS.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedAccommodationTypeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccommodationTypeId",
                table: "PropertyTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AccommodationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccommodationTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_AccommodationTypeId",
                table: "PropertyTypes",
                column: "AccommodationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyTypes_AccommodationTypes_AccommodationTypeId",
                table: "PropertyTypes",
                column: "AccommodationTypeId",
                principalTable: "AccommodationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyTypes_AccommodationTypes_AccommodationTypeId",
                table: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "AccommodationTypes");

            migrationBuilder.DropIndex(
                name: "IX_PropertyTypes_AccommodationTypeId",
                table: "PropertyTypes");

            migrationBuilder.DropColumn(
                name: "AccommodationTypeId",
                table: "PropertyTypes");
        }
    }
}
