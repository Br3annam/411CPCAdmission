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
    public partial class NursingWindow : Form
    {
        private CallSheetWindow callSheet;
        private AdmissionsWindow admission;
        private AdultSocialWorkWindow adultSW;
        private ChildSocialWorkerWindow childSW;
        private ChangeLogWindow changeLog;

        public NursingWindow()
        {
            InitializeComponent();
        }

        private void allergiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.allergiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPCAppDataSet);

        }

        private void NursingWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPCAppDataSet.abuse_assessment' table. You can move, or remove it, as needed.
            this.abuse_assessmentTableAdapter.Fill(this.cPCAppDataSet.abuse_assessment);
            // TODO: This line of code loads data into the 'cPCAppDataSet.pain_assessment' table. You can move, or remove it, as needed.
            this.pain_assessmentTableAdapter.Fill(this.cPCAppDataSet.pain_assessment);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission' table. You can move, or remove it, as needed.
            this.patient_admissionTableAdapter.Fill(this.cPCAppDataSet.patient_admission);
            // TODO: This line of code loads data into the 'cPCAppDataSet.allergies' table. You can move, or remove it, as needed.
            this.allergiesTableAdapter.Fill(this.cPCAppDataSet.allergies);

        }

        private void btnCallSheet_Click(object sender, EventArgs e)
        {
            callSheet = new CallSheetWindow();
            callSheet.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admission = new AdmissionsWindow();
            admission.ShowDialog();
        }

        private void btnAdultSW_Click(object sender, EventArgs e)
        {
            adultSW = new AdultSocialWorkWindow();
            adultSW.ShowDialog();
        }

        private void btnChildSW_Click(object sender, EventArgs e)
        {
            childSW = new ChildSocialWorkerWindow();
            childSW.ShowDialog();
        }

        private void btnChangeLog_Click(object sender, EventArgs e)
        {
            changeLog = new ChangeLogWindow();
            changeLog.ShowDialog();
        }
    }
}
