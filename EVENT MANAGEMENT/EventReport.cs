﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT
{
    public partial class EventReport : Form
    {
        public EventReport()
        {
            InitializeComponent();
        }

        private void btnEventReportExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
