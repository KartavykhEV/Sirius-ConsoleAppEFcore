using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleAppEFcore.Migrations
{
    /// <inheritdoc />
    public partial class gender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BDay",
                table: "persons",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<int>(
                name: "genderId",
                table: "persons",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_persons_genderId",
                table: "persons",
                column: "genderId");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_genders_genderId",
                table: "persons",
                column: "genderId",
                principalTable: "genders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_genders_genderId",
                table: "persons");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropIndex(
                name: "IX_persons_genderId",
                table: "persons");

            migrationBuilder.DropColumn(
                name: "genderId",
                table: "persons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BDay",
                table: "persons",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
