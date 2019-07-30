namespace EVENT_MANAGEMENT
{
    partial class ResultReport
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
            this.dataGridViewResultReport = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judge1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judge2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judge3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LblResultReportEvents = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxResultReportEvents = new System.Windows.Forms.ToolStripComboBox();
            this.LblResultReportGo = new System.Windows.Forms.ToolStripLabel();
            this.ResultReportErrorMsg = new System.Windows.Forms.StatusStrip();
            this.btnResultReportExit = new System.Windows.Forms.Button();
            this.btnResultReportPrint = new System.Windows.Forms.Button();
            this.btnResultReportCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultReport)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResultReport
            // 
            this.dataGridViewResultReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewResultReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.EventRollNo,
            this.RollNo,
            this.Name,
            this.Judge1,
            this.Judge2,
            this.Judge3,
            this.AvgMarks});
            this.dataGridViewResultReport.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewResultReport.Name = "dataGridViewResultReport";
            this.dataGridViewResultReport.RowHeadersVisible = false;
            this.dataGridViewResultReport.Size = new System.Drawing.Size(888, 432);
            this.dataGridViewResultReport.TabIndex = 0;
            // 
            // SlNo
            // 
            this.SlNo.HeaderText = "Sl No";
            this.SlNo.Name = "SlNo";
            this.SlNo.Width = 80;
            // 
            // EventRollNo
            // 
            this.EventRollNo.HeaderText = "Event Roll No";
            this.EventRollNo.Name = "EventRollNo";
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "Roll No";
            this.RollNo.Name = "RollNo";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Judge1
            // 
            this.Judge1.HeaderText = "Judge 1";
            this.Judge1.Name = "Judge1";
            this.Judge1.Width = 125;
            // 
            // Judge2
            // 
            this.Judge2.HeaderText = "Judge 2";
            this.Judge2.Name = "Judge2";
            this.Judge2.Width = 125;
            // 
            // Judge3
            // 
            this.Judge3.HeaderText = "Judge 3";
            this.Judge3.Name = "Judge3";
            this.Judge3.Width = 125;
            // 
            // AvgMarks
            // 
            this.AvgMarks.HeaderText = "Avg. Marks";
            this.AvgMarks.Name = "AvgMarks";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblResultReportEvents,
            this.ComboBoxResultReportEvents,
            this.LblResultReportGo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 35);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LblResultReportEvents
            // 
            this.LblResultReportEvents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultReportEvents.Name = "LblResultReportEvents";
            this.LblResultReportEvents.Size = new System.Drawing.Size(55, 32);
            this.LblResultReportEvents.Text = "Events";
            // 
            // ComboBoxResultReportEvents
            // 
            this.ComboBoxResultReportEvents.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxResultReportEvents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxResultReportEvents.Name = "ComboBoxResultReportEvents";
            this.ComboBoxResultReportEvents.Size = new System.Drawing.Size(250, 35);
            // 
            // LblResultReportGo
            // 
            this.LblResultReportGo.Name = "LblResultReportGo";
            this.LblResultReportGo.Size = new System.Drawing.Size(22, 32);
            this.LblResultReportGo.Text = "Go";
            // 
            // ResultReportErrorMsg
            // 
            this.ResultReportErrorMsg.Location = new System.Drawing.Point(0, 515);
            this.ResultReportErrorMsg.Name = "ResultReportErrorMsg";
            this.ResultReportErrorMsg.Size = new System.Drawing.Size(910, 22);
            this.ResultReportErrorMsg.TabIndex = 20;
            this.ResultReportErrorMsg.Text = "statusStrip1";
            // 
            // btnResultReportExit
            // 
            this.btnResultReportExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultReportExit.Location = new System.Drawing.Point(792, 481);
            this.btnResultReportExit.Name = "btnResultReportExit";
            this.btnResultReportExit.Size = new System.Drawing.Size(93, 28);
            this.btnResultReportExit.TabIndex = 21;
            this.btnResultReportExit.Text = "Exit";
            this.btnResultReportExit.UseVisualStyleBackColor = true;
            // 
            // btnResultReportPrint
            // 
            this.btnResultReportPrint.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultReportPrint.Location = new System.Drawing.Point(689, 481);
            this.btnResultReportPrint.Name = "btnResultReportPrint";
            this.btnResultReportPrint.Size = new System.Drawing.Size(97, 28);
            this.btnResultReportPrint.TabIndex = 22;
            this.btnResultReportPrint.Text = "Print";
            this.btnResultReportPrint.UseVisualStyleBackColor = true;
            // 
            // btnResultReportCancel
            // 
            this.btnResultReportCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultReportCancel.Location = new System.Drawing.Point(586, 481);
            this.btnResultReportCancel.Name = "btnResultReportCancel";
            this.btnResultReportCancel.Size = new System.Drawing.Size(97, 28);
            this.btnResultReportCancel.TabIndex = 23;
            this.btnResultReportCancel.Text = "Cancel";
            this.btnResultReportCancel.UseVisualStyleBackColor = true;
            // 
            // ResultReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 537);
            this.Controls.Add(this.btnResultReportCancel);
            this.Controls.Add(this.btnResultReportExit);
            this.Controls.Add(this.btnResultReportPrint);
            this.Controls.Add(this.ResultReportErrorMsg);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewResultReport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           // this.Name = "ResultReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultReport)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LblResultReportEvents;
        private System.Windows.Forms.ToolStripComboBox ComboBoxResultReportEvents;
        private System.Windows.Forms.ToolStripLabel LblResultReportGo;
        private System.Windows.Forms.StatusStrip ResultReportErrorMsg;
        private System.Windows.Forms.Button btnResultReportExit;
        private System.Windows.Forms.Button btnResultReportPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judge1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judge2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judge3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgMarks;
        private System.Windows.Forms.Button btnResultReportCancel;
    }
}