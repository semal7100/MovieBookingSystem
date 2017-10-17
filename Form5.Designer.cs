namespace WindowsFormsApplication3
{
    partial class Form5
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
            this.movieshemalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new WindowsFormsApplication3.masterDataSet();
            this.movieshemalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieshemalTableAdapter = new WindowsFormsApplication3.masterDataSetTableAdapters.movieshemalTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.movieshemalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movienameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofticketsavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet1 = new WindowsFormsApplication3.masterDataSet1();
            this.movieprojectTableAdapter = new WindowsFormsApplication3.masterDataSet1TableAdapters.movieprojectTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieshemalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieshemalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieshemalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieprojectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieshemalBindingSource1
            // 
            this.movieshemalBindingSource1.DataMember = "movieshemal";
            this.movieshemalBindingSource1.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieshemalBindingSource
            // 
            this.movieshemalBindingSource.DataMember = "movieshemal";
            this.movieshemalBindingSource.DataSource = this.masterDataSet;
            // 
            // movieshemalTableAdapter
            // 
            this.movieshemalTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(35, 236);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Enter MovieId:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // movieshemalBindingSource2
            // 
            this.movieshemalBindingSource2.DataMember = "movieshemal";
            this.movieshemalBindingSource2.DataSource = this.masterDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movienameDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn,
            this.movieidDataGridViewTextBoxColumn,
            this.noofticketsavailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieprojectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // movienameDataGridViewTextBoxColumn
            // 
            this.movienameDataGridViewTextBoxColumn.DataPropertyName = "moviename";
            this.movienameDataGridViewTextBoxColumn.HeaderText = "moviename";
            this.movienameDataGridViewTextBoxColumn.Name = "movienameDataGridViewTextBoxColumn";
            // 
            // actorDataGridViewTextBoxColumn
            // 
            this.actorDataGridViewTextBoxColumn.DataPropertyName = "actor";
            this.actorDataGridViewTextBoxColumn.HeaderText = "actor";
            this.actorDataGridViewTextBoxColumn.Name = "actorDataGridViewTextBoxColumn";
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movieid";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "movieid";
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            // 
            // noofticketsavailableDataGridViewTextBoxColumn
            // 
            this.noofticketsavailableDataGridViewTextBoxColumn.DataPropertyName = "Noofticketsavailable";
            this.noofticketsavailableDataGridViewTextBoxColumn.HeaderText = "Noofticketsavailable";
            this.noofticketsavailableDataGridViewTextBoxColumn.Name = "noofticketsavailableDataGridViewTextBoxColumn";
            // 
            // movieprojectBindingSource
            // 
            this.movieprojectBindingSource.DataMember = "movieproject";
            this.movieprojectBindingSource.DataSource = this.masterDataSet1;
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet1";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieprojectTableAdapter
            // 
            this.movieprojectTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter No of tickets required:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(196, 233);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(112, 20);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieshemalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieshemalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieshemalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieprojectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource movieshemalBindingSource;
        private masterDataSetTableAdapters.movieshemalTableAdapter movieshemalTableAdapter;
        private System.Windows.Forms.BindingSource movieshemalBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource movieshemalBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet1 masterDataSet1;
        private System.Windows.Forms.BindingSource movieprojectBindingSource;
        private masterDataSet1TableAdapters.movieprojectTableAdapter movieprojectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movienameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofticketsavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button2;
    }
}