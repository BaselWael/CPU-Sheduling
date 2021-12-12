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
    public partial class FCFSForm : MaterialSkin.Controls.MaterialForm
    {
        Calc obj = new Calc();
        List<int> nums = new List<int>();
        List<int> numsB = new List<int>();
        string Proccess = "";
        public FCFSForm()
        {
            InitializeComponent();
        }

        private void FCFSForm_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            PSort.Visible = true;
            PSort.Text = " ";
            nums.Clear();
            numsB.Clear();
            //      Arrival time      \\
            nums.Add(int.Parse(txtp1.Text));
            nums.Add(int.Parse(txtp2.Text));
            nums.Add(int.Parse(txtp3.Text));
            nums.Add(int.Parse(txtp4.Text));
            nums.Add(int.Parse(txtp5.Text));
            nums.Add(int.Parse(txtp6.Text));
            //       Burst time       \\
            numsB.Add(int.Parse(txtB1.Text));
            numsB.Add(int.Parse(txtB2.Text));
            numsB.Add(int.Parse(txtB3.Text));
            numsB.Add(int.Parse(txtB4.Text));
            numsB.Add(int.Parse(txtB5.Text));
            numsB.Add(int.Parse(txtB6.Text));
            List<string> Names = obj.calc(nums,numsB);
            foreach (var p in Names)
            {
                Proccess += p + " |";
            }
            
            PSort.Text = Proccess.Remove(Proccess.Length - 1, 1);


            float avgres = obj.Get_avg();
            AvgRes.Text = $"AVG Time = {avgres}";
        }
        private void txtp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
