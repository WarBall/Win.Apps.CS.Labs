using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Apps.CS.Labs4.EditPerson
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        List<Person> pers = new List<Person>();

        private void addButton_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            EditPersonForm editForm = new EditPersonForm(p);           

            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            //ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            //newItem.SubItems.Add(editForm.LastName);
            //newItem.SubItems.Add(editForm.Age.ToString());            
            pers.Add(p);
            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            #region 
            ////Проверка  на наличие элементов в форме
            //if (personsListView.SelectedItems.Count == 0)
            //    return;
            //ListViewItem item = personsListView.SelectedItems[0];

            ////Создаем форму и передаем содержимое
            //EditPersonForm editForm = new EditPersonForm();

            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            ////Передача новых значений свойст
            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;
            //item.Text = editForm.FirstName;
            //item.SubItems[1].Text = editForm.LastName;
            //item.SubItems[2].Text = editForm.Age.ToString();
            #endregion
            if (personsListView.SelectedIndices.Count == 0)
                return;

            Person p = pers[personsListView.SelectedIndices[0]];

            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }

        }

        private void listViewButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
