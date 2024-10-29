using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._01
{
    public class Ukrainian : Person
    {
        public override void PrintCountryName()
        {
            MessageBox.Show("Country: Ukraine");
        }

        public override void Speak()
        {
            MessageBox.Show("Speaking in Ukrainian: Привіт!");
        }
    }
}
