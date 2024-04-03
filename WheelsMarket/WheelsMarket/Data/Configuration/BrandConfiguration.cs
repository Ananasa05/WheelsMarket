using Microsoft.EntityFrameworkCore;
using WheelsMarket.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace WheelsMarket.Data.Configuration
{
    public class BrandConfiguration:IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(CreateBrand());
        }

        private List<Brand> CreateBrand()
        {
            List<Brand> brands = new List<Brand>();
            Brand brand = new Brand()
            {
                Id = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2"),
                Name = "Alfa Romeo",
                VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};
            brands.Add(brand);

            brand = new Brand()
            {
                Id = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de"),
                Name = "Audi",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};//джип
            brands.Add(brand);

			brand = new Brand()
			{
				Id = Guid.Parse("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0"),
				Name = "Audi",
				VehicleTypeTypeId = Guid.Parse("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49")
			};//Комби
			brands.Add(brand);





			brand = new Brand()
            {
                Id = Guid.Parse("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"),
                Name = "BMW",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};//джип
            brands.Add(brand);

			brand = new Brand()
			{
				Id = Guid.Parse("b53d3c4b-2227-482a-846d-e528bfe4d6f5"),
				Name = "BMW",
				VehicleTypeTypeId = Guid.Parse("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14")
			};//кабрио
			brands.Add(brand);

			brand = new Brand()
			{
				Id = Guid.Parse("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2"),
				Name = "BMW",
				VehicleTypeTypeId = Guid.Parse("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49")
			};//комби
			brands.Add(brand);



			brand = new Brand()
            {
                Id = Guid.Parse("7a0ccdd0-847f-45bc-bf56-baac3fafbd37"),
                Name = "Ferrari",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};
            brands.Add(brand);

            brand = new Brand()
            {
                Id = Guid.Parse("5c20260c-1fe0-4f09-87d1-9fecab63bb93"),
                Name = "Ford",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};
            brands.Add(brand);

            brand = new Brand()
            {
                Id = Guid.Parse("adcf7fdf-46aa-4c40-a38a-61b4047d590f"),
                Name = "Jeep",
				VehicleTypeTypeId = Guid.Parse("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14")
			};//кабрио
            brands.Add(brand);

			brand = new Brand()
			{
				Id = Guid.Parse("c16d7e37-2017-46b1-bf0e-7dce36674ce4"),
				Name = "Jeep",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};//джип
			brands.Add(brand);

			brand = new Brand()
            {
                Id = Guid.Parse("ef196c35-750e-4904-bb67-eb9df6831267"),
                Name = "Lada",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};
            brands.Add(brand);

            brand = new Brand()
            {
                Id = Guid.Parse("6adf767f-a026-4bac-81c7-407a379a745d"),
                Name = "Lexus",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};
            brands.Add(brand);

            brand = new Brand()
            {
                Id = Guid.Parse("a45d4356-b783-4063-af85-ecb0287b682c"),
                Name = "Mercedes-Benz",
				VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
			};
            brands.Add(brand);


            return brands;
        }

    }
}
