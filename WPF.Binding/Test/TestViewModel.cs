using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Binding.Test
{
    public class TestViewModel
    {
        public TestViewModel()
        {
            FirstName = "Marek";
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
