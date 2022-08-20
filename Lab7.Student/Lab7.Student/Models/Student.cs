using System.ComponentModel.DataAnnotations;

namespace Lab7.Student.Models
{
    public class Students
    {
        [Key]
        public int Student_Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}
        public string Address { get; set; }

        public string Grade { get; set; }
        [StringLength(10)]
        public string Phone_Number { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
       
    }
}
