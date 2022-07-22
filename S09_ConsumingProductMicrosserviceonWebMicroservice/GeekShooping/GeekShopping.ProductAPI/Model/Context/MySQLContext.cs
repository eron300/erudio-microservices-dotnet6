using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context {
    public class MySqlContext : DbContext {
        public MySqlContext() {}
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 2,
                Name = "Camiseta No Internet",
                Price = new decimal(69.9),
                Description = "Camiseta No Internet personalizada na tematica Jurassic Park",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 3,
                Name = "Capecete Darth Vader Star Wars Black Series",
                Price = new decimal(999.99),
                Description = "Figure do Capecete Darth Vader Star Wars Black Series edição limitada",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true",
                CategoryName = "Action Figure"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 4,
                Name = "Storm Tropper",
                Price = new decimal(169.9),
                Description = "Figure de qualidade da série star wars",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true",
                CategoryName = "Action Figure"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 5,
                Name = "100% Gamer",
                Price = new decimal(29.9),
                Description = "Camisa personalizada para aqueles que são 100% Geek",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true",
                CategoryName = "Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 6,
                Name = "Camisa Space X",
                Price = new decimal(19.9),
                Description = "Camisa para fãs da space X feita de algodão",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true",
                CategoryName = "Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 7,
                Name = "Camisa Coffee drinking",
                Price = new decimal(39.9),
                Description = "Camisa hiper foda sobre os benefícios do café para viciados em café",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                CategoryName = "Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 8,
                Name = "Moletom Cora Kai",
                Price = new decimal(56.0),
                Description = "Moletom preto da série Cobra Kai",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                CategoryName = "Sweatshirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 9,
                Name = "Stat Talk",
                Price = new decimal(69.9),
                Description = "Livro Star Talk com Neil deGrasse Tyson",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true",
                CategoryName = "Book"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 10,
                Name = "Milennium Falcon",
                Price = new decimal(499.9),
                Description = "Action figure da Milennium Falcon dos filmes de Star Wars",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                CategoryName = "Action Figure"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 11,
                Name = "Camisa Occupy Mars",
                Price = new decimal(19.9),
                Description = "Camisa Occupy Mars de algodão preta",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true",
                CategoryName = "Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 12,
                Name = "Camiseta branca Gnu Linux",
                Price = new decimal(19.9),
                Description = "Camisa branca escrito Gnu/Linux Freedom",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product {
                Id = 13,
                Name = "Camiseta do Goku",
                Price = new decimal(59.99),
                Description = "Camiseta branca com o personagem Goku do anime Dragon ball estampada",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg?raw=true",
                CategoryName = "T-Shirt"
            });

            //modelBuilder.Entity<Product>().HasData(new Product {
            //    Id = 14,
            //    Name = "Name",
            //    Price = new decimal(9.9),
            //    Description = "Logo da Nasa",
            //    ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/14_patch_nasa.jpg?raw=true",
            //    CategoryName = ""
            //});
        }
    }
}
