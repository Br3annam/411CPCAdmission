using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleLook
{
    public partial class Start : Form
    {

        private CallSheetWindow frmCallSheet;
        private AdmissionsWindow admission;
        public Start()
        {
            InitializeComponent();
        }

        private void btnCallSheet_Click(object sender, EventArgs e)
        {
            frmCallSheet = new CallSheetWindow();
            frmCallSheet.ShowDialog();
        }

        private void btnPatLookUp_Click(object sender, EventArgs e)
        {
            admission = new AdmissionsWindow();
            admission.ShowDialog();
        }
    }
}
