namespace Dataset0119
{
    partial class Form1
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
            this.adatbazis = new System.Data.DataSet();
            this.Szemelyek = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.generatebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fizatlag = new System.Windows.Forms.Label();
            this.Eletatlag = new System.Windows.Forms.Label();
            this.nonevek = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szemelyek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adatbazis
            // 
            this.adatbazis.DataSetName = "NewDataSet";
            this.adatbazis.Tables.AddRange(new System.Data.DataTable[] {
            this.Szemelyek});
            // 
            // Szemelyek
            // 
            this.Szemelyek.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.Szemelyek.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Szemely_id"}, true)});
            this.Szemelyek.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.Szemelyek.TableName = "Szemelyek";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.AutoIncrement = true;
            this.dataColumn1.ColumnName = "Szemely_id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Nev";
            this.dataColumn2.DefaultValue = "Nem ismert";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Nem";
            this.dataColumn3.DefaultValue = "Ferfi";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Kor";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn4.DefaultValue = "18";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Fizetes";
            this.dataColumn5.DataType = typeof(decimal);
            this.dataColumn5.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // generatebutton
            // 
            this.generatebutton.Location = new System.Drawing.Point(12, 12);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(75, 23);
            this.generatebutton.TabIndex = 0;
            this.generatebutton.Text = "Generate";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // Fizatlag
            // 
            this.Fizatlag.AutoSize = true;
            this.Fizatlag.Location = new System.Drawing.Point(93, 17);
            this.Fizatlag.Name = "Fizatlag";
            this.Fizatlag.Size = new System.Drawing.Size(64, 13);
            this.Fizatlag.TabIndex = 2;
            this.Fizatlag.Text = "Átlag fizetés";
            // 
            // Eletatlag
            // 
            this.Eletatlag.AutoSize = true;
            this.Eletatlag.Location = new System.Drawing.Point(211, 17);
            this.Eletatlag.Name = "Eletatlag";
            this.Eletatlag.Size = new System.Drawing.Size(66, 13);
            this.Eletatlag.TabIndex = 3;
            this.Eletatlag.Text = "Átlag életkor";
            // 
            // nonevek
            // 
            this.nonevek.FormattingEnabled = true;
            this.nonevek.Location = new System.Drawing.Point(698, 41);
            this.nonevek.Name = "nonevek";
            this.nonevek.Size = new System.Drawing.Size(132, 225);
            this.nonevek.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 475);
            this.Controls.Add(this.nonevek);
            this.Controls.Add(this.Eletatlag);
            this.Controls.Add(this.Fizatlag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generatebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.adatbazis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Szemelyek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet adatbazis;
        private System.Data.DataTable Szemelyek;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Fizatlag;
        private System.Windows.Forms.Label Eletatlag;
        private System.Windows.Forms.ListBox nonevek;
    }
}

