using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{    public class Actor
    {
        [Key]
        public int Id { get; set; }

       
        [Display(Name ="Profile Pic")]
        [Required(ErrorMessage = "Pic needed")]
        public string ProfilePictureURL { get; set; }
       
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name needed")]
        public string FullName { get; set; }
       
        [Display(Name = "Biography")]
        [StringLength(50,MinimumLength=3,ErrorMessage ="length between 3 and 5 chars")]
        [Required(ErrorMessage = "Bio  needed")]
        public string Bio { get; set; }
        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }    
        
    }
}
