namespace AppleMarket
{
    partial class NewSort
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
            this.tbSortName = new System.Windows.Forms.TextBox();
            this.tbTaste = new System.Windows.Forms.TextBox();
            this.CancelSort = new System.Windows.Forms.Button();
            this.SaveSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSortName
            // 
            this.tbSortName.Location = new System.Drawing.Point(20, 30);
            this.tbSortName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSortName.Name = "tbSortName";
            this.tbSortName.Size = new System.Drawing.Size(252, 23);
            this.tbSortName.TabIndex = 0;
            this.tbSortName.TextChanged += new System.EventHandler(this.tbSortName_TextChanged);
            // 
            // tbTaste
            // 
            this.tbTaste.Location = new System.Drawing.Point(21, 75);
            this.tbTaste.MaximumSize = new System.Drawing.Size(250, 23);
            this.tbTaste.MinimumSize = new System.Drawing.Size(250, 23);
            this.tbTaste.Name = "tbTaste";
            this.tbTaste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTaste.Size = new System.Drawing.Size(250, 23);
            this.tbTaste.TabIndex = 1;
            this.tbTaste.TextChanged += new System.EventHandler(this.tbTaste_TextChanged);
            // 
            // CancelSort
            // 
            this.CancelSort.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelSort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSort.Location = new System.Drawing.Point(35, 109);
            this.CancelSort.Name = "CancelSort";
            this.CancelSort.Size = new System.Drawing.Size(105, 33);
            this.CancelSort.TabIndex = 2;
            this.CancelSort.Text = "Отменить";
            this.CancelSort.UseVisualStyleBackColor = false;
            this.CancelSort.Click += new System.EventHandler(this.CancelSort_Click);
            // 
            // SaveSort
            // 
            this.SaveSort.BackColor = System.Drawing.Color.Khaki;
            this.SaveSort.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveSort.Location = new System.Drawing.Point(153, 109);
            this.SaveSort.Name = "SaveSort";
            this.SaveSort.Size = new System.Drawing.Size(105, 33);
            this.SaveSort.TabIndex = 3;
            this.SaveSort.Text = "Сохранить";
            this.SaveSort.UseVisualStyleBackColor = false;
            this.SaveSort.Click += new System.EventHandler(this.SaveSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название нового сорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вкус нового сорта";
            // 
            // NewSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(292, 158);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveSort);
            this.Controls.Add(this.CancelSort);
            this.Controls.Add(this.tbTaste);
            this.Controls.Add(this.tbSortName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый сорт яблок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSortName;
        private System.Windows.Forms.TextBox tbTaste;
        private System.Windows.Forms.Button CancelSort;
        private System.Windows.Forms.Button SaveSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}