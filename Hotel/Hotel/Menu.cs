﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Configuration;
using Hotel.BUS;
using Hotel.Model;
using Hotel.ListForm;

namespace Hotel
{
    public partial class Menu : Form
    {
        private Button[,] btnTest;
        private Panel[,] pnThanhMN;

        public Menu()
        {
            InitializeComponent();
        }

        public void CreateListMenu(int n)
        {
            btnTest = new Button[n, n];
            pnThanhMN = new Panel[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    btnTest[i, j] = new Button();
                    btnTest[i, j].Location = new System.Drawing.Point(0, 40 + 42 * i);
                    btnTest[i, j].Name = "btnTest" + i + "." + j;
                    btnTest[i, j].Size = new System.Drawing.Size(200, 40);
                    // btnTest[i, j].Text = "(" + i + ", " + j + ")";
                    btnTest[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
                    btnTest[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    btnTest[i, j].FlatStyle = FlatStyle.Flat;
                    btnTest[i, j].FlatAppearance.BorderSize = 0;
                    btnTest[i, j].UseVisualStyleBackColor = false;
                    btnTest[i, j].Tag = "" + i + "," + j + "";
                    btnTest[i, j].MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTest_MouseMove);
                    btnTest[i, j].MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
                    btnTest[i, j].Click += new System.EventHandler(this.btnTest_Click);

                    // btnTest[i, j].Click += new System.EventHandler(this.btnTest_Click);

                    pnThanhMN[i, j] = new Panel();
                    pnThanhMN[i, j].Location = new System.Drawing.Point(0, 40 + 42 * i);
                    pnThanhMN[i, j].Name = "pbThanh" + i + "." + j;
                    pnThanhMN[i, j].Size = new System.Drawing.Size(10, 40);
                    pnThanhMN[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
                    pnThanhMN[i, j].Visible = false;

                    pnMenuLeft.Controls.Add(pnThanhMN[i, j]);
                    pnMenuLeft.Controls.Add(btnTest[i, j]);
                }
            }
        }

        public void CreateNameMenuAD()
        {
            btnTest[0, 0].Text = "TRANG CHỦ";
            btnTest[1, 0].Text = "TIẾP NHẬN KHÁCH";
            btnTest[2, 0].Text = "DANH SÁCH PHÒNG";
            btnTest[3, 0].Text = "LOẠI PHÒNG";
            btnTest[4, 0].Text = "DỊCH VỤ";
            btnTest[5, 0].Text = "THỰC ĐƠN";
            btnTest[6, 0].Text = "PHÒNG BAN";
            btnTest[7, 0].Text = "THÔNG TIN KHÁCH HÀNG";
            btnTest[8, 0].Text = "THÔNG TIN NHÂN VIÊN";
            btnTest[9, 0].Text = "KHU VỰC";
            btnTest[10, 0].Text = "DANH SÁCH HÓA ĐƠN";
            btnTest[11, 0].Text = "CHỨC VỤ";
            btnTest[12, 0].Text = "LỊCH DỌN PHÒNG";
            btnTest[13, 0].Text = "TÀI KHOẢN CỦA TÔI";
            btnTest[14, 0].Text = "PHÂN QUYỀN";
            lbNameNV.Text = Properties.Settings.Default.Name.ToString();
            Login lg = new Login();

            btnTest[0, 0].Enabled = Login.TrangChu == true ? true : false;
            btnTest[1, 0].Enabled = Login.TiepNhanKhach == true ? true : false;
            btnTest[2, 0].Enabled = Login.DanhSachPhong == true ? true : false;
            btnTest[3, 0].Enabled = Login.LoaiPhong == true ? true : false;
            btnTest[4, 0].Enabled = Login.DichVu == true ? true : false;
            btnTest[5, 0].Enabled = Login.ThucDon == true ? true : false;
            btnTest[6, 0].Enabled = Login.PhongBan == true ? true : false;
            btnTest[7, 0].Enabled = Login.ThongTinKhach == true ? true : false;
            btnTest[8, 0].Enabled = Login.ThongTinNV == true ? true : false;
            btnTest[9, 0].Enabled = Login.KhuVuc == true ? true : false;
            btnTest[10, 0].Enabled = Login.DanhSachHD == true ? true : false;
            btnTest[11, 0].Enabled = Login.ChucVu == true ? true : false;
            btnTest[12, 0].Enabled = Login.LichDonPhong == true ? true : false;
            btnTest[13, 0].Enabled = Login.TKCuaTui == true ? true : false;
            btnTest[14, 0].Enabled = Login.PhanQuyen == true ? true : false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Button test = (Button)sender;
            string[] vt = test.Tag.ToString().Split(',');
            int i = int.Parse(vt[0]);
            int j = int.Parse(vt[1]);
            if (i == 0)
            {
                pnMenu.Controls.Clear();
            }
            if (i == 1)
            {
            }
            if (i == 2)
            {
            }
            if (i == 3)
            {
            }
            if (i == 4)
            {
            }
            if (i == 5)
            {
            }
            if (i == 6)
            {
            }
            if (i == 7)
            {
            }
            if (i == 8)
            {
            }
            if (i == 9)
            {
            }
            if (i == 10)
            {
            }
            if (i == 11)
            {
            }
            if (i == 12)
            {
            }
            if (i == 13)
            {
            }
            if (i == 14)
            {
                pnMenu.Controls.Clear();
                frmPhanQuyen frmPhanQuyen = new frmPhanQuyen();
                pnMenu.Controls.Add(frmPhanQuyen);
            }
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            Button test = (Button)sender;
            string[] vt = test.Tag.ToString().Split(',');
            int i = int.Parse(vt[0]);
            int j = int.Parse(vt[1]);
            pnThanhMN[i, j].Visible = false;
        }

        private void btnTest_MouseMove(object sender, MouseEventArgs e)
        {
            Button test = (Button)sender;
            string[] vt = test.Tag.ToString().Split(',');
            int i = int.Parse(vt[0]);
            int j = int.Parse(vt[1]);
            pnThanhMN[i, j].Visible = true;
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            CreateListMenu(15);
            CreateNameMenuAD();
        }
    }
}