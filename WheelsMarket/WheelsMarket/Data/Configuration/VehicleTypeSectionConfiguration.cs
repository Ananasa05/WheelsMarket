using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsMarket.Data.Models;

namespace WheelsMarket.Data.Configuration
{
    public class VehicleTypeSectionConfiguration:IEntityTypeConfiguration<VehicleTypeSection>
    {
        public void Configure(EntityTypeBuilder<VehicleTypeSection> builder)
        {
            builder.HasData(CreateBrand());
        }

        private List<VehicleTypeSection> CreateBrand()
        {
            List<VehicleTypeSection> typeSections = new List<VehicleTypeSection>();
            VehicleTypeSection typeSection = new VehicleTypeSection()
            {
                Id = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428"),
                Section = "Автомобили и джипове"
            };
            typeSections.Add(typeSection);

            typeSection = new VehicleTypeSection()
            {
                Id = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118"),
                Section = "Бусове"
            };
            typeSections.Add(typeSection);

            typeSection = new VehicleTypeSection()
            {
                Id = Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01"),
                Section = "Камиони"
            };
            typeSections.Add(typeSection);

            return typeSections;
        }
    }
}
