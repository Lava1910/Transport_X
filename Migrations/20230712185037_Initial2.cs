using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transport_X.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostOffices_Wards_WardId",
                table: "PostOffices");

            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Regions_RegionId",
                table: "Provinces");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Provinces",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WardId",
                table: "PostOffices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PostOfficeAddress",
                table: "PostOffices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_PostOffices_Wards_WardId",
                table: "PostOffices",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "WardCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Regions_RegionId",
                table: "Provinces",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostOffices_Wards_WardId",
                table: "PostOffices");

            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Regions_RegionId",
                table: "Provinces");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Provinces",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WardId",
                table: "PostOffices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostOfficeAddress",
                table: "PostOffices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PostOffices_Wards_WardId",
                table: "PostOffices",
                column: "WardId",
                principalTable: "Wards",
                principalColumn: "WardCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Regions_RegionId",
                table: "Provinces",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
