
namespace Сведения_о_сотрудниках
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.Teacher = new System.Windows.Forms.Button();
            this.Study_plan = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Teacher
            // 
            this.Teacher.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teacher.Location = new System.Drawing.Point(145, 115);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(231, 54);
            this.Teacher.TabIndex = 3;
            this.Teacher.Text = "Список сотрудников";
            this.Teacher.UseVisualStyleBackColor = false;
            this.Teacher.Click += new System.EventHandler(this.Teacher_Click);
            // 
            // Study_plan
            // 
            this.Study_plan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Study_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Study_plan.Location = new System.Drawing.Point(145, 175);
            this.Study_plan.Name = "Study_plan";
            this.Study_plan.Size = new System.Drawing.Size(231, 54);
            this.Study_plan.TabIndex = 1;
            this.Study_plan.Text = "Учебный план";
            this.Study_plan.UseVisualStyleBackColor = false;
            this.Study_plan.Click += new System.EventHandler(this.Study_plan_Click);
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Students.Location = new System.Drawing.Point(145, 235);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(231, 55);
            this.Students.TabIndex = 2;
            this.Students.Text = "Список студентов";
            this.Students.UseVisualStyleBackColor = false;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::Сведения_о_сотрудниках.Properties.Resources.Значок;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(525, 415);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Study_plan);
            this.Controls.Add(this.Teacher);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Органайзер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Teacher;
        private System.Windows.Forms.Button Study_plan;
        private System.Windows.Forms.Button Students;
    }
}

