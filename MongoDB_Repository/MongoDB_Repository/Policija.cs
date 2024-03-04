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
    public partial class Policija : Form
    {
        public Policija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PolicijaUpravljajVozacima s = new PolicijaUpravljajVozacima();
            s.ShowDialog();
        }

        private void btnPretraziVozace_Click(object sender, EventArgs e)
        {
            PolicijaPretraziVozace s = new PolicijaPretraziVozace();
            s.ShowDialog();
        }

        private void btnUpravljajServisima_Click(object sender, EventArgs e)
        {
            PolicijaUpravljajServisima s = new PolicijaUpravljajServisima();
            // s.client = client;
            s.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var vozaci = db.GetCollection<Vozac>("vozaci");

            var vozila = db.GetCollection<Vozilo>("vozila");

            var servisi = db.GetCollection<Servis>("servisi");

            if (vozaci.RemoveAll().Ok && vozila.RemoveAll().Ok && servisi.RemoveAll().Ok)
                MessageBox.Show("Uspesan reset podataka!");
            else MessageBox.Show("Neuspesan reset podataka!");
        }

        private void btnUpravljajVozacima_MouseEnter(object sender, EventArgs e)
        {
            btnUpravljajVozacima.ForeColor = Color.AntiqueWhite;
            btnUpravljajVozacima.BackColor = Color.DimGray;
        }

        private void btnUpravljajVozacima_MouseHover(object sender, EventArgs e)
        {
            btnUpravljajVozacima.ForeColor = Color.AntiqueWhite;
            btnUpravljajVozacima.BackColor = Color.DimGray;
        }

        private void btnUpravljajVozacima_MouseLeave(object sender, EventArgs e)
        {
            btnUpravljajVozacima.ForeColor = Color.FromArgb(64, 64, 64);
            btnUpravljajVozacima.BackColor = Color.Transparent;
        }

        private void btnPretraziVozace_MouseEnter(object sender, EventArgs e)
        {
            btnPretraziVozace.ForeColor = Color.AntiqueWhite;
            btnPretraziVozace.BackColor = Color.DimGray;
        }

        private void btnPretraziVozace_MouseHover(object sender, EventArgs e)
        {
            btnPretraziVozace.ForeColor = Color.AntiqueWhite;
            btnPretraziVozace.BackColor = Color.DimGray;
        }

        private void btnPretraziVozace_MouseLeave(object sender, EventArgs e)
        {
            btnPretraziVozace.ForeColor = Color.FromArgb(64, 64, 64);
            btnPretraziVozace.BackColor = Color.Transparent;
        }

        private void btnUpravljajServisima_MouseEnter(object sender, EventArgs e)
        {
            btnUpravljajServisima.ForeColor = Color.AntiqueWhite;
            btnUpravljajServisima.BackColor = Color.DimGray;
        }

        private void btnUpravljajServisima_MouseHover(object sender, EventArgs e)
        {
            btnUpravljajServisima.ForeColor = Color.AntiqueWhite;
            btnUpravljajServisima.BackColor = Color.DimGray;
        }

        private void btnUpravljajServisima_MouseLeave(object sender, EventArgs e)
        {
            btnUpravljajServisima.ForeColor = Color.FromArgb(64, 64, 64);
            btnUpravljajServisima.BackColor = Color.Transparent;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.AntiqueWhite;
            btnReset.BackColor = Color.DimGray;
        }

        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.AntiqueWhite;
            btnReset.BackColor = Color.DimGray;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.FromArgb(64, 64, 64);
            btnReset.BackColor = Color.Transparent;
        }
    }
}
