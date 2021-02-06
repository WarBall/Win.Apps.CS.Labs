using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Apps.CS.Labs1.Task4
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();

            // Свойству Text панели spData устанавливается текущая дата
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }
        //Содержит номер открытой формы
        private int openDocuments = 0;



        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void TileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is horizontal";
        }
    }
}
