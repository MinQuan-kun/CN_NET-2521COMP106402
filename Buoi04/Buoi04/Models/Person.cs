using System.ComponentModel.DataAnnotations;

namespace Buoi04.Models
{
    public class Person
    {
        [Display(Name = "Họ và tên")]
        [MinLength(5, ErrorMessage = "Họ và tên phải có ít nhất 5 ký tự.")]
        public string FullName { get; set; }
        [Display(Name = "Tuổi")]
        [Range(18, 62, ErrorMessage = "Tuổi phải nằm trong khoảng từ 18 đến 62.")]
        public int Age { get; set; }
    }
}
