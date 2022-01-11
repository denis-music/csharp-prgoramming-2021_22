using DLWMS.WinForms.DB;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P14
{
    public partial class frmAsync : Form
    {

        public string Sadrzaj { get; set; }
        public frmAsync()
        {
            InitializeComponent();
        }

        private async Task<string> ProvjeriServiseILicencu()
        {
            await Task.Run(() => ProvjeriServise());//10s //dio 1
            await Task.Run(() => ProvjeriLicencu());//5s  //dio 2
            return "ZAVRSENA DVA AWAIT-a";
        }


        private async void btnPokreni_Click(object sender, EventArgs e)
        {

            //var r = await ProvjeriServiseILicencu();            

            Thread konekcija = new Thread(ProvjeriKonekciju);
           // Thread konekcija2 = new Thread(ProvjeriKonekciju);

            Thread licence = new Thread(ProvjeriLicencu);
         //   Thread servisi = new Thread(ProvjeriServise);
         //   Thread studenti = new Thread(DodajStudente);


            //konekcija.Start(new dtoProvjeraKonekcije() { 
            //    WebAdresa ="www.google.ba",
            //    BrojMilisekundiPauze= 300,
            //    BrojZahtjeva = 5
            //});
            //konekcija2.Start(new dtoProvjeraKonekcije()
            //{
            //    WebAdresa = "www.fit.ba",
            //    BrojMilisekundiPauze = 300,
            //    BrojZahtjeva = 20
            //});
           // licence.Start();
          //  servisi.Start();
         //   studenti.Start();
            
            PrikaziInfo("------------------------------");
            //txtInfo.Text = Sadrzaj;

            //ProvjeriKonekciju();
            //ProvjeriLicencu();
            //ProvjeriServise();
        }

        private void DodajStudente()
        {
            KonekcijaNaBazu db = DLWMSdb.Baza;
            var slika = db.Studenti.Find(1).Slika;
            var spol = db.Spolovi.Find(1);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                var student = new P7.Student()
                {
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now,
                    Email = $"student{i + 1}@edu.fit.ba",
                    GodinaStudija = 1,
                    Ime = $"Student{i + 1}",
                    Prezime = $"Student{i + 1}",
                    Indeks = $"IB{210000 + i}",
                    Lozinka = "lozinka",
                    Slika = slika,
                    Spol = spol
                };
                db.Studenti.Add(student);
                Action akcija = () => PrikaziInfo($"Dodat -> {student}");
                BeginInvoke(akcija);
            }
            db.SaveChanges();
        }
        private void ProvjeriKonekciju(object obj)
        {
            var dtoKonekcija = obj as dtoProvjeraKonekcije;
            Ping ping = new Ping();
            for (int i = 0; i < dtoKonekcija.BrojZahtjeva; i++)
            {
                Thread.Sleep(dtoKonekcija.BrojMilisekundiPauze);
                var odgovor = ping.Send(dtoKonekcija.WebAdresa);
                var poruka = $"{odgovor.Address} {odgovor.RoundtripTime} {odgovor.Status}";
                Action akcija = () => PrikaziInfo(poruka);
                BeginInvoke(akcija);
            }            
        }
        private void PrikaziInfo(string poruka)
        {
            txtInfo.Text += poruka + Environment.NewLine;
            PomjeriNaKraj();
        }

        private void PomjeriNaKraj()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void ProvjeriServise()
        {
            Thread.Sleep(3000); 
            Action akcija = () => PrikaziInfo("Servisi dostupni");
            BeginInvoke(akcija);
        }

        private int GetInt(int broj) { return broj * 2; }

        private void ProvjeriLicencu()
        {
            Thread.Sleep(1000);           
            Action akcija = () => PrikaziInfo("Licenca validna");
            BeginInvoke(akcija);
        }     
    }

    public class dtoProvjeraKonekcije
    {
        public string WebAdresa { get; set; }
        public int BrojZahtjeva { get; set; }
        public int BrojMilisekundiPauze { get; set; }
    }
}
