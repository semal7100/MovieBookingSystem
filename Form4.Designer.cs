namespace WindowsFormsApplication3
{
    partial class Form4
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
            this.txtsh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet1 = new WindowsFormsApplication3.masterDataSet1();
            this.movieprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieprojectTableAdapter = new WindowsFormsApplication3.masterDataSet1TableAdapters.movieprojectTableAdapter();
            this.movienameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofticketsavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieprojectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Ticket price:";
            // 
            // txtsh
            // 
            this.txtsh.Location = new System.Drawing.Point(179, 307);
            this.txtsh.Name = "txtsh";
            this.txtsh.Size = new System.Drawing.Size(200, 20);
            this.txtsh.TabIndex = 1;
            this.txtsh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter for refund:\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the Date:";
            // 
            // datetimepicker
            // 
            this.datetimepicker.Location = new System.Drawing.Point(179, 267);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker.TabIndex = 5;
            this.datetimepicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter movieid:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(179, 223);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(200, 20);
            this.txt10.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Enter for available tickets:\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(179, 186);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(200, 20);
            this.txt11.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter the number of tickets:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movienameDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn,
            this.movieidDataGridViewTextBoxColumn,
            this.noofticketsavailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieprojectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet1";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieprojectBindingSource
            // 
            this.movieprojectBindingSource.DataMember = "movieproject";
            this.movieprojectBindingSource.DataSource = this.masterDataSet1;
            // 
            // movieprojectTableAdapter
            // 
            this.movieprojectTableAdapter.ClearBeforeFill = true;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsh);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieprojectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet1 masterDataSet1;
        private System.Windows.Forms.BindingSource movieprojectBindingSource;
        private masterDataSet1TableAdapters.movieprojectTableAdapter movieprojectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movienameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofticketsavailableDataGridViewTextBoxColumn;

    }
}