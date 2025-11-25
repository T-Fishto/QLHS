using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHS
{
    public partial class HocSinh : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maHocSinh = "";

        public HocSinh()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

		private void BatTat(bool giaTri)
		{
			txtMaHocSinh.Enabled = giaTri;
			txtHoVaTen.Enabled = giaTri;
			txtDiaChi.Enabled = giaTri;
			chkGioiTinhNu.Enabled = giaTri;
			dtpNgaySinh.Enabled = giaTri;
			cboQueQuan.Enabled = giaTri;

			btnLuu.Enabled = giaTri;
			btnHuyBo.Enabled = giaTri;

			btnThem.Enabled = !giaTri;
			btnSua.Enabled = !giaTri;
			btnXoa.Enabled = !giaTri;
		}

		public void LayDuLieu()
        {
			// Lấy dữ liệu vào cboQueQuan
			MyDataTable queQuan = new MyDataTable();
			queQuan.OpenConnection();
			string queQuanSql = "SELECT * FROM QueQuan";
			SqlCommand queQuanCmd = new SqlCommand(queQuanSql);
			queQuan.Fill(queQuanCmd);
			cboQueQuan.DataSource = queQuan;
			cboQueQuan.DisplayMember = "TenQueQuan";
			cboQueQuan.ValueMember = "MaQueQuan";

			// Lấy dữ liệu vào DataGridView
			string hocSinhSql = @"SELECT H.*, Q.TenQueQuan
								  FROM HocSinh H, QueQuan Q
								  WHERE H.MaQueQuan = Q.MaQueQuan";
			SqlCommand hocSinhCmd = new SqlCommand(hocSinhSql);
            dataTable.Fill(hocSinhCmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dataGridView.DataSource = binding;

            // Liên kết dữ liệu từ DataGridView lên các control
            txtMaHocSinh.DataBindings.Clear();
            txtHoVaTen.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            chkGioiTinhNu.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            cboQueQuan.DataBindings.Clear();

            txtMaHocSinh.DataBindings.Add("Text", binding, "MaHocSinh");
            txtHoVaTen.DataBindings.Add("Text", binding, "HoVaTen");
            txtDiaChi.DataBindings.Add("Text", binding, "DiaChi");
            chkGioiTinhNu.DataBindings.Add("Checked", binding, "GioiTinh");
            dtpNgaySinh.DataBindings.Add("Value", binding, "NgaySinh");
            cboQueQuan.DataBindings.Add("SelectedValue", binding, "MaQueQuan");
        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
			dataGridView.AutoGenerateColumns = false;

            LayDuLieu();
			BatTat(false);
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}