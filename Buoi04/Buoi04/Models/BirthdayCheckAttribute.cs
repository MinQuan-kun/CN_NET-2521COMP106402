using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Buoi04.Models
{
    public class BirthdayCheckAttribute : ValidationAttribute
    {
        public BirthdayCheckAttribute() : base("Ngày sinh không hợp lệ") { }
        //public override bool IsValid(object? value)
        //{
        //    if(value is DateTime birthDate)
        //    {
        //        var today = DateTime.Today;
        //        var age = today.Year - birthDate.Year;
        //        if (birthDate > today.AddYears(-age)) age--;
        //        return age >= 18 && age <= 62;
        //    }
        //    return false;
        //}
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // 1 Ngày sinh bắt buộc
            if (value == null)
            {
                return new ValidationResult("Ngày sinh là bắt buộc.");
            }

            // 2. Tuổi > 18
            var bi = (DateTime)value;
            if(DateTime.Now.Year - bi.Year < 18)
            {
                return new ValidationResult("Tuổi phải lớn hơn hoặc bằng 18.");
            }
            if (DateTime.Now.Year - bi.Year > 62)
            {
                return new ValidationResult("Tuổi phải nhỏ hơn hoặc bằng 62.");
            }
            return ValidationResult.Success;
        }
    }
}