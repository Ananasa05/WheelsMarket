using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;
using WheelsMarket.Services.Vehicles;
using WheelsMarket.Services.VehicleTypeSections;
using Moq;
using static Testing.DataBaseSeeder;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Data.Models;

namespace Testing
{
    [TestFixture]

    public class VehicleTypeSectionServiceTests
    {
        private DbContextOptions<WheelsMarketDbContext> dbOptions;
        private WheelsMarketDbContext dbContext;
        private IVehicleTypeSectionService vehicleTypeSectionService;

        [SetUp]
        public void SetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<WheelsMarketDbContext>()
                    .UseInMemoryDatabase("WheelsMarketInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

            this.dbContext = new WheelsMarketDbContext(this.dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);


            this.vehicleTypeSectionService = new VehicleTypeSectionService(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetAllAsync_Returns_AllVehicleTypeSections()
        {
            // Arrange

            // Act
            var result = await vehicleTypeSectionService.ShowAllVehicleTypeSectionAsync();

            // Assert
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllAsync_Returns_CorrectVehicleTypeSectionNames()
        {
            // Arrange
            var expectedNames = new List<string> { "Автомобили и джипове", "Бусове", "Камиони" };

            // Act
            var result = await vehicleTypeSectionService.ShowAllVehicleTypeSectionAsync();

            // Assert
            CollectionAssert.AreEqual(expectedNames, result.Select(p => p.Section));
        }

        [Test]
        public async Task GetAllAsync_Returns_VehicleTypeSectionsIds()
        {
            // Arrange
            var expectedIds = new List<Guid>
        {
            Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428"),
            Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118"),
            Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01")
        };

            // Act
            var result = await vehicleTypeSectionService.ShowAllVehicleTypeSectionAsync();

            // Assert
            CollectionAssert.AreEqual(expectedIds, result.Select(p => p.Id));
        }

        [Test]
        public async Task GetAllAsync_Returns_EmptyList_WhenNoVehicleTypeSections()
        {
            // Arrange
            dbContext.VehicleTypeSections.RemoveRange(dbContext.VehicleTypeSections);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await vehicleTypeSectionService.ShowAllVehicleTypeSectionAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllAsync_Returns_WithNames_AllPublishers()
        {
            // Arrange
            var expectedVehicleTypeSections = new List<AllVehicleTypeSectionViewModel>
            {
                new AllVehicleTypeSectionViewModel { Id = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428"), Section = "Автомобили и джипове" },
                new AllVehicleTypeSectionViewModel { Id = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118"), Section = "Бусове" },
                new AllVehicleTypeSectionViewModel { Id = Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01"), Section = "Камиони" }
            };

            // Act
            var result = await vehicleTypeSectionService.ShowAllVehicleTypeSectionAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedVehicleTypeSections.Count, result.Count());
            foreach (var expectedVehicleTypeSection in expectedVehicleTypeSections)
            {
                Assert.IsTrue(result.Any(p => p.Id == expectedVehicleTypeSection.Id && p.Section== expectedVehicleTypeSection.Section));
            }
        }

        [Test]
        public async Task AddVehicleTypeSectionAsync_Should_Add_New_VehicleTypeSection()
        {
            // Arrange
            var model = new AddVehicleTypeSectionViewModel { Section = "New Section" };

            // Act
            await vehicleTypeSectionService.AddVehicleTypeSectionAsync(model);

            // Assert
            var addedVehicleTypeSection = await dbContext.VehicleTypeSections.FirstOrDefaultAsync(p => p.Section == "New Section");
            Assert.IsNotNull(addedVehicleTypeSection);
        }

        [Test]
        public async Task DeleteVehicleTypeSectionsAsync_RemovesVehicleTypeSectionsFromDatabase()
        {
            // Arrange
            var vehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428");

            // Act
            await vehicleTypeSectionService.DeleteVehicleTypeSectionAsync(vehicleTypeSectionId);

            // Assert
            var deletedVehicleTypeSection = await dbContext.VehicleTypeSections.FindAsync(vehicleTypeSectionId);
            Assert.IsNull(deletedVehicleTypeSection);
        }

        [Test]
        public void DeleteVehicleTypeSectionsAsync_ThrowsException_WhenIdNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await vehicleTypeSectionService.DeleteVehicleTypeSectionAsync(nonExistentId));
        }

        [Test]
        public async Task DeleteVehicleTypeSectionsAsync_RemovesAssociatedVehicleTypeTypes()
        {
            // Arrange
            var vehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428");

            // Act
            await vehicleTypeSectionService.DeleteVehicleTypeSectionAsync(vehicleTypeSectionId);

            // Assert
            var books = await dbContext.VehicleTypeTypes.Where(b => b.VehicleTypeSectionId== vehicleTypeSectionId).ToListAsync();
            Assert.IsEmpty(books);
        }

        [Test]
        public async Task DeleteVehicleTypeSectionsAsync_ThrowsException_WhenIdIsEmptyGuid()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await vehicleTypeSectionService.DeleteVehicleTypeSectionAsync(emptyGuid));
        }

        [Test]
        public async Task DeleteVehicleTypeSectionsAsync_DoesNotRemoveOtherVehicleTypeSections()
        {
            // Arrange
            var vehicleTypeSectionId = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118");
            var remainingVehicleTypeSectionId = Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01");

            // Act
            await vehicleTypeSectionService.DeleteVehicleTypeSectionAsync(vehicleTypeSectionId);

            // Assert
            var remainingVehicleTypeSection = await dbContext.VehicleTypeSections.FindAsync(remainingVehicleTypeSectionId);
            Assert.IsNotNull(remainingVehicleTypeSection);
        }

        [Test]
        public async Task DeleteVehicleTypeSectionsAsync_ThrowsException_WhenIdIsInvalid()
        {
            // Arrange
            var invalidId = "InvalidId";

            // Act & Assert
            Assert.ThrowsAsync<FormatException>(async () => await vehicleTypeSectionService.DeleteVehicleTypeSectionAsync(Guid.Parse(invalidId)));
        }
    }
}
