using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorExample.ViewModel
{
    public class ListDisplay2ViewModel : ViewModelBase
    {
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

        public ListDisplay2ViewModel(EventAggregator eventAggregator)
        {
            eventAggregator.Subscribe<DataUpdated1Event>(HandleDataUpdated);
        }

        private void HandleDataUpdated(DataUpdated1Event e)
        {
            Items.Add($"Blue list: {e.Text}");
        }
    }
}
