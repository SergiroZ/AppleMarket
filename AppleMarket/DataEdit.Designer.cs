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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEdit));
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Sort = new System.Windows.Forms.ComboBox();
            this.appleSortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appleOrchardDataSet = new AppleMarket.AppleOrchardDataSet();
            this.label_Taste = new System.Windows.Forms.Label();
            this.bott_Cancel = new System.Windows.Forms.Button();
            this.appleSortsTableAdapter = new AppleMarket.AppleOrchardDataSetTableAdapters.AppleSortsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appleSortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(140, 48);
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(77, 20);
            this.textBox_Size.TabIndex = 1;
            this.textBox_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Size.TextChanged += new System.EventHandler(this.textBox_Size_TextChanged);
            this.textBox_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Size_KeyDown);
            this.textBox_Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Size_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Image = global::AppleMarket.Properties.Resources.apple2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.MinimumSize = new System.Drawing.Size(100, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Image = global::AppleMarket.Properties.Resources.apple2;
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сорт";
            // 
            // comboBox_Sort
            // 
            this.comboBox_Sort.DataSource = this.appleSortsBindingSource;
            this.comboBox_Sort.DisplayMember = "SortName";
            this.comboBox_Sort.FormattingEnabled = true;
            this.comboBox_Sort.Location = new System.Drawing.Point(81, 94);
            this.comboBox_Sort.Name = "comboBox_Sort";
            this.comboBox_Sort.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Sort.TabIndex = 2;
            this.comboBox_Sort.ValueMember = "Taste";
            this.comboBox_Sort.SelectedIndexChanged += new System.EventHandler(this.comboBox_Sort_SelectedIndexChanged);
            // 
            // appleSortsBindingSource
            // 
            this.appleSortsBindingSource.DataMember = "AppleSorts";
            this.appleSortsBindingSource.DataSource = this.appleOrchardDataSet;
            this.appleSortsBindingSource.CurrentChanged += new System.EventHandler(this.appleSortsBindingSource_CurrentChanged);
            // 
            // appleOrchardDataSet
            // 
            this.appleOrchardDataSet.DataSetName = "AppleOrchardDataSet";
            this.appleOrchardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_Taste
            // 
            this.label_Taste.BackColor = System.Drawing.Color.YellowGreen;
            this.label_Taste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Taste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Taste.Location = new System.Drawing.Point(81, 118);
            this.label_Taste.MaximumSize = new System.Drawing.Size(150, 36);
            this.label_Taste.MinimumSize = new System.Drawing.Size(150, 36);
            this.label_Taste.Name = "label_Taste";
            this.label_Taste.Size = new System.Drawing.Size(150, 36);
            this.label_Taste.TabIndex = 3;
            this.label_Taste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bott_Cancel
            // 
            this.bott_Cancel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bott_Cancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bott_Cancel.Location = new System.Drawing.Point(31, 186);
            this.bott_Cancel.Name = "bott_Cancel";
            this.bott_Cancel.Size = new System.Drawing.Size(93, 30);
            this.bott_Cancel.TabIndex = 4;
            this.bott_Cancel.Text = "Отменить";
            this.bott_Cancel.UseVisualStyleBackColor = false;
            this.bott_Cancel.Click += new System.EventHandler(this.bott_Cancel_Click);
            // 
            // appleSortsTableAdapter
            // 
            this.appleSortsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Image = global::AppleMarket.Properties.Resources.apple2;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.MinimumSize = new System.Drawing.Size(46, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вкус";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(136, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Save_Click);
            // 
            // DataEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = global::AppleMarket.Properties.Resources.apple2;
            this.ClientSize = new System.Drawing.Size(269, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bott_Cancel);
            this.Controls.Add(this.label_Taste);
            this.Controls.Add(this.comboBox_Sort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Size);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о яблоке";
            this.Load += new System.EventHandler(this.DataEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appleSortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Taste;
        private System.Windows.Forms.Button bott_Cancel;
        private AppleOrchardDataSet appleOrchardDataSet;
        private AppleOrchardDataSetTableAdapters.AppleSortsTableAdapter appleSortsTableAdapter;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox_Sort;
        public System.Windows.Forms.BindingSource appleSortsBindingSource;
        private System.Windows.Forms.Button button1;
    }
}