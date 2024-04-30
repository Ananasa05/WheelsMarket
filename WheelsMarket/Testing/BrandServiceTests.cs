using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;
using WheelsMarket.Services.Brands;
using WheelsMarket.Services.Brands.ViewModel;
using static Testing.DataBaseSeeder;

namespace Testing
{
    public class BrandServiceTests
    {
        private DbContextOptions<WheelsMarketDbContext> dbOptions;
        private WheelsMarketDbContext dbContext;
        private IBrandService brandService;

        [SetUp]
        public void SetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<WheelsMarketDbContext>()
                    .UseInMemoryDatabase("WheelsMarketInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

            this.dbContext = new WheelsMarketDbContext(this.dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);


            this.brandService = new BrandService(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetAllAsync_Returns_AllBrands()
        {
            // Arrange

            // Act
            var result = await brandService.ShowAllBrandAsync();

            // Assert
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllAsync_Returns_CorrectBrandNames()
        {
            // Arrange
            var expectedNames = new List<string> { "Alfa Romeo", "Audi", "BMW"};

            // Act
            var result = await brandService.ShowAllBrandAsync();

            // Assert
            CollectionAssert.AreEqual(expectedNames, result.Select(p => p.Name));
        }

        [Test]
        public async Task GetAllAsync_Returns_BrandIds()
        {
            // Arrange
            var expectedIds = new List<Guid>
    {
        Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2"),
        Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de"),
        Guid.Parse("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"),
    };

            // Act
            var result = await brandService.ShowAllBrandAsync();

            // Assert
            CollectionAssert.AreEqual(expectedIds, result.Select(p => p.Id));
        }

        [Test]
        public async Task GetAllAsync_Returns_EmptyList_WhenNoBrands()
        {
            // Arrange
            dbContext.Brands.RemoveRange(dbContext.Brands);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await brandService.ShowAllBrandAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllAsync_Returns_WithNames_AllBrands()
        {
            // Arrange
            var expectedBrands = new List<AllBrandViewModel>
    {
        new AllBrandViewModel { Id = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2"), Name = "Alfa Romeo" },
        new AllBrandViewModel { Id = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de"), Name = "Audi" },
        new AllBrandViewModel { Id = Guid.Parse("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"), Name = "BMW" },
    };

            // Act
            var result = await brandService.ShowAllBrandAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBrands.Count, result.Count());
            foreach (var expectedBrand in expectedBrands)
            {
                Assert.IsTrue(result.Any(p => p.Id == expectedBrand.Id && p.Name == expectedBrand.Name));
            }
        }

        [Test]
        public async Task AddBrandAsync_Should_Add_New_Brand()
        {
            // Arrange
            var model = new AddBrandViewModel { Name = "New Brand" };

            // Act
            await brandService.AddBrandAdminAsync(model);

            // Assert
            var addedBrand = await dbContext.Brands.FirstOrDefaultAsync(p => p.Name == "New Brand");
            Assert.IsNotNull(addedBrand);
        }




        [Test]
        public async Task DeleteBrandsAsync_RemovesBrandsFromDatabase()
        {
            // Arrange
            var brandId = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2");

            // Act
            await brandService.DeleteBrandAdminAsync(brandId);

            // Assert
            var deletedBrand = await dbContext.Brands.FindAsync(brandId);
            Assert.IsNull(deletedBrand);
        }

        [Test]
        public void DeleteBrandsAsync_ThrowsException_WhenIdNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await brandService.DeleteBrandAdminAsync(nonExistentId));
        }

        [Test]
        public async Task DeleteBrandsAsync_RemovesAssociatedEdition()
        {
            // Arrange
            var brandId = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2");

            // Act
            await brandService.DeleteBrandAdminAsync(brandId);

            // Assert
            var vehicles = await dbContext.Editions.Where(v => v.BrandId== brandId).ToListAsync();
            Assert.IsEmpty(vehicles);
        }

        [Test]
        public async Task DeleteBrandsAsync_ThrowsException_WhenIdIsEmptyGuid()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await brandService.DeleteBrandAdminAsync(emptyGuid));
        }

        [Test]
        public async Task DeleteBrandsAsync_DoesNotRemoveOtherBrands()
        {
            // Arrange
            var brandId = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2");
            var remainingBrandId = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de");

            // Act
            await brandService.DeleteBrandAdminAsync(brandId);

            // Assert
            var remainingBrand = await dbContext.Brands.FindAsync(remainingBrandId);
            Assert.IsNotNull(remainingBrand);
        }

        [Test]
        public async Task DeleteBrandsAsync_ThrowsException_WhenIdIsInvalid()
        {
            // Arrange
            var invalidId = "InvalidId";

            // Act & Assert
            Assert.ThrowsAsync<FormatException>(async () => await brandService.DeleteBrandAdminAsync(Guid.Parse(invalidId)));
        }

    }
}
