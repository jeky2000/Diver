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
    public partial class Diver : Form
    {
        private Tournament tournatment = new Tournament();
        //write to the list in the design
        BindingSource hoppareBinding = new BindingSource();
        public Diver()
        {
            //dont write anything befor initializecomponet()
            InitializeComponent();
            setupdata();//call
            hoppareBinding.DataSource = tournatment.hopparelist;
            DiverList.DataSource = hoppareBinding;

            DiverList.DisplayMember = "Display";
            DiverList.DisplayMember = "Display";
        }

        private void Diver_Load(object sender, EventArgs e)
        {

        }
        private void setupdata()
        {
            //lägg till judges

            tournatment.judges.Add(new judge { FirstName = "jek", LastName = "hurry" });//add to list
            tournatment.judges.Add(new judge { FirstName = "son", LastName = "hurry" });
            tournatment.judges.Add(new judge { FirstName = "sarmad", LastName = "hurry" });
            tournatment.judges.Add(new judge { FirstName = "ako", LastName = "hurry" });
            tournatment.judges.Add(new judge { FirstName = "ronny", LastName = "hurry" });

            //add hoppare
            tournatment.hopparelist.Add(new hoppare { FirstName = "jon", LastName = "obama", dateofbirth = "1990.12.12", dive = 1 });
            tournatment.hopparelist.Add(new hoppare { FirstName = "jin", LastName = "obama", dateofbirth = "1990.12.12", dive = 1 });
            tournatment.hopparelist.Add(new hoppare { FirstName = "jun", LastName = "obama", dateofbirth = "1990.12.12", dive = 1 });

            tournatment.Name = "OS";
        }

    }
}
