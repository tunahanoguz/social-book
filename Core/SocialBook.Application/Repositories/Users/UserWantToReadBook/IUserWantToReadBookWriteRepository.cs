﻿using SocialBook.Application.Repositories.Common;
using SocialBook.Domain.Users;

namespace SocialBook.Application.Repositories.Users
{
    public interface IUserWantToReadBookWriteRepository : IWriteRepository<UserWantToReadBook>
    {
    }
}