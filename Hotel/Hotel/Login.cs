﻿using Hotel.BUS;
using Hotel.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login : Form
    {
        public static bool ChucVu;
        public static bool DanhSachHD;
        public static bool DanhSachPhong;
        public static bool DichVu;
        public static bool KhuVuc;
        public static bool LichDonPhong;
        public static bool LoaiPhong;
        public static bool PhanQuyen;
        public static bool PhongBan;
        public static bool ThongTinKhach;
        public static bool ThongTinNV;
        public static bool ThucDon;
        public static bool TiepNhanKhach;
        public static bool TKCuaTui;
        public static bool TrangChu;

        public Login()
        {
            InitializeComponent();
        }

        public List<NhanVien> login()
        {
            NhanVienBUS nv = new NhanVienBUS();
            List<NhanVien> lst = new List<NhanVien>();
            lst = nv.Login(txtUser.Text, txtPass.Text);
            return lst;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            List<NhanVien> list = login();
            NhanVien nv = new NhanVien();
            if (list.Count() == 1)
            {
                Properties.Settings.Default.Email = txtUser.Text;
                Properties.Settings.Default.Pass = txtPass.Text;
                foreach (var i in list)
                {
                    Properties.Settings.Default.Name = i.TenNV.ToString();
                }
                Menu mn = new Hotel.Menu();
                setBtnMenu();

                mn.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng");
            }
        }

        private bool KTPhanQuyen(int col)
        {
            DataTable dt = new DataTable();
            PhanQuyenBUS PQBUS = new PhanQuyenBUS();
            dt = PQBUS.Get_By_Top("", "", "");

            bool check = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][col].ToString() == "True")
                    return check = true;
            }
            return check;
        }

        private void lcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void setBtnMenu()
        {
            ChucVu = KTPhanQuyen(12);
            DanhSachHD = KTPhanQuyen(11);
            DanhSachPhong = KTPhanQuyen(3);
            DichVu = KTPhanQuyen(5);
            KhuVuc = KTPhanQuyen(8);
            LichDonPhong = KTPhanQuyen(13);
            LoaiPhong = KTPhanQuyen(4);
            PhanQuyen = KTPhanQuyen(16);
            PhongBan = KTPhanQuyen(7);
            ThongTinKhach = KTPhanQuyen(9);
            ThongTinNV = KTPhanQuyen(10);
            ThucDon = KTPhanQuyen(6);
            TiepNhanKhach = KTPhanQuyen(2);
            TKCuaTui = KTPhanQuyen(14);
            TrangChu = KTPhanQuyen(1);
        }
    }
}