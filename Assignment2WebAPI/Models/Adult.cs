using System.ComponentModel.DataAnnotations;

namespace Models {
    
public class Adult : Person {
    
    public Job JobTitle { get; set; }
}
}