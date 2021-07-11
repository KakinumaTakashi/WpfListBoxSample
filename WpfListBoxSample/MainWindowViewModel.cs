using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp4;

namespace WpfListBoxSample
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {
        private MainWindow View { get; set; }


        public class ListItem : NotifyPropertyChanged
        {
            public string Text1
            {
                get { return this._Text1; }
                set
                {
                    this._Text1 = value;
                    this.RaisePropertyChanged();
                }
            }
            private string _Text1;

            public string Text2
            {
                get { return this._Text2; }
                set
                {
                    this._Text2 = value;
                    this.RaisePropertyChanged();
                }
            }
            private string _Text2;
        }

        public ObservableCollection<ListItem> ListItems { get; private set; }
            = new ObservableCollection<ListItem>();


        public MainWindowViewModel(MainWindow view)
        {
            this.View = view;

            this.ListItems.Add(new ListItem() { Text1 = "AAAAAAAA", Text2 = "aaaaaaaaaaa" });
            this.ListItems.Add(new ListItem() { Text1 = "BBBBBBBB", Text2 = "bbbbbbbbbbb" });
            this.ListItems.Add(new ListItem() { Text1 = "CCCCCCCC", Text2 = "ccccccccccc" });
        }
    }
}
