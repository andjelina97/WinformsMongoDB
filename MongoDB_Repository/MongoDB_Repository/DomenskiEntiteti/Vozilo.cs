using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoDB_Repository.DomenskiEntiteti
{
    public class Vozilo
    {
        public Vozilo(bool registrovano, ObjectId id, string marka, string boja, string tip, ObjectId id_vlasnika)
        {
            this.registrovano = registrovano;
            Id = id;
            Marka = marka;
            Boja = boja;
            Tip = tip;
            Id_vlasnika = id_vlasnika;
        }

        public Vozilo(bool registrovano, string marka, string boja, string tip, ObjectId id_vlasnika)
        {
            this.registrovano = registrovano;
            Marka = marka;
            Boja = boja;
            Tip = tip;
            Id_vlasnika = id_vlasnika;
        }

        public bool registrovano { get; set; }
        public ObjectId Id { get; set; }
        public String Marka { get; set; }
        public String Boja { get; set; }
        public String Tip { get; set; } //"kola", "brod"
        public ObjectId Id_vlasnika { get; set; }


    }
}
