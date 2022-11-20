using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormError : Form
    {
        Query controller;
        public FormError()
        {
            InitializeComponent();
            controller = new Query(ConnectionSrting.ConnStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Кнопка_удаления_сотрудника_Click(object sender, EventArgs e)
        {
            FormTable FormTable = Owner as FormTable;
            int k = FormTable.Таблица.SelectedCells[0].RowIndex;
            int n = int.Parse(FormTable.Таблица.Rows[k].Cells[0].Value.ToString());
            controller.Delete(n);
            FormTable.Таблица.DataSource = controller.UpdateEmployee(); //обновляю

            //удаление из второй таблицы
            foreach (DataGridViewRow row1 in FormTable.Таблица2.Rows)
            {
                if (int.Parse(row1.Cells[0].Value.ToString()) == n)
                {
                    FormTable.Таблица2.Rows.Remove(row1);
                    return;
                }
            }
            Close();
            MessageBox.Show("Учетная запись удалена!", "Внимание!");          
        }

        private void FormError_Load(object sender, EventArgs e)
        {

        }

        private void Отмена_удаления_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
