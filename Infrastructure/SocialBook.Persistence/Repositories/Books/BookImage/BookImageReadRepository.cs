﻿using SocialBook.Application.Repositories.Books;
using SocialBook.Domain.Entities.Books;
using SocialBook.Persistence.Contexts;
using SocialBook.Persistence.Repositories.Common;

namespace SocialBook.Persistence.Repositories.Books
{
    public class BookImageReadRepository : ReadRepository<BookImage>, IBookImageReadRepository
    {
        public BookImageReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}