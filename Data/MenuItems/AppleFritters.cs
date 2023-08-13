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
    /// Represents an apple fritters
    /// </summary>
    public class AppleFritters : Popper, IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Name of the apple fritters 
        /// </summary>
        public override string Name
        {
            get { return $"{Size} Apple Fritters"; }


        }




        /// <summary>
        /// Name for ToString() method
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return Name;
        }





        /// <summary>
        /// Price of the apple fritters
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 3.00m;
                }
                else if (Size == ServingSize.Medium)
                {
                    return 4.00m;
                }
                else if (Size == ServingSize.Large)
                {
                    return 5.00m;
                }

                return 0m;
            }
        }


        /// <summary>
        /// Calories of the apple fritters
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint cal = 0;

                if (Size == ServingSize.Small)
                {
                    cal = 240;
                }
                else if (Size == ServingSize.Medium)
                {
                    cal = 360;
                }
                else if (Size == ServingSize.Large)
                {
                    cal = 480;
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
