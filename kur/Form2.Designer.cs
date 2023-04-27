namespace kur
{
    partial class Form2
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
            this.knigiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knigiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursachDataSet = new kur.kursachDataSet();
            this.knigiTableAdapter = new kur.kursachDataSetTableAdapters.knigiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDknigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieknigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDavtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDzhanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDizdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataizdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здесь вы можете просмотреть книги всех литературных издательств";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(760, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // knigiBindingSource
            // 
            this.knigiBindingSource.DataMember = "knigi";
            this.knigiBindingSource.DataSource = this.bindingSource1;
            // 
            // knigiBindingSource1
            // 
            this.knigiBindingSource1.DataMember = "knigi";
            this.knigiBindingSource1.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = this.kursachDataSet;
            this.bindingSource1.Position = 0;
            // 
            // kursachDataSet
            // 
            this.kursachDataSet.DataSetName = "kursachDataSet";
            this.kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knigiTableAdapter
            // 
            this.knigiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDknigiDataGridViewTextBoxColumn,
            this.nazvanieknigiDataGridViewTextBoxColumn,
            this.iDavtorDataGridViewTextBoxColumn,
            this.iDzhanrDataGridViewTextBoxColumn,
            this.iDizdDataGridViewTextBoxColumn,
            this.dataizdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.knigiBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.Location = new System.Drawing.Point(43, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(962, 307);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDknigiDataGridViewTextBoxColumn
            // 
            this.iDknigiDataGridViewTextBoxColumn.DataPropertyName = "ID_knigi";
            this.iDknigiDataGridViewTextBoxColumn.HeaderText = "ID_knigi";
            this.iDknigiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDknigiDataGridViewTextBoxColumn.Name = "iDknigiDataGridViewTextBoxColumn";
            this.iDknigiDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDknigiDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazvanieknigiDataGridViewTextBoxColumn
            // 
            this.nazvanieknigiDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie_knigi";
            this.nazvanieknigiDataGridViewTextBoxColumn.HeaderText = "Nazvanie_knigi";
            this.nazvanieknigiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazvanieknigiDataGridViewTextBoxColumn.Name = "nazvanieknigiDataGridViewTextBoxColumn";
            this.nazvanieknigiDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDavtorDataGridViewTextBoxColumn
            // 
            this.iDavtorDataGridViewTextBoxColumn.DataPropertyName = "ID_avtor";
            this.iDavtorDataGridViewTextBoxColumn.HeaderText = "ID_avtor";
            this.iDavtorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDavtorDataGridViewTextBoxColumn.Name = "iDavtorDataGridViewTextBoxColumn";
            this.iDavtorDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDzhanrDataGridViewTextBoxColumn
            // 
            this.iDzhanrDataGridViewTextBoxColumn.DataPropertyName = "ID_zhanr";
            this.iDzhanrDataGridViewTextBoxColumn.HeaderText = "ID_zhanr";
            this.iDzhanrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDzhanrDataGridViewTextBoxColumn.Name = "iDzhanrDataGridViewTextBoxColumn";
            this.iDzhanrDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDizdDataGridViewTextBoxColumn
            // 
            this.iDizdDataGridViewTextBoxColumn.DataPropertyName = "ID_izd";
            this.iDizdDataGridViewTextBoxColumn.HeaderText = "ID_izd";
            this.iDizdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDizdDataGridViewTextBoxColumn.Name = "iDizdDataGridViewTextBoxColumn";
            this.iDizdDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataizdDataGridViewTextBoxColumn
            // 
            this.dataizdDataGridViewTextBoxColumn.DataPropertyName = "data_izd";
            this.dataizdDataGridViewTextBoxColumn.HeaderText = "data_izd";
            this.dataizdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataizdDataGridViewTextBoxColumn.Name = "dataizdDataGridViewTextBoxColumn";
            this.dataizdDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1034, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knigiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kursachDataSet kursachDataSet;
        private System.Windows.Forms.BindingSource knigiBindingSource;
        private kursachDataSetTableAdapters.knigiTableAdapter knigiTableAdapter;
        private System.Windows.Forms.BindingSource knigiBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDknigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieknigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDavtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzhanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDizdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataizdDataGridViewTextBoxColumn;
    }
}