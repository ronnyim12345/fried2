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
using System.Windows.Shapes;
using System.ComponentModel;
using FriedPiper.Data;
using FriedPiper.Data.MenuItems;


namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;







        /// <summary>
        /// Constructor for MainWindow
        /// </summary>
        public MainWindow()
        {

            InitializeComponent();

            this.DataContext = orderSummaryControl.DataContext;

        }






        // THE THREE CLICK EVENT BUTTONS:


        /// <summary>
        /// Handles the Select More Items button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {

            // CREATE NEW ORDER SUMMARY CONTROL

            orderSummaryControlGrid.Children.Clear();

            orderSummaryControl = new OrderSummaryControl();

            orderSummaryControlGrid.Children.Add(orderSummaryControl);

            this.DataContext = orderSummaryControl.DataContext;

        }





        /// <summary>
        /// Select more items button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        void SelectMoreItems(object sender, RoutedEventArgs e)
        {

            // ADD ITEM TO ORDER

            if (this.DataContext is Order order)
            {
                if (menuItemSelection.DataContext != null)
                {
                    order.Add((IMenuItem)menuItemSelection.DataContext);

                }

                order.UpdateTotals();


            }




            // MAKE NEW MENU SCREEN

            menuItemSelectionGrid.Children.Clear();

            MenuItemSelectionControl menuItemSelection2 = new MenuItemSelectionControl();

            menuItemSelectionGrid.Children.Add(menuItemSelection2);

            menuItemSelection = menuItemSelection2;




            // DISABLE BUTTON

            selectMoreItems.IsEnabled = false;





            // UPDATE PRICE

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

        }



        /// <summary>
        /// Complete Order Button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void CompleteOrder(object sender, RoutedEventArgs e)
        {


        }



        /// <summary>
        /// enables select more items
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void EnableSelectMoreItemsButton(object sender, RoutedEventArgs e)
        {
            selectMoreItems.IsEnabled = true;

        }



        /// <summary>
        /// clicking the customize button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void CustomizeButtonClick(object sender, RoutedEventArgs e)
        {


            selectMoreItems.IsEnabled = true;


            if (e.OriginalSource is Button button)
            {
                if (button.Tag.ToString() == "customize")
                {


                    IMenuItem item = (IMenuItem)orderSummaryControl.OrderList.SelectedItem;


                    if (item is AppleFritters)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeAppleFritters customizeAppleFritters = new CustomizeAppleFritters();

                        customizeAppleFritters.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeAppleFritters);


                    }
                    else if (item is FriedBananas)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeFriedBananas customizeFriedBananas = new CustomizeFriedBananas();

                        customizeFriedBananas.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeFriedBananas);


                    }
                    else if (item is FriedCandyBar)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeCandyBar customizeCandyBar = new CustomizeCandyBar();

                        customizeCandyBar.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeCandyBar);


                    }
                    else if (item is FriedCheesecake)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeFriedCheesecake customizeCheesecake = new CustomizeFriedCheesecake();

                        customizeCheesecake.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeCheesecake);


                    }
                    else if (item is FriedIceCream)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeIceCream customizeIceCream = new CustomizeIceCream();

                        customizeIceCream.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeIceCream);


                    }
                    else if (item is FriedOreos)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeFriedOreos customizeFriedOreos = new CustomizeFriedOreos();

                        customizeFriedOreos.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeFriedOreos);


                    }
                    else if (item is FriedPie)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeFriedPie customizeFriedPie = new CustomizeFriedPie();

                        customizeFriedPie.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeFriedPie);


                    }
                    else if (item is FriedTwinkie)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizeFriedTwinkie customizeFriedTwinkie = new CustomizeFriedTwinkie();

                        customizeFriedTwinkie.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizeFriedTwinkie);


                    }
                    else if (item is PopperPlatter)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizePopperPlatter customizePopperPlatter = new CustomizePopperPlatter();

                        customizePopperPlatter.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizePopperPlatter);


                    }
                    else if (item is PiperPlatter)
                    {
                        menuItemSelectionGrid.Children.Clear();

                        CustomizePiperPlatter customizePiperPlatter = new CustomizePiperPlatter();

                        customizePiperPlatter.DataContext = item;

                        menuItemSelectionGrid.Children.Add(customizePiperPlatter);


                    }





                }



            }


        }

    }
}
