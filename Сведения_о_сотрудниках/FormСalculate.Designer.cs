
namespace Сведения_о_сотрудниках
{
    partial class FormСalculate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormСalculate));
            this.label1 = new System.Windows.Forms.Label();
            this.Какая_задача = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Лабел = new System.Windows.Forms.Label();
            this.Выберите_название_отдела = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Вывод_ответа = new System.Windows.Forms.TextBox();
            this.Таблица_стажа = new System.Windows.Forms.DataGridView();
            this.ID_сотудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стаж_работы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стаж_работы_в_годах = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Выберите_оклад = new System.Windows.Forms.NumericUpDown();
            this.Кнопка_отменить_создавать_новую_запись = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Таблица_стажа)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выберите_оклад)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите задачу:";
            // 
            // Какая_задача
            // 
            this.Какая_задача.FormattingEnabled = true;
            this.Какая_задача.Items.AddRange(new object[] {
            "Стаж работы всех сотрудников",
            "Средний стаж работы сотрудников заданного отдела",
            "Количество сотрудников с окладом ниже заданного"});
            this.Какая_задача.Location = new System.Drawing.Point(209, 19);
            this.Какая_задача.Name = "Какая_задача";
            this.Какая_задача.Size = new System.Drawing.Size(396, 28);
            this.Какая_задача.TabIndex = 4;
            this.Какая_задача.SelectedIndexChanged += new System.EventHandler(this.Какая_задача_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Лабел);
            this.panel1.Controls.Add(this.Выберите_название_отдела);
            this.panel1.Location = new System.Drawing.Point(18, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 64);
            this.panel1.TabIndex = 6;
            // 
            // Лабел
            // 
            this.Лабел.AutoSize = true;
            this.Лабел.Location = new System.Drawing.Point(12, 21);
            this.Лабел.Name = "Лабел";
            this.Лабел.Size = new System.Drawing.Size(148, 20);
            this.Лабел.TabIndex = 1;
            this.Лабел.Text = "Название отдела:";
            // 
            // Выберите_название_отдела
            // 
            this.Выберите_название_отдела.FormattingEnabled = true;
            this.Выберите_название_отдела.Items.AddRange(new object[] {
            "Кафедра зарубежной журналистики и литературы",
            "Кафедра истории и правового регулирования отечественных СМИ",
            "Кафедра истории русской литературы и журналистики",
            "Кафедра литературно-художественной критики и публицистики",
            "Кафедра медиалингвистики",
            "Кафедра новой и новейшей истории",
            "Кафедра новых медиа и теории коммуникации",
            "Кафедра рекламы и связей с общественностью",
            "Кафедра социологии массовых коммуникаций",
            "Кафедра стилистики русского языка",
            "Кафедра телевидения и радиовещания",
            "Кафедра теории и методики редактирования",
            "Кафедра теории и экономики СМИ",
            "Кафедра фотожурналистики и технологий СМИ",
            "Кафедра цифровой журналистики",
            "Учебный мультимедийный центр"});
            this.Выберите_название_отдела.Location = new System.Drawing.Point(191, 18);
            this.Выберите_название_отдела.Name = "Выберите_название_отдела";
            this.Выберите_название_отдела.Size = new System.Drawing.Size(280, 28);
            this.Выберите_название_отдела.TabIndex = 0;
            this.Выберите_название_отдела.SelectedIndexChanged += new System.EventHandler(this.Выберите_название_отдела_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ответ:";
            // 
            // Вывод_ответа
            // 
            this.Вывод_ответа.Location = new System.Drawing.Point(659, 83);
            this.Вывод_ответа.Multiline = true;
            this.Вывод_ответа.Name = "Вывод_ответа";
            this.Вывод_ответа.Size = new System.Drawing.Size(96, 28);
            this.Вывод_ответа.TabIndex = 8;
            // 
            // Таблица_стажа
            // 
            this.Таблица_стажа.AllowUserToAddRows = false;
            this.Таблица_стажа.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Таблица_стажа.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Таблица_стажа.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Таблица_стажа.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_сотудника,
            this.Стаж_работы,
            this.Стаж_работы_в_годах});
            this.Таблица_стажа.Location = new System.Drawing.Point(18, 215);
            this.Таблица_стажа.Name = "Таблица_стажа";
            this.Таблица_стажа.ReadOnly = true;
            this.Таблица_стажа.RowHeadersWidth = 62;
            this.Таблица_стажа.RowTemplate.Height = 28;
            this.Таблица_стажа.Size = new System.Drawing.Size(587, 201);
            this.Таблица_стажа.TabIndex = 9;
            // 
            // ID_сотудника
            // 
            this.ID_сотудника.Frozen = true;
            this.ID_сотудника.HeaderText = "ID сотрудника";
            this.ID_сотудника.MinimumWidth = 8;
            this.ID_сотудника.Name = "ID_сотудника";
            this.ID_сотудника.ReadOnly = true;
            this.ID_сотудника.Width = 80;
            // 
            // Стаж_работы
            // 
            this.Стаж_работы.Frozen = true;
            this.Стаж_работы.HeaderText = "Стаж работы в днях";
            this.Стаж_работы.MinimumWidth = 8;
            this.Стаж_работы.Name = "Стаж_работы";
            this.Стаж_работы.ReadOnly = true;
            this.Стаж_работы.Width = 125;
            // 
            // Стаж_работы_в_годах
            // 
            this.Стаж_работы_в_годах.Frozen = true;
            this.Стаж_работы_в_годах.HeaderText = "Стаж работы в годах";
            this.Стаж_работы_в_годах.MinimumWidth = 8;
            this.Стаж_работы_в_годах.Name = "Стаж_работы_в_годах";
            this.Стаж_работы_в_годах.ReadOnly = true;
            this.Стаж_работы_в_годах.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Выберите_оклад);
            this.panel2.Location = new System.Drawing.Point(18, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 64);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Оклад:";
            // 
            // Выберите_оклад
            // 
            this.Выберите_оклад.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Выберите_оклад.Location = new System.Drawing.Point(191, 21);
            this.Выберите_оклад.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Выберите_оклад.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.Выберите_оклад.Name = "Выберите_оклад";
            this.Выберите_оклад.Size = new System.Drawing.Size(280, 26);
            this.Выберите_оклад.TabIndex = 0;
            this.Выберите_оклад.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.Выберите_оклад.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Кнопка_отменить_создавать_новую_запись
            // 
            this.Кнопка_отменить_создавать_новую_запись.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Кнопка_отменить_создавать_новую_запись.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_отменить_создавать_новую_запись.Location = new System.Drawing.Point(639, 378);
            this.Кнопка_отменить_создавать_новую_запись.Name = "Кнопка_отменить_создавать_новую_запись";
            this.Кнопка_отменить_создавать_новую_запись.Size = new System.Drawing.Size(116, 38);
            this.Кнопка_отменить_создавать_новую_запись.TabIndex = 12;
            this.Кнопка_отменить_создавать_новую_запись.Text = "Отменить";
            this.Кнопка_отменить_создавать_новую_запись.UseVisualStyleBackColor = false;
            this.Кнопка_отменить_создавать_новую_запись.Click += new System.EventHandler(this.Кнопка_отменить_создавать_новую_запись_Click);
            // 
            // FormСalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 434);
            this.Controls.Add(this.Кнопка_отменить_создавать_новую_запись);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Таблица_стажа);
            this.Controls.Add(this.Вывод_ответа);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Какая_задача);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormСalculate";
            this.Text = "Анализ данных первой таблицы";
            this.Load += new System.EventHandler(this.FormСalculate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Таблица_стажа)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Выберите_оклад)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Какая_задача;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Лабел;
        private System.Windows.Forms.ComboBox Выберите_название_отдела;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Вывод_ответа;
        private System.Windows.Forms.DataGridView Таблица_стажа;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Выберите_оклад;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_сотудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стаж_работы;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стаж_работы_в_годах;
        private System.Windows.Forms.Button Кнопка_отменить_создавать_новую_запись;
    }
}