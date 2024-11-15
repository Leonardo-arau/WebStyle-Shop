using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStyle.ProductApi.Migrations
{
    public partial class SeedProduct : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId) " + 
                "Values('Camisa',20.55,'Camisa',20,'camisa.jpg',5)");

            mb.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId) " +
                "Values('Mochila',26.50,'Mochila',10,'mochila.jpg',1)");

            mb.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId) " +
                "Values('Saia',29.90,'Saia',15,'saia.jpg',2)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Products");
        }
    }
}
