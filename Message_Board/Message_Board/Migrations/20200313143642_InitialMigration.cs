using Microsoft.EntityFrameworkCore.Migrations;

namespace Message_Board.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment_mgs = table.Column<string>(nullable: true),
                    like = table.Column<int>(nullable: true),
                    msg_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Msg_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(nullable: false),
                    like = table.Column<int>(nullable: false),
                    Msg_content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Msg_id);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "comment_mgs", "like", "msg_id", "name" },
                values: new object[] { 1, "Same to you", 1, 1, "Kuldeep Nikum" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Msg_id", "Msg_content", "User_name", "like" },
                values: new object[] { 1, "Happy Holi...", "Mohit Yadav", 10 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Msg_id", "Msg_content", "User_name", "like" },
                values: new object[] { 2, "Whatever", "Kuldeep Nikum", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
