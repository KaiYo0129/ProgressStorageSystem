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
    public partial class QueryStockForm : Form
    {
        public QueryStockForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QueryStockForm_Load(object sender, EventArgs e)
        {
            
             var service = new ProcurementService();
             var viewModel = service.GetStockList();
             dataGridView1.DataSource = viewModel.Items;

        }
    }
}
