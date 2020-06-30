using NoteCuoiKyWF.Controller;
using NoteCuoiKyWF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCuoiKyWF.View
{
    public partial class Form1 : Form
    {
        public NoteAppEntities1 db = new NoteAppEntities1();
        List<Note> t = new List<Note>();
        fpnController x = new fpnController();
        private int save { get; set; }
        public int sonote { get; set; }
        public Form1()
        {
            InitializeComponent();
            Sonote();
            ShowNote();
        }

        // chức năng search
        private void btSeacrh_Click(object sender, EventArgs e)
        {
            // get data
            using (var ctx = new NoteAppEntities1())
            {
                t = ctx.Notes
                    .SqlQuery("Select * from Note")
                    .ToList<Note>();
            }
           
            if (cbSearch.SelectedItem == null)
            {
                MessageBox.Show("Select Information For Combobox", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbSearch.SelectedItem.ToString() == "ID")
                {
                    int j = t.Count;
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Please enter something in the search box", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        j = 0;
                    }
                    else
                    {
                        for (int i = 0; i < sonote; i++)
                        {
                            if (t[i].id.ToString() == txtSearch.Text.Trim())
                            {
                                fpnButton.Controls.Clear();
                                fpn x = new fpn();
                                fpnButton.Controls.Add(x.fpnnote(t[i]));
                                j = 0;
                                break;
                            }
                        }
                    }
                    txtSearch.Clear();
                    if (j == t.Count)
                    {
                        MessageBox.Show("Not found", "Notification", MessageBoxButtons.OK);
                        txtSearch.Clear();
                        ShowNote();
                    }
                }

                if (cbSearch.SelectedItem.ToString()=="TITLE")
                {
                    
                    int j = t.Count;
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Please enter something in the search box", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        j = 0;
                    }
                    else
                        for (int i = 0; i < t.Count(); i++)
                    {
                        if (txtSearch.Text== t[i].tieude)
                        {
                            if (j == t.Count)
                            {
                                fpnButton.Controls.Clear();
                            }
                            fpn x = new fpn();
                            fpnButton.Controls.Add(x.fpnnote(t[i]));
                            j = 0;
                        }

                    }
                    txtSearch.Clear();
                    if (j==t.Count)
                    {
                        MessageBox.Show("Not found", "Notification", MessageBoxButtons.OK);
                        txtSearch.Clear();
                        ShowNote();
                    }    

                }
                
                if (cbSearch.SelectedItem.ToString().Trim() == "TAG")
                {
                    int j = t.Count;
                    string r = "#" + txtSearch.Text.Trim();
                    if (txtSearch.Text == "")
                    {
                        MessageBox.Show("Please enter something in the search box", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        j = 0;
                    }
                    else
                    for (int i = 0; i < t.Count(); i++)
                    {
                       
                        if (t[i].noidung.Contains(r))
                        {
                            
                            if (j == t.Count)
                            {
                                fpnButton.Controls.Clear();
                            }
                            fpn x = new fpn();
                            fpnButton.Controls.Add(x.fpnnote(t[i]));
                            j = 0;
                        }


                    }
                    txtSearch.Clear();
                    if (j == t.Count)
                    {
                        MessageBox.Show("Not found", "Notification", MessageBoxButtons.OK);
                        txtSearch.Clear();
                        ShowNote();
                    }
                }
                if (cbSearch.SelectedItem.ToString().Trim() == "DESCRIPTION")
                {
                    int j = t.Count;
                    string r =txtSearch.Text.Trim();
                    if (txtSearch.Text =="")
                    {
                        MessageBox.Show("Please enter something in the search box", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        j = 0;
                    }  
                    else
                    for (int i = 0; i < t.Count(); i++)
                    {

                        if (t[i].noidung.Contains(r))
                        {

                            if (j == t.Count)
                            {
                                fpnButton.Controls.Clear();
                            }
                            fpn x = new fpn();
                            fpnButton.Controls.Add(x.fpnnote(t[i]));
                            j = 0;
                        }


                    }
                    if (j == t.Count)
                    {
                        MessageBox.Show("Not found", "Notification", MessageBoxButtons.OK);
                        txtSearch.Clear();
                        ShowNote();
                    }
                }


            }
        }

        // Add note mới 
        public void addNote_Click(object sender, EventArgs e)
        {
            Sonote(); // đếm số note hiện có
            ShowNote();

            // tạo id không trùng với những id đã có , 
            int g = 1;
            for (int i = 0; i < sonote; i++)
            {
                if (g != t[i].id)
                {
                    break;
                }
                else
                    g++;
            }
            
            fpn p = new fpn();
            Note z = new Note();
            p = x.Getfpn(g); // tạo flowlayoutpannel id = g , viết tắt flowlayoutpannel viết tắt = fpn
            fpnButton.Controls.Add(p.h); // add fpn vừa tạo vào form chính
            z = x.Getnote(p); // tạo note theo fpn 
            t.Add(z);
            db.Notes.Add(z); // add note mới vào bảng
            db.SaveChanges(); // lưu thay đổi
            //ShowNote();
            
            p.txtTitle.Focus(); // đưa con trỏ chuột đến vị textbox title của fpn vừa tạo

        }
        // đếm số note có trong table
        public void Sonote()
        {
            sonote = (from Note in db.Notes
                      select Note.id).Count();
        }

        // button Note of you
        private void btShowNote_Click(object sender, EventArgs e)
        {
            fpnButton.Controls.Clear();
            ShowNote(); // gọi hàm get dữ liệu từ data lên
        }

        // hàm tạo fpn của tất cả các note đc tạo
        public void ShowNote()
        {
            fpnButton.Controls.Clear(); //
            using (var ctx = new NoteAppEntities1()) 
            {
                t = ctx.Notes
                    .SqlQuery("Select * from Note")
                    .ToList<Note>();
            }
            foreach (var item in t)
            {

                fpn z = new fpn();
                z.h = z.fpnnote(item);
                fpnButton.Controls.Add(z.h);
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void fpnButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
