using Blogden.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Service.Validations
{
    public class AuthorDtoValidator : AbstractValidator<Author>
    {
        public AuthorDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
