using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models
{
    [PrimaryKey(nameof(TeacherId))]
    [Index(nameof(TeacherFirstName), nameof(TeacherLastName), IsUnique = true)] // avoid duplicate names
    public class Teacher
    {

        public int TeacherId { get; set; }
        [Required]
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string Email { get; set; }

        public ICollection<Subject>? Subject { get; }

    }
}
