using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WheelsMarket.Data.Models;

namespace WheelsMarket.Data.Configuration
{
    public class EditionConfiguration : IEntityTypeConfiguration<Edition>
    {
        public void Configure(EntityTypeBuilder<Edition> builder)
        {
            builder.HasData(CreateEdition());
        }

        private List<Edition>CreateEdition()
        {
            List<Edition> editions = new List<Edition>();
            Edition edition = new Edition()
            {
                Id = Guid.Parse("a5c1ff08-a57c-49b7-80a9-7d5804e1b4ef"),
                Name = "GT",
                BrandId = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("05109622-9b86-40c7-8b2b-89bafa09fc21"),
                Name = "Spider",
                BrandId = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2")
            };
            editions.Add(edition);



            edition = new Edition()
            {
                Id = Guid.Parse("94187284-2cdf-4d3c-8ae3-47c266122a26"),
                Name = "А4 Allroad",
                BrandId = Guid.Parse("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0")
            };//
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("15e67473-da39-433b-8c24-50ae8344a48a"),
                Name = "RS 6",
                BrandId = Guid.Parse("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0")
            };//
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8"),
                Name = "Q7",
                BrandId = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de")
            };//
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"),
                Name = "RSQ8",
                BrandId = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de")
            };//
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("addca70a-f8e1-4165-9ad6-ead636411b65"),
                Name = "M3 Touring",
                BrandId = Guid.Parse("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("1e9ade8f-9650-43cd-9cb9-cf167e53d61e"),
                Name = "i5 Touring",
                BrandId = Guid.Parse("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("9b5026f5-a2da-4fd1-9d64-adfbd1e1034e"),
                Name = "X6",
                BrandId = Guid.Parse("da6e5a3a-79c5-4ffb-926d-b1fb055688c1")
            };
            editions.Add(edition);

			edition = new Edition()
			{
				Id = Guid.Parse("aa7212f8-75b8-474a-91e2-dda3bc404caf"),
				Name = "X5",
				BrandId = Guid.Parse("da6e5a3a-79c5-4ffb-926d-b1fb055688c1")
			};
			editions.Add(edition);

			edition = new Edition()
			{
				Id = Guid.Parse("22656d2b-e20e-48d9-bee0-dd5e0c661dc3"),
				Name = "430i Convertible",
				BrandId = Guid.Parse("b53d3c4b-2227-482a-846d-e528bfe4d6f5")
			};
			editions.Add(edition);

			edition = new Edition()
			{
				Id = Guid.Parse("c65b36c2-2eae-4908-83c0-3d0f2f773e6c"),
				Name = "M3 Convertible",
				BrandId = Guid.Parse("b53d3c4b-2227-482a-846d-e528bfe4d6f5")
			};
			editions.Add(edition);

			edition = new Edition()
            {
                Id = Guid.Parse("a0eac45a-9df8-4307-9ecf-f9301e76bf02"),
                Name = "F12",
                BrandId = Guid.Parse("7a0ccdd0-847f-45bc-bf56-baac3fafbd37")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("de5f924e-3139-4025-9156-929beed960b7"),
                Name = "Enzo",
                BrandId = Guid.Parse("7a0ccdd0-847f-45bc-bf56-baac3fafbd37")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("be74fb89-0291-475c-9995-1982714d8b4d"),
                Name = "Focus",
                BrandId = Guid.Parse("5c20260c-1fe0-4f09-87d1-9fecab63bb93")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("de1bafe4-18a6-404c-bef6-734f8bedd697"),
                Name = "Fiesta",
                BrandId = Guid.Parse("5c20260c-1fe0-4f09-87d1-9fecab63bb93")
            };
            editions.Add(edition);



            edition = new Edition()
            {
                Id = Guid.Parse("71545e27-d6f3-41c6-ad01-d422b733c252"),
                Name = "Jeep Grand Cherokee",
                BrandId = Guid.Parse("c16d7e37-2017-46b1-bf0e-7dce36674ce4")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("30160a51-800f-4e7f-88b0-6ba7cd352190"),
                Name = "Avenger",
                BrandId = Guid.Parse("c16d7e37-2017-46b1-bf0e-7dce36674ce4")
            };
            editions.Add(edition);

			edition = new Edition()
			{
				Id = Guid.Parse("236ebe94-b13a-423a-97f4-9caed0519b90"),
				Name = "Wrangler",
				BrandId = Guid.Parse("adcf7fdf-46aa-4c40-a38a-61b4047d590f")
			};
			editions.Add(edition);

			return editions;


        }
    }
}
