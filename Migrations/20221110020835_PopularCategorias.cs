using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_project.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Categories (CategoryName, Description) Values 
                                ('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql(@"INSERT INTO Categories (CategoryName, Description) Values 
                                ('Natural', 'Lanche feito com ingredientes integrais e naturais')");
                            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Categories");
        }
    }
}
