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
    public partial class ServisFormTehnickiPregled : Form
    {

        Servis _ovajServis;
        public ServisFormTehnickiPregled(Servis s)
        {
            InitializeComponent();
            _ovajServis = s;
            foreach (String str in s.MozeDaProveri)
            {
                clbPregled.Items.Add(str);
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
            button1.ForeColor = Color.Bisque;
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxIdVozila.Text == String.Empty)
            {
                MessageBox.Show("Niste uneli identifikator vozila!");
                return;
            }

            List<String> cekirani = new List<string>();
            foreach (object cekiran in clbPregled.CheckedItems)
            {
                cekirani.Add(cekiran.ToString());
                MessageBox.Show(cekiran.ToString());
            }

            String idVozila = tbxIdVozila.Text;
            T_pregled t_Pregled = new T_pregled(ObjectId.Parse(idVozila), DateTime.Now.ToString(), cekirani);
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<T_pregled>("t_pregledi");
            collection.Insert(t_Pregled);
        }
    }
}
