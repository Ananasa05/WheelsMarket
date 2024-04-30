using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Editions;
using WheelsMarket.Services.Vehicles;
using WheelsMarket.Services.Vehicles.ViewModel;
using static Testing.DataBaseSeeder;

namespace Testing
{
    public class VehicleServiceTests
    {
        private DbContextOptions<WheelsMarketDbContext> dbOptions;
        private WheelsMarketDbContext dbContext;
        private IVehicleService vehicleService;

        [SetUp]
        public void SetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<WheelsMarketDbContext>()
                    .UseInMemoryDatabase("WheelsMarketInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

            this.dbContext = new WheelsMarketDbContext(this.dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);


            this.vehicleService = new VehicleService(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task FavoriteVehicleAsync_AddsBookToUserFavorites()
        {
            // Arrange
            var user = dbContext.Users.First();
            var vehicle = dbContext.Vehicles.First();

            // Act
            await vehicleService.FavouritesVehicleAsync(vehicle.Id, user);

            // Assert
            Assert.AreEqual(1, dbContext.Favourites.Count());
            var addedFavorite = dbContext.Favourites.First();
            Assert.AreEqual(user.Id, addedFavorite.UserId);
            Assert.AreEqual(vehicle.Id, addedFavorite.VehicleId);
        }

        [Test]
        public async Task FavoriteVehicleAsync_VehicleNotFound_DoesNotAddToUserFavorites()
        {
            // Arrange
            var user = dbContext.Users.First();
            var nonExistingBookId = Guid.NewGuid();

            // Act
            await vehicleService.FavouritesVehicleAsync(nonExistingBookId, user);

            // Assert
            Assert.IsEmpty(dbContext.Favourites);
        }

        [Test]
        public async Task VehicleFavoriteAsync_ReturnsFavoriteVehiclesForUser()
        {
            // Arrange
            var user = dbContext.Users.First();

            // Act
            var result = await vehicleService.VehicleFavouritesAsync(user);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(user.Favourites.Count, result.Count());
        }

        

        [Test]
        public async Task GetVehicleByIdAsync_ReturnsNull_WhenVehicleNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid(); 

            // Act
            var result = await vehicleService.GetVehicleId(nonExistentId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task GetVehicleIsApprovedByIdAsync_ReturnsNull_WhenVehicleNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid(); 

            // Act
            var result = await vehicleService.GetEditIsApproved(nonExistentId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void DeleteVehiclesAsync_ThrowsException_WhenIdNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await vehicleService.DeleteVehicleAdminAsync(nonExistentId));
        }

        [Test]
        public async Task DeleteVehiclesAsync_RemovesAssociatedFavourites()
        {
            // Arrange
            var vehicleId = Guid.Parse("0a1f1c92-f170-481f-a301-46c8f72c9b82");

            // Act
            await vehicleService.DeleteVehicleAdminAsync(vehicleId);

            // Assert
            var brands = await dbContext.Favourites.Where(b => b.VehicleId== vehicleId).ToListAsync();
            Assert.IsEmpty(brands);
        }

        [Test]
        public async Task DeleteVehiclesAsync_ThrowsException_WhenIdIsEmptyGuid()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await vehicleService.DeleteVehicleAdminAsync(emptyGuid));
        }

        [Test]
        public async Task DeleteVehiclesAsync_DoesNotRemoveOtherVehicles()
        {
            // Arrange
            var vehicleId = Guid.Parse("0a1f1c92-f170-481f-a301-46c8f72c9b82");
            var remainingVehicleId = Guid.Parse("2e1506d8-3bf5-44a3-a123-f61b2d8372ba");

            // Act
            await vehicleService.DeleteVehicleAdminAsync(vehicleId);

            // Assert
            var remainingVehicle = await dbContext.Vehicles.FindAsync(remainingVehicleId);
            Assert.IsNotNull(remainingVehicle);
        }

        [Test]
        public async Task DeleteVehiclesAsync_ThrowsException_WhenIdIsInvalid()
        {
            // Arrange
            var invalidId = "InvalidId";

            // Act & Assert
            Assert.ThrowsAsync<FormatException>(async () => await vehicleService.DeleteVehicleAdminAsync(Guid.Parse(invalidId)));
        }

    }
}
