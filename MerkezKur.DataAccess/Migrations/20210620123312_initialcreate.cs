using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MerkezKur.DataAccess.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurlars",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    CrossRateName = table.Column<string>(type: "text", nullable: true),
                    ForexBuying = table.Column<double>(type: "double precision", nullable: false),
                    ForexSelling = table.Column<double>(type: "double precision", nullable: false),
                    BanknoteBuying = table.Column<double>(type: "double precision", nullable: false),
                    BanknoteSelling = table.Column<double>(type: "double precision", nullable: false),
                    DatetimeKurGet = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurlars", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kurlars");
        }
    }
}
