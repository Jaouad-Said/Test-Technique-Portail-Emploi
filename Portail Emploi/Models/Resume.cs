using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portail_Emploi.Models
{
    public class Resume
    {
        [Key]
        public int ID_Resume { get; set; }
        [Required]
        [NotMapped]
        public IFormFile CVurl { get; set; }
        
        //Realtion
        public int ID_Candidat { get; set; }
        [ForeignKey("ID_Candidat")]
        public Candidat Candidats { get; set; }
    }
}
