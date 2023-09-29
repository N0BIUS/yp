namespace Система_управления_библиотекой
{
    partial class Каталог_книг
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Шифр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_издательства = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Первый_автор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Год_издания = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.В_наличии = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Шифр,
            this.Название,
            this.Код_издательства,
            this.Первый_автор,
            this.Год_издания,
            this.Цена,
            this.В_наличии});
            this.dataGridView1.Location = new System.Drawing.Point(34, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // Шифр
            // 
            this.Шифр.HeaderText = "Шифр";
            this.Шифр.Name = "Шифр";
            this.Шифр.ReadOnly = true;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            // 
            // Код_издательства
            // 
            this.Код_издательства.HeaderText = "Код издательства";
            this.Код_издательства.Name = "Код_издательства";
            this.Код_издательства.ReadOnly = true;
            // 
            // Первый_автор
            // 
            this.Первый_автор.HeaderText = "Первый_автор";
            this.Первый_автор.Name = "Первый_автор";
            this.Первый_автор.ReadOnly = true;
            // 
            // Год_издания
            // 
            this.Год_издания.HeaderText = "Год издания";
            this.Год_издания.Name = "Год_издания";
            this.Год_издания.ReadOnly = true;
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            this.Цена.ReadOnly = true;
            // 
            // В_наличии
            // 
            this.В_наличии.HeaderText = "В наличии";
            this.В_наличии.Name = "В_наличии";
            this.В_наличии.ReadOnly = true;
            // 
            // Каталог_книг
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Каталог_книг";
            this.Text = "Каталог_книг";
            this.Load += new System.EventHandler(this.Каталог_книг_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Шифр;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_издательства;
        private System.Windows.Forms.DataGridViewTextBoxColumn Первый_автор;
        private System.Windows.Forms.DataGridViewTextBoxColumn Год_издания;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn В_наличии;
    }
}