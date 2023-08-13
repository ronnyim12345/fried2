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
    /// Represents a piper platter
    /// </summary>
    public class PiperPlatter : IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The details in Order Summary Control
        /// </summary>
        public string DetailsOrderSummName
        {
            get
            {
                return $"- L. Pie: {LeftPie.Flavor} \n- R. Pie:  { RightPie.Flavor} \n- L. IceCr:  {LeftIceCream.Flavor} \n- R. IceCr:  {RightIceCream.Flavor}";
            }
        }






        /// <summary>
        /// Calories change updates
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            if (e.PropertyName == "Calories")
            {

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));


            }
            if (e.PropertyName == "Flavor")
            {

                if (sender == LeftIceCream)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DetailsOrderSummName"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                }
                if (sender == RightIceCream)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DetailsOrderSummName"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                }
                if (sender == LeftPie)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DetailsOrderSummName"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                }
                if (sender == RightPie)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DetailsOrderSummName"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                }



            }

        }



        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This is the name piper platter
        /// </summary>
        public string Name 
        { 
            get { return "Piper Platter"; }
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
        /// field pie
        /// </summary>
        public FriedPie _leftPie = new FriedPie();

        /// <summary>
        /// The left pie
        /// </summary>
        public FriedPie LeftPie
        {
            get
            {
                return _leftPie;
            }
            set
            {
                _leftPie = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }





        /// <summary>
        /// field pie
        /// </summary>
        public FriedPie _rightPie = new FriedPie();

        /// <summary>
        /// The right pie
        /// </summary>
        public FriedPie RightPie
        {
            get
            {
                return _rightPie;
            }
            set
            {
                _rightPie = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }








        /// <summary>
        /// field pie
        /// </summary>
        public FriedIceCream _leftIceCream = new FriedIceCream();

        /// <summary>
        /// The left pie
        /// </summary>
        public FriedIceCream LeftIceCream
        {
            get
            {
                return _leftIceCream;
            }
            set
            {
                _leftIceCream = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }







        /// <summary>
        /// field ice cream
        /// </summary>
        public FriedIceCream _rightIceCream = new FriedIceCream();

        /// <summary>
        /// The right ice cream
        /// </summary>
        public FriedIceCream RightIceCream
        {
            get
            {
                return _rightIceCream;
            }
            set
            {
                _rightIceCream = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }








        /// <summary>
        /// Sum of the calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return LeftPie.Calories + RightPie.Calories 
                    + LeftIceCream.Calories + RightIceCream.Calories;
            }
        }

        /// <summary>
        /// The Price of piper platter
        /// </summary>
        public decimal Price { get { return 12.00m; } }



        /// <summary>
        /// The constructor; default values
        /// </summary>
        public PiperPlatter() 
        {
              
            LeftPie.Flavor = PieFilling.Apple;

            LeftPie.PropertyChanged += HandlePropertyChanged;


            RightPie.Flavor = PieFilling.Apple;

            RightPie.PropertyChanged += HandlePropertyChanged;



            LeftIceCream.Flavor = IceCreamFlavor.Vanilla;

            LeftIceCream.PropertyChanged += HandlePropertyChanged;




            RightIceCream.Flavor = IceCreamFlavor.Vanilla;

            RightIceCream.PropertyChanged += HandlePropertyChanged;



        }






    }
}
