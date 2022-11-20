using System;
using System.Windows.Forms;

namespace Сведения_о_сотрудниках
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Study_plan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный раздел в разработке!","Внимание!");
        }
        private void Teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuthorization FormAuthorization1 = new FormAuthorization();
            FormAuthorization1.Show();
        }
        private void Students_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный раздел в разработке!", "Внимание!");
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
