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
    public partial class AdultSocialWorkWindow : Form
    {
        public AdultSocialWorkWindow()
        {
            InitializeComponent();
        }

        private void patient_admission_extBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_admission_extBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPCAppDataSet);

        }

        private void AdultSocialWorkWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPCAppDataSet.substance_abuse' table. You can move, or remove it, as needed.
            this.substance_abuseTableAdapter.Fill(this.cPCAppDataSet.substance_abuse);
            // TODO: This line of code loads data into the 'cPCAppDataSet.family_members' table. You can move, or remove it, as needed.
            this.family_membersTableAdapter.Fill(this.cPCAppDataSet.family_members);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission' table. You can move, or remove it, as needed.
            this.patient_admissionTableAdapter.Fill(this.cPCAppDataSet.patient_admission);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission_ext' table. You can move, or remove it, as needed.
            this.patient_admission_extTableAdapter.Fill(this.cPCAppDataSet.patient_admission_ext);

        }

        private void grpRiskAssess_Enter(object sender, EventArgs e)
        {

        }
    }
}
