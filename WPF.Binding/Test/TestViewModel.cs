using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace WPF.Binding.Test
{
    [ImplementPropertyChanged]
    public class TestViewModel
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
    }
}
