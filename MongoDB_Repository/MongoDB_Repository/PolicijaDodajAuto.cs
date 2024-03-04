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
    public partial class PolicijaDodajAuto : Form
    {

        public String id;
        public String idVozila;
        public PolicijaDodajAuto(String i)
        {
            InitializeComponent();
            this.id = i;
        }

        private void PolicijaDodajAuto_Load(object sender, EventArgs e)
        {
            lblAuto.Visible = false;
            tbxAuto.Visible = false;
            panel3.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.AntiqueWhite;
            button1.BackColor = Color.DimGray;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.AntiqueWhite;
            button1.BackColor = Color.DimGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(64,64,64);
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            //db.CreateCollection("vozila");

            var collection = db.GetCollection<Vozilo>("vozila");

            if (tbxBoja.Text != "" && tbxMarka.Text != "")
            {
                Vozilo v1 = new Vozilo(false, tbxMarka.Text, tbxBoja.Text, "kola", ObjectId.Parse(id));
                if (collection.Insert(v1).Ok)
                {
                    MessageBox.Show("Uspesno dodavanje!");
                    var vozac = db.GetCollection<Vozac>("vozaci");

                    var query = Query.EQ("_id", ObjectId.Parse(id));

                    Vozac vozac1 = null;
                    foreach (Vozac r in vozac.Find(query))
                    {
                        vozac1 = r;
                        vozac1.Vozila.Add(v1.Id);
                    }
                    idVozila = v1.Id.ToString();
                    tbxAuto.Text = idVozila;
                    lblAuto.Visible = true;
                    tbxAuto.Visible = true;
                    vozac.Save(vozac1);
                }
                else
                    MessageBox.Show("Neuspeno dodavanje!");
            }
            else
                MessageBox.Show("Morate uneti sve podatke o vozilu!");

        }
    }
}
