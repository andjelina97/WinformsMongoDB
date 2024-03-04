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
    public partial class PolicijaDodajBrod : Form
    {

        public String id;
        public PolicijaDodajBrod(String i)
        {
            InitializeComponent();
            this.id = i;
        }

        private void PolicijaDodajBrod_Load(object sender, EventArgs e)
        {
            lblBrod.Visible = false;
            tbxBrod.Visible = false;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.AntiqueWhite;
            button1.BackColor = Color.DimGray;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.AntiqueWhite;
            button1.BackColor = Color.DimGray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
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

            if (tbxBrodBoja.Text != "" && tbxBrodMarka.Text != "")
            {
                Vozilo v1 = new Vozilo(false, tbxBrodMarka.Text, tbxBrodBoja.Text, "kola", ObjectId.Parse(id));
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
                    tbxBrod.Text = v1.Id.ToString();
                    tbxBrod.Visible = true;
                    lblBrod.Visible = true;
                    vozac.Save(vozac1);

                }
                else
                    MessageBox.Show("Neuspesno dodavanje!");



            }
            else
                MessageBox.Show("Morate popuniti sva polja!");
        }
    }
}
