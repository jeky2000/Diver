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
        //lägg till till en annan list
        private List<hoppare> hopparedata = new List<hoppare>();//det här är empty
        //write to the list in the design
        BindingSource hoppareBinding = new BindingSource();
        BindingSource hoppbinding = new BindingSource();
        public Diver()
        {
            //dont write anything befor initializecomponet()
            InitializeComponent();
            setupdata();//call
            hoppareBinding.DataSource = tournatment.hopparelist;
            DiverList.DataSource = hoppareBinding;

            DiverList.DisplayMember = "Display";
            DiverList.DisplayMember = "Display";
            //lägg till från vänster lista to right lista
            hoppbinding.DataSource = hopparedata;
            pointlist.DataSource = hoppbinding;

            pointlist.DisplayMember = "Diplay";
            pointlist.DisplayMember = "Display";

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            Points s = new Points();
            s.Show(this);
            
            //figure out what is selected from the diver list
            //copy that diver to point list
            //do we remove the diver from the diver list? - no
            hoppare selectedItem = (hoppare)DiverList.SelectedItem;

            //MessageBox.Show(selectedItem.FirstName);
            hopparedata.Add(selectedItem);
            hoppbinding.ResetBindings(true);//list is not changed
            

        }
    }
}
