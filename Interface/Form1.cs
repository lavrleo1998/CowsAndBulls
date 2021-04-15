using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        List<int> hiddeNumber = new List<int>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var hideNumb = new hiddenNumber(int.Parse(textBoxHiddenNumber.Text));
            hiddeNumber.AddRange(hideNumb.value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var response = Check.Try(function);
            textBoxBull.Text = response.bull.ToString();
            textBoxCow.Text = response.cow.ToString();
        }
    }
}
