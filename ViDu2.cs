using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class lblThongBao : Form
    {
        public lblThongBao()
        {
            InitializeComponent();
        }

        private void ViDu2_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklbLienHe.Links.Add(0,lienhe.Length,lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];

        }


        public class GiaoVien
        {
            public string MaSo { get; set; }
            public string HoTen { get; set; }
            public DateTime NgaySinh;
            public DanhMucMonHoc dsMonHoc;
            public string GioiTinh;
            public string[] NgoaiNgu;
            public string SoDT;
            public string Mail;
            public GiaoVien() {

                dsMonHoc = new DanhMucMonHoc();
                NgoaiNgu = new string[10];
                
            }
            public GiaoVien(string maso, string hoTen,DateTime ngaysinh , DanhMucMonHoc ds,     string gt, string[]nn,
                string sdt, string mail)
            {
                this.MaSo = maso;
                this.HoTen = hoTen;
                this.NgaySinh = ngaysinh;
                this.dsMonHoc = ds;
                this.GioiTinh = gt;
                this.SoDT = sdt;
                this.Mail = mail;
                this.NgoaiNgu= nn;
            }
            public override string ToString()
            {
                string s = "Ma so:" + MaSo +"\n"+ "Ho Ten:"+HoTen+"\n"+"Ngay Sinh:"+NgaySinh.ToString   ()   +"\n"+"Gioi Tinh:"
                    +GioiTinh+"\n"+"So DT:" + SoDT+"\n"+"Mail:"+Mail+"\n";
                string sngoaingu = "Ngoai ngu:";
                foreach (string t in NgoaiNgu)
                
                    sngoaingu += t + ";";
                    string Monday = "Danh sach mon day: ";
                    foreach (MonHoc mh in dsMonHoc.ds)
                   
                        Monday += mh + ";";

                    s += "\n" + sngoaingu + "\n" + Monday;
                    return s;
                
                }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i>=0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReSet();
        }
        public void ReSet()
        {
            this.cboMaSo.Text ="";
            this.txtHoTen.Text = "";
            this.txtMail.Text = string.Empty;
            this.mtxtSoDT.Text = string.Empty;
            this.rdNam.Checked = true;
            for (int i = 0; i < chklbNgoaiNgu.Items.Count -1; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i,false);
            }
            foreach (object ob  in this.lbMonHocDay.Items)
            {
                this.lbMonHocDay.Items.Clear();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            /*rmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();*/
        }
      /*  public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nu";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen= this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail=this.txtMail.Text;
            gv.SoDT= this.mtxtSoDT.Text;
            //
        }*/

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s= e.Link.LinkData.ToString();
            Process.Start(s);
        }
    }
    public class MonHoc
        {
            public int Id { get; set; }
            public string TenMH { get; set; }
            public string SoTC { get; set; }
            public MonHoc() { }
            public MonHoc(string ten)
            {
                this.TenMH = ten;

            }
            public MonHoc(int id, string ten, string tc)
            {
                this.Id = id;
                this.TenMH = ten;
                this.SoTC = tc;
            }
            public override string ToString()
            {
                return TenMH;
            }
        }
        public class DanhMucMonHoc
        {
            public ArrayList ds;
            public DanhMucMonHoc()
            {
                ds = new ArrayList();
            }
            public MonHoc this[int index]
            {
                get {return ds[index] as MonHoc;}   
            set { ds[index] = value;}
            

            }
            public void Them(MonHoc mh)
            {
                ds.Add(mh);

            }
            public override string ToString()
            {
                string s = "Danh sach mon hoc:";
                foreach (object mh in ds)
                {
                    s += mh as MonHoc + ";";

                }return s;  
            }

        }
    }

