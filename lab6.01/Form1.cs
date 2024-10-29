using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._01
{
    public partial class Form1 : Form
    {
        private Person selectedPerson;
  
     
        public Form1()
        {
            InitializeComponent();
            comboBoxPerson.Items.Add("Italian");
            comboBoxPerson.Items.Add("Ukrainian");
            comboBoxPerson.SelectedIndex = 0;
            comboBoxPerson.SelectedIndexChanged += comboBoxPerson_SelectedIndexChanged;

            // Налаштування початкового об'єкта
            selectedPerson = new Italian();
        }

        private void comboBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ваш код для зміни об’єкта залежно від вибору
            switch (comboBoxPerson.SelectedItem.ToString())
            {
                case "Italian":
                    selectedPerson = new Italian();
                    break;
                case "Ukrainian":
                    selectedPerson = new Ukrainian();
                    break;
            }
        }

        private void btnPrintCountryName_Click(object sender, EventArgs e)
        {
            selectedPerson?.PrintCountryName();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            selectedPerson?.Speak();
        }
    }
}
