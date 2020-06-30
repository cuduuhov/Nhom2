using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteCuoiKyWF.View;
using NoteCuoiKyWF.Model;
using System.Linq.Expressions;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace NoteCuoiKyWF.Controller
{
    class fpnController
    {
        public fpn z = new fpn();
        List<Note> t = new List<Note>();
        NoteAppEntities1 db = new NoteAppEntities1();
        // GET: fpn note new, id note = stt fpn trong fpnbutton
        public fpn Getfpn(int x)
        {
            Note t = new Note();
            fpn a = new fpn();
            t.id = x;
            t.tieude =null;
            t.noidung =null;
            t.lasttimesave = DateTime.Now;
            t.createdatetime = DateTime.Now;
            a.h = a.fpnnote(t);
            return a;
        }
        public Note Getnote(fpn a)
        {
            Note t = new Note();
            t.id = int.Parse(a.lbstt.Text);
            t.tieude = a.txtTitle.Text;
            t.noidung = a.rtDescription.Text;
            t.tag = null;
            t.createdatetime = DateTime.ParseExact(a.lbTimeCreate.Text.Substring(17), "MM/dd/yyyy HH:mm", null);
            t.lasttimesave = DateTime.ParseExact(a.lbtimeLastSave.Text.Substring(17), "MM/dd/yyyy HH:mm", null);
            return t;
        }
        }
    }

