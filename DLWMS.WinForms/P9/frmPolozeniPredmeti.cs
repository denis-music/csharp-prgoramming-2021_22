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

namespace DLWMS.WinForms.P9
{
    public partial class frmPolozeniPredmeti : Form
    {
        private P7.Student student;
        public frmPolozeniPredmeti(P7.Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void frmPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPolozenePredmete();
                UcitajPredmete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = InMemoryDB.NPP;
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = student.PolozeniPredmeti;
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            var nePostoji = PredmetNePostoji();
            if(nePostoji == false)
                MessageBox.Show("Predmet je već dodat!!!");
            if (ValidirajUnos() && nePostoji)
            {
                var polozeni = new PolozeniPredmet()
                {
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Id = student.PolozeniPredmeti.Count + 1,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = cmbPredmeti.SelectedItem as Predmet
                };
                student.PolozeniPredmeti.Add(polozeni);
                UcitajPolozenePredmete();
            }
        }

        private bool PredmetNePostoji()
        {
            var odabrani = cmbPredmeti.SelectedItem as Predmet;
            return student.PolozeniPredmeti.Where(predmet =>
                            predmet.Predmet.Id == odabrani.Id).Count() == 0;
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbOcjene, err, Poruke.ObaveznaVrijednost);
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
