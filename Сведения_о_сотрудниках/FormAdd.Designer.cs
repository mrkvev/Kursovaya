
namespace Сведения_о_сотрудниках
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.Текст_фамилия = new System.Windows.Forms.Label();
            this.Текст_пол = new System.Windows.Forms.Label();
            this.Текст_дата_рождения = new System.Windows.Forms.Label();
            this.Текст_дата_поступления_на_работу = new System.Windows.Forms.Label();
            this.Текст_должность = new System.Windows.Forms.Label();
            this.Текст_название_отдела = new System.Windows.Forms.Label();
            this.Текст_оклад = new System.Windows.Forms.Label();
            this.Ввод_оклада = new System.Windows.Forms.NumericUpDown();
            this.Ввод_фамилии = new System.Windows.Forms.TextBox();
            this.Дата_рождения = new System.Windows.Forms.DateTimePicker();
            this.Дата_поступления_на_работу = new System.Windows.Forms.DateTimePicker();
            this.Женский_пол = new System.Windows.Forms.RadioButton();
            this.Мужской_пол = new System.Windows.Forms.RadioButton();
            this.Кнопка_отменить_создавать_новую_запись = new System.Windows.Forms.Button();
            this.Кнопка_сохранить_новую_запись = new System.Windows.Forms.Button();
            this.Ввод_должности = new System.Windows.Forms.ComboBox();
            this.Ввод_названия_отдела = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ввод_оклада)).BeginInit();
            this.SuspendLayout();
            // 
            // Текст_фамилия
            // 
            this.Текст_фамилия.AutoSize = true;
            this.Текст_фамилия.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Текст_фамилия.Location = new System.Drawing.Point(28, 35);
            this.Текст_фамилия.Name = "Текст_фамилия";
            this.Текст_фамилия.Size = new System.Drawing.Size(85, 20);
            this.Текст_фамилия.TabIndex = 0;
            this.Текст_фамилия.Text = "Фамилия:";
            // 
            // Текст_пол
            // 
            this.Текст_пол.AutoSize = true;
            this.Текст_пол.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Текст_пол.Location = new System.Drawing.Point(28, 69);
            this.Текст_пол.Name = "Текст_пол";
            this.Текст_пол.Size = new System.Drawing.Size(44, 20);
            this.Текст_пол.TabIndex = 1;
            this.Текст_пол.Text = "Пол:";
            // 
            // Текст_дата_рождения
            // 
            this.Текст_дата_рождения.AutoSize = true;
            this.Текст_дата_рождения.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Текст_дата_рождения.Location = new System.Drawing.Point(28, 105);
            this.Текст_дата_рождения.Name = "Текст_дата_рождения";
            this.Текст_дата_рождения.Size = new System.Drawing.Size(132, 20);
            this.Текст_дата_рождения.TabIndex = 2;
            this.Текст_дата_рождения.Text = "Дата рождения:";
            // 
            // Текст_дата_поступления_на_работу
            // 
            this.Текст_дата_поступления_на_работу.AutoSize = true;
            this.Текст_дата_поступления_на_работу.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Текст_дата_поступления_на_работу.Location = new System.Drawing.Point(28, 140);
            this.Текст_дата_поступления_на_работу.Name = "Текст_дата_поступления_на_работу";
            this.Текст_дата_поступления_на_работу.Size = new System.Drawing.Size(231, 20);
            this.Текст_дата_поступления_на_работу.TabIndex = 3;
            this.Текст_дата_поступления_на_работу.Text = "Дата поступления на работу:";
            // 
            // Текст_должность
            // 
            this.Текст_должность.AutoSize = true;
            this.Текст_должность.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Текст_должность.Location = new System.Drawing.Point(28, 213);
            this.Текст_должность.Name = "Текст_должность";
            this.Текст_должность.Size = new System.Drawing.Size(99, 20);
            this.Текст_должность.TabIndex = 4;
            this.Текст_должность.Text = "Должность:";
            // 
            // Текст_название_отдела
            // 
            this.Текст_название_отдела.AutoSize = true;
            this.Текст_название_отдела.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Текст_название_отдела.Location = new System.Drawing.Point(28, 177);
            this.Текст_название_отдела.Name = "Текст_название_отдела";
            this.Текст_название_отдела.Size = new System.Drawing.Size(148, 20);
            this.Текст_название_отдела.TabIndex = 5;
            this.Текст_название_отдела.Text = "Название отдела:";
            // 
            // Текст_оклад
            // 
            this.Текст_оклад.AutoSize = true;
            this.Текст_оклад.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Текст_оклад.Location = new System.Drawing.Point(28, 250);
            this.Текст_оклад.Name = "Текст_оклад";
            this.Текст_оклад.Size = new System.Drawing.Size(63, 20);
            this.Текст_оклад.TabIndex = 6;
            this.Текст_оклад.Text = "Оклад:";
            // 
            // Ввод_оклада
            // 
            this.Ввод_оклада.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ввод_оклада.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Ввод_оклада.Location = new System.Drawing.Point(307, 248);
            this.Ввод_оклада.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Ввод_оклада.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.Ввод_оклада.Name = "Ввод_оклада";
            this.Ввод_оклада.Size = new System.Drawing.Size(120, 26);
            this.Ввод_оклада.TabIndex = 24;
            this.Ввод_оклада.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // Ввод_фамилии
            // 
            this.Ввод_фамилии.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ввод_фамилии.Location = new System.Drawing.Point(306, 35);
            this.Ввод_фамилии.Name = "Ввод_фамилии";
            this.Ввод_фамилии.Size = new System.Drawing.Size(234, 26);
            this.Ввод_фамилии.TabIndex = 20;
            // 
            // Дата_рождения
            // 
            this.Дата_рождения.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Дата_рождения.Location = new System.Drawing.Point(306, 100);
            this.Дата_рождения.Name = "Дата_рождения";
            this.Дата_рождения.Size = new System.Drawing.Size(234, 26);
            this.Дата_рождения.TabIndex = 19;
            // 
            // Дата_поступления_на_работу
            // 
            this.Дата_поступления_на_работу.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Дата_поступления_на_работу.Location = new System.Drawing.Point(306, 135);
            this.Дата_поступления_на_работу.Name = "Дата_поступления_на_работу";
            this.Дата_поступления_на_работу.Size = new System.Drawing.Size(234, 26);
            this.Дата_поступления_на_работу.TabIndex = 18;
            // 
            // Женский_пол
            // 
            this.Женский_пол.AutoSize = true;
            this.Женский_пол.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Женский_пол.Location = new System.Drawing.Point(358, 69);
            this.Женский_пол.Name = "Женский_пол";
            this.Женский_пол.Size = new System.Drawing.Size(45, 24);
            this.Женский_пол.TabIndex = 14;
            this.Женский_пол.TabStop = true;
            this.Женский_пол.Text = "ж";
            this.Женский_пол.UseVisualStyleBackColor = true;
            // 
            // Мужской_пол
            // 
            this.Мужской_пол.AutoSize = true;
            this.Мужской_пол.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Мужской_пол.Location = new System.Drawing.Point(307, 69);
            this.Мужской_пол.Name = "Мужской_пол";
            this.Мужской_пол.Size = new System.Drawing.Size(45, 24);
            this.Мужской_пол.TabIndex = 13;
            this.Мужской_пол.TabStop = true;
            this.Мужской_пол.Text = "м";
            this.Мужской_пол.UseVisualStyleBackColor = true;
            // 
            // Кнопка_отменить_создавать_новую_запись
            // 
            this.Кнопка_отменить_создавать_новую_запись.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Кнопка_отменить_создавать_новую_запись.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_отменить_создавать_новую_запись.Location = new System.Drawing.Point(32, 312);
            this.Кнопка_отменить_создавать_новую_запись.Name = "Кнопка_отменить_создавать_новую_запись";
            this.Кнопка_отменить_создавать_новую_запись.Size = new System.Drawing.Size(116, 38);
            this.Кнопка_отменить_создавать_новую_запись.TabIndex = 11;
            this.Кнопка_отменить_создавать_новую_запись.Text = "Отменить";
            this.Кнопка_отменить_создавать_новую_запись.UseVisualStyleBackColor = false;
            this.Кнопка_отменить_создавать_новую_запись.Click += new System.EventHandler(this.Кнопка_отменить_создавать_новую_запись_Click);
            // 
            // Кнопка_сохранить_новую_запись
            // 
            this.Кнопка_сохранить_новую_запись.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Кнопка_сохранить_новую_запись.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_сохранить_новую_запись.Location = new System.Drawing.Point(409, 312);
            this.Кнопка_сохранить_новую_запись.Name = "Кнопка_сохранить_новую_запись";
            this.Кнопка_сохранить_новую_запись.Size = new System.Drawing.Size(141, 38);
            this.Кнопка_сохранить_новую_запись.TabIndex = 10;
            this.Кнопка_сохранить_новую_запись.Text = "Сохранить";
            this.Кнопка_сохранить_новую_запись.UseVisualStyleBackColor = false;
            this.Кнопка_сохранить_новую_запись.Click += new System.EventHandler(this.Кнопка_сохранить_новую_запись_Click);
            // 
            // Ввод_должности
            // 
            this.Ввод_должности.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ввод_должности.FormattingEnabled = true;
            this.Ввод_должности.Items.AddRange(new object[] {
            "Ведущий научный сотрудник",
            "Внештатный преподаватель",
            "Доцент",
            "Координатор",
            "Куратор",
            "Лаборант",
            "Младший научный сотрудник",
            "Научный сотрудник",
            "Преподаватель",
            "Профессор",
            "Специалист по учебно-методической работе",
            "Старший научный сотрудник",
            "Старший преподаватель"});
            this.Ввод_должности.Location = new System.Drawing.Point(306, 210);
            this.Ввод_должности.Name = "Ввод_должности";
            this.Ввод_должности.Size = new System.Drawing.Size(234, 28);
            this.Ввод_должности.TabIndex = 25;
            // 
            // Ввод_названия_отдела
            // 
            this.Ввод_названия_отдела.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ввод_названия_отдела.FormattingEnabled = true;
            this.Ввод_названия_отдела.Items.AddRange(new object[] {
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
            this.Ввод_названия_отдела.Location = new System.Drawing.Point(306, 174);
            this.Ввод_названия_отдела.Name = "Ввод_названия_отдела";
            this.Ввод_названия_отдела.Size = new System.Drawing.Size(234, 28);
            this.Ввод_названия_отдела.TabIndex = 26;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 366);
            this.Controls.Add(this.Ввод_названия_отдела);
            this.Controls.Add(this.Ввод_должности);
            this.Controls.Add(this.Кнопка_сохранить_новую_запись);
            this.Controls.Add(this.Ввод_оклада);
            this.Controls.Add(this.Кнопка_отменить_создавать_новую_запись);
            this.Controls.Add(this.Текст_оклад);
            this.Controls.Add(this.Дата_рождения);
            this.Controls.Add(this.Ввод_фамилии);
            this.Controls.Add(this.Дата_поступления_на_работу);
            this.Controls.Add(this.Текст_название_отдела);
            this.Controls.Add(this.Текст_фамилия);
            this.Controls.Add(this.Текст_должность);
            this.Controls.Add(this.Женский_пол);
            this.Controls.Add(this.Текст_пол);
            this.Controls.Add(this.Мужской_пол);
            this.Controls.Add(this.Текст_дата_поступления_на_работу);
            this.Controls.Add(this.Текст_дата_рождения);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = " Добавить сотрудника";
            this.Load += new System.EventHandler(this.form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ввод_оклада)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Текст_фамилия;
        private System.Windows.Forms.Label Текст_пол;
        private System.Windows.Forms.Label Текст_дата_рождения;
        private System.Windows.Forms.Label Текст_дата_поступления_на_работу;
        private System.Windows.Forms.Label Текст_должность;
        private System.Windows.Forms.Label Текст_название_отдела;
        private System.Windows.Forms.Label Текст_оклад;
        private System.Windows.Forms.Button Кнопка_сохранить_новую_запись;
        private System.Windows.Forms.Button Кнопка_отменить_создавать_новую_запись;
        private System.Windows.Forms.RadioButton Женский_пол;
        private System.Windows.Forms.RadioButton Мужской_пол;
        private System.Windows.Forms.DateTimePicker Дата_поступления_на_работу;
        private System.Windows.Forms.TextBox Ввод_фамилии;
        private System.Windows.Forms.DateTimePicker Дата_рождения;
        private System.Windows.Forms.NumericUpDown Ввод_оклада;
        private System.Windows.Forms.ComboBox Ввод_должности;
        private System.Windows.Forms.ComboBox Ввод_названия_отдела;
    }
}