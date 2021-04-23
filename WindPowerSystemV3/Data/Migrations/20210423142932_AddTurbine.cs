using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindPowerSystemV3.Data.Migrations
{
    public partial class AddTurbine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turbines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SerialNum = table.Column<string>(nullable: false),
                    ProdMW = table.Column<int>(nullable: false),
                    TurbineTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turbines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turbines_TurbineTypes_TurbineTypeId",
                        column: x => x.TurbineTypeId,
                        principalTable: "TurbineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turbines_TurbineTypeId",
                table: "Turbines",
                column: "TurbineTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turbines");
        }
    }
}
