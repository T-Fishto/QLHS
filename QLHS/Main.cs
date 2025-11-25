using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Main : Form
    {
        QueQuan queQuan = null;
        LopHoc lopHoc = null;
        HocSinh hocSinh = null;
        PhanLop phanLop = null;
        AboutBox aboutBox = null;
        public Main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();
            InitializeComponent();
        }

        private void lớphọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lopHoc == null || lopHoc.IsDisposed)
            {
                lopHoc = new LopHoc();
                lopHoc.MdiParent = this;
                lopHoc.Show();
            }
            else
            {
                lopHoc.Activate();
            }
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo prosec= new ProcessStartInfo();
            prosec.FileName = "chrome.exe";
            prosec.Arguments = "http://regis.agu.edu.vn";
            Process.Start(prosec);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Muốn Thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void mnuQueQuan_Click(object sender, EventArgs e)
        {
            if (queQuan == null || queQuan.IsDisposed)
            {
                queQuan = new QueQuan();
                queQuan.MdiParent = this;
                queQuan.Show();
            }
            else
            {
                queQuan.Activate();
            }
        }

        private void mnuHocSinh_Click(object sender, EventArgs e)
        {
            if (hocSinh == null || hocSinh.IsDisposed)
            {
                hocSinh = new HocSinh();
                hocSinh.MdiParent = this;
                hocSinh.Show();
            }
            else
            {
                hocSinh.Activate();
            }
        }

        private void mnuPhanLop_Click(object sender, EventArgs e)
        {
            if (phanLop == null || phanLop.IsDisposed)
            {
                phanLop = new PhanLop();
                phanLop.MdiParent = this;
                phanLop.Show();
            }
            else
            {
                phanLop.Activate();
            }
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
