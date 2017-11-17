﻿using System;
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
    public partial class AdmissionsWindow : Form
    {
        public AdmissionsWindow()
        {
            InitializeComponent();
        }

        private void patient_admissionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_admissionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPCAppDataSet);

        }

        private void AdmissionsWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPCAppDataSet.abuse_assessment' table. You can move, or remove it, as needed.
            this.abuse_assessmentTableAdapter.Fill(this.cPCAppDataSet.abuse_assessment);
            // TODO: This line of code loads data into the 'cPCAppDataSet.substance_abuse' table. You can move, or remove it, as needed.
            this.substance_abuseTableAdapter.Fill(this.cPCAppDataSet.substance_abuse);
            // TODO: This line of code loads data into the 'cPCAppDataSet.substance_abuse' table. You can move, or remove it, as needed.
            this.substance_abuseTableAdapter.Fill(this.cPCAppDataSet.substance_abuse);
            // TODO: This line of code loads data into the 'cPCAppDataSet.medications' table. You can move, or remove it, as needed.
            this.medicationsTableAdapter.Fill(this.cPCAppDataSet.medications);
            // TODO: This line of code loads data into the 'cPCAppDataSet.psych_hospital' table. You can move, or remove it, as needed.
            this.psych_hospitalTableAdapter.Fill(this.cPCAppDataSet.psych_hospital);
            // TODO: This line of code loads data into the 'cPCAppDataSet.treatment_facility' table. You can move, or remove it, as needed.
            this.treatment_facilityTableAdapter.Fill(this.cPCAppDataSet.treatment_facility);
            // TODO: This line of code loads data into the 'cPCAppDataSet.treatment_facility' table. You can move, or remove it, as needed.
            this.treatment_facilityTableAdapter.Fill(this.cPCAppDataSet.treatment_facility);
            // TODO: This line of code loads data into the 'cPCAppDataSet.patient_admission' table. You can move, or remove it, as needed.
            this.patient_admissionTableAdapter.Fill(this.cPCAppDataSet.patient_admission);

        }

        private void mRNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void thoughtContGraCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void suicIdeaDescLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void howOftenAlcLabel_Click(object sender, EventArgs e)
        {

        }

        private void psychHallDescLabel_Click(object sender, EventArgs e)
        {

        }

        private void psychDelDescLabel_Click(object sender, EventArgs e)
        {

        }

        private void contextFactCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
