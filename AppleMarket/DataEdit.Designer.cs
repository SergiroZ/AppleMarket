namespace AppleMarket
{
    partial class DataEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEdit));
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Sort = new System.Windows.Forms.ComboBox();
            this.label_Taste = new System.Windows.Forms.Label();
            this.bott_Cancel = new System.Windows.Forms.Button();
            this.butt_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(74, 15);
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(60, 20);
            this.textBox_Size.TabIndex = 1;
            this.textBox_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Size.TextChanged += new System.EventHandler(this.textBox_Size_TextChanged);
            this.textBox_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Size_KeyDown);
            this.textBox_Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Size_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сорт";
            // 
            // comboBox_Sort
            // 
            this.comboBox_Sort.FormattingEnabled = true;
            this.comboBox_Sort.Location = new System.Drawing.Point(180, 14);
            this.comboBox_Sort.Name = "comboBox_Sort";
            this.comboBox_Sort.Size = new System.Drawing.Size(172, 21);
            this.comboBox_Sort.TabIndex = 5;
            // 
            // label_Taste
            // 
            this.label_Taste.AutoSize = true;
            this.label_Taste.Location = new System.Drawing.Point(22, 51);
            this.label_Taste.Name = "label_Taste";
            this.label_Taste.Size = new System.Drawing.Size(31, 13);
            this.label_Taste.TabIndex = 6;
            this.label_Taste.Text = "Вкус";
            // 
            // bott_Cancel
            // 
            this.bott_Cancel.Location = new System.Drawing.Point(74, 100);
            this.bott_Cancel.Name = "bott_Cancel";
            this.bott_Cancel.Size = new System.Drawing.Size(115, 30);
            this.bott_Cancel.TabIndex = 7;
            this.bott_Cancel.Text = "Отменить";
            this.bott_Cancel.UseVisualStyleBackColor = true;
            this.bott_Cancel.Click += new System.EventHandler(this.bott_Cancel_Click);
            // 
            // butt_Save
            // 
            this.butt_Save.Location = new System.Drawing.Point(195, 100);
            this.butt_Save.Name = "butt_Save";
            this.butt_Save.Size = new System.Drawing.Size(115, 31);
            this.butt_Save.TabIndex = 8;
            this.butt_Save.Text = "Сохранить";
            this.butt_Save.UseVisualStyleBackColor = true;
            this.butt_Save.Click += new System.EventHandler(this.butt_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "______________________________________________________";
            // 
            // DataEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 153);
            this.Controls.Add(this.butt_Save);
            this.Controls.Add(this.bott_Cancel);
            this.Controls.Add(this.label_Taste);
            this.Controls.Add(this.comboBox_Sort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Size);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о яблоке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Sort;
        private System.Windows.Forms.Label label_Taste;
        private System.Windows.Forms.Button bott_Cancel;
        private System.Windows.Forms.Button butt_Save;
        private System.Windows.Forms.Label label3;
    }
}