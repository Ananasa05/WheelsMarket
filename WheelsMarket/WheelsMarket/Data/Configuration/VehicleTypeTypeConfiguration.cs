using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsMarket.Data.Models;

namespace WheelsMarket.Data.Configuration
{
    public class VehicleTypeTypeConfiguration : IEntityTypeConfiguration<VehicleTypeType>
    {
        public void Configure(EntityTypeBuilder<VehicleTypeType> builder)
        {
            builder.HasData(CreateBrand());
        }

        private List<VehicleTypeType> CreateBrand()
        {
            List<VehicleTypeType> typeTypes = new List<VehicleTypeType>();
            VehicleTypeType typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428"),
                Type = "Ван",
                VehicleTypeSectionId= Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118"),
                Type = "Джип",
                VehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14"),
                Type = "Кабрио",
                VehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49"),
                Type = "Комби",
                VehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("ae578a5d-e436-4458-a851-b0007d9d30bf"),
                Type = "Бордови",
                VehicleTypeSectionId = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("2300898e-6b6f-41fd-a753-02a23634f764"),
                Type = "Самосвал",
                VehicleTypeSectionId = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("c2235044-8910-4cbe-ac12-a5f8ecc0b4d6"),
                Type = "Товарен",
                VehicleTypeSectionId = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("faba9024-217b-45f5-b1d4-45f1036a0995"),
                Type = "Товаропътнически",
                VehicleTypeSectionId = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("31347551-d8ce-48b8-8d73-9338163cd56f"),
                Type = "Кран",
                VehicleTypeSectionId = Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("14690830-faee-4cb9-84ca-8234a0696e8a"),
                Type = "Влекач",
                VehicleTypeSectionId = Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01")

            };
            typeTypes.Add(typeType);

            typeType = new VehicleTypeType()
            {
                Id = Guid.Parse("481e996e-febd-4d6d-a552-df039180948e"),
                Type = "Снегорин",
                VehicleTypeSectionId = Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01")

            };
            typeTypes.Add(typeType);

            return typeTypes;
        }
    }
}
