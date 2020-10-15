using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement
{
    public partial class PurchaseView : Form
    {
        public PurchaseView()
        {
            InitializeComponent();
            displayDetails();
        }

        //display details
        public void displayDetails()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "OR001";
            dataGridView1.Rows[0].Cells[1].Value = "Shehan";
            dataGridView1.Rows[0].Cells[2].Value = "Skyline";
            dataGridView1.Rows[0].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[0].Cells[4].Value = "20/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "OR001";
            dataGridView1.Rows[1].Cells[1].Value = "Shehan";
            dataGridView1.Rows[1].Cells[2].Value = "Skyline";
            dataGridView1.Rows[1].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[1].Cells[4].Value = "20/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "OR001";
            dataGridView1.Rows[2].Cells[1].Value = "Shehan";
            dataGridView1.Rows[2].Cells[2].Value = "Skyline";
            dataGridView1.Rows[2].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[2].Cells[4].Value = "20/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[3].Cells[0].Value = "OR001";
            dataGridView1.Rows[3].Cells[1].Value = "Shehan";
            dataGridView1.Rows[3].Cells[2].Value = "Skyline";
            dataGridView1.Rows[3].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[3].Cells[4].Value = "20/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[4].Cells[0].Value = "OR001";
            dataGridView1.Rows[4].Cells[1].Value = "Shehan";
            dataGridView1.Rows[4].Cells[2].Value = "Skyline";
            dataGridView1.Rows[4].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[4].Cells[4].Value = "20/05/2019";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            createOrder d = new createOrder();
            d.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
