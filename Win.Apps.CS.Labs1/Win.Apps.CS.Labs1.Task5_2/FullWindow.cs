using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Apps.CS.Labs1.Task5_2
{
    public partial class FullWindow : Form
    {
        public FullWindow()
        {
            InitializeComponent();
        }

        private void PresentMenuItem_Click(object sender, EventArgs e)
        {
            GreenpeaceForm newChild = new GreenpeaceForm();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void FullWindow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
