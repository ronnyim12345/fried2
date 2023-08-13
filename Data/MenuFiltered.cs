using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.Data
{
    /// <summary>
    /// Menu class for the website
    /// </summary>
    public class MenuFiltered
    {

        // SEARCH

        /// <summary>
        /// Search treats
        /// </summary>
        /// <param name="s">terms</param>
        /// <param name="cal_low">cal low</param>
        /// <param name="cal_high">cal high</param>
        /// <param name="price_low">price low</param>
        /// <param name="price_high">price high</param>
        public void SearchTreats(string s, uint cal_low, uint cal_high, decimal price_low, decimal price_high)
        {
            string[] sub = new string[10];


            if (s != null)
            {
                sub = s.Split(' ');
            }


            foreach (IMenuItem item in Menu.Treats)
            {
                if (s == null)
                {
                    if (item.Price <= price_high && item.Price >= price_low && item.Calories <= cal_high && item.Calories >= cal_low)
                    {
                        _treats.Add(item);

                    }

                }
                else
                {
                    for (int i = 0; i < sub.Count(); i++)
                    {

                        if (item.Name.Contains(sub[i], StringComparison.CurrentCultureIgnoreCase)
                        && item.Price <= price_high && item.Price >= price_low && item.Calories <= cal_high && item.Calories >= cal_low)
                        {
                            _treats.Add(item);
                            break;

                        }
                    }
                }
            }
        }





        /// <summary>
        /// Search poppers
        /// </summary>
        /// <param name="s">terms</param>
        /// <param name="cal_low">cal low</param>
        /// <param name="cal_high">cal high</param>
        /// <param name="price_low">price low</param>
        /// <param name="price_high">price high</param>
        public void SearchPoppers(string s, uint cal_low, uint cal_high, decimal price_low, decimal price_high)
        {
            string[] sub = new string[10];


            if (s != null)
            {
                sub = s.Split(' ');
            }


            foreach (IMenuItem item in Menu.Poppers)
            {
                if (s == null)
                {
                    if (item.Price <= price_high && item.Price >= price_low && item.Calories <= cal_high && item.Calories >= cal_low)
                    {
                        _poppers.Add(item);

                    }

                }
                else
                {
                    for (int i = 0; i < sub.Count(); i++)
                    {

                        if (item.Name.Contains(sub[i], StringComparison.CurrentCultureIgnoreCase)
                        && item.Price <= price_high && item.Price >= price_low && item.Calories <= cal_high && item.Calories >= cal_low)
                        {
                            _poppers.Add(item);
                            break;

                        }
                    }
                }
            }



        }






        /// <summary>
        /// Search Platters
        /// </summary>
        /// <param name="s">terms</param>
        /// <param name="cal_low">cal low</param>
        /// <param name="cal_high">cal high</param>
        /// <param name="price_low">price low</param>
        /// <param name="price_high">price high</param>
        public void SearchPlatters(string s, uint cal_low, uint cal_high, decimal price_low, decimal price_high)
        {

            string[] sub = new string[10];


            if (s != null)
            {
                sub = s.Split(' ');
            }


            foreach (IMenuItem item in Menu.Platters)
            {
                if (s == null)
                {
                    if (item.Price <= price_high && item.Price >= price_low && item.Calories <= cal_high && item.Calories >= cal_low)
                    {
                        if (item is PopperPlatter pop)
                        {
                            _platters.Add(item);
                        }
                        else if (item is PiperPlatter pip)
                        {
                            _platters.Add(item);
                        }

                    }

                }
                else
                {
                    for (int i = 0; i < sub.Count(); i++)
                    {

                        if (item.Name.Contains(sub[i], StringComparison.CurrentCultureIgnoreCase)
                        && item.Price <= price_high && item.Price >= price_low && item.Calories <= cal_high && item.Calories >= cal_low)
                        {
                            if (item is PopperPlatter pop)
                            {
                                _platters.Add(item);
                            }
                            else if (item is PiperPlatter pip)
                            {
                                _platters.Add(item);
                            }
                            break;

                        }
                    }
                }
            }


        }








        // TREATS:


        /// <summary>
        /// List of treats
        /// </summary>
        private List<IMenuItem> _treats = new List<IMenuItem>();



        /// <summary>
        /// Gets all the treats
        /// </summary>
        public IEnumerable<IMenuItem> Treats { get { return _treats; } }





        // POPPERS:


        /// <summary>
        /// List of poppers
        /// </summary>
        private List<IMenuItem> _poppers = new List<IMenuItem>();



        /// <summary>
        /// Gets all the poppers
        /// </summary>
        public IEnumerable<IMenuItem> Poppers { get { return _poppers; } }





        // PLATTERS:


        /// <summary>
        /// List of platters
        /// </summary>
        private List<IMenuItem> _platters = new List<IMenuItem>();



        /// <summary>
        /// Gets all the platters
        /// </summary>
        public IEnumerable<IMenuItem> Platters { get { return _platters; } }











        /// <summary>
        /// Constructor
        /// </summary>
        public MenuFiltered()
        {
            

        }






    }
}
