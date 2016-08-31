using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sisrii.Models
{
    public class CountryModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}