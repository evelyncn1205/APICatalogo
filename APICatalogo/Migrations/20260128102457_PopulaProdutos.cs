using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categoria_CategoriaID",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaID",
                table: "Produtos",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaID",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categoria_CategoriaID",
                table: "Produtos",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
