﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QuanLyThuVien_CSharp.GUI.AdminForm.fQuanLySach());
            //Application.Run(new QuanLyThuVien_CSharp.GUI.ManagerForm.QLPhieuMuon.fQLPhieuMuon());
            Application.Run(new QuanLyThuVien_CSharp.GUI.ManagerForm.QLDocGia.fQLDocGia());
            //Application.Run(new fQuanLyDanhMuc());
        }
    }
}
