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
    public partial class AddProcurementForm : Form
    {
        public AddProcurementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var viewModel = new ProcurementViewModel();
            viewModel.PartNo = (string)listBox1.SelectedValue;
            viewModel.PurchasingDay = dateTimePicker1.Value;
            viewModel.Quantity = (int)numericUpDown1.Value;
            viewModel.InvetoryQuantity = (int)numericUpDown1.Value;
            viewModel.UintPrice = (int)numericUpDown2.Value;
            var service = new ProcurementService();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProcurementForm_Load(object sender, EventArgs e)
        {
            var service = new ProductService();
            var viewModel = service.GetProducts();
            listBox1.DataSource = viewModel.Items;
            listBox1.DisplayMember = "PartName";
            listBox1.ValueMember = "PartNo";
        }
    }
}
