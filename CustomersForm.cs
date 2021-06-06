using Super_Market_Application.DataBaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_Application
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            SuperMarketDBEntities Data = new SuperMarketDBEntities();
            
            foreach(City c in Data.Cities)
            {
                InsertCityCmb.Items.Add(c.CityName);
            }

            InsertCityCmb.SelectedIndex = 0;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.superMarketDBDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerTable.Insert(
                InsertNameTxt.Text,
                InsertAddressTxt.Text,
                long.Parse(InsertPhoneTxt.Text),
                InsertCityCmb.SelectedItem.ToString()
                );
        }
    }
}
