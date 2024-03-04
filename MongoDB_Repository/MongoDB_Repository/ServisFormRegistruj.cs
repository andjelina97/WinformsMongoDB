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
    public partial class ServisFormRegistruj : Form
    {

        Servis _ovajServis;
        List<String> _zaReg;
        public ServisFormRegistruj(Servis s)
        {
            InitializeComponent();
            _ovajServis = s;
            _zaReg = new List<string>();
            if (_ovajServis.TipServisa == "kola")
            {
                _zaReg.Add("volan");
                _zaReg.Add("motor");
                _zaReg.Add("kocnice");
            }
            else if (_ovajServis.TipServisa == "brod")
            {
                _zaReg.Add("kormilo");
                _zaReg.Add("motor");
                _zaReg.Add("navigacija");
            }
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
            button1.ForeColor = Color.Linen;
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String idVozila = tbIdVozila.Text;
            if (idVozila == String.Empty)
            {
                MessageBox.Show("Potrebno je uneti identifikator vozila/");
                return;
            }
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<T_pregled>("t_pregledi");
            var query = Query.EQ("IdVozila", ObjectId.Parse(idVozila));

            T_pregled poslednji = null;
            foreach (T_pregled t in collection.Find(query))
            {
                if (poslednji == null)
                {
                    poslednji = t;
                    continue;
                }
                DateTime dtp = DateTime.Parse(poslednji.Datum.ToString());
                DateTime dtt = DateTime.Parse(t.Datum.ToString());
                if (dtp < dtt)
                    poslednji = t;
            }

            if (poslednji == null)
            {
                MessageBox.Show("Ne postoji ni jedan tehnicki pregled za taj identifikator!");
                return;
            }

            DateTime dtp1 = DateTime.Parse(poslednji.Datum.ToString());
            if (dtp1 < DateTime.Now.AddDays(-60))
            {
                MessageBox.Show("Poslednji tehnicki pregled je stariji od 60 dana!");
                return;
            }

            bool uspesnaRegistracija = true;
            foreach (String s in _zaReg)
            {
                if (!poslednji.StaRadi.Contains(s))
                {
                    uspesnaRegistracija = false;
                    break;
                }
            }

            if (uspesnaRegistracija == false)
            {
                lblUspesnost.Text = "NIJE USPESNO REGISTROVANO!";
                lblUspesnost.ForeColor = Color.Red;
                return;
            }

            lblUspesnost.Text = "USPESNO REGISTROVANO!";
            lblUspesnost.ForeColor = Color.Green;
            RegistrujVozilo(idVozila);
        }


        public void RegistrujVozilo(String idVozila)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<Vozilo>("vozila");
            var query = Query.EQ("_id", ObjectId.Parse(idVozila));
            long br = 0;
            Vozilo vozilo = null;
            foreach (Vozilo voz in collection.Find(query))
            {
                br++;
                vozilo = voz;
            }

            if (br != 1 || vozilo == null)
            {
                MessageBox.Show("Ne postoji vozilo sa tim identifikatorom!");
                return;
            }

            vozilo.registrovano = true;
            collection.Save(vozilo);
        }
    }
}
