using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorExample.ViewModel
{
    public class ListDisplay3ViewModel : ViewModelBase
    {
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

        public ListDisplay3ViewModel(EventAggregator eventAggregator)
        {
            eventAggregator.Subscribe<DataUpdated2Event>(HandleDataUpdated);
        }

        private void HandleDataUpdated(DataUpdated2Event e)
        {
            Items.Add($"Yellow list: {e.Text}");
        }
    }
}
