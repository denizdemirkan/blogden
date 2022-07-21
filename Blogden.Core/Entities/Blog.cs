using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.Entities
{
    public class Blog : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? CoverPhotoPath { get; set; }
        public int LikeCount { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
