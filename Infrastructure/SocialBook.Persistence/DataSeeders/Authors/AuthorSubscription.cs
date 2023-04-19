﻿using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Entities.Authors;

namespace SocialBook.Persistence.DataSeeders
{
    public static partial class DataSeeder
    {
        private static AuthorSubscription[] AuthorSubscriptions => new AuthorSubscription[]
        {
            new AuthorSubscription { Id = new Guid(), Author = Authors[0], User = Users[2] },
            new AuthorSubscription { Id = new Guid(), Author = Authors[1], User = Users[2] }
        };

        public static void SeedAuthorSubscriptions(this ModelBuilder builder)
        {
            builder.Entity<AuthorSubscription>().HasData(AuthorSubscriptions);
        }
    }
}
