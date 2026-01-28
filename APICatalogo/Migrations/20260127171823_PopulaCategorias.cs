using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mB)
        {
            mB.Sql("Insert into Categoria(Nome, ImageUrl) Values('Bebidas','bebidas.jpg')");
            mB.Sql("Insert into Categoria(Nome, ImageUrl) Values('Lanches','lanches.jpg')");
            mB.Sql("Insert into Categoria(Nome, ImageUrl) Values('Sobremesas','sobremesas.jpg')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mB)
        {
            mB.Sql("Delete from Categoria");
        }
    }
}
