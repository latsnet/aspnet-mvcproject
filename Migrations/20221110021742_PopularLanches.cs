using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_project.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Snacks (CategoryId, SnackName, ShortDescription, DetailDescription, Price, FavoriteSnack, InStock, ImageUrl, ImageThumbnailUrl)
                 Values (1, 'Cheese Salada', 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Deliciso Lanche', 10.00, 1, 1, '', '')");

            migrationBuilder.Sql(@"INSERT INTO Snacks (CategoryId, SnackName, ShortDescription, DetailDescription, Price, FavoriteSnack, InStock, ImageUrl, ImageThumbnailUrl)
                 Values (1, 'Double Cheese Salada', 'Pão, 2 hambúrgueres, ovo, presunto, queijo e batata palha', 'McLanche Feliz', 12.00, 1, 1, '', '')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Snacks");
        }
    }
}
