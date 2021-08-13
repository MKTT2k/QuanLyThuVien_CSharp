﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLPhieuMuon
{
    public partial class fAddPhieuMuon : Form
    {
        QuanLyThuVien_CSharpDataContext db = new QuanLyThuVien_CSharpDataContext();
        fQLPhieuMuon QLPhieuMuon;
        int index = -1;
        String tenDangNhap = "hola";
        public fAddPhieuMuon(fQLPhieuMuon f)
        {
            InitializeComponent();
            QLPhieuMuon = f;
            loadForm();

        }
        public void loadForm()
        {
            var s = (from p in db.PHIEUMUONs
                     orderby p.SoPhieuMuon descending
                     select p).FirstOrDefault();
            lblChiTietPhieu.Text = (s == null ? 1 : s.SoPhieuMuon + 1).ToString();
            loadComBoSach();
        }

        public void loadComBoSach()
        {
            var s = from p in db.SACHes
                    select new { Ten = p.MaSach + " - " + p.TenSach, p.MaSach };
            cbbSach.DataSource = s;
            cbbSach.DisplayMember = "Ten";
            cbbSach.ValueMember = "MaSach";
            cbbSach.SelectedIndex = -1;
        }

        private void fAddPhieuMuon_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbSach.Text.Contains("-"))
                {
                    var s = (from p in db.SACHes
                             where p.MaSach == Int32.Parse(cbbSach.SelectedValue.ToString())
                             select new { p.MaSach, p.TenSach, p.GiaMuon, p.SoLuong }).FirstOrDefault();
                    int slThuc = Int32.Parse(nudSoLuong.Text);
                    if (dgvCTPHieu.Rows.Count > 0)
                    {
                        for (int z = 0; z < dgvCTPHieu.Rows.Count; z++)
                        {
                            if (dgvCTPHieu.Rows[z].Cells[0].Value.ToString().Equals(cbbSach.SelectedValue.ToString()))
                                slThuc++;
                        }
                    }
                    if (s.SoLuong < slThuc)
                    {
                        throw new Exception("Không đủ sách để cho mượn!");
                    }
                    for (int i = 0; i < Int32.Parse(nudSoLuong.Text); i++)
                    {
                        dgvCTPHieu.Rows.Add(s.MaSach, s.TenSach, s.GiaMuon);
                        //txtTongTien.Text = (Int32.Parse(txtTongTien.Text) + s.GiaMuon).ToString();
                        txtTongTien.Text = (Int32.Parse(txtTongTien.Text) + s.GiaMuon).ToString();
                    }
                }
                else
                {
                    if (cbbSach.Text.Equals(""))
                    {
                        cbbSach.Focus();
                        throw new Exception("Vui lòng nhập mã sách");
                    }
                    if (!cbbSach.Text.All(char.IsDigit))
                    {
                        cbbSach.Focus();
                        throw new Exception("Mã sách phải là số");
                    }
                    var s = (from p in db.SACHes
                             where p.MaSach == Int32.Parse(cbbSach.Text)
                             select new { p.MaSach, p.TenSach, p.GiaMuon, p.SoLuong }).FirstOrDefault();
                    if (s == null)
                    {
                        throw new Exception("Mã sách không tồn tại");
                    }
                    int slThuc = Int32.Parse(nudSoLuong.Text);
                    if (dgvCTPHieu.Rows.Count > 0)
                    {
                        for (int z = 0; z < dgvCTPHieu.Rows.Count; z++)
                        {
                            if (dgvCTPHieu.Rows[z].Cells[0].Value.ToString().Equals(cbbSach.Text))
                                slThuc++;
                        }
                    }
                    if (s.SoLuong < slThuc)
                    {
                        throw new Exception("Không đủ sách để cho mượn!");
                    }
                    for (int i = 0; i < Int32.Parse(nudSoLuong.Text); i++)
                    {
                        dgvCTPHieu.Rows.Add(s.MaSach, s.TenSach, s.GiaMuon);
                        txtTongTien.Text = (Int32.Parse(txtTongTien.Text) + s.GiaMuon).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvCTPHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                txtTongTien.Text = (Int32.Parse(txtTongTien.Text) - Int32.Parse(dgvCTPHieu.Rows[index].Cells[2].Value.ToString())).ToString();
                dgvCTPHieu.Rows.RemoveAt(index);
                index = -1;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xoá!", "Lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNguoiMuon.Text.Equals(""))
                {
                    txtNguoiMuon.Focus();
                    throw new Exception("Vui lòng nhập mã sinh viên người mượn!");
                }
                if (dgvCTPHieu.RowCount <= 0)
                {
                    throw new Exception("Danh sách mượn không được để trống!");
                }
                if (dgvCTPHieu.RowCount > 10)
                {
                    throw new Exception("Mỗi lần không được mượn quá 10 quyển!");
                }
                PHIEUMUON phieu = new PHIEUMUON();
                phieu.TenDangNhap = tenDangNhap;
                phieu.MaSinhVien = txtNguoiMuon.Text;
                db.PHIEUMUONs.InsertOnSubmit(phieu);
                db.SubmitChanges();
                var s = (from p in db.PHIEUMUONs
                         orderby p.SoPhieuMuon descending
                         select p).First();
                DateTime localDate = DateTime.Now;
                string currentDate = localDate.Date.ToString(new CultureInfo("en-GB")).Split(' ')[0];
                string ngay = currentDate.Substring(0, 2);
                string thang = currentDate.Substring(3, 2);
                string nam = currentDate.Substring(6);
                for (int i = 0; i < dgvCTPHieu.RowCount; i++)
                {
                    CTPHIEUMUON a = new CTPHIEUMUON();
                    a.SoPhieuMuon = s.SoPhieuMuon;
                    a.MaSach = Int32.Parse(dgvCTPHieu.Rows[i].Cells[0].Value.ToString());
                    a.TinhTrang = false;
                    a.NgayMuon = DateTime.ParseExact(thang + "/" + ngay + "/" + nam, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    a.NgayTra = null;
                    db.CTPHIEUMUONs.InsertOnSubmit(a);
                    var updatesl = db.SACHes.Single(sp => sp.MaSach == Int32.Parse(dgvCTPHieu.Rows[i].Cells[0].Value.ToString()));
                    updatesl.SoLuong = updatesl.SoLuong - 1;
                    db.SubmitChanges();
                }
                QLPhieuMuon.loadForm();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}