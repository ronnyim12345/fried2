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
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;


namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeIceCream.xaml
    /// </summary>
    public partial class CustomizeIceCream : UserControl
    {


        /// <summary>
        /// Constructor for ice cream
        /// </summary>
        public CustomizeIceCream()
        {
            InitializeComponent();
            this.DataContext = new FriedIceCream();
        }





    }
}
