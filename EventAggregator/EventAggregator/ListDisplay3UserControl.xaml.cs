using EventAggregatorExample.ViewModel;
using System.Windows.Controls;

namespace EventAggregatorExample
{
    /// <summary>
    /// Interaction logic for ListDisplayView.xaml
    /// </summary>
    public partial class ListDisplay3UserControl : UserControl
    {
        public ListDisplay3ViewModel ViewModel { get; set; }

        public ListDisplay3UserControl()
        {
            InitializeComponent();
        }
    }
}
