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
    public partial class PolicijaPretraziVozace : Form
    {
        public PolicijaPretraziVozace()
        {
            InitializeComponent();
        }

        private void PolicijaPretraziVozace_Load(object sender, EventArgs e)
        {

        }

        private void btnPronadji_MouseEnter(object sender, EventArgs e)
        {
            btnPronadji.ForeColor = Color.DimGray;
            btnPronadji.BackColor = Color.AntiqueWhite;
        }

        private void btnPronadji_MouseHover(object sender, EventArgs e)
        {
            btnPronadji.ForeColor = Color.DimGray;
            btnPronadji.BackColor = Color.AntiqueWhite;
        }

        private void btnPronadji_MouseLeave(object sender, EventArgs e)
        {
            btnPronadji.ForeColor = Color.Bisque;
            btnPronadji.BackColor = Color.Transparent;
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<Vozac>("vozaci");
            var voz = db.GetCollection<Vozilo>("vozila");
            if (rdbBojaKose.Checked)
            {

                var query = Query.EQ("Boja_kose", tbxVrednostAtributa.Text);
                foreach (Vozac r in collection.Find(query))
                {
                    var vozila = Query.EQ("Id_vlasnika", ObjectId.Parse(r.Id.ToString()));
                    String niz = "";
                    foreach (Vozilo v in voz.Find(vozila))
                    {
                        niz += v.Id.ToString() + " " + v.Tip + " " + v.Marka + " " + v.Boja + "; ";

                    }
                    lbxRez.Items.Add(r.Id + " " + r.Ime + " " + r.Prezime + " ima vozila: " + niz);

                }

            }
            else if (rdbBojaOciju.Checked)
            {

                var query = Query.EQ("Boja_ociju", tbxVrednostAtributa.Text);
                foreach (Vozac r in collection.Find(query))
                {
                    var vozila = Query.EQ("Id_vlasnika", ObjectId.Parse(r.Id.ToString()));
                    String niz = "";
                    foreach (Vozilo v in voz.Find(vozila))
                    {
                        niz += v.Id.ToString() + " " + v.Tip + " " + v.Marka + " " + v.Boja + "; ";
                    }
                    lbxRez.Items.Add(r.Id + " " + r.Ime + " " + r.Prezime + " ima vozila: " + niz);
                }
            }
            else
            {
                int visina = Int32.Parse(tbxVrednostAtributa.Text);
                var query = Query.EQ("Visina", visina);


                foreach (Vozac r in collection.Find(query))
                {
                    var vozila = Query.EQ("Id_vlasnika", ObjectId.Parse(r.Id.ToString()));
                    String niz = "";
                    foreach (Vozilo v in voz.Find(vozila))
                    {
                        niz += v.Id.ToString() + " " + v.Tip + " " + v.Marka + " " + v.Boja + "; ";
                    }
                    lbxRez.Items.Add(r.Id + " " + r.Ime + " " + r.Prezime + " ima vozila: " + niz);
                }
            }
        }
    }
}
