using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;
using WheelsMarket.Services.Vehicles;
using static Testing.DataBaseSeeder;

namespace Testing
{
    [TestFixture]

    public class VehicleServiceTests
    {
        //private DbContextOptions<WheelsMarketDbContext> dbOptions;
        //private WheelsMarketDbContext dbContext;
        //private IVehicleService vehicleService;


        //[SetUp]
        //public void SetUp()
        //{
        //    this.dbOptions = new DbContextOptionsBuilder<WheelsMarketDbContext>()
        //            .UseInMemoryDatabase("WheelsMarketInMemoryDb" + Guid.NewGuid().ToString())
        //            .Options;

        //    this.dbContext = new WheelsMarketDbContext(this.dbOptions, false);
        //    this.dbContext.Database.EnsureCreated();
        //    SeedDatabase(this.dbContext);


        //    this.vehicleService = new VehicleService(dbContext);

        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    dbContext.Database.EnsureDeleted();
        //}

        //[Test]

        //public async Task DeleteVehicleAdminAsync_ValidId_DeletesVehicle()

        //{

        //    // Arrange

        //    var service = new VehicleService(/* initialize context here */);

        //    var vehicleId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6");


        //    // Act

        //    await service.DeleteVehicleAdminAsync(vehicleId);


        //    // Assert

        //    var vehicle = await /* context.Vehicles.FindAsync(vehicleId) */;

        //    Assert.IsNull(vehicle);

        //}


        //[Test]

        //public async Task DeleteVehicleAdminAsync_InvalidId_ThrowsArgumentNullException()

        //{

        //    // Arrange

        //    var service = new VehicleService(/* initialize context here */);

        //    var vehicleId = Guid.NewGuid();


        //    // Act & Assert

        //    await Assert.ThrowsAsync<ArgumentNullException>(() => service.DeleteVehicleAdminAsync(vehicleId));

        //}


        //[Test]

        //public async Task DeleteVehicleAdminAsync_SeededData_DeletesVehicle()

        //{

        //    // Arrange

        //    var service = new VehicleService(/* initialize context here */);


        //    // Act

        //    await service.DeleteVehicleAdminAsync(Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"));


        //    // Assert

        //    var vehicle = await /* context.Vehicles.FindAsync(Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6")) */;

        //    Assert.IsNull(vehicle);

        //}

    }
}
