using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.EntityFramework.Migrations
{
    public partial class createTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articleGenre",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    genreName = table.Column<string>(maxLength: 50, nullable: false),
                    createTime = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articleGenre", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tip",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    genreName = table.Column<string>(maxLength: 50, nullable: false),
                    createTime = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tip", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "article",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    title = table.Column<string>(maxLength: 128, nullable: false),
                    content = table.Column<string>(nullable: true),
                    createTime = table.Column<DateTime>(nullable: false),
                    intro = table.Column<string>(nullable: true),
                    introImage = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    isTop = table.Column<bool>(nullable: false),
                    GenreId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_article", x => x.id);
                    table.ForeignKey(
                        name: "FK_article_articleGenre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "articleGenre",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleRelationShip",
                columns: table => new
                {
                    ArticleId = table.Column<string>(nullable: false),
                    TipId = table.Column<string>(nullable: false),
                    ArticlesId = table.Column<string>(nullable: true),
                    TipsId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleRelationShip", x => new { x.ArticleId, x.TipId });
                    table.ForeignKey(
                        name: "FK_ArticleRelationShip_article_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "article",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticleRelationShip_tip_TipsId",
                        column: x => x.TipsId,
                        principalTable: "tip",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_article_GenreId",
                table: "article",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleRelationShip_ArticlesId",
                table: "ArticleRelationShip",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleRelationShip_TipsId",
                table: "ArticleRelationShip",
                column: "TipsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleRelationShip");

            migrationBuilder.DropTable(
                name: "article");

            migrationBuilder.DropTable(
                name: "tip");

            migrationBuilder.DropTable(
                name: "articleGenre");
        }
    }
}
