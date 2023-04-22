using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityPostCommentConfiguration : IEntityTypeConfiguration<CommunityPostComment>
    {
        public void Configure(EntityTypeBuilder<CommunityPostComment> builder)
        {
            builder.HasData(
                new CommunityPostComment { Id = new Guid("8743e248-4a73-4669-84e8-c366a87e0370"), Body = "Community post comment body.", CommunityPostId = new Guid("95fdab59-cd2e-412d-9358-31a3c2f63461"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new CommunityPostComment { Id = new Guid("190fee70-14a5-418d-8bce-3bf9c27a9d91"), Body = "Community post comment body.", CommunityPostId = new Guid("27e480c1-d49a-4e67-996c-1410ad424758"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new CommunityPostComment { Id = new Guid("4f36a23d-df41-4519-b0b1-4312f34da98c"), Body = "Community post comment body.", CommunityPostId = new Guid("3e0e1e1c-fbb1-4b3b-9796-731d07995cdb"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new CommunityPostComment { Id = new Guid("f47d93bf-e256-44e1-a7f1-815d9b9f78df"), Body = "Community post comment body.", CommunityPostId = new Guid("7ad1ed68-7552-40bb-b369-b54fa93131d0"), UserId = "5088a487-2384-4eb6-ac10-eac5d24ee1d1" },
                new CommunityPostComment { Id = new Guid("565171d5-f12f-4598-9444-681076032301"), Body = "Community post comment body.", CommunityPostId = new Guid("d3132383-9763-427a-9079-fd57b46fbf56"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new CommunityPostComment { Id = new Guid("45bb9ccc-912e-4c6d-9a99-83ec7629916c"), Body = "Community post comment body.", CommunityPostId = new Guid("e0d803e5-d394-4eaf-b203-9d0a88e92619"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new CommunityPostComment { Id = new Guid("cb93a714-504d-40d2-816f-fd5a1a17da3c"), Body = "Community post comment body.", CommunityPostId = new Guid("0e270ba7-af85-4f84-8afb-6543009e1cc8"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" },
                new CommunityPostComment { Id = new Guid("66e8ad10-d833-459f-818e-29fbf306a2ec"), Body = "Community post comment body.", CommunityPostId = new Guid("1806e788-ec19-42d5-9cc7-7019652bcfa1"), UserId = "92088e43-474e-4bd6-9dbe-cfc5293e885f" }
            );
        }
    }
}
