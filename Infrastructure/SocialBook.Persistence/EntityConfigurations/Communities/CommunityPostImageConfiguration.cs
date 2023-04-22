using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityPostImageConfiguration : IEntityTypeConfiguration<CommunityPostImage>
    {
        public void Configure(EntityTypeBuilder<CommunityPostImage> builder)
        {
            builder.HasData(
                new CommunityPostImage { Id = new Guid("6e1106bb-ec63-40c2-8061-961b06c30f81"), FileName = "community-post-image-1", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("95fdab59-cd2e-412d-9358-31a3c2f63461") },
                new CommunityPostImage { Id = new Guid("e375c1d7-f815-4174-b269-18958b330e1d"), FileName = "community-post-image-2", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("27e480c1-d49a-4e67-996c-1410ad424758") },
                new CommunityPostImage { Id = new Guid("fb9429c1-4564-410d-a450-3ea6f14639c7"), FileName = "community-post-image-3", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("3e0e1e1c-fbb1-4b3b-9796-731d07995cdb") },
                new CommunityPostImage { Id = new Guid("8d07ba22-fd4f-4c17-a0c3-a100a1104b1d"), FileName = "community-post-image-4", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("7ad1ed68-7552-40bb-b369-b54fa93131d0") },
                new CommunityPostImage { Id = new Guid("3ed2a280-f246-4a40-9b89-43db28812980"), FileName = "community-post-image-5", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("d3132383-9763-427a-9079-fd57b46fbf56") },
                new CommunityPostImage { Id = new Guid("1d89ce26-d294-4dc5-9d9c-406039c0d949"), FileName = "community-post-image-6", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("e0d803e5-d394-4eaf-b203-9d0a88e92619") },
                new CommunityPostImage { Id = new Guid("d4df3e7d-e0ff-4622-badb-1fc557cfbda3"), FileName = "community-post-image-7", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("0e270ba7-af85-4f84-8afb-6543009e1cc8") },
                new CommunityPostImage { Id = new Guid("9f6b798a-e979-49f0-a2b5-09631faf1eca"), FileName = "community-post-image-8", FileExtension = "png", FileSize = 10, CommunityPostId = new Guid("1806e788-ec19-42d5-9cc7-7019652bcfa1") }
            );
        }
    }
}
