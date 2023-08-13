using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FriedPiper.Data;
using FriedPiper.Data.MenuItems;
using System.Linq;

namespace FriedPiperWebsite.Pages
{
    /// <summary>
    /// the back code
    /// </summary>
    public class IndexModel : PageModel
    {
        /*
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }


        */




        /// <summary>
        /// Search terms
        /// </summary>
        public string SearchTerms { get; set; }


        /// <summary>
        /// min price
        /// </summary>
        public decimal PriceMin { get; set; }



        /// <summary>
        /// max price
        /// </summary>
        public decimal PriceMax { get; set; }



        /// <summary>
        /// min cal
        /// </summary>
        public uint CaloriesMin { get; set; }


        /// <summary>
        /// max cal
        /// </summary>
        public uint CaloriesMax { get; set; }



        /// <summary>
        /// check boxes property
        /// </summary>
        public string[] Checked {get; set;}



        /// <summary>
        /// splits searchterms
        /// </summary>
        public string[] EachWord;



        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        /// <param name="SearchTerms">search</param>
        /// <param name="PriceMin">price min</param>
        /// <param name="PriceMax">price max</param>
        /// <param name="CaloriesMin">calories min</param>
        /// <param name="CaloriesMax">calorie max</param>
        public void OnGet(string SearchTerms, decimal PriceMin, decimal PriceMax, uint CaloriesMin, uint CaloriesMax, string[] Checked)
        {

            if (PriceMax == 0)
            {
                PriceMax = 100;
            }

            if (CaloriesMax == 0)
            {
                CaloriesMax = 5000;
            }








            this.SearchTerms = SearchTerms;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;




            this.Checked = Checked;


            if (SearchTerms != null)
            {
                EachWord = SearchTerms.Split(' ');

            }




        }









    }
}