using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// Represents a fried twinkie
    /// </summary>
    public class FriedTwinkie : IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;



        /// <summary>
        /// Name of the Fried twinkie
        /// </summary>
        public string Name
        {
            get { return "Fried Twinkie"; } 
        }









        /// <summary>
        /// name for tostring method
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return Name;
        }








        /// <summary>
        /// Price of the fried twinkie
        /// </summary>
        public decimal Price
        {
            get
            {
                return 2.25m;
            }
        }


        /// <summary>
        /// Calories of the fried twinkie
        /// </summary>
        public uint Calories
        {
            get
            {
                return 420;
            }
        }
    }
}
