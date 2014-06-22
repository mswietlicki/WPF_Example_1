using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace WPF.Binding.Test
{
    [ImplementPropertyChanged]
    public class TestViewModel : INotifyPropertyChanged
    {
        public TestViewModel()
        {
            FirstName = "Marek";
            LastName = "Testowy";
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
