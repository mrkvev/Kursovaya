using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormAdd : Form
    {
        Query controller;
        public FormAdd()
        {
            InitializeComponent();
            controller = new Query(ConnectionSrting.ConnStr);
        }

        private void form3_Load(object sender, EventArgs e)
        {

        }

        private void Кнопка_сохранить_новую_запись_Click(object sender, EventArgs e) //сохранить
        {
            FormTable FormTable = Owner as FormTable;
            int max = int.MinValue;
            bool flag = false;
            foreach (DataGridViewRow row in FormTable.Таблица.Rows)
            {
                if (int.Parse(row.Cells[0].Value.ToString()) > max)
                {
                    max = int.Parse(row.Cells[0].Value.ToString());
                    flag = true;
                }
            }
            if (flag == false)
            {
                max = 0;
            }
            int ID = max + 1;
            string gender = "ж";
            if (Мужской_пол.Checked == true)
            { gender = "м"; }
            if (Ввод_фамилии.Text == "" || Ввод_названия_отдела.Text == "" || Ввод_должности.Text == "" || (Мужской_пол.Checked == false && Женский_пол.Checked == false))
            {
                MessageBox.Show("Заполнены не все обязательные поля!", "Внимание!");
                return;
            }
            DateTime enrollment_date = DateTime.Parse(Дата_поступления_на_работу.Value.ToString());
            DateTime date_of_birth = DateTime.Parse(Дата_рождения.Value.ToString());
            controller.Add(ID, Ввод_фамилии.Text, gender, date_of_birth, Ввод_названия_отдела.Text, Ввод_должности.Text, enrollment_date, Ввод_оклада.Value);
            FormTable.Таблица.DataSource = controller.UpdateEmployee();

            //обновление второй таблицы
            DateTime Now = DateTime.Parse(DateTime.Now.ToShortDateString());            
            double experience = Now.Subtract(enrollment_date).Days;
            int age = Now.Subtract(date_of_birth).Days / 365; // сколько лет сотруднику
            if (age >= 55 && gender == "ж")
            {
                FormTable.Таблица2.Rows.Add(ID, Ввод_фамилии.Text, gender, date_of_birth.ToShortDateString(), enrollment_date.ToShortDateString(), Math.Round(experience / 365,2), Ввод_оклада.Value);
            }
            else if (age >= 60)
            {
                FormTable.Таблица2.Rows.Add(ID, Ввод_фамилии.Text, gender, date_of_birth.ToShortDateString(), enrollment_date.ToShortDateString(), Math.Round(experience / 365, 2), Ввод_оклада.Value);
            }
            Close();
            MessageBox.Show("Учетная запись добавлена!", "Внимание!");
        }

        private void Кнопка_отменить_создавать_новую_запись_Click(object sender, EventArgs e) //отменить
        {
            Close();
        }
    }
}
