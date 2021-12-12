using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpu_scheduling_calculator
{
    public partial class SJFForm : MaterialSkin.Controls.MaterialForm
    {
        Calc obj = new Calc();
        List<int> nums = new List<int>();
        List<int> numsB = new List<int>();
        string Proccess = "";
        public SJFForm()
        {
            InitializeComponent();
        }

        private void SJFForm_Load(object sender, EventArgs e)
        {
            PSort.Visible = true;
            PSort.Text = " ";
            nums.Clear();
            nums.Add(int.Parse(txtp1.Text));
            nums.Add(int.Parse(txtp2.Text));
            nums.Add(int.Parse(txtp3.Text));
            nums.Add(int.Parse(txtp4.Text));
            nums.Add(int.Parse(txtp5.Text));
            nums.Add(int.Parse(txtp6.Text));

            //List<string> Names = obj.calc(nums);
            //foreach (var p in Names)
            //{
            //    Proccess += p + " |";
            //}

            PSort.Text = Proccess.Remove(Proccess.Length - 1, 1);


            float avgres = obj.Get_avg();
            AvgRes.Text = $"AVG Time = {avgres}";
        }
        private void txtp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
