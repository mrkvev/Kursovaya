using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormEdit : Form
    {
        Query controller;
        public FormEdit()
        {
            InitializeComponent();
            controller = new Query(ConnectionSrting.ConnStr);
        }

        private void form6_Load(object sender, EventArgs e)
        {


        }
        private void Кнопка_сохранить_новые_данные_Click(object sender, EventArgs e)
        {
            FormTable FormTable = Owner as FormTable;
            string g = "м";
            if (Новый_женский_пол.Checked == true)
            {
                g = "ж";
            }
            if (Новая_фамилия.Text == "" || Новое_названия_отдела.Text == "" || Новая_должность.Text == "")
            {
                MessageBox.Show("Заполнены не все обязательные поля!", "Внимание!");
                return;
            }
            controller.UpDate(int.Parse(Айди.Text), Новая_фамилия.Text, g, Новая_дата_рождения.Value, Новое_названия_отдела.Text, Новая_должность.Text, Новая_дата_поступления_на_работу.Value, Новый_оклад.Value);
            FormTable.Таблица.DataSource = controller.UpdateEmployee();

            //обновляю вторую таблицу
            DateTime date_of_birth = DateTime.Parse(Новая_дата_рождения.Value.ToString());
            DateTime enrollment_date = DateTime.Parse(Новая_дата_поступления_на_работу.Value.ToString());
            DateTime Now = DateTime.Parse(DateTime.Now.ToShortDateString());
            double experience = Now.Subtract(enrollment_date).Days;
            foreach (DataGridViewRow row in FormTable.Таблица2.Rows)
            {
                if (row.Cells[0].Value.ToString() == Айди.Text)
                {
                    row.Cells[1].Value = Новая_фамилия.Text;
                    row.Cells[2].Value = g;
                    row.Cells[3].Value = date_of_birth.ToShortDateString();
                    row.Cells[4].Value = enrollment_date.ToShortDateString();
                    row.Cells[5].Value = Math.Round(experience / 365, 2);
                    row.Cells[6].Value = Новый_оклад.Value;
                    Close();
                    return;
                }
            }
            int age = Now.Subtract(date_of_birth).Days / 365; // сколько лет сотруднику
            if (age >= 55 && g == "ж")
            {
                FormTable.Таблица2.Rows.Add(Айди.Text, Новая_фамилия.Text, g, date_of_birth.ToShortDateString(), enrollment_date.ToShortDateString(), Math.Round(experience / 365, 2), Новый_оклад.Value);
            }
            else if (age >= 60)
            {
                FormTable.Таблица2.Rows.Add(Айди.Text, Новая_фамилия.Text, g, date_of_birth.ToShortDateString(), enrollment_date.ToShortDateString(), Math.Round(experience / 365, 2), Новый_оклад.Value);
            }
            
            Close();
            MessageBox.Show("Учетная запись обновлена!", "Внимание!");
        }

        private void Кнопка_отменить_создавать_новую_запись_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
