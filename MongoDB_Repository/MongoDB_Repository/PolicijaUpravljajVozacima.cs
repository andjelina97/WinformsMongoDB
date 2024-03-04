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
    public partial class PolicijaUpravljajVozacima : Form
    {
        public PolicijaUpravljajVozacima()
        {
            InitializeComponent();
        }

        private void PolicijaUpravljajVozacima_Load(object sender, EventArgs e)
        {
            lblDodatiVozac.Visible = false;
            tbxDodatiVozac.Visible = false;
        }

        private void btnDodajVozaca_MouseEnter(object sender, EventArgs e)
        {
            btnDodajVozaca.ForeColor = Color.DimGray;
            btnDodajVozaca.BackColor = Color.AntiqueWhite;
        }

        private void btnDodajVozaca_MouseHover(object sender, EventArgs e)
        {
            btnDodajVozaca.ForeColor = Color.DimGray;
            btnDodajVozaca.BackColor = Color.AntiqueWhite;
        }

        private void btnDodajVozaca_MouseLeave(object sender, EventArgs e)
        {
            btnDodajVozaca.ForeColor = Color.Bisque;
            btnDodajVozaca.BackColor = Color.Transparent;
        }

        private void btnObrisiVozaca_MouseEnter(object sender, EventArgs e)
        {
            btnObrisiVozaca.ForeColor = Color.DimGray;
            btnObrisiVozaca.BackColor = Color.AntiqueWhite;
        }

        private void btnObrisiVozaca_MouseHover(object sender, EventArgs e)
        {
            btnObrisiVozaca.ForeColor = Color.DimGray;
            btnObrisiVozaca.BackColor = Color.AntiqueWhite;
        }

        private void btnObrisiVozaca_MouseLeave(object sender, EventArgs e)
        {
            btnObrisiVozaca.ForeColor = Color.Bisque;
            btnObrisiVozaca.BackColor = Color.Transparent;
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            //db.CreateCollection("vozaci");

            var collection = db.GetCollection<Vozac>("vozaci");
            // MessageBox.Show(collection.Count().ToString());


            if (tbxBojaKose.Text != "" && tbxBojaOciju.Text != "" && tbxIme.Text != "" && tbxPrezime.Text != "" && tbxVisina.Text != "")
            {
                Vozac v1 = new Vozac(tbxIme.Text, tbxPrezime.Text, float.Parse(tbxVisina.Text), tbxBojaKose.Text, tbxBojaOciju.Text, new List<ObjectId>());
                if (collection.Insert(v1).Ok)
                {
                    MessageBox.Show("Uspesno dodavanje!");
                    String id = v1.Id.ToString();
                    lblDodatiVozac.Visible = true;
                    tbxDodatiVozac.Visible = true;
                    tbxDodatiVozac.Text = id;
                }
                else MessageBox.Show("Neuspesno dodavanje!");
            }
            else
                MessageBox.Show("Morate uneti sve podatke o vozacu!");
        }

        private void btnObrisiVozaca_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<Vozac>("vozaci");
            var voz = db.GetCollection<Vozilo>("vozila");
            var vozz = Query.EQ("Id_vlasnika", ObjectId.Parse(tbxBrisi.Text));

            var query = Query.EQ("_id", ObjectId.Parse(tbxBrisi.Text));

            if (collection.Remove(query).Ok && voz.Remove(vozz).Ok)
            {
                MessageBox.Show("Uspesno brisanje!");

                tbxBojaKose.Text = "";
                tbxBojaOciju.Text = "";
                tbxIme.Text = "";
                tbxPrezime.Text = "";
                tbxVisina.Text = "";
                tbxBrisi.Text = "";
                tbxDodatiVozac.Text = "";
            }
            else
                MessageBox.Show("Neuspesno brisanje!");
        }

        private void btnDodajVozilo_MouseEnter(object sender, EventArgs e)
        {
            btnDodajVozilo.ForeColor = Color.DimGray;
            btnDodajVozilo.BackColor = Color.AntiqueWhite;
        }

        private void btnDodajVozilo_MouseHover(object sender, EventArgs e)
        {
            btnDodajVozilo.ForeColor = Color.DimGray;
            btnDodajVozilo.BackColor = Color.AntiqueWhite;
        }

        private void btnDodajVozilo_MouseLeave(object sender, EventArgs e)
        {
            btnDodajVozilo.ForeColor = Color.Bisque;
            btnDodajVozilo.BackColor = Color.Transparent;
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            if (tbxIdV.Text != "")
            {
                if (rdbAuto.Checked)
                {
                    PolicijaDodajAuto s = new PolicijaDodajAuto(tbxIdV.Text);
                    s.ShowDialog();
                }
                else
                {
                    PolicijaDodajBrod s = new PolicijaDodajBrod(tbxIdV.Text);
                    s.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Morate uneti id vozaca za kog dodajete vozilo!");
            }
        }

        private void btnObrisiVozilo_MouseEnter(object sender, EventArgs e)
        {
            btnObrisiVozilo.ForeColor = Color.DimGray;
            btnObrisiVozilo.BackColor = Color.AntiqueWhite;
        }

        private void btnObrisiVozilo_MouseHover(object sender, EventArgs e)
        {
            btnObrisiVozilo.ForeColor = Color.DimGray;
            btnObrisiVozilo.BackColor = Color.AntiqueWhite;
        }

        private void btnObrisiVozilo_MouseLeave(object sender, EventArgs e)
        {
            btnObrisiVozilo.ForeColor = Color.Bisque;
            btnObrisiVozilo.BackColor = Color.Transparent;
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("registracija");

            var collection = db.GetCollection<Vozac>("vozaci");

            var voz = db.GetCollection<Vozilo>("vozila");

            var query = Query.And((Query.EQ("Id_vlasnika", ObjectId.Parse(tbxBrisiId.Text))), (Query.EQ("_id", ObjectId.Parse(tbxBrisiIdVozilo.Text))));
            var v = Query.EQ("_id", ObjectId.Parse(tbxBrisiId.Text));

            //    foreach (Vozac a in collection.Find(v))
            //        {
            //            foreach (ObjectId i in a.Vozila)
            //            {
            //                if (i == ObjectId.Parse(tbxBrisiIdVozilo.Text))
            //                {
            //                    a.Vozila.Remove(i);

            //                    if(voz.Remove(query).Ok)
            //                    {
            //                        MessageBox.Show("Uspesno brisanje!");

            //                        tbxIdV.Text = "";
            //                        tbxBrisiId.Text = "";
            //                        tbxBrisiIdVozilo.Text = "";
            //                    }
            //                    else MessageBox.Show("Neuspesno brisanje!");

            //                }
            //            collection.Save(a);
            //        }
            //        }

            //}


            foreach (Vozac a in collection.Find(v))
            {
                int j = a.Vozila.Count;
                for (int n = 0; n < j; n++)
                {
                    if (a.Vozila[n] == ObjectId.Parse(tbxBrisiIdVozilo.Text))
                    {
                        a.Vozila.Remove(a.Vozila[n]);
                        collection.Save(a);
                    }
                }
            }

            if (voz.Remove(query).Ok)
            {
                MessageBox.Show("Uspesno brisanje!");

                tbxIdV.Text = "";
                tbxBrisiId.Text = "";
                tbxBrisiIdVozilo.Text = "";
            }
            else
                MessageBox.Show("Neuspesno brisanje!");



            //if (voz.Remove(query).Ok)
            //{
            //    foreach (Vozac a in collection.Find(v))
            //    {
            //        foreach (ObjectId i in a.Vozila)
            //        {
            //            if (i == ObjectId.Parse(tbxBrisiIdVozilo.Text))
            //            {
            //                a.Vozila.Remove(i);
            //                collection.Save(a);
            //            }
            //        }
            //    }


            //    MessageBox.Show("Uspesno brisanje!");

            //    tbxIdV.Text = "";
            //    tbxBrisiId.Text = "";
            //    tbxBrisiIdVozilo.Text = "";
            //}
            //else
            //    MessageBox.Show("Neuspesno brisanje!");
        
    }
    }
}
