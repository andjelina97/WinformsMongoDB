using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoDB_Repository.DomenskiEntiteti
{
    public class T_pregled
    {
        public T_pregled(ObjectId idVozila, string datum, List<string> staRadi)
        {
            //Id = id;
            IdVozila = idVozila;
            Datum = datum;
            StaRadi = staRadi;
        }

        public ObjectId Id { get; set; }
        public ObjectId IdVozila { get; set; }
        public String Datum { get; set; }
        public List<String> StaRadi { get; set; }
    }
}
