using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FIRST_DOTNET_PROEJCT.Models
{
    public class Categorie
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
   
        public string OrdreAffichage { get; set; }

    }
}
