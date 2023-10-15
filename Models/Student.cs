using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models
{
    [PrimaryKey(nameof(StudentId))]
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "Date")]
        public DateTime StudentDob { get; set; }
       
        [ForeignKey("Classroom")]
        public int ClassroomId { get; set; }

        public Classroom? Classroom { get; }
    }
}
