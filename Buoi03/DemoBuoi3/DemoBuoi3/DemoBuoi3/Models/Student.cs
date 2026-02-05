using System.ComponentModel.DataAnnotations;

namespace DemoBuoi3.Models
{
    public class Student
    {
        [RegularExpression(@"\d{2}.01.104.\d{3}")]
        public int Id { get; set; }
        [MinLength(5, ErrorMessage = "Tên phải có ít nhất 5 ký tự")]
        public string Name { get; set; }
        public string Image { get; set; }

        [Range(0, 10, ErrorMessage = "Điểm từ 0 ... 10")]
        public double Score { get; set; }

    }
}
