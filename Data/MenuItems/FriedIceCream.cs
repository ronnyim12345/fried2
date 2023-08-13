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
    /// Represents a fried ice cream
    /// </summary>
    public class FriedIceCream: IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Name of the Fried Ice Cream
        /// </summary>
        public string Name
        {
            get { return $"Fried {Flavor} Ice Cream"; }
        }







        /// <summary>
        /// Name for toString method
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return Name;
        }







        /// <summary>
        /// ice cream flavor instance
        /// </summary>
        public IceCreamFlavor _flavor = IceCreamFlavor.Vanilla;

        /// <summary>
        /// The flavor of the fried ice cream
        /// </summary>
        public IceCreamFlavor Flavor
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
        /// Price of the fried ice cream
        /// </summary>
        public decimal Price
        {
            get
            {
                return 3.50m;
            }
        }


        /// <summary>
        /// Calories of the fried ice cream
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Flavor == IceCreamFlavor.Vanilla)
                {
                    return 355;
                }
                else if (Flavor == IceCreamFlavor.Chocolate)
                {
                    return 353;
                }
                else if (Flavor == IceCreamFlavor.Strawberry)
                {
                    return 321;
                }
                


                return 0;
            }
        }



    }
}
