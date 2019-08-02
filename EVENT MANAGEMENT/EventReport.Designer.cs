namespace EVENT_MANAGEMENT
{
    partial class EventReport
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
            this.btnEventReportExit = new System.Windows.Forms.Button();
            this.btnEventReportPrint = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LblEventReportEvents = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxEventReport = new System.Windows.Forms.ToolStripComboBox();
            this.LblEventReportGo = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewEventReport = new System.Windows.Forms.DataGridView();
            this.EventRollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultReportErrorMsg = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventReportExit
            // 
            this.btnEventReportExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventReportExit.Location = new System.Drawing.Point(817, 375);
            this.btnEventReportExit.Name = "btnEventReportExit";
            this.btnEventReportExit.Size = new System.Drawing.Size(93, 28);
            this.btnEventReportExit.TabIndex = 16;
            this.btnEventReportExit.Text = "Exit";
            this.btnEventReportExit.UseVisualStyleBackColor = true;
            this.btnEventReportExit.Click += new System.EventHandler(this.btnEventReportExit_Click);
            // 
            // btnEventReportPrint
            // 
            this.btnEventReportPrint.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventReportPrint.Location = new System.Drawing.Point(714, 375);
            this.btnEventReportPrint.Name = "btnEventReportPrint";
            this.btnEventReportPrint.Size = new System.Drawing.Size(97, 28);
            this.btnEventReportPrint.TabIndex = 17;
            this.btnEventReportPrint.Text = "Print";
            this.btnEventReportPrint.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblEventReportEvents,
            this.ComboBoxEventReport,
            this.LblEventReportGo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 35);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LblEventReportEvents
            // 
            this.LblEventReportEvents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEventReportEvents.Name = "LblEventReportEvents";
            this.LblEventReportEvents.Size = new System.Drawing.Size(55, 32);
            this.LblEventReportEvents.Text = "Events";
            // 
            // ComboBoxEventReport
            // 
            this.ComboBoxEventReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxEventReport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEventReport.Name = "ComboBoxEventReport";
            this.ComboBoxEventReport.Size = new System.Drawing.Size(250, 35);
            this.ComboBoxEventReport.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEventReport_SelectedIndexChanged);
            // 
            // LblEventReportGo
            // 
            this.LblEventReportGo.Name = "LblEventReportGo";
            this.LblEventReportGo.Size = new System.Drawing.Size(22, 32);
            this.LblEventReportGo.Text = "Go";
            this.LblEventReportGo.Click += new System.EventHandler(this.LblEventReportGo_Click);
            // 
            // dataGridViewEventReport
            // 
            this.dataGridViewEventReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEventReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventRollNo,
            this.RollNo,
            this.Name,
            this.Qualification});
            this.dataGridViewEventReport.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewEventReport.Name = "dataGridViewEventReport";
            this.dataGridViewEventReport.RowHeadersVisible = false;
            this.dataGridViewEventReport.Size = new System.Drawing.Size(903, 311);
            this.dataGridViewEventReport.TabIndex = 2;
            // 
            // EventRollNo
            // 
            this.EventRollNo.HeaderText = "Event Roll No";
            this.EventRollNo.Name = "EventRollNo";
            this.EventRollNo.Width = 150;
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "Roll No";
            this.RollNo.Name = "RollNo";
            this.RollNo.Width = 150;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 300;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.Name = "Qualification";
            this.Qualification.Width = 300;
            // 
            // ResultReportErrorMsg
            // 
            this.ResultReportErrorMsg.Location = new System.Drawing.Point(0, 415);
            this.ResultReportErrorMsg.Name = "ResultReportErrorMsg";
            this.ResultReportErrorMsg.Size = new System.Drawing.Size(925, 22);
            this.ResultReportErrorMsg.TabIndex = 19;
            this.ResultReportErrorMsg.Text = "statusStrip1";
            // 
            // EventReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 437);
            this.Controls.Add(this.ResultReportErrorMsg);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEventReportExit);
            this.Controls.Add(this.btnEventReportPrint);
            this.Controls.Add(this.dataGridViewEventReport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.Name = "EventReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Report";
            this.Load += new System.EventHandler(this.EventReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEventReportExit;
        private System.Windows.Forms.Button btnEventReportPrint;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LblEventReportEvents;
        private System.Windows.Forms.ToolStripComboBox ComboBoxEventReport;
        private System.Windows.Forms.ToolStripLabel LblEventReportGo;
        private System.Windows.Forms.DataGridView dataGridViewEventReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventRollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.StatusStrip ResultReportErrorMsg;
    }
}