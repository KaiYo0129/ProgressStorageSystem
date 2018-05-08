using BuildSchoolBizApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildSchoolBizApp
{
    public partial class QuerySellingBySalesForm : Form
    {
        public QuerySellingBySalesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jobNumber = (int)listBox1.SelectedValue;
            var begin = dateTimePicker1.Value.Date;
            var end = dateTimePicker2.Value.Date.AddDays(1);
            var service = new SellingService();
            var viewModel = service.GetSellingBySalesAndDay(jobNumber, begin, end);
            dataGridView1.DataSource = viewModel.Items;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuerySellingBySalesForm_Load(object sender, EventArgs e)
        {
            BindSalesManListBox();
        }

        private void BindSalesManListBox()
        {
            var service = new SalesManService();
            var viewModel = service.GetSalesMen();
            listBox1.DataSource = viewModel.Items;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "JobNumber";
        }


    }
}
