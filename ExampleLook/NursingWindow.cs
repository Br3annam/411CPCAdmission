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

        private void feelAboutHospitalizedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpImpSelf_Enter(object sender, EventArgs e)
        {

        }
    }
}
