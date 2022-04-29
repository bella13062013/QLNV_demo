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

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadPB();
            loadData();
            KetNoi.dongKetNoi();
        }
    }
}
