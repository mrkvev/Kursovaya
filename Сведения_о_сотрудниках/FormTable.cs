using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormTable : Form
    {
        Query controller;
        public FormTable()
        {
            InitializeComponent();
            controller = new Query(ConnectionSrting.ConnStr);
            Таблица.DataSource = controller.UpdateEmployee();

            //заполнение второй таблицы при загрузке
            DateTime Now = DateTime.Parse(DateTime.Now.ToShortDateString());
            foreach (DataGridViewRow row in Таблица.Rows)
            {
                DateTime enrollment_date = DateTime.Parse(row.Cells[6].Value.ToString());
                DateTime date_of_birth = DateTime.Parse(row.Cells[3].Value.ToString());
                double experience = Now.Subtract(enrollment_date).Days;
                int age = Now.Subtract(date_of_birth).Days / 365;

                if (age >= 55 && row.Cells[2].Value.ToString() == "ж")
                {
                    Таблица2.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, date_of_birth.ToShortDateString(), enrollment_date.ToShortDateString(), Math.Round(experience / 365, 2), row.Cells[7].Value);
                }
                else if (age >= 60)
                {
                    Таблица2.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, date_of_birth.ToShortDateString(), enrollment_date.ToShortDateString(), Math.Round(experience / 365, 2), row.Cells[7].Value);
                }
            }
        }
        private void Добавить_запись_Click(object sender, EventArgs e)
        {
            FormAdd FormAdd = new FormAdd
            {
                Owner = this
            };
            FormAdd.Show();
        }
        private void Редактировать_запись_Click(object sender, EventArgs e)
        {
            int k = Таблица.SelectedCells[0].RowIndex;
            FormEdit FormEdit = new FormEdit
            {
                Owner = this
            };
            FormEdit.Show();

            //вывожу данные сотрудника на экран
            FormEdit.Айди.Text = Таблица.Rows[k].Cells[0].Value.ToString();
            FormEdit.Новая_фамилия.Text = Таблица.Rows[k].Cells[1].Value.ToString();
            if (Таблица.Rows[k].Cells[2].Value.ToString() == "ж")
            {
                FormEdit.Новый_женский_пол.Checked = true;
            }
            else
            {
                FormEdit.Новый_мужской_пол.Checked = true;
            }
            FormEdit.Новая_дата_рождения.Text = DateTime.Parse(Таблица.Rows[k].Cells[3].Value.ToString()).ToShortDateString();
            FormEdit.Новая_дата_поступления_на_работу.Text = DateTime.Parse(Таблица.Rows[k].Cells[6].Value.ToString()).ToShortDateString();
            FormEdit.Новая_должность.Text = Таблица.Rows[k].Cells[5].Value.ToString();
            FormEdit.Новое_названия_отдела.Text = Таблица.Rows[k].Cells[4].Value.ToString();
            FormEdit.Новый_оклад.Value = int.Parse(Таблица.Rows[k].Cells[7].Value.ToString());
        }
    
        private void Удалить_запись_Click(object sender, EventArgs e)
        {
            int k = Таблица.SelectedCells[0].RowIndex;
            FormError FormError = new FormError
            {
                Owner = this
            };
            FormError.Show();
            FormError.Строка_подтверждения.Text += $"(ID = {Таблица.Rows[k].Cells[0].Value})";
        }

        private void FormTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormMenu FormMenu = new FormMenu();
            FormMenu.Show();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {

        }

        private void обновитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Таблица.DataSource = controller.UpdateEmployee();
        }

        private void Анализ_данных_1_таблицы_Click(object sender, EventArgs e)
        {
            FormСalculate FormCalculate = new FormСalculate()
            {
                Owner = this
            };
            FormCalculate.Show();
        }

        private void Работа_со_2_таблицей_Click(object sender, EventArgs e)
        {
            FormIncrease FormTwoForm = new FormIncrease()
            {
                Owner = this
            };
            FormTwoForm.Show();
        }

        private void О_программе_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный органайзер менеждера по учёту сотрудников университета разработан" +
                " студенткой 2 курса Мещеряковой Евгенией во время выполнения курсового проекта по *ТРПО*\nКубГТУ 2022г.", "О программе");
        }

        private void удалениеСотрпенсвозрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Parse(DateTime.Now.ToShortDateString());
            foreach (DataGridViewRow row in Таблица.Rows)
            {
                DateTime date_of_birth = DateTime.Parse(row.Cells[3].Value.ToString());
                int age = Now.Subtract(date_of_birth).Days / 365;

                if (age >= 55 && row.Cells[2].Value.ToString() == "ж")
                {
                    controller.Delete(int.Parse(row.Cells[0].Value.ToString()));
                }
                else if (age >= 60)
                {
                    controller.Delete(int.Parse(row.Cells[0].Value.ToString()));
                }
            }
            Таблица2.Rows.Clear(); //очищаю таблицу
            Таблица.DataSource = controller.UpdateEmployee(); //обновляю            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Вкладка2_Selected(object sender, TabControlEventArgs e)
        {

        }
    }
}