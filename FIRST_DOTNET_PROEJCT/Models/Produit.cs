using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FIRST_DOTNET_PROEJCT.Models
{
    public class Produit

    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Code { get; set; }

       
        public int PrixProduit { get; set; }

        public string Description { get; set; }

        public int categorieId { get; set; }

        public Categorie categorie { get; set; }
    }
}
