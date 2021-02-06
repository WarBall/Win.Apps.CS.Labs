using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Apps.CS.Labs2.BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Item> its = new List<Item>();

        #region Element Form Book
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Срок пользования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        #endregion

        #region Element Form Journal
        public string AuthorJor // автор
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string TitleJor // Название
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public string PublishHouseJor // Издательство
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        public int PageJor // Количество страниц
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public int YearJor // Год публикации
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public int InvNumberJor // Инвентарный номер
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public bool ExistenceJor // Наличие
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        public bool ReturnTimeJor // Возвращение в срок
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public int PeriodUseJor // Срок пользования
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);

            if (ReturnTime) //Проверка возврата книги в срок
                b.ReturnSrok();

            b.PriceBook(PeriodUse); //Расчет с учетом срока пользования

            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 1000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }

            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Journal j = new Journal(AuthorJor, TitleJor, PublishHouseJor, PageJor, YearJor, InvNumberJor, ExistenceJor);

            if (ReturnTimeJor) //Проверка возврата книги в срок
                j.ReturnSrok();

            j.PriceJournal(PeriodUseJor); //Расчет с учетом срока пользования

            its.Add(j);

            AuthorJor = TitleJor = PublishHouseJor = "";
            PageJor = InvNumberJor = PeriodUseJor = 0;
            YearJor = 1000;
            ExistenceJor = ReturnTimeJor = false;
        }
    }
}
