using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P7
{
    public partial class frmNoviStudent : Form
    {
        private Student student;        

        public frmNoviStudent(Student student = null)
        {
            InitializeComponent();
            this.student = student ?? new Student();
        }

        private void frmNoviStudent_Load(object sender, EventArgs e)
        {
            UcitajGodineStudija();
            if (student.Id == 0)
            {
                GeneriBrojIndeksa();
                GenerisiLozinku();
            }
            else
                UcitajPodatkeOStudentu();
        }

        private void UcitajPodatkeOStudentu()
        {
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            dtpDatumRodjenja.Value = student.DatumRodjenja;
            txtEmail.Text = student.Email;
            txtLozinka.Text = student.Lozinka;
            cbAktivan.Checked = student.Aktivan;
            cmbGodinaStudija.SelectedValue = student.GodinaStudija;
            txtIndeks.Text = student.Indeks;
            pbSlika.Image = student.Slika;
        }

        private void GenerisiLozinku()
        {
            txtLozinka.Text = Generator.GenerisLozinku();
        }

        private void GeneriBrojIndeksa()
        {
            //IB210158
            txtIndeks.Text = $"IB{((DateTime.Now.Year - 2000) * 10000) + InMemoryDB.Studenti.Count + 1}";                                            
        }

        private void UcitajGodineStudija()
        {
            cmbGodinaStudija.DataSource = InMemoryDB.GodineStudija;
            cmbGodinaStudija.ValueMember = "Id";
            cmbGodinaStudija.DisplayMember = "Opis";
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var putanja = openFileDialog1.FileName;
                pbSlika.Image = Image.FromFile(putanja);
                txtPutanja.Text = putanja;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (ValidirajUnos())
            {
                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.DatumRodjenja = dtpDatumRodjenja.Value;
                student.Email = txtEmail.Text;
                student.Lozinka = txtLozinka.Text;
                student.Aktivan = cbAktivan.Checked;
                student.GodinaStudija = int.Parse(cmbGodinaStudija.SelectedValue.ToString());
                student.Indeks = txtIndeks.Text;
                student.Slika = pbSlika.Image;

                string poruka = Poruke.StudentUspjesnoModifikovan;
                if (student.Id == 0)
                {
                    student.Id = InMemoryDB.Korisnici.Count + 1;
                    InMemoryDB.Studenti.Add(student);
                    poruka = Poruke.StudentUspjesnoDodat;
                }
                MessageBox.Show(poruka, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtIme, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtIndeks, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtEmail, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbGodinaStudija, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);


        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void GenerisiEmail()
        {
            txtEmail.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}@edu.fit.ba";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }
    }
}
