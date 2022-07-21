﻿using Blogden.Core.DTOs;
using Blogden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.Repositories
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        public Task<Author> GetAuthorWithBlogsAsync(int id);
    }
}
