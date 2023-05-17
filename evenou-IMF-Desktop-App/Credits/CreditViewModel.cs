using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenou_IMF_Desktop_App.Credits
{
    public class CreditViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CreditsModel CreditMod;


        private List<Credit> _credits;
        public List<Credit> Credits { get { return _credits; } set { _credits = value; } }

        public CreditViewModel() 
        {
            CreditMod = new CreditsModel();
            Credits = CreditMod.Credits;
        }
    }
}
