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
    public partial class ChildSocialWorkerWindow : Form
    {
        private CallSheetWindow callSheet;
        private AdmissionsWindow admission;
        private NursingWindow nursing;
        private AdultSocialWorkWindow adultSW;
        private ChangeLogWindow changeLog;

        public ChildSocialWorkerWindow()
        {
            InitializeComponent();
        }

        private void patient_admission_extBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_admission_extBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPCAppDataSet);

        }

        private void ChildSocialWorkerWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPCAppDataSet.functions' table. You can move, or remove it, as needed.
            this.functionsTableAdapter.Fill(this.cPCAppDataSet.functions);
            // TODO: This line of code loads data into the 'cPCAppDataSet.substance_abuse' table. You can move, or remove it, as needed.
            this.substance_abuseTableAdapter.Fill(this.cPCAppDataSet.substance_abuse);
            // TODO: This line of code loads data into the 'cPCAppDataSet.family_members' table. You can move, or remove it, as needed.
            this.family_membersTableAdapter.Fill(this.cPCAppDataSet.family_members);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission' table. You can move, or remove it, as needed.
            this.patient_admissionTableAdapter.Fill(this.cPCAppDataSet.patient_admission);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission_ext' table. You can move, or remove it, as needed.
            this.patient_admission_extTableAdapter.Fill(this.cPCAppDataSet.patient_admission_ext);

        }

        private void btnCallSheet_Click(object sender, EventArgs e)
        {
            callSheet = new CallSheetWindow();
            callSheet.ShowDialog();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            admission = new AdmissionsWindow();
            admission.ShowDialog();
        }

        private void btnNursing_Click(object sender, EventArgs e)
        {
            nursing = new NursingWindow();
            nursing.ShowDialog();
        }

        private void btnAdultSW_Click(object sender, EventArgs e)
        {
            adultSW = new AdultSocialWorkWindow();
            adultSW.ShowDialog();
        }

        private void btnChangeLog_Click(object sender, EventArgs e)
        {
            changeLog = new ChangeLogWindow();
            changeLog.ShowDialog();
        }
    }
}
