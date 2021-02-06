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
    public partial class EdditForm : Form
    {
        Student s;

        //Проверка на входящие данные
        bool CheckNum(string inText)
        {
            foreach (char c in inText)
            {
                if (Char.IsNumber(c))
                    return true;
            }
            return false;
        }

        public EdditForm(Student s)
        {
            InitializeComponent();

            this.s = s;
            this.FirstName = s.FirstName;
            this.LastName = s.LastName;
            this.PersonNumber = s.PersonNumber;
        }

        #region Window variables
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }
        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }
        public int PersonNumber
        {
            get { return (int)persNumUpDown.Value; }
            set { persNumUpDown.Value = value; }
        }
        #endregion

        private void SaveButton_Click(object sender, EventArgs e)
        {
            s.FirstName = this.FirstName;
            s.LastName = this.LastName;
            s.PersonNumber = this.PersonNumber;

            MessageBox.Show("Студент: " + s.ToString());
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CheckNum(firstNameTextBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Поле может содержать только буквы");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CheckNum(lastNameTextBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Поле может содержать только буквы");
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
