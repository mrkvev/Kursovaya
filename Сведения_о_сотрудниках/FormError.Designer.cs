
namespace Сведения_о_сотрудниках
{
    partial class FormError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormError));
            this.Строка_подтверждения = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Отмена_удаления = new System.Windows.Forms.Button();
            this.Кнопка_удаления_сотрудника = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Строка_подтверждения
            // 
            this.Строка_подтверждения.Location = new System.Drawing.Point(105, 44);
            this.Строка_подтверждения.Name = "Строка_подтверждения";
            this.Строка_подтверждения.Size = new System.Drawing.Size(413, 46);
            this.Строка_подтверждения.TabIndex = 0;
            this.Строка_подтверждения.Text = "Вы действительно хотите удалить учетную запись? ";
            this.Строка_подтверждения.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Сведения_о_сотрудниках.Properties.Resources.Знак_внимание1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Отмена_удаления
            // 
            this.Отмена_удаления.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Отмена_удаления.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Отмена_удаления.Location = new System.Drawing.Point(410, 110);
            this.Отмена_удаления.Name = "Отмена_удаления";
            this.Отмена_удаления.Size = new System.Drawing.Size(126, 37);
            this.Отмена_удаления.TabIndex = 5;
            this.Отмена_удаления.Text = "Отмена";
            this.Отмена_удаления.UseVisualStyleBackColor = false;
            this.Отмена_удаления.Click += new System.EventHandler(this.Отмена_удаления_Click);
            // 
            // Кнопка_удаления_сотрудника
            // 
            this.Кнопка_удаления_сотрудника.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Кнопка_удаления_сотрудника.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_удаления_сотрудника.Location = new System.Drawing.Point(262, 110);
            this.Кнопка_удаления_сотрудника.Name = "Кнопка_удаления_сотрудника";
            this.Кнопка_удаления_сотрудника.Size = new System.Drawing.Size(126, 37);
            this.Кнопка_удаления_сотрудника.TabIndex = 4;
            this.Кнопка_удаления_сотрудника.Text = "Удалить";
            this.Кнопка_удаления_сотрудника.UseVisualStyleBackColor = false;
            this.Кнопка_удаления_сотрудника.Click += new System.EventHandler(this.Кнопка_удаления_сотрудника_Click);
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 159);
            this.Controls.Add(this.Отмена_удаления);
            this.Controls.Add(this.Кнопка_удаления_сотрудника);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Строка_подтверждения);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormError";
            this.ShowIcon = false;
            this.Text = "Подтверждение удаления";
            this.Load += new System.EventHandler(this.FormError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Отмена_удаления;
        private System.Windows.Forms.Button Кнопка_удаления_сотрудника;
        public System.Windows.Forms.Label Строка_подтверждения;
    }
}