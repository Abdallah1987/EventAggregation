using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventAggregatorExample.ViewModel
{
    public class UpdateViewModel : ViewModelBase
    {
        private EventAggregator _eventAggregator; 

        public ICommand UpdateCommand { get; set; }
        public ICommand Update2Command { get; set; }

        public UpdateViewModel(EventAggregator eventAggregator)
        {
            UpdateCommand = new RelayCommand(UpdateData);
            Update2Command = new RelayCommand(UpdateData2);

            _eventAggregator = eventAggregator;
        }

        public void UpdateData()
        {
            _eventAggregator.Publish(new DataUpdated1Event($"Event raised time: {DateTime.Now}"));

        }

        public void UpdateData2()
        {
            _eventAggregator.Publish(new DataUpdated2Event($"Event raised time: {DateTime.Now}"));

        }
    }
}
