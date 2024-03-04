using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MongoDB_Repository.DomenskiEntiteti;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace MongoDB_Repository
{
    public partial class PolicijaUpravljajServisima : Form
    {
        public PolicijaUpravljajServisima()
        {
            InitializeComponent();
        }

        private void PolicijaUpravljajServisima_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            panel1.Visible = false;
            textBox1.Visible = false;
        }

        private void btnDodajServis_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            // db.CreateCollection("servisi");

            var collection = db.GetCollection<Servis>("servisi");

            String tip = "";
            Servis s1;
            if (rdbZaAutomobile.Checked)
            {
                tip = "kola";
                if (tbxUpravljajServisimaNaziv.Text != "")
                {
                    s1 = new Servis(tbxUpravljajServisimaNaziv.Text, tip, new List<string> { "motor", "kocnice", "volan" });
                    if (collection.Insert(s1).Ok)
                    {
                        MessageBox.Show("Uspesno dodavanje!");
                        String id = s1.Id.ToString();
                        //MessageBox.Show(id);
                        //tbxUpravljajServisimaNaziv.Text = "";
                        label3.Text = "ID dodatog servisa je:";
                        label3.Visible = true;
                        textBox1.Text = id;
                        textBox1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Neuspesno dodavanje!");
                    }

                }
                else
                    MessageBox.Show("Morate uneti naziv servisa!");
            }
            else
            {
                tip = "brod";
                if (tbxUpravljajServisimaNaziv.Text != "")
                {
                    s1 = new Servis(tbxUpravljajServisimaNaziv.Text, tip, new List<string> { "motor", "kormilo", "navigacija" });
                    if (collection.Insert(s1).Ok)
                    {
                        MessageBox.Show("Uspesno dodavanje!");
                        String id = s1.Id.ToString();
                        //MessageBox.Show(id);
                        //tbxUpravljajServisimaNaziv.Text = "";
                        label1.Text = "Id dodatog servisa je:";
                        label1.Visible = true;
                        textBox1.Text = id;
                        textBox1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Neuspesno dodavanje!");
                    }

                }
                else
                    MessageBox.Show("Morate uneti naziv servisa!");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<Servis>("servisi");
            if (tbxBrisanje.Text != "")
            {
                var query = Query.EQ("_id", ObjectId.Parse(textBox1.Text));

                if (collection.Remove(query).Ok)
                {
                    MessageBox.Show("Uspesno brisanje!");
                    tbxUpravljajServisimaNaziv.Text = "";
                    tbxBrisanje.Text = "";
                    textBox1.Text = "";
                    textBox1.Visible = false;
                    label1.Visible = false;
                }
                else MessageBox.Show("Neuspesno brisanje!");
            }
            else
                MessageBox.Show("Morate uneti id za brisanje!");
        }

        private void btnDodajServis_MouseEnter(object sender, EventArgs e)
        {
            btnDodajServis.ForeColor = Color.DimGray;
            btnDodajServis.BackColor = Color.AntiqueWhite;
        }

        private void btnDodajServis_MouseHover(object sender, EventArgs e)
        {
            btnDodajServis.ForeColor = Color.DimGray;
            btnDodajServis.BackColor = Color.AntiqueWhite;
        }

        private void btnDodajServis_MouseLeave(object sender, EventArgs e)
        {
            btnDodajServis.ForeColor = Color.FromArgb(64,64,64);
            btnDodajServis.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DimGray;
            button1.BackColor = Color.AntiqueWhite;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DimGray;
            button1.BackColor = Color.AntiqueWhite;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(64,64,64);
            button1.BackColor = Color.Transparent;
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            ServisLoginServis fs = new ServisLoginServis();
            fs.ShowDialog();
        }

        private void btnServis_MouseEnter(object sender, EventArgs e)
        {
            btnServis.ForeColor = Color.DimGray;
            btnServis.BackColor = Color.AntiqueWhite;
        }

        private void btnServis_MouseHover(object sender, EventArgs e)
        {
            btnServis.ForeColor = Color.DimGray;
            btnServis.BackColor = Color.AntiqueWhite;
        }

        private void btnServis_MouseLeave(object sender, EventArgs e)
        {
            btnServis.ForeColor = Color.Bisque;
            btnServis.BackColor = Color.Transparent;
        }
    }
}
