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
    /// Represents a Popper platter
    /// </summary>
    public class PopperPlatter : IMenuItem, INotifyPropertyChanged
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
            get { return $"{Size} Popper Platter"; }
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
        /// Temp holder of size
        /// </summary>
        private ServingSize _size;

        /// <summary>
        /// The size of the popper
        /// </summary>
        public ServingSize Size
        {
            get 
            {
                return _size;
            }
            set
            {
                _size = value;

                AppleFritters.Size = _size;
                FriedBananas.Size = _size;
                FriedCheesecake.Size = _size;
                FriedOreos.Size = _size;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Size)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }


        /// <summary>
        /// Temp holder of glazed
        /// </summary>
        private bool _glazed;

        /// <summary>
        /// Whether its glazed or not
        /// </summary>
        public bool Glazed
        {
            get
            {
                return _glazed;
            }
            set
            {
                _glazed = value;

                AppleFritters.Glazed = _glazed;
                FriedBananas.Glazed = _glazed;
                FriedCheesecake.Glazed = _glazed;
                FriedOreos.Glazed = _glazed;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Glazed)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }






        /// <summary>
        /// The applefritter
        /// </summary>
        public AppleFritters AppleFritters { get; } = new AppleFritters();


        /// <summary>
        /// The fried banana
        /// </summary>
        public FriedBananas FriedBananas { get; } = new FriedBananas();


        /// <summary>
        /// The fried cheesecake
        /// </summary>
        public FriedCheesecake FriedCheesecake { get; } = new FriedCheesecake();


        /// <summary>
        /// The fried oreos
        /// </summary>
        public FriedOreos FriedOreos { get; } = new FriedOreos();



        /// <summary>
        /// Sum of the calories
        /// </summary>
        public uint Calories
        {
            
            get
            {
                return AppleFritters.Calories + FriedBananas.Calories + FriedCheesecake.Calories
                    + FriedOreos.Calories;
            }
        }




        /// <summary>
        /// Price of Popper platter
        /// </summary>
        public decimal Price
        {
            get
            {
                if (Size == ServingSize.Small)
                {
                    return 12.00m;

                }
                else if (Size == ServingSize.Medium)
                {
                    return 16.00m;
                }
                else if (Size == ServingSize.Large)
                {
                    return 20.00m;
                }



                return 0m;


            }
        }


        /// <summary>
        /// The constructor; default values
        /// </summary>
        public PopperPlatter()
        {
            Glazed = true;
            Size = ServingSize.Small;

        }
     }
}
