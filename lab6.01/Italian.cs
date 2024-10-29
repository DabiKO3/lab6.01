using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._01
{
    public class Italian : Person
    {
        public override void PrintCountryName()
        {
            MessageBox.Show("Country: Italy");
        }

        public override void Speak()
        {
            MessageBox.Show("Speaking in Italian: Ciao!");
        }
    }
}
