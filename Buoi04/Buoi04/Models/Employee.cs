using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Buoi04.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "Mã nhân viên")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Mã nhân viên không được vượt quá 20 ký tự.")]
        [Remote(action: "CheckEmployeeNo", controller:"Employee", ErrorMessage = "Mã nhân viên đã tồn tại.")]
        public string EmployeeNo { get; set; }
        [Display(Name = "Họ và tên")]
        [MaxLength(100, ErrorMessage = "Họ tên không vượt quá 100 ký tự" )]
        public string FullName { get; set; }
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; }
        [Url]
        public string website { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [BirthdayCheck]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Giới tính")]
        [Range(0, double.MaxValue, ErrorMessage = "Giới tính phải là 0 (nữ) hoặc 1 (nam).")]
        public bool Gender { get; set; }
        [Display(Name = "Lương")]
        public double Salary { get; set; }
        [Display(Name = "Làm việc bán thời gian")]
        public bool isPartTime { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Số điện thoại")]
        [RegularExpression("^0[35789]\\d{8}$", ErrorMessage = "Số điện thoại phải có 10 chữ số.")]
        public string Phone { get; set; }
        [Display(Name = "Số tài khoản")]
        [CreditCard]
        public string CreditCard { get; set; }
        [Display(Name = "Mô tả")]
        [MaxLength(255, ErrorMessage = "Mô tả không quá 255 ký tự")]
        public string Description { get; set; }

    }
}
