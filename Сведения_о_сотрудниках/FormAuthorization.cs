using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        // логин админ/ пароль KubSTU22
        private void FormAuthorization1_Load(object sender, EventArgs e)
        {
            Пароль.UseSystemPasswordChar = true;            
        }

        private void Кнопка_войти_Click(object sender, EventArgs e)
        {
            if (Логин.Text == "Admin" && Пароль.Text == "KubSTU22")
            {
                this.Hide();
                FormTable FormTable = new FormTable();
                FormTable.Show();                
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                Пароль.Text = "";
            }
        }

        private void Кнопка_пропустить_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTable FormTable = new FormTable();
            FormTable.Show();
            FormTable.работаСТаблицейToolStripMenuItem.Enabled = false;
            FormTable.Работа_со_2_таблицей.Enabled = false;
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormMenu FormMenu = new FormMenu();
            FormMenu.Show();
        }
    }
}
