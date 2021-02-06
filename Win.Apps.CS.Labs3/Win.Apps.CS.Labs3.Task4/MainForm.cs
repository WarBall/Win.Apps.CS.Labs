using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Apps.CS.Labs3.Task4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Student> stud = new List<Student>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            EdditForm editForm = new EdditForm(s);

            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            stud.Add(s);
            StudentListView.VirtualListSize = stud.Count;
            StudentListView.Invalidate();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (StudentListView.SelectedIndices.Count == 0)
                return;

            Student s = stud[StudentListView.SelectedIndices[0]];
            EdditForm editForm = new EdditForm(s);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                StudentListView.Invalidate();
            }
        }

        private void StudentListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < stud.Count)
            {
                e.Item = new ListViewItem(stud[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(stud[e.ItemIndex].LastName);
                e.Item.SubItems.Add(stud[e.ItemIndex].PersonNumber.ToString());
            }
        }
    }
}
