/*
 * Author: Ethan Wheeler
 * Class name: Index.cshtml.cs
 * Purpose: Codebehind for Index.cshtml page
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    /// <summary>
    /// Index page that inherits from PageModel
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Private backing variable for ILogger
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Constructs a new IndexModel instance and initializes ILogger
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The menu items to display on the index page
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Could contain entree, drink, or side
        /// </summary>
        public string[] Categories { get; set; }

        /// <summary>
        /// Minimum calories
        /// </summary>
        public int CaloriesMin { get; set; }

        /// <summary>
        /// Maximum calories
        /// </summary>
        public int CaloriesMax { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        public int PriceMin { get; set; }

        /// <summary>
        /// Maximum price
        /// </summary>
        public int PriceMax { get; set; }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];

            try
            {
                CaloriesMin = int.Parse(Request.Query["CaloriesMin"]);
            }
            catch
            {
                CaloriesMin = 0;
            }

            try
            {
                CaloriesMax = int.Parse(Request.Query["CaloriesMax"]);
            }
            catch
            {
                CaloriesMax = 0;
            }

            try
            {
                PriceMin = int.Parse(Request.Query["PriceMin"]);
            }
            catch
            {
                PriceMin = 0;
            }

            try
            {
                PriceMax = int.Parse(Request.Query["PriceMax"]);
            }
            catch
            {
                PriceMax = 0;
            }

            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
