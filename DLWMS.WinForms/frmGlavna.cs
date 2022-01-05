using DLWMS.WinForms.P7;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Text = "Nastava iz Programiranja III";
        }

        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = new frmNoviStudent();
            //form.MdiParent = this;
            //form.Show();
            PrikaziFormu(new frmNoviStudent());
        }
        private void PrikaziFormu(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
        private void pretragaStudenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = new frmStudenti();
            //form.MdiParent = this;
            //form.Show();
            PrikaziFormu(new frmStudenti());
        }

        private void krajProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Poruke.KrajRada,
                Poruke.Pitanje,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }

    public partial class Student
    {
        public string ImePrezime { get; set; }
    }
}
