using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tuan7
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối sử dụng Windows Authentication
        private string connectionString = "Server=LAPTOP-2HIEQ3KN\\SQLEXPRESS;Database=QLSanpham;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            LoadData(); // Tải dữ liệu khi khởi động form
            LoadLoaiSanPham(); // Tải loại sản phẩm khi khởi động form
        }

        // Tải dữ liệu từ cơ sở dữ liệu vào DataGridView
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sanpham", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvQuanly.DataSource = dataTable;

                    // Kiểm tra xem DataGridView đã có dữ liệu hay chưa
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có sản phẩm nào trong cơ sở dữ liệu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        // Tải loại sản phẩm vào ComboBox
        private void LoadLoaiSanPham()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM LoaiSanPham", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cboLoaiSP.DataSource = dataTable;
                    cboLoaiSP.DisplayMember = "TenLoaiSP"; // Tên loại sản phẩm hiển thị
                    cboLoaiSP.ValueMember = "MaLoaiSP"; // Giá trị loại sản phẩm
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải loại sản phẩm: " + ex.Message);
                }
            }
        }

        // Thêm sản phẩm mới
        private void btThem_Click(object sender, EventArgs e)
        {
            string maSP = TxtMaSP.Text; // Sử dụng TxtMaSP
            string tenSP = TxtTenSP.Text; // Sử dụng TxtTenSP
            DateTime ngaynhap = dtNgaynhap.Value; // Sử dụng dtNgaynhap
            string maLoaiSP = cboLoaiSP.SelectedValue.ToString(); // Sử dụng cboLoaiSP

            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(tenSP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Sanpham (MaSP, TenSP, Ngaynhap, MaLoaiSP) VALUES (@MaSP, @TenSP, @Ngaynhap, @MaLoaiSP)", connection);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@Ngaynhap", ngaynhap);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", maLoaiSP);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadData(); // Tải lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
                }
            }
        }

        // Sửa sản phẩm
        private void btSua_Click(object sender, EventArgs e)
        {
            string maSP = TxtMaSP.Text; // Sử dụng TxtMaSP
            string tenSP = TxtTenSP.Text; // Sử dụng TxtTenSP
            DateTime ngaynhap = dtNgaynhap.Value; // Sử dụng dtNgaynhap
            string maLoaiSP = cboLoaiSP.SelectedValue.ToString(); // Sử dụng cboLoaiSP

            if (string.IsNullOrWhiteSpace(maSP))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để sửa.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Sanpham SET TenSP = @TenSP, Ngaynhap = @Ngaynhap, MaLoaiSP = @MaLoaiSP WHERE MaSP = @MaSP", connection);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@Ngaynhap", ngaynhap);
                    cmd.Parameters.AddWithValue("@MaLoaiSP", maLoaiSP);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa sản phẩm thành công!");
                    LoadData(); // Tải lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message);
                }
            }
        }

        // Xóa sản phẩm
        private void btXoa_Click(object sender, EventArgs e)
        {
            string maSP = TxtMaSP.Text; // Sử dụng TxtMaSP

            if (string.IsNullOrWhiteSpace(maSP))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để xóa.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Sanpham WHERE MaSP = @MaSP", connection);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadData(); // Tải lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
                }
            }
        }

        private void dgvQuanly_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Điền thông tin vào các ô nhập liệu khi chọn sản phẩm trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQuanly.Rows[e.RowIndex];
                TxtMaSP.Text = row.Cells["ColMASP"].Value.ToString(); // Sử dụng tên cột là ColMASP
                TxtTenSP.Text = row.Cells["ColTenSP"].Value.ToString(); // Sử dụng tên cột là ColTenSP
                dtNgaynhap.Value = Convert.ToDateTime(row.Cells["ColNgayNhap"].Value); // Sử dụng tên cột là ColNgayNhap
                cboLoaiSP.SelectedValue = row.Cells["ColLoaiSP"].Value.ToString(); // Sử dụng tên cột là ColLoaiSP
            }
        }
    }
}
