using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody_Git2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime za100dni(DateTime datum)
        {
            DateTime plus100 = datum.AddDays(100);
            return plus100;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            MessageBox.Show("Datum za 100 dni: " + za100dni(datum));


        }
    }
}
