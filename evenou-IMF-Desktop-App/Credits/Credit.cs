using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenou_IMF_Desktop_App.Credits
{
    public class Credit
    {
        private string _id;
        public string Id { get { return _id; } set { _id = value; } }

        private int _amount;
        public int Amount { get { return _amount; } set { _amount = value; } }

        public Credit(string id, int amount) 
        {
            Id = id;
            Amount = amount;
        }
    }
}
