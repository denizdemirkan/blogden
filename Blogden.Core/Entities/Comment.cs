using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.Entities
{
    public class Comment : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
