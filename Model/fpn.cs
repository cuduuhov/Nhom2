using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteCuoiKyWF.Model;
using NoteCuoiKyWF.Controller;
using NHibernate.Event;

namespace NoteCuoiKyWF.Model
{
    public class fpn 
    {
        public NoteAppEntities1 db = new NoteAppEntities1();
        List<Note> x = new List<Note>();
        public FlowLayoutPanel h { get; set; }
        public Label lbTimeCreate { get; set; }
        public Label lbtimeLastSave { get; set; }
        public Label lbTitle { get; set; }
        public TextBox txtTitle { get; set; }
        public Label lbDescription { get; set; }
        public RichTextBox rtDescription { get; set; }
        public Label lbtag { get; set; }
        public TextBox txttag { get; set; }
        public Button btaddtag { get; set; }
        public Button btdelete { get; set; }
        public Label lbstt { get; set; }
        public DateTime timelastsave { get; set; }
        public DateTime timecreate { get; set; }

        #region các hàm tạo form flowlayoutpannel cho note 
        public void Taolbstt(Note t)
        {
            lbstt = new Label();
            lbstt.Width = 20;
            lbstt.Text = t.id.ToString();
        }

        public void Taolbcreatetime(Note t)
        {
            lbTimeCreate = new Label();
            lbTimeCreate.Text = "Time create    : " + t.createdatetime.ToString("MM/dd/yyyy HH:mm");
            lbTimeCreate.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            lbTimeCreate.Width = 400;
        }

        public void Taolbtimelastsave(Note t)
        {
           
            #region Label time last save
            lbtimeLastSave = new Label();
            lbtimeLastSave.Text = "Time last save : " + t.lasttimesave.ToString("MM/dd/yyyy HH:mm");
            lbtimeLastSave.Width = 350;
            lbtimeLastSave.Font = new Font("Times New Roman", 10, FontStyle.Regular);
          

            #endregion
        }

        public void Taotimelastsave(Note t)
        {
            timelastsave = DateTime.Now;
        }
        public void Taotimecreate(Note t)
        {
            timecreate = DateTime.Now;
        }
        public void Taotitle(Note t)
        {

            //Label Tiêu đề
            lbTitle = new Label();
            lbTitle.Text = "Title :";
            lbTitle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            lbTitle.Width = 50;
            lbTitle.Height = 20;
            // Textbox nhập tiêu đề
            txtTitle = new TextBox();
            txtTitle.Text = t.tieude;
            txtTitle.Width = 330;
            txtTitle.Font = new Font("Arial", 13, FontStyle.Bold);
            txtTitle.TextChanged += (o, ep) =>
            {
                int dem = 0;
                for (int i = 0; i < x.Count(); i++)
                {
                    if (x[i].id == (int.Parse(lbstt.Text)))
                    {
                        dem = i;
                        break;
                    }
                }
                x[dem].tieude = txtTitle.Text;
                x[dem].noidung = rtDescription.Text;
                x[dem].lasttimesave = DateTime.Now;
                lbtimeLastSave.Text = "Time last save : " + x[dem].lasttimesave.ToString("MM/dd/yyyy HH:mm");
                db.SaveChanges();
            };

        }

        public void Taodescription(Note t)
        {
            // Label nội dung
            lbDescription = new Label();
            lbDescription.Text = "Description :";
            lbDescription.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            lbDescription.Width = 400;
            lbDescription.Height = 20;
            // Richtextbox nhập nội dung
            rtDescription = new RichTextBox();
            rtDescription.Width = 395;
            rtDescription.Height = 250;
            rtDescription.Text = t.noidung;
            rtDescription.TextChanged += (o, ep) =>
            {
                int dem = 0;
                for (int i = 0; i < x.Count(); i++)
                {
                    if (x[i].id == (int.Parse(lbstt.Text)))
                    {
                        dem = i;
                        break;
                    }
                }
                x[dem].tieude = txtTitle.Text;
                x[dem].noidung = rtDescription.Text;
                x[dem].lasttimesave = DateTime.Now;
                lbtimeLastSave.Text = "Time last save : " + x[dem].lasttimesave.ToString("MM/dd/yyyy HH:mm");
                db.SaveChanges();
            };
        }

        public void TaoTag(Note t)
        {

            // Tag
            lbtag = new Label();
            lbtag.Text = "Tag";
            lbtag.Width = 30;
            lbtag.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txttag = new TextBox();
            txttag.Width = 270;
            btaddtag = new Button();
            btaddtag.Text = "Add tag";
            btaddtag.Width = 80;
            if (t.tag != null)
            {
                rtDescription.Text += "\n#" + t.tag.ToString();
            }
            // btaddtag.Height = 20;
            btaddtag.BackColor = Color.White;
            btaddtag.Click += (sender, args) =>
            {

                if (txttag.TextLength != 0)
                {
                    // add tag vào cuối 
                    rtDescription.Text += "\n#" + txttag.Text.Trim();
                    MessageBox.Show("Addtag Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txttag.Clear();
                    int dem = 0;
                    for (int i = 0; i < x.Count(); i++)
                    {
                        if (x[i].id == (int.Parse(lbstt.Text)))
                        {
                            dem = i;
                            break;
                        }
                    }
                    x[dem].tieude = txtTitle.Text;
                    x[dem].noidung = rtDescription.Text;
                    x[dem].lasttimesave = DateTime.Now;
                    lbtimeLastSave.Text = "Time last save : " + x[dem].lasttimesave.ToString("MM/dd/yyyy HH:mm");
                    db.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Addtag fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                t.tag += " " + txttag.Text;
                timelastsave = DateTime.Now;
                db.SaveChanges();
            };
        }
        public void TaoDelete(Note t)
        {
            #region Button delete 
            //Button delete  , thêm chức năng hỏi trc khi xóa
            btdelete = new Button();
            btdelete.Text = "Delete";
            btdelete.Width = 100;
            btdelete.Height = 30;
            btdelete.BackColor = Color.White;
            btdelete.Click += (sender, args) =>
            {
                /// chức năng xác nhận trc khi xóa 
                DialogResult dialogResult = MessageBox.Show("Sure", "Delete Note?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Delete Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // lấy vị trị trong list để xóa
                    int dem = 0;
                    for (int i = 0; i < x.Count(); i++)
                    {
                        if(x[i].id==(int.Parse(lbstt.Text)))
                        {
                            dem = i;
                            break;
                        }    
                    }
                    db.Notes.Remove(x[dem]);
                    x.Remove(x[dem]);
                    h.Dispose();
                    db.SaveChanges();
                    //h.Dispose();


                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Delete Fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            };
            #endregion
        }
        #endregion

        // hàm tạo flowlayoutpanel
        public FlowLayoutPanel fpnnote(Note t)
        {
            FlowLayoutPanel h = new FlowLayoutPanel();
            h.Width = 420;
            h.Height = 420;
            h.BackColor = Color.Khaki;
            Taotimelastsave(t);
            Taotimecreate(t);
            Taolbstt(t);
            Taolbcreatetime(t);
            Taotitle(t);
            TaoDelete(t);
            Taolbtimelastsave(t);
            Taodescription(t);
            TaoTag(t);
            #region Tạo fpn
            h.Controls.Add(lbTitle);
            h.Controls.Add(txtTitle);
            h.Controls.Add(lbDescription);
            h.Controls.Add(rtDescription);
            h.Controls.Add(lbtag);
            h.Controls.Add(txttag);
            h.Controls.Add(btaddtag);
            h.Controls.Add(btdelete);
            h.Controls.Add(lbTimeCreate);
            h.Controls.Add(lbtimeLastSave);
            h.Controls.Add(lbstt);
            x = db.Notes.SqlQuery("Select * from Note").ToList<Note>();
            #endregion
            return h;
        }

    }
}
