using DLWMS.WinForms.DB;

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
    public partial class frmStudenti : Form
    {
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Student> podaci = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = podaci ?? InMemoryDB.Studenti;
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            var forma = new frmNoviStudent();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajStudente();
        }

        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            if (student != null)
            {
                var forma = new frmNoviStudent(student);
                if (forma.ShowDialog() == DialogResult.OK)
                    UcitajStudente();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filter = txtFilter.Text;
            var rezultat = new List<Student>();

            foreach (var student in InMemoryDB.Studenti)
            {
                if (student.Ime.ToLower().Contains(filter) || student.Prezime.ToLower().Contains(filter))
                    rezultat.Add(student);
            }
            UcitajStudente(rezultat);
        }
    }
}
