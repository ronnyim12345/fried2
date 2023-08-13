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
    /// The popper base class; all common properties
    /// </summary>
    public abstract class Popper : INotifyPropertyChanged
    {


        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Name of the popper
        /// </summary>
        public abstract string Name {get;}


        /// <summary>
        /// instance of glazed
        /// </summary>
        public bool _glazed = true;

        /// <summary>
        /// Whether the its glazed; default is true
        /// </summary>
        public bool Glazed
        {
            get => _glazed;
            set
            {
                _glazed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Glazed)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }





        /// <summary>
        /// instance of size
        /// </summary>
        public ServingSize _size = ServingSize.Small;

        /// <summary>
        /// The size of the popper
        /// </summary>
        public ServingSize Size
        {
            get => _size;
            set
            {
                _size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Size)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }






        /// <summary>
        /// Price of the popper
        /// </summary>
        public abstract decimal Price{ get; }


        /// <summary>
        /// Calories of the popper
        /// </summary>
        public abstract uint Calories {get; }






    }
}
