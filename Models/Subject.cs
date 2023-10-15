using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models
{
    [PrimaryKey(nameof(SubjectId))]
    [Index(nameof(SubjectName), IsUnique = true)]
    public class Subject
    {
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }

        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }

    }
}
