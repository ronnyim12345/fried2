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
using FriedPiper.Data.Enums;
using FriedPiper.Data.MenuItems;
using System.ComponentModel;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCandyBar.xaml
    /// </summary>
    public partial class CustomizeCandyBar : UserControl
    {
       



        /// <summary>
        /// Constructor for candy bar
        /// </summary>
        public CustomizeCandyBar()
        {
            InitializeComponent();
            this.DataContext = new FriedCandyBar();

        }








    }
}
