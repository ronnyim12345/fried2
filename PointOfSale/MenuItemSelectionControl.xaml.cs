using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// selected item field
        /// </summary>
        public IMenuItem _selectedItem = null;

        /// <summary>
        /// selected item property
        /// </summary>
        public IMenuItem SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedItem"));
            }
        }



        /// <summary>
        /// Menu item constructor
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            this.DataContext = null;

        }






        /// <summary>
        /// event handler for fried candy bar click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FriedCandyBar_Click(object sender, RoutedEventArgs e)
        {
            CustomizeCandyBar customizeCandyBar = new CustomizeCandyBar();

            this.DataContext = customizeCandyBar.DataContext;

            this.Content = customizeCandyBar;

        }







        /// <summary>
        /// event handler for twinkie click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FriedTwinkies_Click(object sender, RoutedEventArgs e)
        {


            CustomizeFriedTwinkie customizeFriedTwinkie = new CustomizeFriedTwinkie();

            this.DataContext = customizeFriedTwinkie.DataContext;

            this.Content = customizeFriedTwinkie;

        }



        /// <summary>
        /// event handler for ice cream click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FriedIceCream_Click(object sender, RoutedEventArgs e)
        {
            CustomizeIceCream customizeIceCream = new CustomizeIceCream();

            this.DataContext = customizeIceCream.DataContext;

            this.Content = customizeIceCream;



        }







        /// <summary>
        /// event handler for pie click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FriedPie_Click(object sender, RoutedEventArgs e)
        {
            CustomizeFriedPie customizeFriedPie = new CustomizeFriedPie();

            this.DataContext = customizeFriedPie.DataContext;

            this.Content = customizeFriedPie;
        }




        /// <summary>
        /// event handler for apple frit click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void AppleFritters_Click(object sender, RoutedEventArgs e)
        {
            CustomizeAppleFritters customizeAppleFritters = new CustomizeAppleFritters();

            this.DataContext = customizeAppleFritters.DataContext;

            this.Content = customizeAppleFritters;
        }








        /// <summary>
        /// event handler for bananas click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FriedBananas_Click(object sender, RoutedEventArgs e)
        {
            CustomizeFriedBananas customizeFriedBananas = new CustomizeFriedBananas();

            this.DataContext = customizeFriedBananas.DataContext;

            this.Content = customizeFriedBananas;
        }





        /// <summary>
        /// event handler for cheesecake click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FriedCheesecake_Click(object sender, RoutedEventArgs e)
        {
            CustomizeFriedCheesecake customizeFriedCheesecake = new CustomizeFriedCheesecake();

            this.DataContext = customizeFriedCheesecake.DataContext;

            this.Content = customizeFriedCheesecake;
        }



        /// <summary>
        /// event handler for oreos
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FriedOreos_Click(object sender, RoutedEventArgs e)
        {
            CustomizeFriedOreos customizeFriedOreos = new CustomizeFriedOreos();

            this.DataContext = customizeFriedOreos.DataContext;

            this.Content = customizeFriedOreos;
        }




        /// <summary>
        /// event handler for piper platter click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void PiperPlatter_Click(object sender, RoutedEventArgs e)
        {
            CustomizePiperPlatter customizePiperPlatter = new CustomizePiperPlatter();

            this.DataContext = customizePiperPlatter.DataContext;

            this.Content = customizePiperPlatter;
        }





        /// <summary>
        /// event handler for popperplatter click
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void PopperPlatter_Click(object sender, RoutedEventArgs e)
        {
            CustomizePopperPlatter customizePopperPlatter = new CustomizePopperPlatter();

            this.DataContext = customizePopperPlatter.DataContext;

            this.Content = customizePopperPlatter;
        }

    }
}
