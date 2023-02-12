using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Media;

namespace cafe
{
    
    public partial class Form2 : Form
    {
        private FilterInfoCollection camera;
        private VideoCaptureDevice cam;
        public Form2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cam = new VideoCaptureDevice();
        }


        clalog cla = new clalog();
        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string checktable(string name)
        {
            string check = "";
            DataTable dt = cla.readdata("SELECT * From Ban WHERE Ten_ban = N'" + name + "' ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    check = dr["Trang_thai"].ToString();
                }
            }
            else if (dt == null)
            {
                check = "";
            }
            return check;
        }
        private void checkt(Button bt)
        {
            string check = checktable(bt.Text);
            if(check=="free")
            {
                bt.ForeColor = CLfree.BackColor;
            }    
            else if(check == "busy")
            {
                bt.ForeColor = CLbusy.BackColor;
            }    
            else if(check == "oder")
            {
                bt.ForeColor = CLoder.BackColor;
            }    
        }
        public void Createtable()
        {
            khung_Ban.Controls.Clear();
            int x = 3;
            int y = 3;
            DataTable dt = cla.readdata("SELECT * FROM Ban ");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    Button bt = new Button();
                    bt.Name = string.Format(dr["Ten_ban"].ToString());
                    bt.Text = string.Format(dr["Ten_ban"].ToString());
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.Image = cafe.Properties.Resources.tải_xuống__1_;
                    bt.Width = 80;
                    bt.Height = 80;
                    bt.Location = new Point(x, y);
                    x = x + 85;
                    string check = checktable(bt.Text);
                    if (check == "free")
                    {
                        bt.ForeColor = CLfree.BackColor;
                    }
                    else if (check == "busy")
                    {
                        bt.ForeColor = CLbusy.BackColor;
                    }
                    else if (check == "oder")
                    {
                        bt.ForeColor = CLoder.BackColor;
                    }
                    else if (check == "")
                        bt.ForeColor = CLfree.BackColor;
                    bt.Click += Bt_Click;
                    khung_Ban.Controls.Add(bt);
                }    
            }    
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            kt_Ban = bt;
            lbTenban.Text = kt_Ban.Text;
            khung_menu.Visible = true;
            if (bt.ForeColor == CLfree.BackColor)
            {
                lbTrangthai.Text = lbCLfree.Text;
                cmdDatban.Text = "Đặt bàn";
                cmdGoimon.Text = "Gọi món";
                khung_buttonNEW.Enabled = true;
                khung_buttonOLD.Enabled = false;
                khung_menu.Controls.Clear();
                lbTongtien.Text = "0";
            }    
            else if (bt.ForeColor == CLbusy.BackColor)
            {
                lbTrangthai.Text = lbCLbusy.Text;
                khung_buttonNEW.Enabled = false;
                khung_buttonOLD.Enabled = true;
                khung_menu.Enabled = true;
                IDhoadon = getIDhoadon(Convert.ToInt32(getIDt(kt_Ban.Text)));
                Createmenu(Convert.ToInt32(getIDhoadon(Convert.ToInt32(getIDt(kt_Ban.Text)))));
                lbTongtien.Text = getThanhtien(IDhoadon).ToString("#,##0");
            }    
            else if (bt.ForeColor == CLoder.BackColor)
            {
                lbTrangthai.Text = lbCLoder.Text;
                khung_buttonNEW.Enabled = true;
                khung_buttonOLD.Enabled = false;
                cmdGoimon.Text = "Gọi món";
                cmdDatban.Text = "Hủy đặt bàn";
                khung_menu.Controls.Clear();
                lbTongtien.Text = "0";
            }    

        }
        private void Createloaimon()
        {
            int x = 3;
            int y = 3;
            DataTable dt = cla.readdata("SELECT * From Loai_mon");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    Button bt = new Button();
                    bt.Text = string.Format(dr["Loai_mon"].ToString());
                    bt.Width = 121;
                    bt.Height = 52;
                    bt.Location = new Point(x, y);
                    y = y + 58;
                    bt.Click += Bt_Click1;
                    khung_loaimon.Controls.Add(bt);
                }    
            }    
        }
        
        private void Bt_Click1(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            Createmon(bt.Text);
        }
        private string getID(string name)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * From Loai_mon WHERE Loai_mon = N'"+ name +"' ");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    ID = dr["IDloaimon"].ToString();
                }    
            }
            return ID;    
        }
        private string getIDt(string name)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * From Ban WHERE Ten_ban = N'" + name + "' ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ID = dr["IDban"].ToString();
                }
            }
            return ID;
        }
        private string getIDhoadon(int IDban)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * From Hoa_don WHERE IDban = " + IDban +" AND trang_thai ='NO' ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ID = dr["IDhoadon"].ToString();
                }
            }
            return ID;
        }
        private string gettenmon(string IDban)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * From Mon WHERE IDmon = N'" + IDban + "' ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ID = dr["Ten_mon"].ToString();
                }
            }
            return ID;
        }
        private void Createmon(string name)
        {
            khung_monan.Controls.Clear();
            int x = 3;
            int y = 32;
            string id = getID(name);
            DataTable dt = cla.readdata("SELECT * From Mon WHERE IDloaimon = N'" + id + "' ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Button bt = new Button();
                    bt.Text = string.Format(dr["Ten_mon"].ToString());
                    bt.Tag = string.Format(dr["IDmon"].ToString());
                    bt.Width = 100;
                    bt.Height = 30;
                    bt.Location = new Point(x, y);
                    y = y + 36;
                    bt.Click += Bt_Click2;
                    khung_monan.Controls.Add(bt);
                }
            }
        }

        public static Button kt_mon = new Button();
        private void Createmenu(int IDhoadon)
        {
            khung_menu.Controls.Clear();
            DataTable dt = cla.readdata("SELECT * FROM Thuc_don WHERE IDhoadon = "+IDhoadon+" ");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    Panel gb = new Panel();
                    gb.Width = 298;
                    gb.Height = 53;
                    gb.Tag = dr["IDThucdon"].ToString();
                    gb.BorderStyle = BorderStyle.Fixed3D;
                    Label lb_tenmon = new Label();
                    lb_tenmon.AutoSize = true;
                    lb_tenmon.Text = gettenmon(dr["IDmon"].ToString()) ;
                    lb_tenmon.Font = new Font("Microsoft Sans Serif", 12);
                    lb_tenmon.Location = new Point(1, 13);
                    gb.Controls.Add(lb_tenmon);
                    Label lb_soluong = new Label();
                    lb_soluong.AutoSize = true;
                    lb_soluong.Text = dr["So_luong"].ToString() ;
                    lb_soluong.Font = new Font("Microsoft Sans Serif", 12);
                    lb_soluong.Location = new Point(129, 16);
                    gb.Controls.Add(lb_soluong);
                    Button bt = new Button();
                    bt.Width = 41;
                    bt.Height = 23;
                    bt.Text = "Xóa";
                    bt.Location = new Point(212, 16);
                    bt.Click += Bt_Click3;
                    gb.Controls.Add(bt);
                    gb.Click += Gb_Click;
                    khung_menu.Controls.Add(gb);
                }    
            }    
            
        }
        private static Panel pt_menu;
        private void Gb_Click(object sender, EventArgs e)
        {
            Panel pn = sender as Panel;
            pn.Enabled = true;
            pt_menu = pn;    
        }

        private void Bt_Click3(object sender, EventArgs e)
        {
            deletemenu(pt_menu.Tag.ToString());
            lbTongtien.Text = getThanhtien(IDhoadon).ToString("#,##0");
            khung_menu.Controls.Remove(pt_menu); 
        }
        private string search(int IDmon, string IDhoadon)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * FROM Thuc_don WHERE IDmon = " + IDmon + " AND IDhoadon ='"+IDhoadon+"' ");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    ID = dr["IDthucdon"].ToString();
                }    
            }
            return ID;   
        }
        private string searchtt(int IDmon)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * FROM Thuc_don WHERE IDmon = " + IDmon + " ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ID = dr["thanh_tien"].ToString();

                }
            }
            return ID;
        }
        private string searchsl(int IDmon)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * FROM Thuc_don WHERE IDmon = " + IDmon + " ");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ID = dr["So_luong"].ToString();
                }
            }
            return ID;
        }
        private void addmenu(int IDmon, int so_luong, int IDhoadon, int thanhtien)
        {
           Boolean check = cla.exedata("INSERT INTO Thuc_don (IDmon,So_luong,IDhoadon,thanh_tien) VALUES (" + IDmon + ", " + so_luong + ", " + IDhoadon + "," + thanhtien + " )");
        }
        private void updatemenu(int IDmon,int so_luong,int IDhoadon,int thanhtien)
        {
            Boolean check = cla.exedata("UPDATE Thuc_don SET So_luong = " + so_luong + ", thanh_tien = " + thanhtien + " WHERE IDmon = " + IDmon + " AND IDhoadon = " + IDhoadon + " ");
        }
        private void deletemenu(string IDthucdon)
        {
             cla.exedata("DELETE FROM Thuc_don WHERE IDthucdon = '"+ IDthucdon +"' ");   
        }
        private int getThanhtien(string IDhoadon)
        {
            int num = 0;
            DataTable dt = cla.readdata("SELECT * FROM Thuc_don WHERE IDhoadon = " + IDhoadon + " ");
            if(dt != null)
            {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        num = num + Convert.ToInt32(dt.Rows[i]["thanh_tien"]);
                    }
            }
            return num;
        }
        private void Bt_Click2(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            kt_mon = bt;
            lbTongtien.Text = "0";
            Form3 f = new Form3();
            f.ShowDialog();
            if(search(Convert.ToInt32(kt_mon.Tag),IDhoadon)=="")
            {
                addmenu(Convert.ToInt32(kt_mon.Tag), Convert.ToInt32(Form3.soluong),Convert.ToInt32(getIDhoadon(Convert.ToInt32(getIDt(kt_Ban.Text)))),Form3.thanhtien);
            }
            else if(search(Convert.ToInt32(kt_mon.Tag),IDhoadon) != "")
            {
                int soluongdt = Convert.ToInt32(searchsl(Convert.ToInt32(kt_mon.Tag))) + Convert.ToInt32(Form3.soluong);
                int thanhtiendt = Convert.ToInt32(searchtt(Convert.ToInt32(kt_mon.Tag))) + Form3.thanhtien;
                updatemenu(Convert.ToInt32(kt_mon.Tag), soluongdt, Convert.ToInt32(getIDhoadon(Convert.ToInt32(getIDt(kt_Ban.Text)))), thanhtiendt);
            }
            Createmenu(Convert.ToInt32(getIDhoadon(Convert.ToInt32(getIDt(kt_Ban.Text)))));
            lbTongtien.Text = getThanhtien(IDhoadon).ToString("#,##0");
            khung_buttonOLD.Enabled = true;

        }
        private void viewhd()
        {
            DataTable dt = cla.readdata("SELECT h.IDhoadon, b.Ten_ban,h.Giamgia,h.Tong_tien,h.Hinh_thuctt,h.trang_thai FROM Ban b, Hoa_don h where b.IDban = h.IDban ");
            if(dt!=null)
            {
                int num = 0;
                dataHoadon.DataSource = dt;
                foreach(DataRow dr in dt.Rows)
                {
                    num = num + Convert.ToInt32(dr["Tong_tien"]);
                }
                LBtongdoanhso.Text = num.ToString("#,##0");
            }    
        }
        void time()
        {
            while (true)
            {
                LBtime.Text = DateTime.Now.ToString("HH:mm:ss");
                LBday.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }
        private void checkquyen(string lv)
        {
            tabControl1.Controls.Remove(tabQuanLy);
            if(lv=="admin")
            {
                tabControl1.TabPages.Insert(1, tabQuanLy);
            }    
        }
        private SoundPlayer sp;
        private void Form2_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(time);
            th.IsBackground = true;
            th.Start();
            if (Form1.linkimage != "")
            {
                Image i = Image.FromFile(Form1.linkimage);
                picBOX.Image = picBOX1.Image = i;

            }
            splitContainer3.Panel1.Controls.Add(lbTenban);
            splitContainer3.Panel1.Controls.Add(picBOX);
            Createtable();
            Createloaimon();
            khung_buttonNEW.Enabled = false;
            khung_buttonOLD.Enabled = false;
            khung_menu.Visible = false;
            checkquyen(Form1.lv);
            sp = new SoundPlayer("pip.wav");
        }

        private void cmdThemban_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private static string n = "NO";
        private void goimon()
        {
           Boolean check = cla.exedata("INSERT INTO Hoa_don ( IDban , trang_thai ) VALUES (" + Convert.ToInt32(getIDt(kt_Ban.Text)) + ",N'"+ n +"' )");
        }
        public static string IDhoadon = "";
        private void cmdGoimon_Click(object sender, EventArgs e)
        {
            if (cmdGoimon.Text == "Gọi món")
            {
                goimon();
                IDhoadon = getIDhoadon(Convert.ToInt32(getIDt(kt_Ban.Text)));
                khung_loaimon.Enabled = true;
                cmdGoimon.Text = "Hủy";
            }
            else if (cmdGoimon.Text == "Hủy")
            {
                cla.exedata("DELETE FROM Hoa_don WHERE IDhoadon = '" + IDhoadon + "' ");
                khung_loaimon.Enabled = false;
                khung_menu.Enabled = false;
                khung_menu.Controls.Clear();
                cmdGoimon.Text = "Gọi món";
            }    
        }

        private Button kt_Ban = new Button();
        private void cmdDatban_Click(object sender, EventArgs e)
        {
            if (cmdDatban.Text == "Đặt bàn")
            {
                Boolean check = cla.exedata("UPDATE Ban SET Trang_thai = 'oder' WHERE Ten_ban = N'" + kt_Ban.Text + "' ");
                if (check)
                {
                    MessageBox.Show("Đặt bàn thành công", "Thông báo", MessageBoxButtons.OK);
                    checkt(kt_Ban);
                    cmdDatban.Text = "Hủy đặt bàn";
                }
                else
                {
                    MessageBox.Show("Đặt bàn không thành công");
                }
            }
            else if (cmdDatban.Text == "Hủy đặt bàn")
            {
                Boolean check = cla.exedata("UPDATE Ban SET Trang_thai = 'free' WHERE Ten_ban = N'" + kt_Ban.Text + "' ");
                if (check)
                {
                    MessageBox.Show("Hủy đặt bàn thành công", "Thông báo", MessageBoxButtons.OK);
                    checkt(kt_Ban);
                    cmdDatban.Text = "Đặt bàn";
                }
                else
                {
                    MessageBox.Show("Hủy đặt bàn không thành công");
                }
            }    
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
            
        }

        private void khung_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void khung_menu_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void khung_menu_ControlRemoved(object sender, ControlEventArgs e)
        {
        }

        private void cmdHoanthanh_Click(object sender, EventArgs e)
        {
            cla.exedata("UPDATE Ban SET Trang_thai = 'busy' WHERE Ten_ban = N'" + kt_Ban.Text + "' ");
            cla.exedata("UPDATE Hoa_don SET Tong_tien = " + getThanhtien(IDhoadon) + " WHERE IDhoadon = " + IDhoadon + "");
            checkt(kt_Ban);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdThanhtoan_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            cla.exedata("UPDATE Ban SET Trang_thai = 'free' WHERE Ten_ban = N'" + kt_Ban.Text + "' ");
            checkt(kt_Ban);
        }
        private int getIDtT()
        {
            int ID = 0;
            DataTable dt = cla.readdata("SELECT TOP(1) IDban FROM Ban ORDER BY IDban DESC");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    ID = Convert.ToInt32(dr["IDban"]);
                }    
            }
            return ID;
        }
        private void cmdThemban_Click_1(object sender, EventArgs e)
        {
            int ID = getIDtT()-6;
            string tenban = string.Format("Bàn {0}", ID);
            Boolean check = cla.exedata("INSERT INTO Ban (Ten_ban,Trang_thai) VALUES (N'"+ tenban +"','free') ");
            if (check)
            {
                Createtable();
            }
            else
                MessageBox.Show("Lỗi Tạo thêm");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //TAB Quản lý 
        private void viewct(string IDhoadon)
        {
            DataTable dt = cla.readdata("SELECT Ten_mon , Don_gia , So_luong , thanh_tien FROM Mon m, Thuc_don td Where m.IDmon = td.IDmon and td.IDhoadon = '" + IDhoadon + "' ");
            if(dt!=null)
            {
                dataThucdon.DataSource = dt;
            }    
        }
        private void dataHoadon_Click(object sender, EventArgs e)
        {
            int index;
            string ID;
            index = dataHoadon.CurrentCell.RowIndex;
            ID = dataHoadon.Rows[index].Cells["IDhoadon"].Value.ToString();
            viewct(ID);
        }
        private int getThongke(string IDmon)
        {
            int num = 0;
            DataTable dt = cla.readdata("SELECT * FROM Thuc_don WHERE IDmon = '" + IDmon + "'");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    num = num + Convert.ToInt32(dr["So_luong"]);
                }    
            }
            return num;
        }
        private void thongke()
        {
            DataTable dt = cla.readdata("SELECT * FROM Mon ");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    string ID = dr["IDmon"].ToString();
                    int num =  getThongke(ID);
                    cla.exedata("UPDATE Mon SET Sldaban = " + num + " Where IDmon = '" + ID + "' ");
                }    
            }

            DataTable dt1 = cla.readdata("SELECT Ten_mon , Don_gia, Sldaban FROM Mon");
            if(dt1!=null)
            {
                dataThongke.DataSource = dt1;
                foreach(DataRow dr in dt1.Rows)
                {
                    bangbieu.Series["bangbieu"].Points.AddXY(string.Format(dr["Ten_mon"].ToString()),Convert.ToInt32(dr["Sldaban"]));
                }    
            }    
        }


        //TAB Nhân viên
        private void cmdStart_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(camera[0].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            if(cam!=null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam.Start();
            cmdCheckin.Enabled = true;
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            khung_camera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning == true)
            {
                cam.Stop();

                khung_camera.Image = null;
                if (Form1.linkimage != "")
                {
                    Image i = Image.FromFile(Form1.linkimage);
                    khung_camera.Image = i;

                }

            }
            cmdCheckin.Enabled = false;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();

            }
        }
        private int getIDnvT()
        {
            int ID = 0;
            DataTable dt = cla.readdata("SELECT TOP(1) IDtt FROM Nhanvien ORDER BY IDtt DESC");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ID = Convert.ToInt32(dr["IDtt"]);
                }
            }
            return ID;
        }
        private void addCheckin(string IDuser,int day,int month,int year,string Time,string filename)
        {
            Boolean check = cla.exedata("INSERT INTO Nhanvien (id_user,Day,Month,Year,Time,Image_checkin) VALUES ('" + IDuser + "'," + day + "," + month + "," + year + ",N'" + Time + "',N'" + filename + "') ");
            if(check)
            {
                timer1.Start();
                LBthongbao.Text = "CHECK IN Thành công";
                LBthongbao.ForeColor = Color.Green;
                sp.Play();

            }    
            else
            {
                timer2.Start();
                LBthongbao.Text = "CHECK IN KHÔNG Thành công";
                LBthongbao.ForeColor = Color.Red;
                
            }    
        }
        private void cmdCheckin_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\code.Net\cafe\cafe\bin\Debug";
            saveFileDialog1.FileName = string.Format(@"D:\code.Net\cafe\cafe\bin\Debug\{0}+{1}.jpg", Form1.Id_user,getIDnvT());
            khung_camera.Image.Save(saveFileDialog1.FileName);
            string time = string.Format("{2}:{1}:{0}",DateTime.Now.Second , DateTime.Now.Minute, DateTime.Now.Hour);
            addCheckin(Form1.Id_user, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, time, saveFileDialog1.FileName);
            showbangchamcong(Form1.Id_user);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBthongbao.Text = "";
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LBthongbao.Text = "";
            timer2.Stop();
        }
        private void showbangchamcong(string ID)
        {
            DateTime[] dt = new DateTime[1000];
            DataTable data = cla.readdata("SELECT * FROM Nhanvien WHERE id_user =N'" + ID + "'");
            if(data!=null)
            {
                int i = 0;
                foreach(DataRow dr in data.Rows)
                {
                    dt[i] = new DateTime(Convert.ToInt32(dr["Year"]), Convert.ToInt32(dr["Month"]), Convert.ToInt32(dr["Day"]));
                    i++;
                }    
            }
            bangchamcong.BoldedDates = dt;
            quanlyChamCong.BoldedDates = dt;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private DataTable quanlyNV()
        {
            DataTable dt = cla.readdata("SELECT Name,Numberphone FROM userandpass WHERE lv ='user' ");
            return dt;
        }
        private DataTable lichlv(string ID)
        {
            DataTable dt = cla.readdata("SELECT u.Name,n.Day,n.Month,n.Year,n.Time,n.Image_checkin FROM userandpass u, Nhanvien n Where u.id_user = n.id_user and u.id_user = '" + ID + "' ");
            return dt;
        }
        private void tabDoanhso_Click(object sender, EventArgs e)
        {
            viewhd();
            thongke();
            dataNhanvien.DataSource = quanlyNV();
        }

        private string getIDuser(string name)
        {

            string id = "";
            DataTable da = cla.readdata("SELECT * FROM userandpass WHERE Name =N'"+ name +"' ");
            if (da != null)
            {
                foreach (DataRow dr in da.Rows)
                {
                    id = dr["id_user"].ToString();
                }
            }
            else
            {
                id = null;
            }
            return id;
        }
        private void dataNhanvien_Click(object sender, EventArgs e)
        {
            
            int index = dataNhanvien.CurrentCell.RowIndex;
            string name = dataNhanvien.Rows[index].Cells["Name"].Value.ToString();
            dataCheckin.DataSource = lichlv( getIDuser(name));
            showbangchamcong(getIDuser(name));
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabNhanvien_Click(object sender, EventArgs e)
        {
            showbangchamcong(Form1.Id_user);
        }
        private bool ischanged;
        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            if(!ischanged)
            {
                ischanged = true;
            }    
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            if (!ischanged)
            {
                ischanged = true;
            }
        }

        private void txtNhaplaimk_TextChanged(object sender, EventArgs e)
        {
            if (!ischanged)
            {
                ischanged = true;
            }
            if(txtNhaplaimk.Text == txtMatkhau.Text )
            {
                lbnhacnho.Text = "Nhập đúng";
                cmdTaotk.Enabled = true;
            }   
            else if(txtMatkhau.Text == "" && txtNhaplaimk.Text=="")
            {
                lbnhacnho.Text = "Cần nhập mật khẩu";
            }    
            else if(txtMatkhau.Text !="" && txtNhaplaimk.Text =="" )
            {
                lbnhacnho.Text = "Chưa nhập mật khẩu xác nhận";
            }    
            else
            {
                lbnhacnho.Text = "Nhập sai";
            }    
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (!ischanged)
            {
                ischanged = true;
            }
        }
        private int checktentk(string name)
        {
            string ID = "";
            DataTable dt = cla.readdata("SELECT * From userandpass WHERE username = '"+ name +"' ");
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    ID = dr["id_user"].ToString();
                }    
            }    
            
            if(ID!="")
            {
                return 1;
            }    
            else
            {
                return 2;
            }    
            
        }
        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {
            if(checktentk(txtTaikhoan.Text)==1)
            {
                lbchecktk.Text = "Tài khoản đã tồn tại";
                cmdTaotk.Visible = false;
            }    
            else if(checktentk(txtTaikhoan.Text)==2)
            {
                lbchecktk.Text = "";
                cmdTaotk.Visible = true;
            }    
            else if(txtTaikhoan.Text=="")
            {
                lbchecktk.Text = "";
                cmdTaotk.Visible = true;
            }    
        }

        private void cmdTaotk_Click(object sender, EventArgs e)
        {
            Boolean check = cla.exedata("INSERT INTO userandpass (username,password,Numberphone,Name,lv) VALUES (N'" + txtTaikhoan.Text + "','" + txtMatkhau.Text + "','" + txtSdt.Text + "',N'"+ txtTen.Text + "','user')");
            if (check == true)
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản không thành công");
            }
        }

        private void chkHienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienmk.Checked)
            {
                txtMatkhau.PasswordChar = '\0';
                txtNhaplaimk.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
                txtNhaplaimk.PasswordChar = '*';
            }
        }

        private void cmdHuy_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = txtMatkhau.Text = txtNhaplaimk.Text = txtTen.Text = txtSdt.Text = "";
        }

        private void dataCheckin_Click(object sender, EventArgs e)
        {
            int index = dataCheckin.CurrentCell.RowIndex;
            string path = dataCheckin.Rows[index].Cells["Image_checkin"].Value.ToString();
            Image i = Image.FromFile(path);
            picAnhCheck.Image = i;

        }

        private void dataHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void khung_Ban_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
