using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBase.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        public String Titolo { get; set; }

        public MainWindowViewModel()
        {
            Titolo = "Applicazione di base";
        }

    }
}
