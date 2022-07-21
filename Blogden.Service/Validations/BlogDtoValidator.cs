using Blogden.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Service.Validations
{
    public class BlogDtoValidator : AbstractValidator<Blog>
    {
        public BlogDtoValidator()
        {
            RuleFor(x => x.Author).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Content).NotEmpty();
        }
    }
}
