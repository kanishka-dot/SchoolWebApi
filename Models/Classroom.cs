using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace SchoolWebApi.Models
{
    [PrimaryKey(nameof(ClassroomId))]
    [Index(nameof(ClassroomName), IsUnique = true)]
    public class Classroom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassroomId { get; set; }
        [Required]
        public string ClassroomName { get; set; }
  
        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }

        public List<Teacher>? Teachers { get;}
    }
}
