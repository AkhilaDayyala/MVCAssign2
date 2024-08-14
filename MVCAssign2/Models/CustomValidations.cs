using System;
using System.ComponentModel.DataAnnotations;

namespace MVCAssign2.Models
{
    public class DOBValidations : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int year = Convert.ToDateTime(value).Year;
                if (year >= 2002 && year <= 2005)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "Date of Birth should be between 2002 and 2005.");
        }
    }

    public class DOJValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime? dateTime = (DateTime?)value;
                if (dateTime < DateTime.Now)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "Date of Joining should be earlier than the current date.");
        }
    }

    public class DeptValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string dept = value.ToString();
                if (dept == "HR" || dept == "Accts")
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "Department should be HR or Accts.");
        }
    }


}
