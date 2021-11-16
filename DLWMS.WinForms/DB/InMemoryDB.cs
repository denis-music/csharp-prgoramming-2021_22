using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    internal class InMemoryDB
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();

        private static List<Korisnik> GenerisiKorisnike()
        {
            return new List<Korisnik>() { new Korisnik()
            {
                Id = 1,
                Ime = "Denis",
                Prezime = "Music",
                DatumRodjenja = DateTime.Now,
                KorisnickoIme = "denis",
                Lozinka = "denis",
                Aktivan = false
            }};         

            //var korisnik = new Korisnik()
            //{
            //    Id = 1,
            //    Ime = "Denis",
            //    Prezime = "Music",
            //    DatumRodjenja = DateTime.Now,
            //    KorisnickoIme = "denis",
            //    Lozinka = "denis",
            //    Aktivan = true
            //};
            //var lista = new List<Korisnik>();
            //lista.Add(korisnik);
            //return lista;
        }
    }
}
