﻿using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Common;
using SocialBook.Persistence.Contexts;

namespace SocialBook.Persistence.Repositories.Common
{
    public class GenreReadRepository : ReadRepository<Genre>, IGenreReadRepository
    {
        public GenreReadRepository(SocialBookAPIDbContext context) : base(context)
        {
        }
    }
}
