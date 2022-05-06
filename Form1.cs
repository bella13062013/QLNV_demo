using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Demo_QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadPB()
        {
            string sql = "select * from PHONGBAN";

            cboPB.DataSource = KetNoi.getData(sql);
            cboPB.DisplayMember = "TenPB";
            cboPB.ValueMember = "MaPB";
        }
        public void loadData()
        {
            string sql = "select * from NHANVIEN";
            data.DataSource = KetNoi.getData(sql);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values (@MaNV,@TenNV,@Nsinh,@Gtinh,@SDT,@PB,@picture)";
            string[] name = { "@MaNV", "@TenNV", "@Nsinh", "@Gtinh", "@SDT", "@PB", "@Picture" };

            bool gt = rdnam.Checked == true ? true : false;

            object[] value = { txtMaNV.Text, txtHT.Text, dttns.Value, gt, txtsdt.Text, cboPB.SelectedValue, lbAnh.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 7);
            loadData();
            KetNoi.dongKetNoi();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadPB();
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                PTAnh.Image = Image.FromFile(oFile.FileName);
                lbAnh.Text = Path.GetFileName(oFile.FileName);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            if (i >= 0)
            {
                DialogResult dr = MessageBox.Show("Ban co muon xoa khong?", "Thong Bao", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string ma = data.Rows[i].Cells[0].Value.ToString();
                    string sql = string.Format("delete from NHANVIEN where MaNV ='{0}'", ma);
                    object[] value = { };
                    string[] name = { };

                    KetNoi.moKetNoi();
                    KetNoi.updateData(sql, value, name, 0);
                    loadData();
                    KetNoi.dongKetNoi();
                }
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            txtMaNV.Text = data.Rows[i].Cells[0].Value.ToString();
            txtHT.Text = data.Rows[i].Cells[1].Value.ToString();
            dttns.Text = data.Rows[i].Cells[2].Value.ToString();

            string gt = data.Rows[i].Cells[3].Value.ToString();
            if (gt == "True")
            {
                rdnam.Checked = true;
            }
            else
                rdnu.Checked = true;
            txtsdt.Text = data.Rows[i].Cells[4].Value.ToString();
            cboPB.SelectedValue = data.Rows[i].Cells[5].Value.ToString();

            lbAnh.Text = data.Rows[i].Cells[6].Value.ToString();

            string pathAnh = ConfigurationManager.AppSettings.Get("duongdanhanh") + "\\" + lbAnh.Text;
            if (File.Exists(pathAnh))
            {
                PTAnh.Image = Image.FromFile(pathAnh);

            }
            else
                PTAnh.Image = null;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update NHANVIEN set MaNV = @MaNV,TenNV = @TenNV,Nsinh =@Nsinh,Gtinh = @Gtinh,SDT = @SDT,PB =@PB,picture = @picture where MaNV ='{0}'", txtMaNV.Text);

            string[] name = { "@MaNV", "@TenNV", "@Nsinh", "@Gtinh", "@SDT", "@PB", "@picture" };

            bool gt = rdnam.Checked == true ? true : false;

            object[] value = { txtMaNV.Text, txtHT.Text, dttns.Value, gt, txtsdt.Text, cboPB.SelectedValue, lbAnh.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 7);
            loadData();
            KetNoi.dongKetNoi();

        }
    }
}
