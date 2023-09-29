namespace Система_управления_библиотекой
{
    partial class Сотрудники_редакция_строки
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
            this.pass = new System.Windows.Forms.TextBox();
            this.priv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loc = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(26, 200);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 33;
            // 
            // priv
            // 
            this.priv.Location = new System.Drawing.Point(26, 164);
            this.priv.Name = "priv";
            this.priv.Size = new System.Drawing.Size(100, 20);
            this.priv.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(26, 133);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(100, 20);
            this.loc.TabIndex = 30;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(26, 98);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 29;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(26, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 28;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(26, 26);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Сотрудники_редакция_строки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.priv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "Сотрудники_редакция_строки";
            this.Text = "Сотрудники_редакция_строки";
            this.Load += new System.EventHandler(this.Сотрудники_редакция_строки_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox priv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button2;
    }
}