using EZero.Infrastructure.Runtime.Validation;
using EZero.Infrastructure.Services.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EZero.Application.Dto.Request.Auth
{
    [ModelValidationFilter]
    public class LoginRequest: IValidatableObject, ICustomValidate
    {
        [Required]
        [StringLength(16)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        public string ReturnUrl{ get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {

        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Password.Length < 6)
            {
                yield return new ValidationResult("123456");
            }
        }


    }
}
