using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityMemberConfiguration : IEntityTypeConfiguration<CommunityMember>
    {
        public void Configure(EntityTypeBuilder<CommunityMember> builder)
        {
            builder.HasData(
                new CommunityMember { Id = new Guid("a7e231c7-6a28-4856-94c7-32e0f0860fe9"), CommunityId = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityMember { Id = new Guid("ed904104-fa07-4975-82fe-57679219a269"), CommunityId = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityMember { Id = new Guid("3782e0c5-0090-4484-929c-11bdf47c522e"), CommunityId = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityMember { Id = new Guid("3d9f273c-bfaf-42f6-bd97-f2a4d9c767cf"), CommunityId = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityMember { Id = new Guid("b2b072aa-a986-4feb-854c-72aa01a4f2e0"), CommunityId = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityMember { Id = new Guid("82fc9a4c-2ea2-47b6-97a5-a5f1220543fb"), CommunityId = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityMember { Id = new Guid("caec6866-b558-44a9-aebf-70db6c30cc54"), CommunityId = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityMember { Id = new Guid("6d4928c5-8c4d-48fa-9777-3db1b44e8e01"), CommunityId = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
