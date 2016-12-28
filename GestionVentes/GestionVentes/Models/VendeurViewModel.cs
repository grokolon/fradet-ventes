using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestionVentes.Models
{
    public class VendeurViewModel
    {
        [Required]
        [Display(Name = "Identifiant")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nom du vendeur")]
        public string Nom { get; set; }
    }

}