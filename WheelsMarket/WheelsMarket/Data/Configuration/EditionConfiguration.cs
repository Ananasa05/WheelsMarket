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
                Name = "A4",
                BrandId = Guid.Parse("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("15e67473-da39-433b-8c24-50ae8344a48a"),
                Name = "A6",
                BrandId = Guid.Parse("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8"),
                Name = "S8",
                BrandId = Guid.Parse("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"),
                Name = "RSQ8",
                BrandId = Guid.Parse("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("addca70a-f8e1-4165-9ad6-ead636411b65"),
                Name = "M4",
                BrandId = Guid.Parse("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("1e9ade8f-9650-43cd-9cb9-cf167e53d61e"),
                Name = "M5",
                BrandId = Guid.Parse("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2")
            };
            editions.Add(edition);

            edition = new Edition()
            {
                Id = Guid.Parse("9b5026f5-a2da-4fd1-9d64-adfbd1e1034e"),
                Name = "X6",
                BrandId = Guid.Parse("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2")
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

            return editions;


        }
    }
}
