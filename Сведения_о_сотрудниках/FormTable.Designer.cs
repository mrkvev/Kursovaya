
namespace Сведения_о_сотрудниках
{
    partial class FormTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Добавить_запись = new System.Windows.Forms.ToolStripMenuItem();
            this.Редактировать_запись = new System.Windows.Forms.ToolStripMenuItem();
            this.Удалить_запись = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеСотрпенсвозрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Анализ_данных_1_таблицы = new System.Windows.Forms.ToolStripMenuItem();
            this.Работа_со_2_таблицей = new System.Windows.Forms.ToolStripMenuItem();
            this.Справка = new System.Windows.Forms.ToolStripMenuItem();
            this.О_программе = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Таблица2 = new System.Windows.Forms.DataGridView();
            this.ID_сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_рождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_поступления_на_работу = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стаж = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оклад = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Таблица = new System.Windows.Forms.DataGridView();
            this.Вкладка2 = new System.Windows.Forms.TabControl();
            this.таблицаTableAdapter = new Сведения_о_сотрудниках.БазаСотрудниковDataSetTableAdapters.ТаблицаTableAdapter();
            this.таблицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Таблица2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Таблица)).BeginInit();
            this.Вкладка2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицейToolStripMenuItem,
            this.Анализ_данных_1_таблицы,
            this.Работа_со_2_таблицей,
            this.Справка});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1099, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТаблицейToolStripMenuItem
            // 
            this.работаСТаблицейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Добавить_запись,
            this.Редактировать_запись,
            this.Удалить_запись,
            this.удалениеСотрпенсвозрToolStripMenuItem});
            this.работаСТаблицейToolStripMenuItem.Name = "работаСТаблицейToolStripMenuItem";
            this.работаСТаблицейToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            this.работаСТаблицейToolStripMenuItem.Text = "Работа с таблицей";
            // 
            // Добавить_запись
            // 
            this.Добавить_запись.Name = "Добавить_запись";
            this.Добавить_запись.Size = new System.Drawing.Size(491, 34);
            this.Добавить_запись.Text = "Добавить запись";
            this.Добавить_запись.Click += new System.EventHandler(this.Добавить_запись_Click);
            // 
            // Редактировать_запись
            // 
            this.Редактировать_запись.Name = "Редактировать_запись";
            this.Редактировать_запись.Size = new System.Drawing.Size(491, 34);
            this.Редактировать_запись.Text = "Редактировать запись";
            this.Редактировать_запись.Click += new System.EventHandler(this.Редактировать_запись_Click);
            // 
            // Удалить_запись
            // 
            this.Удалить_запись.Name = "Удалить_запись";
            this.Удалить_запись.Size = new System.Drawing.Size(491, 34);
            this.Удалить_запись.Text = "Удалить запись";
            this.Удалить_запись.Click += new System.EventHandler(this.Удалить_запись_Click);
            // 
            // удалениеСотрпенсвозрToolStripMenuItem
            // 
            this.удалениеСотрпенсвозрToolStripMenuItem.Name = "удалениеСотрпенсвозрToolStripMenuItem";
            this.удалениеСотрпенсвозрToolStripMenuItem.Size = new System.Drawing.Size(491, 34);
            this.удалениеСотрпенсвозрToolStripMenuItem.Text = "Удаление сотрудников пенсионного возраста";
            this.удалениеСотрпенсвозрToolStripMenuItem.Click += new System.EventHandler(this.удалениеСотрпенсвозрToolStripMenuItem_Click);
            // 
            // Анализ_данных_1_таблицы
            // 
            this.Анализ_данных_1_таблицы.Name = "Анализ_данных_1_таблицы";
            this.Анализ_данных_1_таблицы.Size = new System.Drawing.Size(291, 32);
            this.Анализ_данных_1_таблицы.Text = "Анализ данных первой таблицы";
            this.Анализ_данных_1_таблицы.Click += new System.EventHandler(this.Анализ_данных_1_таблицы_Click);
            // 
            // Работа_со_2_таблицей
            // 
            this.Работа_со_2_таблицей.Name = "Работа_со_2_таблицей";
            this.Работа_со_2_таблицей.Size = new System.Drawing.Size(253, 32);
            this.Работа_со_2_таблицей.Text = "Работа со второй таблицей";
            this.Работа_со_2_таблицей.Click += new System.EventHandler(this.Работа_со_2_таблицей_Click);
            // 
            // Справка
            // 
            this.Справка.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.О_программе});
            this.Справка.Name = "Справка";
            this.Справка.Size = new System.Drawing.Size(97, 32);
            this.Справка.Text = "Справка";
            // 
            // О_программе
            // 
            this.О_программе.Name = "О_программе";
            this.О_программе.Size = new System.Drawing.Size(227, 34);
            this.О_программе.Text = "О программе";
            this.О_программе.Click += new System.EventHandler(this.О_программе_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Таблица2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1091, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица сотрудников пенсионного возраста";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Таблица2
            // 
            this.Таблица2.AllowUserToAddRows = false;
            this.Таблица2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.Таблица2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Таблица2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Таблица2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Таблица2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_сотрудника,
            this.Фамилия,
            this.Пол,
            this.Дата_рождения,
            this.Дата_поступления_на_работу,
            this.Стаж,
            this.Оклад});
            this.Таблица2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Таблица2.Location = new System.Drawing.Point(3, 2);
            this.Таблица2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Таблица2.Name = "Таблица2";
            this.Таблица2.ReadOnly = true;
            this.Таблица2.RowHeadersWidth = 62;
            this.Таблица2.RowTemplate.Height = 28;
            this.Таблица2.Size = new System.Drawing.Size(1085, 454);
            this.Таблица2.TabIndex = 0;
            // 
            // ID_сотрудника
            // 
            this.ID_сотрудника.Frozen = true;
            this.ID_сотрудника.HeaderText = "ID сотрудника";
            this.ID_сотрудника.MinimumWidth = 8;
            this.ID_сотрудника.Name = "ID_сотрудника";
            this.ID_сотрудника.ReadOnly = true;
            this.ID_сотрудника.Width = 150;
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.MinimumWidth = 8;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.ReadOnly = true;
            this.Фамилия.Width = 150;
            // 
            // Пол
            // 
            this.Пол.HeaderText = "Пол";
            this.Пол.MinimumWidth = 8;
            this.Пол.Name = "Пол";
            this.Пол.ReadOnly = true;
            this.Пол.Width = 150;
            // 
            // Дата_рождения
            // 
            this.Дата_рождения.HeaderText = "Дата рождения";
            this.Дата_рождения.MinimumWidth = 8;
            this.Дата_рождения.Name = "Дата_рождения";
            this.Дата_рождения.ReadOnly = true;
            this.Дата_рождения.Width = 150;
            // 
            // Дата_поступления_на_работу
            // 
            this.Дата_поступления_на_работу.HeaderText = "Дата поступления на работу";
            this.Дата_поступления_на_работу.MinimumWidth = 8;
            this.Дата_поступления_на_работу.Name = "Дата_поступления_на_работу";
            this.Дата_поступления_на_работу.ReadOnly = true;
            this.Дата_поступления_на_работу.Width = 150;
            // 
            // Стаж
            // 
            this.Стаж.HeaderText = "Стаж работы в годах";
            this.Стаж.MinimumWidth = 8;
            this.Стаж.Name = "Стаж";
            this.Стаж.ReadOnly = true;
            this.Стаж.Width = 150;
            // 
            // Оклад
            // 
            this.Оклад.HeaderText = "Оклад";
            this.Оклад.MinimumWidth = 8;
            this.Оклад.Name = "Оклад";
            this.Оклад.ReadOnly = true;
            this.Оклад.Width = 150;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Таблица);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1091, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица сотрудников";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Таблица
            // 
            this.Таблица.AllowUserToAddRows = false;
            this.Таблица.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.Таблица.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Таблица.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Таблица.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Таблица.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Таблица.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Таблица.Location = new System.Drawing.Point(3, 2);
            this.Таблица.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Таблица.Name = "Таблица";
            this.Таблица.ReadOnly = true;
            this.Таблица.RowHeadersWidth = 62;
            this.Таблица.RowTemplate.Height = 28;
            this.Таблица.Size = new System.Drawing.Size(1085, 457);
            this.Таблица.TabIndex = 2;
            // 
            // Вкладка2
            // 
            this.Вкладка2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Вкладка2.Controls.Add(this.tabPage1);
            this.Вкладка2.Controls.Add(this.tabPage2);
            this.Вкладка2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Вкладка2.Location = new System.Drawing.Point(0, 36);
            this.Вкладка2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Вкладка2.Multiline = true;
            this.Вкладка2.Name = "Вкладка2";
            this.Вкладка2.SelectedIndex = 0;
            this.Вкладка2.Size = new System.Drawing.Size(1099, 491);
            this.Вкладка2.TabIndex = 3;
            this.Вкладка2.Selected += new System.Windows.Forms.TabControlEventHandler(this.Вкладка2_Selected);
            // 
            // таблицаTableAdapter
            // 
            this.таблицаTableAdapter.ClearBeforeFill = true;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1099, 527);
            this.Controls.Add(this.Вкладка2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTable";
            this.Text = "Учетная книга сотрудников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTable_FormClosing);
            this.Load += new System.EventHandler(this.FormTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Таблица2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Таблица)).EndInit();
            this.Вкладка2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.таблицаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem работаСТаблицейToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Добавить_запись;
        public System.Windows.Forms.BindingSource таблицаBindingSource;
        public БазаСотрудниковDataSetTableAdapters.ТаблицаTableAdapter таблицаTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem Редактировать_запись;
        private System.Windows.Forms.ToolStripMenuItem Удалить_запись;
        private System.Windows.Forms.ToolStripMenuItem Справка;
        private System.Windows.Forms.ToolStripMenuItem О_программе;
        private System.Windows.Forms.ToolStripMenuItem Анализ_данных_1_таблицы;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView Таблица;
        public System.Windows.Forms.TabControl Вкладка2;
        public System.Windows.Forms.DataGridView Таблица2;
        public System.Windows.Forms.ToolStripMenuItem Работа_со_2_таблицей;
        private System.Windows.Forms.ToolStripMenuItem удалениеСотрпенсвозрToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пол;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_рождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_поступления_на_работу;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стаж;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оклад;
    }
}