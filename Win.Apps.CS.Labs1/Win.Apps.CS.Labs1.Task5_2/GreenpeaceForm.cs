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
    public partial class GreenpeaceForm : Form
    {
        public GreenpeaceForm()
        {
            InitializeComponent();
        }

        private void GreenpeaceForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();

            myPath.AddLines(new Point[] { new Point(250, 0), new Point(500, 200), new Point(250, 400), new Point(0, 200) });

            Region myRegion = new Region(myPath);

            this.Region = myRegion;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
