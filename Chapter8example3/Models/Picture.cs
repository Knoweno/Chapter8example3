using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chapter8example3.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        [Required]
        public string AltAttribute { get; set; }
        [NotMapped]
        public IFormFile MyPicture { get; set; }
        [Display(Name ="Enter a Desciption:")]
        public string Description {  get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }

    }
}
