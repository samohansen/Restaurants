using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    // Creates a list to store our responses
    public static class TempStorage
    {
        private static List<SuggestionResponse> suggestions = new List<SuggestionResponse>();

        public static IEnumerable<SuggestionResponse> Suggestions => suggestions;

        public static void AddApplication(SuggestionResponse suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
