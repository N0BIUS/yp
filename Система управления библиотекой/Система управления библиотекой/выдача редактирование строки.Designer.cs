namespace Система_управления_библиотекой
{
    partial class выдача_редактирование_строки
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
            this.button2 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.priv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loc = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(30, 195);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 41;
            // 
            // priv
            // 
            this.priv.Location = new System.Drawing.Point(30, 159);
            this.priv.Name = "priv";
            this.priv.Size = new System.Drawing.Size(100, 20);
            this.priv.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(30, 128);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(100, 20);
            this.loc.TabIndex = 38;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 57);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 36;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(30, 21);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 35;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(30, 83);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 43;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // выдача_редактирование_строки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 279);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.priv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "выдача_редактирование_строки";
            this.Text = "выдача_редактирование_строки";
            this.Load += new System.EventHandler(this.выдача_редактирование_строки_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox priv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}