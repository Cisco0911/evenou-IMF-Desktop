using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenou_IMF_Desktop_App.Credits
{
    public class CreditsModel
    {
        private List<Credit> _credits;
        public List<Credit> Credits { get { return _credits; } set { _credits = value; } }

        public CreditsModel() 
        {
            Credits = new List<Credit>(2);
            Credits.Add(new Credit("001", 4892));
            Credits.Add(new Credit("002", 7023));
        }
    }
}
