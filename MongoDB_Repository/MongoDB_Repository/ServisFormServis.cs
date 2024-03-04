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
    public partial class ServisFormServis : Form
    {

        Servis _ovajServis;

        public ServisFormServis(Servis s)
        {
            InitializeComponent();
            _ovajServis = s;
            //lblNaziv.Text = s.Naziv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServisFormTehnickiPregled fr = new ServisFormTehnickiPregled(_ovajServis);
            fr.ShowDialog();
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
            button1.BackColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.AntiqueWhite;
            button2.BackColor = Color.DimGray;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.AntiqueWhite;
            button2.BackColor = Color.DimGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.DimGray;
            button2.BackColor = Color.White;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.AntiqueWhite;
            button1.BackColor = Color.DimGray;
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.AntiqueWhite;
            button1.BackColor = Color.DimGray;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DimGray;
            button1.BackColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ServisFormRegistruj fr = new ServisFormRegistruj(_ovajServis);
            fr.ShowDialog();
        }
    }
}
