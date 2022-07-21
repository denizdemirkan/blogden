using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Core.DTOs
{
    public class AuthorDTO : BaseEntityDTO, IEntityDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhotoPath { get; set; }
        public string? About { get; set; }
    }
}
