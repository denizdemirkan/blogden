using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.Entities
{
    public class Author : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhotoPath { get; set; }
        public string? About { get; set; }

        public ICollection<Blog>? Blogs { get; set; }
    }
}
