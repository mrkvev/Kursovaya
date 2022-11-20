using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormСalculate : Form
    {
        public FormСalculate()
        {
            InitializeComponent();
            panel1.Enabled = false;
            panel2.Enabled = false;
            
        }
        private void FormСalculate_Load(object sender, EventArgs e)
        {

        }
        private void Какая_задача_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Какая_задача.SelectedIndex == 0)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                Таблица_стажа.Enabled = true;
                Таблица_стажа.Rows.Clear();
                FormTable FormTable = Owner as FormTable;
                DateTime Now = DateTime.Parse(DateTime.Now.ToShortDateString());
                foreach (DataGridViewRow row in FormTable.Таблица.Rows)
                {
                    DateTime time = DateTime.Parse(row.Cells[6].Value.ToString());
                    double timeSpan = Now.Subtract(time).Days;
                    Таблица_стажа.Rows.Add(row.Cells[0].Value, timeSpan, Math.Round(timeSpan / 365,2));
                }
            }
            //средний стаж работы заданного отдела
            if (Какая_задача.SelectedIndex == 1)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                Вывод_ответа.Text = "";
                
            }
            //количество сотрудников с окладом ниже заданного
            if (Какая_задача.SelectedIndex == 2)
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
                Вывод_ответа.Text = "0";
            }
        }
       
        private void Выберите_название_отдела_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormTable FormTable = Owner as FormTable;
            DateTime Now = DateTime.Parse(DateTime.Now.ToShortDateString());
            double sum = 0; int n = 0;
            foreach (DataGridViewRow row in FormTable.Таблица.Rows)
            {
                if (row.Cells[4].Value.ToString() == Выберите_название_отдела.Text)
                {
                    DateTime time = DateTime.Parse(row.Cells[6].Value.ToString());
                    sum += Now.Subtract(time).Days;
                    n++;
                }
            }
            if (n == 0)
            {
                MessageBox.Show("Сотрудники не найдены!", "Внимение!");
                return;
            }
            Вывод_ответа.Text = $"{Math.Round((sum/356)/n,2)}";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FormTable FormTable = Owner as FormTable;
            int n = 0;
            foreach (DataGridViewRow row in FormTable.Таблица.Rows)
            {
                if (int.Parse(row.Cells[7].Value.ToString()) < int.Parse(Выберите_оклад.Value.ToString()))
                {
                    n++;
                }
            }
            Вывод_ответа.Text = $"{n}";
        }
        private void Кнопка_отменить_создавать_новую_запись_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
