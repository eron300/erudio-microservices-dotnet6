using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-Shirt", "Camiseta No Internet personalizada na tematica Jurassic Park", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true", "Camiseta No Internet", 69.9m },
                    { 3L, "Action Figure", "Figure do Capecete Darth Vader Star Wars Black Series edição limitada", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capecete Darth Vader Star Wars Black Series", 999.99m },
                    { 4L, "Action Figure", "Figure de qualidade da série star wars", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Storm Tropper", 169.9m },
                    { 5L, "Shirt", "Camisa personalizada para aqueles que são 100% Geek", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "100% Gamer", 29.9m },
                    { 6L, "Shirt", "Camisa para fãs da space X feita de algodão", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camisa Space X", 19.9m },
                    { 7L, "Shirt", "Camisa hiper foda sobre os benefícios do café para viciados em café", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camisa Coffee drinking", 39.9m },
                    { 8L, "Sweatshirt", "Moletom preto da série Cobra Kai", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Cora Kai", 56m },
                    { 9L, "Book", "Livro Star Talk com Neil deGrasse Tyson", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Stat Talk", 69.9m },
                    { 10L, "Action Figure", "Action figure da Milennium Falcon dos filmes de Star Wars", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Milennium Falcon", 499.9m },
                    { 11L, "Shirt", "Camisa Occupy Mars de algodão preta", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camisa Occupy Mars", 19.9m },
                    { 12L, "T-Shirt", "Camisa branca escrito Gnu/Linux Freedom", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta branca Gnu Linux", 19.9m },
                    { 13L, "T-Shirt", "Camiseta branca com o personagem Goku do anime Dragon ball estampada", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg?raw=true", "Camiseta do Goku", 59.99m },
                    { 14L, "", "Logo da Nasa", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/14_patch_nasa.jpg?raw=true", "Name", 9.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L);
        }
    }
}
