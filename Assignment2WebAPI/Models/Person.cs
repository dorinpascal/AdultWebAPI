using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required] [StringLength(1000)] public string FirstName { get; set; }
        [Required] [StringLength(1000)] public string LastName { get; set; }
       public string HairColor { get; set; }
         public string EyeColor { get; set; }
        [Range(1,120,ErrorMessage = "Please enter a value bigger than {1} for Age Field")] public int Age { get; set; }
        [Range(1,int.MaxValue,ErrorMessage = "Please enter a value bigger than {1} for Weight Field")]public float Weight { get; set; }

        [Range(1,int.MaxValue,ErrorMessage = "Please enter a value bigger than {1} for Height Field")] public int Height { get; set; }
  

        public string Sex { get; set; }


      
    }
}