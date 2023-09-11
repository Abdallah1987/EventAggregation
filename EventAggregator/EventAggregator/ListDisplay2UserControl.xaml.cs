using EventAggregatorExample.ViewModel;
using System.Windows.Controls;

namespace EventAggregatorExample
{
    /// <summary>
    /// Interaction logic for ListDisplayView.xaml
    /// </summary>
    public partial class ListDisplay2UserControl : UserControl
    {
        public ListDisplay2ViewModel ViewModel { get; set; }

        public ListDisplay2UserControl()
        {
            InitializeComponent();
        }
    }
}
