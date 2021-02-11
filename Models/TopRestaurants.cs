using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    public class TopRestaurants
    {
        public TopRestaurants(int rank)
        {
            Rank = rank;
        }

        public int? Rank { get; set; }
        public string RestaurantName { get; set; }
        [Required]
        public string FavoriteDish { get; set; }
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string RestaurantPhone { get; set; } // Must be in a phone number format
        [Required]
        public string LinkToWebsite { get; set; } = "Coming soon.";

        public static TopRestaurants[] GetRestaurants()
        {
            TopRestaurants r1 = new TopRestaurants(1)
            {
                Rank = 1,
                RestaurantName = "Wendy's",
                FavoriteDish = "Four for Four",
                Address = "1234 Flavor Town Drive",
                RestaurantPhone = "(555)-555-5555",
                LinkToWebsite = "www.wendys.com"
            };

            TopRestaurants r2 = new TopRestaurants(2)
            {
                Rank = 2,
                RestaurantName = "McDonald's",
                FavoriteDish = "Big Mac",
                Address = "2335 Flavor Town Drive",
                RestaurantPhone = "(555)-555-5555",
                LinkToWebsite = "www.mcdonalds.com"
            };

            TopRestaurants r3 = new TopRestaurants(3)
            {
                Rank = 3,
                RestaurantName = "Arby's",
                //FavoriteDish = "The Meats",
                Address = "5869 Flavor Town Drive",
                RestaurantPhone = "(555)-555-5555",
                //LinkToWebsite = "www.arbys.com"
            };

            TopRestaurants r4 = new TopRestaurants(4)
            {
                Rank = 4,
                RestaurantName = "Taco Bell",
                //FavoriteDish = "Chicken Quesadilla",
                Address = "4985 Flavor Town Drive",
                RestaurantPhone = "(555)-123-6543",
                LinkToWebsite = "www.tacobell.com"
            };
            TopRestaurants r5 = new TopRestaurants(4)
            {
                Rank = 5,
                RestaurantName = "Burger King",
                FavoriteDish = "Whopper",
                Address = "0933 Flavor Town Drive",
                RestaurantPhone = "(555)-555-5555",
                //LinkToWebsite = "www.burgerking.com"
            };

            return new TopRestaurants[] { r1, r2, r3, r4, r5 };
        }







    }
}

//• Rank
//• Restaurant Name
//• Favorite Dish
//• Address
//• Restaurant Phone #
//• Link to Website
