using System.Windows.Forms;

namespace kur
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kursachDataSet = new kur.kursachDataSet();
            this.knigiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knigiTableAdapter = new kur.kursachDataSetTableAdapters.knigiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.knigiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDzhanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataizdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здесь вы можете просмотреть отчет по изданной и неизданной литературе ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(851, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzhanrDataGridViewTextBoxColumn,
            this.dataizdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knigiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(39, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(371, 216);
            this.dataGridView1.TabIndex = 2;
            
            // 
            // kursachDataSet
            // 
            this.kursachDataSet.DataSetName = "kursachDataSet";
            this.kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knigiBindingSource
            // 
            this.knigiBindingSource.DataMember = "knigi";
            this.knigiBindingSource.DataSource = this.kursachDataSet;
            // 
            // knigiTableAdapter
            // 
            this.knigiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.knigiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(550, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(371, 216);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_zhanr";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_zhanr";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_izd";
            this.dataGridViewTextBoxColumn2.HeaderText = "data_izd";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изданная литература";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(565, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Неизданная литература";
            // 
            // knigiBindingSource1
            // 
            this.knigiBindingSource1.DataMember = "knigi";
            this.knigiBindingSource1.DataSource = this.kursachDataSet;
            // 
            // iDzhanrDataGridViewTextBoxColumn
            // 
            this.iDzhanrDataGridViewTextBoxColumn.DataPropertyName = "ID_zhanr";
            this.iDzhanrDataGridViewTextBoxColumn.HeaderText = "ID_zhanr";
            this.iDzhanrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDzhanrDataGridViewTextBoxColumn.Name = "iDzhanrDataGridViewTextBoxColumn";
            this.iDzhanrDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDzhanrDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataizdDataGridViewTextBoxColumn
            // 
            this.dataizdDataGridViewTextBoxColumn.DataPropertyName = "data_izd";
            this.dataizdDataGridViewTextBoxColumn.HeaderText = "data_izd";
            this.dataizdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataizdDataGridViewTextBoxColumn.Name = "dataizdDataGridViewTextBoxColumn";
            this.dataizdDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataizdDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1021, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kursachDataSet kursachDataSet;
        private System.Windows.Forms.BindingSource knigiBindingSource;
        private kursachDataSetTableAdapters.knigiTableAdapter knigiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzhanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataizdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource knigiBindingSource1;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick;
        private DataGridViewCellEventHandler dataGridView2_CellContentClick;
    }
}