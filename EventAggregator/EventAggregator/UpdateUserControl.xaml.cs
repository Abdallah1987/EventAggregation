using EventAggregatorExample.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace EventAggregatorExample
{
    /// <summary>
    /// Interaction logic for UpdateView.xaml
    /// </summary>
    public partial class UpdateUserControl : UserControl
    {
        public UpdateViewModel ViewModel { get; set; }

        public UpdateUserControl()
        {
            InitializeComponent();
        }
    }
}
