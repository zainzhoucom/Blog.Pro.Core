using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.EntityFramework.Migrations
{
    public partial class update1Table5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "blogging");

            migrationBuilder.RenameTable(
                name: "tip",
                newName: "tip",
                newSchema: "blogging");

            migrationBuilder.RenameTable(
                name: "ArticleRelationShip",
                newName: "ArticleRelationShip",
                newSchema: "blogging");

            migrationBuilder.RenameTable(
                name: "articleGenre",
                newName: "articleGenre",
                newSchema: "blogging");

            migrationBuilder.RenameTable(
                name: "article",
                newName: "article",
                newSchema: "blogging");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "tip",
                schema: "blogging",
                newName: "tip");

            migrationBuilder.RenameTable(
                name: "ArticleRelationShip",
                schema: "blogging",
                newName: "ArticleRelationShip");

            migrationBuilder.RenameTable(
                name: "articleGenre",
                schema: "blogging",
                newName: "articleGenre");

            migrationBuilder.RenameTable(
                name: "article",
                schema: "blogging",
                newName: "article");
        }
    }
}
