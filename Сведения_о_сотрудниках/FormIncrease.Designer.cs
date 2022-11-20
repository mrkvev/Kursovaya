
namespace Сведения_о_сотрудниках
{
    partial class FormIncrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncrease));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Нужный_процент = new System.Windows.Forms.NumericUpDown();
            this.Нужный_стаж = new System.Windows.Forms.NumericUpDown();
            this.Кнопка_увеличения = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Нужный_процент)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Нужный_стаж)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите необходимый минимальный стаж:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите процент:";
            // 
            // Нужный_процент
            // 
            this.Нужный_процент.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Нужный_процент.Location = new System.Drawing.Point(249, 80);
            this.Нужный_процент.Name = "Нужный_процент";
            this.Нужный_процент.Size = new System.Drawing.Size(98, 26);
            this.Нужный_процент.TabIndex = 2;
            // 
            // Нужный_стаж
            // 
            this.Нужный_стаж.DecimalPlaces = 1;
            this.Нужный_стаж.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Нужный_стаж.Location = new System.Drawing.Point(249, 32);
            this.Нужный_стаж.Name = "Нужный_стаж";
            this.Нужный_стаж.Size = new System.Drawing.Size(98, 26);
            this.Нужный_стаж.TabIndex = 3;
            this.Нужный_стаж.ValueChanged += new System.EventHandler(this.Нужный_стаж_ValueChanged);
            // 
            // Кнопка_увеличения
            // 
            this.Кнопка_увеличения.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Кнопка_увеличения.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_увеличения.Location = new System.Drawing.Point(235, 157);
            this.Кнопка_увеличения.Name = "Кнопка_увеличения";
            this.Кнопка_увеличения.Size = new System.Drawing.Size(121, 39);
            this.Кнопка_увеличения.TabIndex = 4;
            this.Кнопка_увеличения.Text = "Увеличить";
            this.Кнопка_увеличения.UseVisualStyleBackColor = false;
            this.Кнопка_увеличения.Click += new System.EventHandler(this.Кнопка_увеличения_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(96, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIncrease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Кнопка_увеличения);
            this.Controls.Add(this.Нужный_стаж);
            this.Controls.Add(this.Нужный_процент);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIncrease";
            this.Text = "Увеличение оклада";
            this.Load += new System.EventHandler(this.FormTwoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Нужный_процент)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Нужный_стаж)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Нужный_процент;
        private System.Windows.Forms.NumericUpDown Нужный_стаж;
        private System.Windows.Forms.Button Кнопка_увеличения;
        private System.Windows.Forms.Button button1;
    }
}