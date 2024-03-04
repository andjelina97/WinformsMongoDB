using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoDB_Repository.DomenskiEntiteti
{
    public class Servis
    {
        public Servis(string naziv, string tipServisa, List<string> mozeDaProveri)
        {
            //Id = id;
            Naziv = naziv;
            TipServisa = tipServisa;
            MozeDaProveri = mozeDaProveri;
        }

        public ObjectId Id { get; set; }
        public String Naziv { get; set; }
        public String TipServisa { get; set; }
        public List<String> MozeDaProveri { get; set; }
    }
}
