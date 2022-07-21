using Blogden.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Service.Validations
{
    public class CommentDtoValidator : AbstractValidator<Comment>
    {
        public CommentDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Content).NotEmpty();
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
