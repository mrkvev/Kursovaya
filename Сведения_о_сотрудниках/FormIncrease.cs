using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormIncrease : Form
    {
        Query controller;
        public FormIncrease()
        {
            InitializeComponent();
            controller = new Query(ConnectionSrting.ConnStr);
        }

        private void FormTwoForm_Load(object sender, EventArgs e)
        {

        }

        private void Кнопка_увеличения_Click(object sender, EventArgs e)
        {
            FormTable FormTable = Owner as FormTable;
            foreach (DataGridViewRow row in FormTable.Таблица2.Rows)
            {
                if ((double.Parse(row.Cells[5].Value.ToString())) > double.Parse(Нужный_стаж.Value.ToString()))
                {
                    decimal pecent = decimal.Parse(Нужный_процент.Value.ToString());
                    decimal now_calary = decimal.Parse(row.Cells[6].Value.ToString()) + Math.Round((decimal.Parse(row.Cells[6].Value.ToString()) * pecent) / 100,0);
                    row.Cells[6].Value = now_calary;
                    controller.UpDate(int.Parse(row.Cells[0].Value.ToString()),now_calary);
                    FormTable.Таблица.DataSource = controller.UpdateEmployee(); //обновляю
                    Close();
                    return;
                }
            }
            MessageBox.Show("Сотрудники не найдены!", "Внимание!");
        }

        private void Нужный_стаж_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
