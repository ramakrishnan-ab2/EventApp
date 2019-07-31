namespace EVENT_MANAGEMENT
{
    partial class FormMarkEntry
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
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventRollNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Judges = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AvgMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMarkExit = new System.Windows.Forms.Button();
            this.btnMarkSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnMarkCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.EventRollNo,
            this.Judges,
            this.AvgMark});
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(578, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SlNo
            // 
            this.SlNo.HeaderText = "Sl No";
            this.SlNo.Name = "SlNo";
            this.SlNo.Width = 50;
            // 
            // EventRollNo
            // 
            this.EventRollNo.HeaderText = "Event Roll No";
            this.EventRollNo.Name = "EventRollNo";
            this.EventRollNo.Width = 200;
            // 
            // Judges
            // 
            this.Judges.HeaderText = "Judges";
            this.Judges.Name = "Judges";
            this.Judges.Width = 200;
            // 
            // AvgMark
            // 
            this.AvgMark.HeaderText = "Avg. Mark";
            this.AvgMark.Name = "AvgMark";
            this.AvgMark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AvgMark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AvgMark.Width = 125;
            // 
            // btnMarkExit
            // 
            this.btnMarkExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkExit.Location = new System.Drawing.Point(497, 399);
            this.btnMarkExit.Name = "btnMarkExit";
            this.btnMarkExit.Size = new System.Drawing.Size(93, 28);
            this.btnMarkExit.TabIndex = 24;
            this.btnMarkExit.Text = "Exit";
            this.btnMarkExit.UseVisualStyleBackColor = true;
            this.btnMarkExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMarkSave
            // 
            this.btnMarkSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkSave.Location = new System.Drawing.Point(394, 399);
            this.btnMarkSave.Name = "btnMarkSave";
            this.btnMarkSave.Size = new System.Drawing.Size(97, 28);
            this.btnMarkSave.TabIndex = 25;
            this.btnMarkSave.Text = "Save";
            this.btnMarkSave.UseVisualStyleBackColor = true;
            this.btnMarkSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(606, 35);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 32);
            this.toolStripLabel1.Text = "Events";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(250, 35);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(22, 32);
            this.toolStripLabel2.Text = "Go";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // btnMarkCancel
            // 
            this.btnMarkCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkCancel.Location = new System.Drawing.Point(291, 399);
            this.btnMarkCancel.Name = "btnMarkCancel";
            this.btnMarkCancel.Size = new System.Drawing.Size(97, 28);
            this.btnMarkCancel.TabIndex = 27;
            this.btnMarkCancel.Text = "Cancel";
            this.btnMarkCancel.UseVisualStyleBackColor = true;
            this.btnMarkCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMarkEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 473);
            this.Controls.Add(this.btnMarkCancel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMarkExit);
            this.Controls.Add(this.btnMarkSave);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMarkEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkEntry";
            this.Load += new System.EventHandler(this.MarkEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMarkExit;
        private System.Windows.Forms.Button btnMarkSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button btnMarkCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn EventRollNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Judges;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgMark;
    }
}