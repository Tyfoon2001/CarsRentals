using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class customers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "customerId", "name" },
                values: new object[,]
                {
                    { 1, "rushi" },
                    { 2, "Test" },
                    { 3, "Jack" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerId",
                keyValue: 3);
        }
    }
}
