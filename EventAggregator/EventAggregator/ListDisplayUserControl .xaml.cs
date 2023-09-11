using EventAggregatorExample.ViewModel;
using System.Windows.Controls;

namespace EventAggregatorExample
{
    /// <summary>
    /// Interaction logic for ListDisplayView.xaml
    /// </summary>
    public partial class ListDisplayUserControl : UserControl
    {
        public ListDisplayViewModel ViewModel { get; set; }

        public ListDisplayUserControl()
        {
            InitializeComponent();
        }
    }
}
