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
    public partial class CallSheetWindow : Form
    {
        DataLayer dl;
        public CallSheetWindow()
        {
            InitializeComponent();

            dl = new DataLayer();

        }
        
        private void patient_admissionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_admissionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPCAppDataSet);

            // TODO: This line of code loads data into the 'cPCAppDataSet.medications' table. You can move, or remove it, as needed.
            this.medicationsTableAdapter.Fill(this.cPCAppDataSet.medications);
            // TODO: This line of code loads data into the 'cPCAppDataSet.medications' table. You can move, or remove it, as needed.
            this.medicationsTableAdapter.Fill(this.cPCAppDataSet.medications);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission' table. You can move, or remove it, as needed.
            this.patient_admissionTableAdapter.Fill(this.cPCAppDataSet.patient_admission);

        }

        private void CallSheetWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPCAppDataSet.abuse_assessment' table. You can move, or remove it, as needed.
           // this.abuse_assessmentTableAdapter.Fill(this.cPCAppDataSet.abuse_assessment);


            // TODO: This line of code loads data into the 'cPCAppDataSet.allergies' table. You can move, or remove it, as needed.
            this.allergiesTableAdapter.Fill(this.cPCAppDataSet.allergies);
            // TODO: This line of code loads data into the 'cPCAppDataSet.medications' table. You can move, or remove it, as needed.
            this.medicationsTableAdapter.Fill(this.cPCAppDataSet.medications);
            // TODO: This line of code loads data into the 'cPCAppDataSet.medications' table. You can move, or remove it, as needed.
            this.medicationsTableAdapter.Fill(this.cPCAppDataSet.medications);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission' table. You can move, or remove it, as needed.
            this.patient_admissionTableAdapter.Fill(this.cPCAppDataSet.patient_admission);
            lastNameTextBox.Text = dl.LastName;
            if (dl.Gender == 'f')
                genderComboBox.Text = "Female";
            dOBDateTimePicker.Text = dl.DOB.ToString();
            if (dl.PresentSuicide == 'y')
                presentSuicideCheckBox.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dl.DOB = dOBDateTimePicker.Value;
            if(genderComboBox.Text =="Male")
            {
                dl.Gender = 'm';
            }
            else if(genderComboBox.Text =="Female")
            {
                dl.Gender = 'm';
            }
            dl.LastName = lastNameTextBox.Text;
            if (presentSuicideCheckBox.Checked)
                dl.PresentSuicide = 'y';
            else
                dl.PresentSuicide = 'n';

            MessageBox.Show(dl.DOB.ToString() + " " + dl.Gender + " " + dl.LastName + " " + dl.PresentSuicide);
        }
    }
}
