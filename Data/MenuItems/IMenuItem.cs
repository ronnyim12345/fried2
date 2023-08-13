using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// Interface for menu items
    /// </summary>
    public interface IMenuItem : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        string Name
        {
            get; 
        }


        /// <summary>
        /// Returns the price of the menu item
        /// </summary>
        decimal Price
        {
            get;
        }


        /// <summary>
        /// Returns the calories of the menu item
        /// </summary>
        uint Calories
        {
            get;
        }







    }
}
