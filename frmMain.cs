﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiQuanCaPhe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UserControl uC_DangNhap = new UC_DangNhap();
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uC_DangNhap);
            uC_DangNhap.Dock = DockStyle.Fill;
            uC_DangNhap.BringToFront();
        }
    }
}
