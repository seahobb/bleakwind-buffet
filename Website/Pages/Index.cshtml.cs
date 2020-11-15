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
using System.Text;

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

            Items = Menu.All;

            // Filter by search terms
            if (SearchTerms != null)
            {
                var result = new List<IOrderItem>();
                var resultOne = Items;
                var resultTwo = Items;

                if (SearchTerms.ToLowerInvariant().Contains(" "))
                {
                    List<string> searchTermsSplit = new List<string>();
                    StringBuilder sb = new StringBuilder();
                    int count = 0;
                    foreach(char c in SearchTerms)
                    {
                        count++;
                        if (count == SearchTerms.Length)
                        {
                            sb.Append(c);
                            searchTermsSplit.Add(sb.ToString());
                            sb.Clear();
                        }
                        if (c == ' ')
                        {
                            searchTermsSplit.Add(sb.ToString());
                            sb.Clear();
                        }
                        else
                        {
                            if (count != SearchTerms.Length)
                                sb.Append(c);
                        }
                    }

                    var listDescriptions = new List<string>();
                    foreach (var menuItem in Menu.All)
                    {
                        listDescriptions.Add(menuItem.ToString());
                    }


                    var resultOneCopy = Items;
                    var resultTwoCopy = Items;
                    List<IOrderItem> resultOneCopyHolder = new List<IOrderItem>();
                    List<IOrderItem> resultTwoCopyHolder = new List<IOrderItem>();
     
                    foreach(var word in searchTermsSplit)
                    {
                        resultOneCopy = resultOne.Where(item => item.ToString() != null &&
                        item.ToString().ToLowerInvariant().Contains(word.ToLowerInvariant()));

                        resultTwoCopy = resultTwo.Where(item => item.Description != null &&
                        item.Description.ToLowerInvariant().Contains(word.ToLowerInvariant()));

                        foreach (var item in resultOneCopy)
                            resultOneCopyHolder.Add(item);
                        foreach (var item in resultTwoCopy)
                            resultTwoCopyHolder.Add(item);
                        resultOneCopy = Items;
                        resultTwoCopy = Items;
                    }

                    resultOne = resultOneCopyHolder;
                    resultTwo = resultTwoCopyHolder;

                }
                else
                {
                    resultOne = resultOne.Where(item => item.ToString() != null &&
                    item.ToString().ToLowerInvariant().Contains(SearchTerms.ToLowerInvariant()));

                    resultTwo = resultTwo.Where(item => item.Description != null &&
                    item.Description.ToLowerInvariant().Contains(SearchTerms.ToLowerInvariant()));
                }

                
                
                foreach (var item in resultOne) 
                {
                    if (!result.Contains(item)) 
                        result.Add(item); 
                }
                    
                foreach (var item in resultTwo) 
                {
                    if (!result.Contains(item))
                        result.Add(item);
                }
                   

                Items = result;

            }

            // Filter by categories
            if (Categories != null && Categories.Count() != 0)
            {
                var result = new List<IOrderItem>();
                var resultOne = Items;
                var resultTwo = Items;
                var resultThree = Items;
                
                if (Categories.Contains("Entrees"))
                {
                    List<string> strings = new List<string>();
                    foreach (var entree in Menu.Entrees())
                    {
                        strings.Add(entree.ToString());
                    }

                    resultOne = resultOne.Where(item =>
                    item != null && strings.Contains(item.ToString()));
                }

                if (Categories.Contains("Sides"))
                {
                    List<string> strings = new List<string>();
                    foreach (var side in Menu.Sides())
                    {
                        strings.Add(side.ToString());
                    }

                    resultTwo = resultTwo.Where(item =>
                    item != null && strings.Contains(item.ToString()));
                }

                if (Categories.Contains("Drinks"))
                {
                    List<string> strings = new List<string>();
                    foreach (var drink in Menu.Drinks())
                    {
                        strings.Add(drink.ToString());
                    }

                    resultThree = resultThree.Where(item =>
                    item != null && strings.Contains(item.ToString()));
                }
                
                if (Categories.Contains("Entrees"))
                {
                    foreach (var item in resultOne)
                        if (!result.Contains(item))
                            result.Add(item);
                }
                
                if (Categories.Contains("Sides"))
                {
                    foreach (var item in resultTwo)
                        if (!result.Contains(item))
                            result.Add(item);
                }
                
                if (Categories.Contains("Drinks"))
                {
                    foreach (var item in resultThree)
                        if (!result.Contains(item))
                            result.Add(item);
                }
                
                Items = result;
            }

            // Filter by calories
            if (CaloriesMin > 0 && CaloriesMax > 0)
            {
                Items = Items.Where(item =>
                item.Calories >= CaloriesMin &&
                item.Calories <= CaloriesMax);
            }
            else if (CaloriesMin == 0 && CaloriesMax != 0)
            {
                Items = Items.Where(item =>
                item.Calories <= CaloriesMax);
            }
            else if (CaloriesMax == 0 && CaloriesMin != 0)
            {
                Items = Items.Where(item =>
                item.Calories >= CaloriesMin);
            }

            // Filter by price
            if (PriceMin > 0 && PriceMax > 0)
            {
                Items = Items.Where(item =>
                item.Price >= PriceMin &&
                item.Price <= PriceMax);
            }
            else if (PriceMin == 0 && PriceMax != 0)
            {
                Items = Items.Where(item =>
                item.Price <= PriceMax);
            }
            else if (PriceMax == 0 && PriceMin != 0)
            {
                Items = Items.Where(item =>
                item.Price >= PriceMin);
            }

            //Items = Menu.FilterByCategory(Items, Categories);

            /*Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);*/
        }
    }
}
