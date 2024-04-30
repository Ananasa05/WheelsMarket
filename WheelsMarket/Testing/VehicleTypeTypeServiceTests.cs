using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeSections;
using WheelsMarket.Services.VehicleTypeTypes;
using static Testing.DataBaseSeeder;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace Testing
{
    public class VehicleTypeTypeServiceTests
    {
        private DbContextOptions<WheelsMarketDbContext> dbOptions;
        private WheelsMarketDbContext dbContext;
        private IVehicleTypeTypeService vehicleTypeTypeService;

        [SetUp]
        public void SetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<WheelsMarketDbContext>()
                    .UseInMemoryDatabase("WheelsMarketInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

            this.dbContext = new WheelsMarketDbContext(this.dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);


            this.vehicleTypeTypeService = new VehicleTypeTypeService(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetAllAsync_Returns_AllVehicleTypeTypes()
        {
            // Arrange

            // Act
            var result = await vehicleTypeTypeService.ShowAllVehicleTypeTypeAsync();

            // Assert
            Assert.AreEqual(4, result.Count());
        }

        [Test]
        public async Task GetAllAsync_Returns_CorrectVehicleTypeTypeNames()
        {
            // Arrange
            var expectedNames = new List<string> { "Ван", "Джип", "Кабрио", "Комби" };

            // Act
            var result = await vehicleTypeTypeService.ShowAllVehicleTypeTypeAsync();

            // Assert
            CollectionAssert.AreEqual(expectedNames, result.Select(p => p.Type));
        }

        [Test]
        public async Task GetAllAsync_Returns_VehicleTypeTypesIds()
        {
            // Arrange
            var expectedIds = new List<Guid>
        {
            Guid.Parse("c80fdbba-9d3d-485c-bb9d-085da4e9b69e"),
            Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23"),
            Guid.Parse("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14"),
            Guid.Parse("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49")
        };

            // Act
            var result = await vehicleTypeTypeService.ShowAllVehicleTypeTypeAsync();

            // Assert
            CollectionAssert.AreEqual(expectedIds, result.Select(p => p.Id));
        }

        [Test]
        public async Task GetAllAsync_Returns_EmptyList_WhenNoVehicleTypeTypes()
        {
            // Arrange
            dbContext.VehicleTypeTypes.RemoveRange(dbContext.VehicleTypeTypes);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await vehicleTypeTypeService.ShowAllVehicleTypeTypeAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllAsync_Returns_WithNames_AllVehicleTypeTypes()
        {
            // Arrange
            var expectedVehicleTypeTypes = new List<AllVehicleTypeTypeViewModel>
            {
                new AllVehicleTypeTypeViewModel { Id = Guid.Parse("c80fdbba-9d3d-485c-bb9d-085da4e9b69e"), Type = "Ван" },
                new AllVehicleTypeTypeViewModel { Id = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23"), Type = "Джип" },
                new AllVehicleTypeTypeViewModel { Id = Guid.Parse("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14"), Type = "Кабрио" },
                new AllVehicleTypeTypeViewModel { Id = Guid.Parse("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49"), Type = "Комби" },
            };

            // Act
            var result = await vehicleTypeTypeService.ShowAllVehicleTypeTypeAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedVehicleTypeTypes.Count, result.Count());
            foreach (var expectedVehicleTypeType in expectedVehicleTypeTypes)
            {
                Assert.IsTrue(result.Any(p => p.Id == expectedVehicleTypeType.Id && p.Type== expectedVehicleTypeType.Type));
            }
        }

        [Test]
        public async Task AddVehicleTypeTypeAsync_Should_Add_New_VehicleTypeType()
        {
            // Arrange
            var model = new AddVehicleTypeTypeViewModel { Type= "New Type" };

            // Act
            await vehicleTypeTypeService.AddVehicleTypeTypeAsync(model);

            // Assert
            var addedVehicleTypeType = await dbContext.VehicleTypeTypes.FirstOrDefaultAsync(p => p.Type == "New Type");
            Assert.IsNotNull(addedVehicleTypeType);
        }

        [Test]
        public async Task DeleteVehicleTypeTypesAsync_RemovesVehicleTypeTypesFromDatabase()
        {
            // Arrange
            var vehicleTypeTypeId = Guid.Parse("c80fdbba-9d3d-485c-bb9d-085da4e9b69e");

            // Act
            await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(vehicleTypeTypeId);

            // Assert
            var deletedVehicleTypeType = await dbContext.VehicleTypeTypes.FindAsync(vehicleTypeTypeId);
            Assert.IsNull(deletedVehicleTypeType);
        }

        [Test]
        public void DeleteVehicleTypeTypesAsync_ThrowsException_WhenIdNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(nonExistentId));
        }

        [Test]
        public async Task DeleteVehicleTypeTypesAsync_RemovesAssociatedBrand()
        {
            // Arrange
            var vehicleTypeTypeId = Guid.Parse("c80fdbba-9d3d-485c-bb9d-085da4e9b69e");

            // Act
            await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(vehicleTypeTypeId);

            // Assert
            var types = await dbContext.Brands.Where(b => b.VehicleTypeTypeId== vehicleTypeTypeId).ToListAsync();
            Assert.IsEmpty(types);
        }

        [Test]
        public async Task DeleteVehicleTypeTypesAsync_ThrowsException_WhenIdIsEmptyGuid()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(emptyGuid));
        }

        [Test]
        public async Task DeleteVehicleTypeTypesAsync_DoesNotRemoveOtherVehicleTypeTypes()
        {
            // Arrange
            var vehicleTypeTypeId = Guid.Parse("c80fdbba-9d3d-485c-bb9d-085da4e9b69e");
            var remainingVehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23");

            // Act
            await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(vehicleTypeTypeId);

            // Assert
            var remainingVehicleTypeType = await dbContext.VehicleTypeTypes.FindAsync(remainingVehicleTypeTypeId);
            Assert.IsNotNull(remainingVehicleTypeType);
        }

        [Test]
        public async Task DeleteVehicleTypeTypesAsync_ThrowsException_WhenIdIsInvalid()
        {
            // Arrange
            var invalidId = "InvalidId";

            // Act & Assert
            Assert.ThrowsAsync<FormatException>(async () => await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(Guid.Parse(invalidId)));
        }
    }
}
