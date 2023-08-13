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
    /// Represents a fried cheesecake
    /// </summary>
    public class FriedCheesecake: Popper, IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Name of the Fried Cheesecake
        /// </summary>
        public override string Name
        {
            get { return $"{Size} Fried Cheesecake"; }
        }



        /// <summary>
        /// Name for ToString() method
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return Name;
        }







        /// <summary>
        /// Price of the fried cheesecake
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
        /// Calories of the fried cheesecake
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint cal = 0;

                if (Size == ServingSize.Small)
                {
                    cal = 310;
                }
                else if (Size == ServingSize.Medium)
                {
                    cal = 425;
                }
                else if (Size == ServingSize.Large)
                {
                    cal = 620;
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
