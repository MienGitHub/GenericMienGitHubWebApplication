using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationRegLogin.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6dd65e-ed64-4675-ba71-c9218d9e9006");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eca4d2b7-69da-488b-b07c-8be4cfeb82d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c3f7947-a45b-49f6-af98-b20cc1110fce", "de70eb43-c2ee-4f15-8d60-49cd196ae84b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc28b6c4-5fa5-410d-b069-4eb826e47152", "1421c20a-e1fd-47d1-a3ea-fb6e00c45ba5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c3f7947-a45b-49f6-af98-b20cc1110fce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc28b6c4-5fa5-410d-b069-4eb826e47152");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eca4d2b7-69da-488b-b07c-8be4cfeb82d6", "6838f58f-ffc6-444e-bda9-1a5154e79360", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d6dd65e-ed64-4675-ba71-c9218d9e9006", "1b1c06c3-3428-405a-ad35-47bdd1b47fd1", "Administrator", "ADMINISTRATOR" });
        }
    }
}
