using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorExample.ViewModel
{
    public class ListDisplayViewModel : ViewModelBase
    {
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

        public ListDisplayViewModel(EventAggregator eventAggregator)
        {
            eventAggregator.Subscribe<DataUpdated1Event>(HandleDataUpdated);
        }

        private void HandleDataUpdated(DataUpdated1Event e)
        {
            Items.Add($"Green list: {e.Text}");
        }
    }
}
