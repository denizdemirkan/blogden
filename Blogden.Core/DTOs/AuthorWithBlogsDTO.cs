using Blogden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.DTOs
{
    public class AuthorWithBlogsDTO :  AuthorDTO
    {
        public ICollection<BlogDTO>? Blogs { get; set; }
    }
}
