﻿namespace AppleMarket
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.applesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appleOrchardDataSet = new AppleMarket.AppleOrchardDataSet();
            this.applesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.appleOrchardDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appleOrchardDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applesTableAdapter = new AppleMarket.AppleOrchardDataSetTableAdapters.ApplesTableAdapter();
            this.applesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Size,
            this.SortName,
            this.Taste});
            this.dataGridView1.DataSource = this.applesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DarkGreen;
            this.dataGridView1.Size = new System.Drawing.Size(495, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "AppleOrchardDataSet.Apples.FillBySort,GetDataBySort ()";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // applesBindingSource
            // 
            this.applesBindingSource.DataMember = "Apples";
            this.applesBindingSource.DataSource = this.appleOrchardDataSet;
            // 
            // appleOrchardDataSet
            // 
            this.appleOrchardDataSet.DataSetName = "AppleOrchardDataSet";
            this.appleOrchardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applesBindingSource2
            // 
            this.applesBindingSource2.DataMember = "Apples";
            this.applesBindingSource2.DataSource = this.appleOrchardDataSetBindingSource;
            // 
            // appleOrchardDataSetBindingSource
            // 
            this.appleOrchardDataSetBindingSource.DataSource = this.appleOrchardDataSet;
            this.appleOrchardDataSetBindingSource.Position = 0;
            // 
            // appleOrchardDataSetBindingSource1
            // 
            this.appleOrchardDataSetBindingSource1.DataSource = this.appleOrchardDataSet;
            this.appleOrchardDataSetBindingSource1.Position = 0;
            // 
            // applesTableAdapter
            // 
            this.applesTableAdapter.ClearBeforeFill = true;
            // 
            // applesBindingSource1
            // 
            this.applesBindingSource1.DataMember = "Apples";
            this.applesBindingSource1.DataSource = this.appleOrchardDataSet;
            this.applesBindingSource1.CurrentChanged += new System.EventHandler(this.applesBindingSource1_CurrentChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // SortName
            // 
            this.SortName.DataPropertyName = "SortName";
            this.SortName.HeaderText = "SortName";
            this.SortName.Name = "SortName";
            // 
            // Taste
            // 
            this.Taste.DataPropertyName = "Taste";
            this.Taste.HeaderText = "Taste";
            this.Taste.Name = "Taste";
            this.Taste.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppleMarket.Properties.Resources.apple6;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Apple Market";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleOrchardDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AppleOrchardDataSet appleOrchardDataSet;
        private System.Windows.Forms.BindingSource applesBindingSource;
        private AppleOrchardDataSetTableAdapters.ApplesTableAdapter applesTableAdapter;
        private System.Windows.Forms.BindingSource appleOrchardDataSetBindingSource1;
        private System.Windows.Forms.BindingSource applesBindingSource1;
        private System.Windows.Forms.BindingSource appleOrchardDataSetBindingSource;
        private System.Windows.Forms.BindingSource applesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taste;
    }
}

