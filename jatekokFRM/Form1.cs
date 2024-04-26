using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatekokFRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenLoad();
            DGVLoad();
        }

        private void GenLoad()
        {
            db db = new db("SELECT name FROM genre");
            while (db.Dr.Read())
            {
                cb_genre.Items.Add(db.Dr[0]);
            }
        }

        private void DGVLoad()
        {
            DGV.Rows.Clear();
            if (cb_genre.SelectedIndex!=0)
            {
                db db = new db("SELECT game.*,genre.name FROM game, genre WHERE game.genreid = genre.id");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["id"], db.Dr["title"], db.Dr["gyear"], db.Dr["name"]);
                }
            }
            else
            {
                db db = new db($"SELECT game.*,genre.name FROM game, genre WHERE game.genreid = genre.id AND genre.name ='{cb_genre.SelectedItem.ToString()}'");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["id"], db.Dr["title"], db.Dr["gyear"], db.Dr["name"]);
                }
            }
        }
        private void DGVLoad(string title)
        {
            if (cb_genre.SelectedIndex != 0)
            {
                DGV.Rows.Clear();
                db db = new db($"SELECT game.*,genre.name FROM game, genre WHERE game.genreid = genre.id AND title LIKE '%{title}%'");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["id"], db.Dr["title"], db.Dr["gyear"], db.Dr["name"]);
                }
            }
            else
            {
                DGV.Rows.Clear();
                db db = new db($"SELECT game.*,genre.name FROM game, genre WHERE game.genreid = genre.id AND title LIKE '%{title}%' AND genre.name ='{cb_genre.SelectedItem.ToString()}'");
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["id"], db.Dr["title"], db.Dr["gyear"], db.Dr["name"]);
                }
            }
        }

        private void cb_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVLoad();
        }

        private void tb_title_TextChanged(object sender, EventArgs e)
        {
            if (tb_title.TextLength > 0)
            {
                DGVLoad(tb_title.Text);
            }
            else 
            {
                DGVLoad();
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            l_link.Text =$"http://www.google.com/search?q={DGV.Rows[e.RowIndex].Cells[1].Value.ToString().Replace(' ','+')}";
        }

        private void l_link_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_link.Text);
        }
    }
}
