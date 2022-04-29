
namespace Demo_QLNV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPB = new System.Windows.Forms.ComboBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.dttns = new System.Windows.Forms.DateTimePicker();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbPB = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbgt = new System.Windows.Forms.Label();
            this.lbns = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.PTAnh = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.lbAnh = new System.Windows.Forms.Label();
            this.btnCA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboPB);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.rdnu);
            this.panel1.Controls.Add(this.rdnam);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.dttns);
            this.panel1.Controls.Add(this.txtHT);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.lbPB);
            this.panel1.Controls.Add(this.lbsdt);
            this.panel1.Controls.Add(this.lbgt);
            this.panel1.Controls.Add(this.lbns);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.lbMaNV);
            this.panel1.Location = new System.Drawing.Point(39, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 338);
            this.panel1.TabIndex = 0;
            // 
            // cboPB
            // 
            this.cboPB.FormattingEnabled = true;
            this.cboPB.Location = new System.Drawing.Point(152, 300);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(163, 24);
            this.cboPB.TabIndex = 17;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(383, 214);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 44);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(383, 131);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(383, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(273, 200);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(42, 20);
            this.rdnu.TabIndex = 13;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(152, 200);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(52, 20);
            this.rdnam.TabIndex = 12;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(152, 248);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(163, 23);
            this.txtsdt.TabIndex = 10;
            // 
            // dttns
            // 
            this.dttns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttns.Location = new System.Drawing.Point(152, 131);
            this.dttns.Name = "dttns";
            this.dttns.Size = new System.Drawing.Size(163, 23);
            this.dttns.TabIndex = 8;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(152, 66);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(163, 23);
            this.txtHT.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(152, 20);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(163, 23);
            this.txtMaNV.TabIndex = 6;
            // 
            // lbPB
            // 
            this.lbPB.AutoSize = true;
            this.lbPB.Location = new System.Drawing.Point(27, 300);
            this.lbPB.Name = "lbPB";
            this.lbPB.Size = new System.Drawing.Size(68, 16);
            this.lbPB.TabIndex = 5;
            this.lbPB.Text = "Phòng ban";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(33, 255);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(32, 16);
            this.lbsdt.TabIndex = 4;
            this.lbsdt.Text = "SDT";
            // 
            // lbgt
            // 
            this.lbgt.AutoSize = true;
            this.lbgt.Location = new System.Drawing.Point(30, 200);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(54, 16);
            this.lbgt.TabIndex = 3;
            this.lbgt.Text = "Giới tính";
            // 
            // lbns
            // 
            this.lbns.AutoSize = true;
            this.lbns.Location = new System.Drawing.Point(30, 136);
            this.lbns.Name = "lbns";
            this.lbns.Size = new System.Drawing.Size(63, 16);
            this.lbns.TabIndex = 2;
            this.lbns.Text = "Ngày sinh";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(27, 71);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(89, 16);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên nhân viên";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(24, 25);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(84, 16);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // PTAnh
            // 
            this.PTAnh.Location = new System.Drawing.Point(546, 49);
            this.PTAnh.Name = "PTAnh";
            this.PTAnh.Size = new System.Drawing.Size(172, 214);
            this.PTAnh.TabIndex = 1;
            this.PTAnh.TabStop = false;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(39, 441);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(662, 184);
            this.data.TabIndex = 2;
            // 
            // lbAnh
            // 
            this.lbAnh.AutoSize = true;
            this.lbAnh.Location = new System.Drawing.Point(676, 281);
            this.lbAnh.Name = "lbAnh";
            this.lbAnh.Size = new System.Drawing.Size(42, 16);
            this.lbAnh.TabIndex = 3;
            this.lbAnh.Text = "label7";
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(546, 278);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(75, 23);
            this.btnCA.TabIndex = 4;
            this.btnCA.Text = "Chọn ảnh";
            this.btnCA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 646);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.lbAnh);
            this.Controls.Add(this.data);
            this.Controls.Add(this.PTAnh);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DateTimePicker dttns;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbPB;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.Label lbns;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.PictureBox PTAnh;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Label lbAnh;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.ComboBox cboPB;
        private object form1;

        public object GetForm1()
        {
            return form1;
        }

        private void SetForm1(object value)
        {
            form1 = value;
        }
    }
}

