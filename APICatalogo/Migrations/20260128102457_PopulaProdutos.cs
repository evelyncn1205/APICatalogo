using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            
            mb.Sql(@"INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataRegisto, CategoriaID)
                VALUES('Coca-Cola Diet', 'Refrigerante de Cola 350ml', 5.45, 'coca-cola.jpg', 50, NOW(), 1)");
            mb.Sql(@"INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataRegisto, CategoriaID)
                VALUES('Lanche de Atum', 'Lanche de Atum com maionese', 8.50, 'atum.jpg', 10, NOW(), 2)");

            mb.Sql(@"INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataRegisto, CategoriaID)
                VALUES('Pudim', 'Pudim de Leite Condensado 100g', 6.75, 'pudim.jpg', 20, NOW(), 3)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");            
        }
    }
}
