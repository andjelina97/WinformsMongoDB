using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoDB_Repository.DomenskiEntiteti
{
    public class Vozac
    {
        public Vozac(ObjectId id, string ime, string prezime, float visina, string boja_kose, string boja_ociju, List<ObjectId> vozila)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Visina = visina;
            Boja_kose = boja_kose;
            Boja_ociju = boja_ociju;
            Vozila = vozila;
        }

        public Vozac(string ime, string prezime, float visina, string boja_kose, string boja_ociju, List<ObjectId> vozila)
        {
            Ime = ime;
            Prezime = prezime;
            Visina = visina;
            Boja_kose = boja_kose;
            Boja_ociju = boja_ociju;
            Vozila = vozila;
        }

        public ObjectId Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public float Visina { get; set; }
        public String Boja_kose { get; set; }
        public String Boja_ociju { get; set; }
        public List<ObjectId> Vozila { get; set; }

    }
}
