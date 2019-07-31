using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMvc.Migrations
{
    public partial class updateArticleTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTags_Article_ArticleId",
                table: "ArticleTags",
                column: "ArticleId",
                principalTable: "Article",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTags_Tags_TagId",
                table: "ArticleTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTags_Article_ArticleId",
                table: "ArticleTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTags_Tags_TagId",
                table: "ArticleTags");
        }
    }
}
