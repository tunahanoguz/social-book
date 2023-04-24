using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityConfiguration : IEntityTypeConfiguration<Community>
    {
        public void Configure(EntityTypeBuilder<Community> builder)
        {
            builder.HasData(
                new Community { Id = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), Name = "Community 1", Description = "Community 1 description.", OwnerUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", ProfileImageId = new Guid("b477d72f-1f05-411c-8448-515e91dd75d8"), CoverImageId = new Guid("6e05c37a-c4da-4dd7-95d8-d78fc7bdd436"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Community { Id = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), Name = "Community 2", Description = "Community 2 description.", OwnerUserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", ProfileImageId = new Guid("0e7ed195-1fb5-4a4a-94c9-36a421d52deb"), CoverImageId = new Guid("4b83ca08-b55c-4581-84d0-6daeeca8929a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Community { Id = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), Name = "Community 3", Description = "Community 3 description.", OwnerUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", ProfileImageId = new Guid("1309047f-eac7-4a9c-b731-b4379e01ddbe"), CoverImageId = new Guid("9b52fb7d-99e3-49a1-8681-bc43a704e17e"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Community { Id = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), Name = "Community 4", Description = "Community 4 description.", OwnerUserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", ProfileImageId = new Guid("669d1738-5abc-4d85-bf4d-3612975b8c75"), CoverImageId = new Guid("3550912e-f963-42f2-bdeb-f3f89736e67a"), CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
