using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P5
{
    public class Validator
    {
        public static bool ValidirajKontrolu(Control kontrola, ErrorProvider err, string poruka)
        {
            if (string.IsNullOrWhiteSpace(kontrola.Text))
            {
                err.SetError(kontrola, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
