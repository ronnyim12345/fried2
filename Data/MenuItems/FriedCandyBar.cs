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
    /// Represents a fried candy bar
    /// </summary>
    public class FriedCandyBar : IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Name of the Fried candy bar
        /// </summary>
        public string Name
        {
            get
            {
                if (CandyBar == CandyBar.Snickers)
                {
                    return "Fried Snickers";
                }
                else if (CandyBar == CandyBar.MilkyWay)
                {
                    return "Fried Milky Way";
                }
                else if (CandyBar == CandyBar.Twix)
                {
                    return "Fried Twix";
                }
                else if (CandyBar == CandyBar.ThreeMusketeers)
                {
                    return "Fried Three Musketeers";
                }
                else if (CandyBar == CandyBar.ButterFingers)
                {
                    return "Fried Butter Fingers";
                }

                return "";

            }
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
        /// instance of candy bar
        /// </summary>
        public CandyBar _candyBar = CandyBar.Snickers;

        /// <summary>
        /// The candy bar of the fried candy bar
        /// </summary>
        public CandyBar CandyBar
        {
            get => _candyBar;
            set
            {
                _candyBar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CandyBar)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }


        /// <summary>
        /// Price of the fried candy bar
        /// </summary>
        public decimal Price
        {
            get
            {
                return 2.50m;
            }
        }


        /// <summary>
        /// Calories of the fried candy bar
        /// </summary>
        public uint Calories
        {
            get
            {
                if (CandyBar == CandyBar.Snickers)
                {
                    return 325;
                }
                else if (CandyBar == CandyBar.MilkyWay)
                {
                    return 213;
                }
                else if (CandyBar == CandyBar.Twix)
                {
                    return 396;
                }
                else if (CandyBar == CandyBar.ThreeMusketeers)
                {
                    return 350;
                }
                else if (CandyBar == CandyBar.ButterFingers)
                {
                    return 385;
                }


                return 0;
            }
        }
    }
}
