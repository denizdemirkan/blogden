using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.DTOs
{
    public class BlogWithCommentsDTO : BlogDTO
    {
        public ICollection<CommentDTO> Comments { get; set; }
    }
}
