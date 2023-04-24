using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialBook.Domain.Entities.Communities;

namespace SocialBook.Persistence.EntityConfigurations.Communities
{
    public class CommunityGenreConfiguration : IEntityTypeConfiguration<CommunityGenre>
    {
        public void Configure(EntityTypeBuilder<CommunityGenre> builder)
        {
            builder.HasData(
                new CommunityGenre { Id = new Guid("4cd330fc-4cb6-4f88-8d11-2fcf2ad64c51"), CommunityId = new Guid("450e3b5d-60d7-4fd8-8b28-7f5215662b01"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityGenre { Id = new Guid("ae83a1e3-3e8e-42aa-9c9c-bfba97e831c6"), CommunityId = new Guid("458c07f9-1061-4fb6-9a10-d90c1236079d"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityGenre { Id = new Guid("6f6f8c2e-f74d-4004-b6d1-a884244d5484"), CommunityId = new Guid("743b1f89-7609-4e21-9837-e470b4c12817"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new CommunityGenre { Id = new Guid("37e166bd-20e4-4f13-9e1e-9d99e2f51dc5"), CommunityId = new Guid("828ec0ff-947c-4c9a-841f-b420f7e1b876"), GenreId = new Guid("c0385818-0ea3-4e64-aede-00a6ac1d4f7a"), CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
