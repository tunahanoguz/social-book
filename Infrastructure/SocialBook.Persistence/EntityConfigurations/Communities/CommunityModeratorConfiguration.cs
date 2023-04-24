using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityModeratorConfiguration : IEntityTypeConfiguration<CommunityModerator>
    {
        public void Configure(EntityTypeBuilder<CommunityModerator> builder)
        {
            builder.HasData(
                new CommunityModerator { Id = new Guid("f9bdb36e-39cc-4dfd-ae7f-7a9ab4cace6c"), CommunityId = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityModerator { Id = new Guid("37e00050-2b58-458c-95db-d40a43cab9b9"), CommunityId = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityModerator { Id = new Guid("d9247cb7-dd6d-4869-a3a5-b9fdbd093af3"), CommunityId = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityModerator { Id = new Guid("91a7a0d6-d4d6-4770-accc-1e72ab0e040f"), CommunityId = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityModerator { Id = new Guid("c1463b4c-74a8-4478-94ed-3c37dec91184"), CommunityId = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityModerator { Id = new Guid("7fc3ac04-6250-4791-a6e8-7bf7ff8f572a"), CommunityId = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityModerator { Id = new Guid("bc5ab8e2-63e1-4123-b9c9-80b8614385ce"), CommunityId = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityModerator { Id = new Guid("8d18b441-2b18-444b-aba5-7cd51abe0ab8"), CommunityId = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
