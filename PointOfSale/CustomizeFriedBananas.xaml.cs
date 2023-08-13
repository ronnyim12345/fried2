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
using FriedPiper.Data.MenuItems;
using FriedPiper.Data.Enums;

namespace FriedPiper.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeFriedBananas.xaml
    /// </summary>
    public partial class CustomizeFriedBananas : UserControl
    {

        /// <summary>
        /// constructor
        /// </summary>
        public CustomizeFriedBananas()
        {
            InitializeComponent();

            this.DataContext = new FriedBananas();
        }
    }
}
