﻿using Microsoft.EntityFrameworkCore;
using SocialBook.Domain.Common;

namespace SocialBook.Application.Repositories.Common
{
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Gets the Entity Framework Core DbSet
        /// </summary>
        DbSet<T> Table { get; }
    }
}