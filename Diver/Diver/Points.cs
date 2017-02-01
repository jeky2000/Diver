using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diver
{
    public partial class Points : Form
    {
        public Points()
        {
            InitializeComponent();

        }

        private void hoppareName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void Points_Load(object sender, EventArgs e)
        {
            labelfirstname.Text = Diver.SetvalueForname;
            labellastname.Text = Diver.setvalueForlastname;
            labeljump.Text = Diver.setvalueForjump;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
            Calculate c = new Calculate();

            txtcalculate.Text = c.ToString();
        }
    }
}
