using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
         
        }

  

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmTrungTam();
            form.ShowDialog();
        }
        private void Vidu2_Load(object sender, EventArgs e)
        {
      
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new lblThongBao();
            form.ShowDialog();
        }
    }
}
