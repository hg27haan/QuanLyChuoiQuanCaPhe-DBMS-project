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
    public partial class UC_QuanLyVaAdmin : UserControl
    {
        private SQLServerConnection sSC = new SQLServerConnection();

        private bool navigationExpand = false;

        private string dataUserName = null;
        private string dataPassword = null;

        private string dataPhanQuyen = null;
        private string dataMaCS = null;

        public UC_QuanLyVaAdmin(string userName, string passWord, string phanQuyen, string dataMaCS)
        {
            InitializeComponent();

            this.dataUserName = userName;
            this.dataPassword = passWord;

            pnlNavigation.Width = pnlNavigation.MinimumSize.Width;

            this.dataPhanQuyen = phanQuyen;
            this.dataMaCS = dataMaCS;

            //if (this.dataPhanQuyen == "ql")
            //{
            //    pictureBox10.Visible = false;
            //    pictureBox9.Visible = false;
            //    pictureBox8.Visible = false;
            //    btnNavigation_DoiTac.Visible = false;
            //    btnNavigation_CoSo.Visible = false;
            //    btnAccount.Visible = false;
            //}    
        }

        private void timerDayTime_Tick(object sender, EventArgs e)
        {
            lblUC_QuanLy_DateTimeNow.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm:ss");
        }

        private void timerNavigation_Tick(object sender, EventArgs e)
        {
            if (navigationExpand == true)
            {
                // nếu navigation đang mở, đóng nó
                pnlNavigation.Width -= 300;
                if(pnlNavigation.Width == pnlNavigation.MinimumSize.Width)
                {
                    navigationExpand = false;
                    timerNavigation.Stop();
                }
            }
            else
            {
                // nếu navigation đang đóng, mở nó
                pnlNavigation.Width += 300;
                if(pnlNavigation.Width == pnlNavigation.MaximumSize.Width)
                {
                    navigationExpand = true;
                    timerNavigation.Stop();
                }    
            }
        }

        private void UC_QuanLy_Load(object sender, EventArgs e)
        {
            hienThi_ThongTinNV();
        }

        private void maximumSize_Navigation_Mouse_Enter()
        {
            if(navigationExpand == false) 
            {
                timerNavigation.Start();
            }
            if(navigationExpand == true)
            {
                timerNavigation.Stop();
            }
        }

        private void maximumSize_Navigation_Mouse_Leave()
        {
            if (navigationExpand == true)
            {
                timerNavigation.Start();
            }
        }

        private void pnlNavigation_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void pnlNavigation_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_ThongTinNV_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_ThongTinNV_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_CaLamViec_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_CaLamViec_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_KhoNguyenLieu_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_KhoNguyenLieu_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_SanPhamHienTai_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_SanPhamHienTai_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnCheBienSanPham_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnCheBienSanPham_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_Luong_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_Luong_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_DoanhThu_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_DoanhThu_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_DoiTac_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_DoiTac_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnNavigation_CoSo_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnNavigation_CoSo_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnKhachHang_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void btnAccount_MouseEnter(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Enter();
        }

        private void btnAccount_MouseLeave(object sender, EventArgs e)
        {
            maximumSize_Navigation_Mouse_Leave();
        }

        private void hienThi_ThongTinNV()
        {
            UserControl uc_QL_NhanVien = new UC_QL_NhanVien(dataUserName, dataPassword, dataPhanQuyen, dataMaCS);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_NhanVien);
            uc_QL_NhanVien.Dock = DockStyle.Fill;
            uc_QL_NhanVien.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Nhân Viên";
        }    

        private void btnNavigation_ThongTinNV_Click(object sender, EventArgs e)
        {
            hienThi_ThongTinNV();
        }

        private void btnNavigation_CaLamViec_Click(object sender, EventArgs e)
        {
            UserControl uc_QL_CaLamViec = new UC_QL_CaLamViec(dataUserName, dataPassword, dataPhanQuyen, dataMaCS);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_CaLamViec);
            uc_QL_CaLamViec.Dock = DockStyle.Fill;
            uc_QL_CaLamViec.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Ca Làm Việc";
        }

        private void btnNavigation_KhoNguyenLieu_Click(object sender, EventArgs e)
        {
            UserControl uc_QL_KhoNguyenLieu = new UC_QL_KhoNguyenLieu(dataUserName, dataPassword, dataPhanQuyen, dataMaCS);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_KhoNguyenLieu);
            uc_QL_KhoNguyenLieu.Dock = DockStyle.Fill;
            uc_QL_KhoNguyenLieu.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Kho Nguyên Liệu";
        }

        private void btnNavigation_SanPhamHienTai_Click(object sender, EventArgs e)
        {
            UserControl uc_QL_SanPham_HienTai = new UC_QL_SanPham_HienTai(dataUserName, dataPassword);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_SanPham_HienTai);
            uc_QL_SanPham_HienTai.Dock = DockStyle.Fill;
            uc_QL_SanPham_HienTai.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Sản Phẩm Hiện Tại";
        }

        private void btnCheBienSanPham_Click(object sender, EventArgs e)
        {
            UserControl uc_QL_CheBienSanPham = new UC_QL_CheBienSanPham(dataUserName, dataPassword);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_CheBienSanPham);
            uc_QL_CheBienSanPham.Dock = DockStyle.Fill;
            uc_QL_CheBienSanPham.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Chế Biến Sản Phẩm";
        }

        private void btnNavigation_Luong_Click(object sender, EventArgs e)
        {
            UserControl uc_QL_TienLuong = new UC_Admin_TienLuong(dataUserName, dataPassword, dataPhanQuyen, dataMaCS);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_TienLuong);
            uc_QL_TienLuong.Dock = DockStyle.Fill;
            uc_QL_TienLuong.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Tiền Lương";
        }

        private void btnNavigation_DoanhThu_Click(object sender, EventArgs e)
        {
            UserControl uc_QL_DoanhThu = new UC_QL_DoanhThu(dataUserName, dataPassword, dataPhanQuyen, dataMaCS);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_DoanhThu);
            uc_QL_DoanhThu.Dock = DockStyle.Fill;
            uc_QL_DoanhThu.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Doanh Thu";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            UserControl uc_QL_Admin_KhachHang = new UC_QL_Admin_KhachHang(dataUserName, dataPassword);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_QL_Admin_KhachHang);
            uc_QL_Admin_KhachHang.Dock = DockStyle.Fill;
            uc_QL_Admin_KhachHang.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Khách Hàng";
        }

        private void btnNavigation_DoiTac_Click(object sender, EventArgs e)
        {
            UserControl uc_Admin_DoiTac = new UC_Admin_DoiTac(dataUserName, dataPassword);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_Admin_DoiTac);
            uc_Admin_DoiTac.Dock = DockStyle.Fill;
            uc_Admin_DoiTac.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Đối Tác";
        }

        private void btnNavigation_CoSo_Click(object sender, EventArgs e)
        {
            UserControl uc_Admin_CoSo = new UC_Admin_CoSo(dataUserName, dataPassword);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_Admin_CoSo);
            uc_Admin_CoSo.Dock = DockStyle.Fill;
            uc_Admin_CoSo.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Cơ Sở";
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UserControl uc_Admin_Account = new UC_Admin_Account(dataUserName, dataPassword);
            pnlUC_QuanLy_Center.Controls.Clear();
            pnlUC_QuanLy_Center.Controls.Add(uc_Admin_Account);
            uc_Admin_Account.Dock = DockStyle.Fill;
            uc_Admin_Account.BringToFront();
            lblTrangThaiQuanLy.Text = "Quản Lý Account (Tài Khoản)";
        }
    }
}
