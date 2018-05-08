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
    public partial class AddSalesManForm : Form
    {
        public AddSalesManForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("料號或名稱不可為空白");
            }
            else
            {
                SalesManViewModel viewModel = new SalesManViewModel();
                viewModel.Name= textBox1.Text.Trim();
                SalesManService service = new SalesManService();
                var result = service.Create(viewModel);
                if (result.IsSuccessful)
                {
                    MessageBox.Show("成員加入成功");
                }
                else
                {
                    var path = result.WriteLog();
                    MessageBox.Show($"發生錯誤，請參考 {path}");
                }
            }
        }
    }
}
