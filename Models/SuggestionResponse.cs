using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Models
{
    public class SuggestionResponse
    {
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }
        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Enter a phone number as the following: ###-###-####")] // valid format (using Regex)
        public string RestaurantPhone { get; set; } 
    }
}

