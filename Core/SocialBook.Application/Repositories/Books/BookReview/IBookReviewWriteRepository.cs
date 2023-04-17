﻿using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Entities.Books;

namespace SocialBook.Application.Repositories.Books
{
    public interface IBookReviewWriteRepository : IWriteRepository<BookReview>
    {
    }
}
