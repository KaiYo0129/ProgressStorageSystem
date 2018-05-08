using BuildSchoolBizApp.Services;
using BuildSchoolBizApp.ViewModels;
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
    public partial class AddSellingForm : Form
    {
        public AddSellingForm()
        {
            InitializeComponent();
        }

        private void AddSellingForm_Load(object sender, EventArgs e)
        {
            BindProductListBox();
            BindSalesManListBox();
        }

        private void BindSalesManListBox()
        {
            var service = new SalesManService();
            var viewModel = service.GetSalesMen();
            listBox2.DataSource = viewModel.Items;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "JobNumber";
        }

        private void BindProductListBox()
        {
            var service = new ProductService();
            var viewModel = service.GetProducts();
            listBox1.DataSource = viewModel.Items;
            listBox1.DisplayMember = "PartName";
            listBox1.ValueMember = "PartNo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var viewModel = new SellingViewModel();
            viewModel.PartNo = (string)listBox1.SelectedValue;
            viewModel.SalesJobNumber = (int)listBox2.SelectedValue;
            viewModel.Quantity = (int)numericUpDown1.Value;
            viewModel.UnitPrice = (int)numericUpDown2.Value;
            viewModel.SellingDay = dateTimePicker1.Value;
            if (CanSale(viewModel.PartNo, viewModel.Quantity))
            {
                var service = new SellingService();
                var result = service.Create(viewModel);
                if (result.IsSuccessful)
                {
                    MessageBox.Show("新增進貨資料成功");
                }
                else
                {
                    var path = result.WriteLog();
                    MessageBox.Show($"發生錯誤，請參考 {path}");
                }
            }
            else
            {
                MessageBox.Show("庫存不足");
            }
        }

        private bool CanSale(string partNo, int quantity)
        {
            var service = new ProcurementService();
            var stock = service.GetStock(partNo);
            return (stock >= quantity);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
