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
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {

        /// <summary>
        /// Constructor for order summary
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();

            this.DataContext = new Order();

            

        }







        /// <summary>
        /// Remove button handler
        /// </summary>
        /// <param name="sender">asd</param>
        /// <param name="e">asd</param>
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is Order order)
            {
                order.Remove((IMenuItem)OrderList.SelectedItem);

            }

        }

    }
}
