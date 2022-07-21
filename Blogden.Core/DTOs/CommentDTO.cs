using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.DTOs
{
    public class CommentDTO : BlogDTO, IEntityDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int BlogId { get; set; }
    }
}
