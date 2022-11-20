
namespace Сведения_о_сотрудниках
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Логин = new System.Windows.Forms.TextBox();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.Кнопка_войти = new System.Windows.Forms.Button();
            this.Кнопка_пропустить = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пожалуйста, авторизуйтесь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // Логин
            // 
            this.Логин.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Логин.Location = new System.Drawing.Point(30, 118);
            this.Логин.Multiline = true;
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(350, 40);
            this.Логин.TabIndex = 4;
            this.Логин.Text = "Admin";
            // 
            // Пароль
            // 
            this.Пароль.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пароль.Location = new System.Drawing.Point(30, 196);
            this.Пароль.Name = "Пароль";
            this.Пароль.PasswordChar = '*';
            this.Пароль.Size = new System.Drawing.Size(350, 39);
            this.Пароль.TabIndex = 5;
            // 
            // Кнопка_войти
            // 
            this.Кнопка_войти.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Кнопка_войти.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_войти.Location = new System.Drawing.Point(239, 258);
            this.Кнопка_войти.Name = "Кнопка_войти";
            this.Кнопка_войти.Size = new System.Drawing.Size(141, 38);
            this.Кнопка_войти.TabIndex = 11;
            this.Кнопка_войти.Text = "Войти";
            this.Кнопка_войти.UseVisualStyleBackColor = false;
            this.Кнопка_войти.Click += new System.EventHandler(this.Кнопка_войти_Click);
            // 
            // Кнопка_пропустить
            // 
            this.Кнопка_пропустить.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Кнопка_пропустить.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_пропустить.Location = new System.Drawing.Point(30, 258);
            this.Кнопка_пропустить.Name = "Кнопка_пропустить";
            this.Кнопка_пропустить.Size = new System.Drawing.Size(141, 38);
            this.Кнопка_пропустить.TabIndex = 12;
            this.Кнопка_пропустить.Text = "Пропустить";
            this.Кнопка_пропустить.UseVisualStyleBackColor = false;
            this.Кнопка_пропустить.Click += new System.EventHandler(this.Кнопка_пропустить_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 316);
            this.Controls.Add(this.Кнопка_пропустить);
            this.Controls.Add(this.Кнопка_войти);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.Логин);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAuthorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuthorization_FormClosing);
            this.Load += new System.EventHandler(this.FormAuthorization1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Логин;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.Button Кнопка_войти;
        private System.Windows.Forms.Button Кнопка_пропустить;
        private System.Windows.Forms.Label label1;
    }
}