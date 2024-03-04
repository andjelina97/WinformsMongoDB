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
    public partial class ServisLoginServis : Form
    {
        public ServisLoginServis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Potrebno je uneti identifikator servisa.");
                return;
            }
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<Servis>("servisi");
            var query = Query.EQ("_id", ObjectId.Parse(textBox1.Text));
            long br = 0;
            Servis servis = null;
            foreach (Servis ser in collection.Find(query))
            {
                br++;
                servis = ser;
            }

            if (br != 1 || servis == null)
            {
                MessageBox.Show("Ne postoji servis sa tim identifikatorom!");
                return;
            }

            ServisFormServis fs = new ServisFormServis(servis);
            fs.ShowDialog();
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
    }
}
