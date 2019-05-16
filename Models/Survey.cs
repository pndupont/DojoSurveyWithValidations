using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;

namespace DOJOSURVEYWITHVALIDATIONS.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2,
        ErrorMessage = "name too short")]
        [Display(Name = "Write your name")]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        
        // [Display(FavStack = "Favorite Stack")]  Not sure why this doesn't work.
        public string FavStack { get; set; }
        [MinLength(20, ErrorMessage = "If you're gonna write something, really write something.")]
        public string Comment { get; set; }

    }
}