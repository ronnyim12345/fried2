using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriedPiper.Data.Enums;
using System.ComponentModel;

namespace FriedPiper.Data.MenuItems
{
    /// <summary>
    /// Represents a fried bananas
    /// </summary>
    public class FriedBananas : Popper, IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Name of the Fried bananas
        /// </summary>
        public override string Name
        {
            get { return $"{Size} Fried Bananas"; }
        }






        /// <summary>
        /// Name of ToString() method
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return Name;
        }









        /// <summary>
        /// Price of the fried bananas
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 3.75m;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 4.50m;
                }
                else if (Size == ServingSize.Large)
                {
                    return 5.25m;
                }

                return 0m;
            }
        }


        /// <summary>
        /// Calories of the fried bananas
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint cal = 0;

                if (Size == ServingSize.Small)
                {
                    cal = 160;
                }
                else if (Size == ServingSize.Medium)
                {
                    cal = 240;
                }
                else if (Size == ServingSize.Large)
                {
                    cal = 320;
                }


                if (Glazed)
                {
                    cal += 130;
                }


                return cal;
            }
        }






    }
}
