using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;

namespace Testing
{
    public class DataBaseSeeder
    {
        public static void SeedDatabase(WheelsMarketDbContext context)
        {
            SeedVehicle(context);
            SeedBook(context);
            SeedUser(context);

            context.SaveChanges();
        }
        //public static void SeedVehicle(WheelsMarketDbContext context)
        //{
        //    var publisher1 = new Vehicle()
        //    {
        //        Id = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"),
        //        Name = "Holiday House"
        //    };
        //    var publisher2 = new Publisher()
        //    {
        //        Id = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7"),
        //        Name = "Candlewick Press"
        //    };
        //    var publisher3 = new Publisher()
        //    {
        //        Id = Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12"),
        //        Name = "Arbordale Publishing"
        //    };
        //    context.Publishers.Add(publisher1);
        //    context.Publishers.Add(publisher2);
        //    context.Publishers.Add(publisher3);

        //}
        //public static void SeedBook(WheelsMarketDbContext context)
        //{
        //    var book1 = new Book()
        //    {
        //        Id = Guid.NewGuid(),
        //        Title = "Where the Wild Things Are",
        //        Author = "Maurice Sendak",
        //        Pages = 48,
        //        ISBN = "9780060254926",
        //        Price = 8.99,
        //        Image = "https://m.media-amazon.com/images/I/91tBaQgfHeL._AC_UF1000,1000_QL80_.jpg",
        //        PublishingYear = 1963,
        //        PublisherId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6")
        //    };
        //    var book2 = new Book()
        //    {
        //        Id = Guid.NewGuid(),
        //        Title = "The Very Hungry Caterpillar",
        //        Author = "Eric Carle",
        //        Pages = 26,
        //        ISBN = "9780399226908",
        //        Price = 6.99,
        //        Image = "https://m.media-amazon.com/images/I/81qsstEtrgL._AC_UF1000,1000_QL80_.jpg",
        //        PublishingYear = 1969,
        //        PublisherId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6")
        //    };
        //    var book3 = new Book()
        //    {
        //        Id = Guid.NewGuid(),
        //        Title = "Goodnight Moon",
        //        Author = "Margaret Wise Brown",
        //        Pages = 32,
        //        ISBN = "9780060775858",
        //        Price = 6.29,
        //        Image = "https://m.media-amazon.com/images/I/91WuHblNkEL._AC_UF1000,1000_QL80_.jpg",
        //        PublishingYear = 1947,
        //        PublisherId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6")
        //    };
        //    context.Books.Add(book1);
        //    context.Books.Add(book2);
        //    context.Books.Add(book3);
        //}
        //public static void SeedUser(WheelsMarketDbContext context)
        //{
        //    var user1 = new User()
        //    {
        //        FirstName = "John",
        //        LastName = "Doe",
        //        Age = 30
        //    };
        //    var user2 = new User()
        //    {
        //        FirstName = "Alice",
        //        LastName = "Smith",
        //        Age = 25
        //    };
        //    context.Users.Add(user1);
        //    context.Users.Add(user2);
        //}
    }
}
