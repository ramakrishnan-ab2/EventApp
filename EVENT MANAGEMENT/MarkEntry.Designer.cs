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
            this.dataGridViewMarkentry = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventRollNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Judges = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AvgMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnMarkentryExit = new System.Windows.Forms.Button();
            this.BtnMarkentrySave = new System.Windows.Forms.Button();
            this.statusStripMarkentry = new System.Windows.Forms.StatusStrip();
            this.toolStripMarkentry = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelMarkentryEvents = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxMarkentryEvents = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelMarkentryEvent = new System.Windows.Forms.ToolStripLabel();
            this.BtnMarkentryCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkentry)).BeginInit();
            this.toolStripMarkentry.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMarkentry
            // 
            this.dataGridViewMarkentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarkentry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.EventRollNo,
            this.Judges,
            this.AvgMark});
            this.dataGridViewMarkentry.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewMarkentry.Name = "dataGridViewMarkentry";
            this.dataGridViewMarkentry.RowHeadersVisible = false;
            this.dataGridViewMarkentry.Size = new System.Drawing.Size(578, 346);
            this.dataGridViewMarkentry.TabIndex = 0;
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
            // BtnMarkentryExit
            // 
            this.BtnMarkentryExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkentryExit.Location = new System.Drawing.Point(497, 399);
            this.BtnMarkentryExit.Name = "BtnMarkentryExit";
            this.BtnMarkentryExit.Size = new System.Drawing.Size(93, 28);
            this.BtnMarkentryExit.TabIndex = 24;
            this.BtnMarkentryExit.Text = "Exit";
            this.BtnMarkentryExit.UseVisualStyleBackColor = true;
            // 
            // BtnMarkentrySave
            // 
            this.BtnMarkentrySave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkentrySave.Location = new System.Drawing.Point(394, 399);
            this.BtnMarkentrySave.Name = "BtnMarkentrySave";
            this.BtnMarkentrySave.Size = new System.Drawing.Size(97, 28);
            this.BtnMarkentrySave.TabIndex = 25;
            this.BtnMarkentrySave.Text = "Save";
            this.BtnMarkentrySave.UseVisualStyleBackColor = true;
            // 
            // statusStripMarkentry
            // 
            this.statusStripMarkentry.Location = new System.Drawing.Point(0, 451);
            this.statusStripMarkentry.Name = "statusStripMarkentry";
            this.statusStripMarkentry.Size = new System.Drawing.Size(606, 22);
            this.statusStripMarkentry.TabIndex = 23;
            this.statusStripMarkentry.Text = "statusStrip1";
            // 
            // toolStripMarkentry
            // 
            this.toolStripMarkentry.AutoSize = false;
            this.toolStripMarkentry.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMarkentry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelMarkentryEvents,
            this.toolStripComboBoxMarkentryEvents,
            this.toolStripLabelMarkentryEvent});
            this.toolStripMarkentry.Location = new System.Drawing.Point(0, 0);
            this.toolStripMarkentry.Name = "toolStripMarkentry";
            this.toolStripMarkentry.Size = new System.Drawing.Size(606, 35);
            this.toolStripMarkentry.TabIndex = 26;
            this.toolStripMarkentry.Text = "toolStrip1";
            // 
            // toolStripLabelMarkentryEvents
            // 
            this.toolStripLabelMarkentryEvents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelMarkentryEvents.Name = "toolStripLabelMarkentryEvents";
            this.toolStripLabelMarkentryEvents.Size = new System.Drawing.Size(55, 32);
            this.toolStripLabelMarkentryEvents.Text = "Events";
            // 
            // toolStripComboBoxMarkentryEvents
            // 
            this.toolStripComboBoxMarkentryEvents.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBoxMarkentryEvents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxMarkentryEvents.Name = "toolStripComboBoxMarkentryEvents";
            this.toolStripComboBoxMarkentryEvents.Size = new System.Drawing.Size(250, 35);
            // 
            // toolStripLabelMarkentryEvent
            // 
            this.toolStripLabelMarkentryEvent.Name = "toolStripLabelMarkentryEvent";
            this.toolStripLabelMarkentryEvent.Size = new System.Drawing.Size(22, 32);
            this.toolStripLabelMarkentryEvent.Text = "Go";
            // 
            // BtnMarkentryCancel
            // 
            this.BtnMarkentryCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkentryCancel.Location = new System.Drawing.Point(291, 399);
            this.BtnMarkentryCancel.Name = "BtnMarkentryCancel";
            this.BtnMarkentryCancel.Size = new System.Drawing.Size(97, 28);
            this.BtnMarkentryCancel.TabIndex = 27;
            this.BtnMarkentryCancel.Text = "Cancel";
            this.BtnMarkentryCancel.UseVisualStyleBackColor = true;
            // 
            // FormMarkEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 473);
            this.Controls.Add(this.BtnMarkentryCancel);
            this.Controls.Add(this.toolStripMarkentry);
            this.Controls.Add(this.BtnMarkentryExit);
            this.Controls.Add(this.BtnMarkentrySave);
            this.Controls.Add(this.statusStripMarkentry);
            this.Controls.Add(this.dataGridViewMarkentry);
            this.Name = "FormMarkEntry";
            this.Text = "MarkEntry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkentry)).EndInit();
            this.toolStripMarkentry.ResumeLayout(false);
            this.toolStripMarkentry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMarkentry;
        private System.Windows.Forms.Button BtnMarkentryExit;
        private System.Windows.Forms.Button BtnMarkentrySave;
        private System.Windows.Forms.StatusStrip statusStripMarkentry;
        private System.Windows.Forms.ToolStrip toolStripMarkentry;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMarkentryEvents;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxMarkentryEvents;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMarkentryEvent;
        private System.Windows.Forms.Button BtnMarkentryCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn EventRollNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Judges;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgMark;
    }
}