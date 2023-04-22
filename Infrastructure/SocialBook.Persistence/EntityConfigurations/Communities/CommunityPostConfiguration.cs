using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityPostConfiguration : IEntityTypeConfiguration<CommunityPost>
    {
        public void Configure(EntityTypeBuilder<CommunityPost> builder)
        {
            builder.HasData(
                new CommunityPost { Id = new Guid("95fdab59-cd2e-412d-9358-31a3c2f63461"), Title = "Community Post 1", Body = "Community Post 1 body.", CommunityId = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new CommunityPost { Id = new Guid("27e480c1-d49a-4e67-996c-1410ad424758"), Title = "Community Post 2", Body = "Community Post 2 body.", CommunityId = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new CommunityPost { Id = new Guid("3e0e1e1c-fbb1-4b3b-9796-731d07995cdb"), Title = "Community Post 3", Body = "Community Post 3 body.", CommunityId = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new CommunityPost { Id = new Guid("7ad1ed68-7552-40bb-b369-b54fa93131d0"), Title = "Community Post 4", Body = "Community Post 4 body.", CommunityId = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new CommunityPost { Id = new Guid("d3132383-9763-427a-9079-fd57b46fbf56"), Title = "Community Post 5", Body = "Community Post 5 body.", CommunityId = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new CommunityPost { Id = new Guid("e0d803e5-d394-4eaf-b203-9d0a88e92619"), Title = "Community Post 6", Body = "Community Post 6 body.", CommunityId = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new CommunityPost { Id = new Guid("0e270ba7-af85-4f84-8afb-6543009e1cc8"), Title = "Community Post 7", Body = "Community Post 7 body.", CommunityId = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new CommunityPost { Id = new Guid("1806e788-ec19-42d5-9cc7-7019652bcfa1"), Title = "Community Post 8", Body = "Community Post 8 body.", CommunityId = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" }
            );
        }
    }
}
