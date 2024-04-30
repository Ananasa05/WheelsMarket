using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Editions;
using WheelsMarket.Data;
using static Testing.DataBaseSeeder;
using WheelsMarket.Services.Brands;

namespace Testing
{
    public class EditionServiceTests
    {
        private DbContextOptions<WheelsMarketDbContext> dbOptions;
        private WheelsMarketDbContext dbContext;
        private IEditionService editionService;

        [SetUp]
        public void SetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<WheelsMarketDbContext>()
                    .UseInMemoryDatabase("WheelsMarketInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

            this.dbContext = new WheelsMarketDbContext(this.dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);


            this.editionService = new EditionService(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }


        [Test]
        public async Task GetAllAsync_Returns_AllEditions()
        {
            // Arrange

            // Act
            var result = await editionService.ShowAllEditionAsync();

            // Assert
            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public async Task GetAllAsync_Returns_CorrectEditionNames()
        {
            // Arrange
            var expectedNames = new List<string> { "Q7", "RSQ8" };

            // Act
            var result = await editionService.ShowAllEditionAsync();

            // Assert
            CollectionAssert.AreEqual(expectedNames, result.Select(p => p.Name));
        }

        [Test]
        public async Task GetAllAsync_Returns_EditionsIds()
        {
            // Arrange
            var expectedIds = new List<Guid>
{
    Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8"),
    Guid.Parse("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"),
};

            // Act
            var result = await editionService.ShowAllEditionAsync();

            // Assert
            CollectionAssert.AreEqual(expectedIds, result.Select(p => p.Id));
        }

        [Test]
        public async Task GetAllAsync_Returns_EmptyList_WhenNoEditions()
        {
            // Arrange
            dbContext.Editions.RemoveRange(dbContext.Editions);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await editionService.ShowAllEditionAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllAsync_Returns_WithNames_AllEditions()
        {
            // Arrange
            var expectedEditions = new List<AllEditionViewModel>
    {
        new AllEditionViewModel { Id = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8"), Name = "Q7" },
        new AllEditionViewModel { Id = Guid.Parse("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"), Name = "RSQ8" },
    };

            // Act
            var result = await editionService.ShowAllEditionAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedEditions.Count, result.Count());
            foreach (var expectedEdition in expectedEditions)
            {
                Assert.IsTrue(result.Any(p => p.Id == expectedEdition.Id && p.Name == expectedEdition.Name));
            }
        }

        [Test]
        public async Task AddEditionAsync_Should_Add_New_Edition()
        {
            // Arrange
            var model = new AddEditionViewModel { Name = "New Type" };

            // Act
            await editionService.AddEditionAsync(model);

            // Assert
            var addedEdition = await dbContext.Editions.FirstOrDefaultAsync(p => p.Name== "New Type");
            Assert.IsNotNull(addedEdition);
        }

        [Test]
        public async Task DeleteEditionsAsync_RemovesEditionsFromDatabase()
        {
            // Arrange
            var editionId = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8");

            // Act
            await editionService.DeleteEditionAsync(editionId);

            // Assert
            var deletedEdition = await dbContext.Editions.FindAsync(editionId);
            Assert.IsNull(deletedEdition);
        }

        [Test]
        public void DeleteEditionsAsync_ThrowsException_WhenIdNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await editionService.DeleteEditionAsync(nonExistentId));
        }

        [Test]
        public async Task DeleteEditionsAsync_RemovesAssociatedVehicle()
        {
            // Arrange
            var editionId = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8");

            // Act
            await editionService.DeleteEditionAsync(editionId);

            // Assert
            var brands = await dbContext.Vehicles.Where(b => b.EditionId == editionId).ToListAsync();
            Assert.IsEmpty(brands);
        }

        [Test]
        public async Task DeleteEditionsAsync_ThrowsException_WhenIdIsEmptyGuid()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await editionService.DeleteEditionAsync(emptyGuid));
        }

        [Test]
        public async Task DeleteEditionsAsync_DoesNotRemoveOtherEditions()
        {
            // Arrange
            var editionId = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8");
            var remainingEditionId = Guid.Parse("2e89ffec-aae1-4620-b5f9-81b3fd59b04d");

            // Act
            await editionService.DeleteEditionAsync(editionId);

            // Assert
            var remainingEdition = await dbContext.Editions.FindAsync(remainingEditionId);
            Assert.IsNotNull(remainingEdition);
        }

        [Test]
        public async Task DeleteEditionsAsync_ThrowsException_WhenIdIsInvalid()
        {
            // Arrange
            var invalidId = "InvalidId";

            // Act & Assert
            Assert.ThrowsAsync<FormatException>(async () => await editionService.DeleteEditionAsync(Guid.Parse(invalidId)));
        }

    }
}
