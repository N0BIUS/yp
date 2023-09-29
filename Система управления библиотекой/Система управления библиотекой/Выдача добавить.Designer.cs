namespace Система_управления_библиотекой
{
    partial class Выдача_добавить
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.рос2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.рос = new System.Windows.Forms.TextBox();
            this.kod = new System.Windows.Forms.TextBox();
            this.shif = new System.Windows.Forms.TextBox();
            this.tid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(26, 85);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 50;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // рос2
            // 
            this.рос2.Location = new System.Drawing.Point(26, 192);
            this.рос2.Name = "рос2";
            this.рос2.Size = new System.Drawing.Size(100, 20);
            this.рос2.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // рос
            // 
            this.рос.Location = new System.Drawing.Point(26, 121);
            this.рос.Name = "рос";
            this.рос.Size = new System.Drawing.Size(100, 20);
            this.рос.TabIndex = 46;
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(26, 157);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(100, 20);
            this.kod.TabIndex = 45;
            // 
            // shif
            // 
            this.shif.Location = new System.Drawing.Point(26, 12);
            this.shif.Name = "shif";
            this.shif.Size = new System.Drawing.Size(100, 20);
            this.shif.TabIndex = 44;
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(26, 47);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(100, 20);
            this.tid.TabIndex = 43;
            // 
            // Выдача_добавить
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 287);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.рос2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.рос);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.shif);
            this.Controls.Add(this.tid);
            this.Name = "Выдача_добавить";
            this.Text = "Выдача_добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox рос2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox рос;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.TextBox shif;
        private System.Windows.Forms.TextBox tid;
    }
}