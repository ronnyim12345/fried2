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
    /// Represents a fried pie
    /// </summary>
    public class FriedPie : IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Name of the Fried Pie
        /// </summary>
        public string Name
        {
            get { return $"Fried {Flavor} Pie"; }
        }





        /// <summary>
        /// Name for tostring method
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return Name;
        }








        /// <summary>
        /// flavor instance
        /// </summary>
        public PieFilling _flavor = PieFilling.Cherry;

        /// <summary>
        /// The filling of the pie
        /// </summary>
        public PieFilling Flavor
        {
            get => _flavor;
            set
            {
                _flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Flavor)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));


            }
        }


        /// <summary>
        /// Price of the fried pie
        /// </summary>
        public decimal Price 
        {
            get 
            {
                return 3.50m;
            }
        }


        /// <summary>
        /// Calories of the fried pie
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Flavor == PieFilling.Cherry)
                {
                    return 287;
                }
                else if (Flavor == PieFilling.Peach)
                {
                    return 304;
                }
                else if (Flavor == PieFilling.Apricot)
                {
                    return 314;
                }
                else if (Flavor == PieFilling.Pineapple)
                {
                    return 302;
                }
                else if (Flavor == PieFilling.Blueberry)
                {
                    return 314;
                }
                else if (Flavor == PieFilling.Apple)
                {
                    return 289;
                }
                else if (Flavor == PieFilling.Pecan)
                {
                    return 314;
                }


                return 0;
            }
        }

    }
}
