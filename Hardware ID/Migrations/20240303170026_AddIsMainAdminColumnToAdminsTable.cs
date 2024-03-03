using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hardware_ID.Migrations
{
    /// <inheritdoc />
    public partial class AddIsMainAdminColumnToAdminsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMainAdmin",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMainAdmin",
                table: "Admins");
        }
    }
}
