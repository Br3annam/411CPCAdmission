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
        DataLayer dl = new DataLayer();
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
            //lastNameTextBox.Text = dl.lastName;
            //if (dl.gender == 'f')
            //    genderComboBox.Text = "Female";
            //dOBDateTimePicker.Text = dl.dOB.ToString();
            //if (dl.presentSuicide == 'y')
            //    presentSuicideCheckBox.Checked = true;
        }

        private void grpBxCommitStat_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //dl.dOB = dOBDateTimePicker.Value;
            //if(genderComboBox.Text =="Male")
            //{
            //    dl.gender = 'm';
            //}
            //else if(genderComboBox.Text =="Female")
            //{
            //    dl.gender = 'm';
            //}
            //dl.lastName = lastNameTextBox.Text;
            //if (presentSuicideCheckBox.Checked)
            //    dl.presentSuicide = 'y';
            //else
            //    dl.presentSuicide = 'n';

            //MessageBox.Show(dl.dOB.ToString() + " " + dl.gender + " " + dl.lastName + " " + dl.presentSuicide);
        }

        private void getCallSheetInfo()
        {
            dl.callerFName = callerFNameTextBox.Text;
            dl.callerZip = callerZipTextBox.Text;
            dl.callerLName = callerLNameTextBox.Text;
            dl.callerState = callerStateTextBox.Text;
            dl.callerRefName = callerRefNameTextBox.Text;
            dl.callerAgency = callerAgencyTextBox.Text;
            dl.callerCity = callerCityTextBox.Text;
            dl.phone = phoneTextBox.Text;
            dl.county = countyTextBox.Text;
            dl.zip = zipTextBox.Text;
            dl.state = stateTextBox.Text;
            dl.city = cityTextBox.Text;
            dl.address = addressTextBox.Text;
            dl.sSN = sSNTextBox.Text;
            dl.dOB = dOBDateTimePicker.Value;
            dl.age = ageTextBox.Text;
            dl.lastName = lastNameTextBox.Text;
            dl.middleInitial = middleInitialTextBox.Text;
            dl.firstName = firstNameTextBox.Text;
            dl.medConcerns = medConcernsTextBox.Text;
            dl.currentOutpat = currentOutpatTextBox.Text;
            dl.prevTx = prevTxTextBox.Text;
            dl.subMisuse = subMisuseTextBox.Text;
            dl.lethalMeans = lethalMeansTextBox.Text;
            dl.presentProb = presentProbTextBox.Text;
            dl.r = rTextBox.Text;
            dl.p = pTextBox.Text;
            dl.t = tTextBox.Text;
            dl.bloodPressure = bloodPressureTextBox.Text;
            dl.iQ = int.Parse(iQTextBox.Text);
            dl.primInsPhone = primInsPhoneTextBox.Text;
            dl.primInsName = primInsNameTextBox.Text;
            dl.nurseIntake = nurseIntakeTextBox.Text;
            dl.secInsPhone = secInsPhoneTextBox.Text;
            dl.secInsName = secInsNameTextBox.Text;
            dl.callEnded = callEndedDateTimePicker.Value;
            dl.callCollectedBy = callCollectedByTextBox.Text;
            dl.callNotes = callNotesTextBox.Text;
            dl.schedAssessTime = schedAssessTimeTextBox.Text;
            dl.schedAssessDate = schedAssessDateDateTimePicker.Value;
            dl.callStarted = callStartedDateTimePicker.Value;
            dl.callerPhone = callerPhoneTextBox.Text;
            dl.presentOtherDesc = presentOtherDescTextBox.Text;
            if (presentOtherCheckBox.Checked)
                dl.presentOther = "Y";
            else
                dl.presentOther = "N";
            if (presentPsychosisCheckBox.Checked)
                dl.presentPsychosis = "Y";
            else
                dl.presentPsychosis = "N";
            if (presentHomicideCheckBox.Checked)
                dl.presentHomicide = "Y";
            else
                dl.presentHomicide = "N";
            if (presentSelfHarmCheckBox.Checked)
                dl.presentSelfHarm = "Y";
            else
                dl.presentSelfHarm = "N";
            if (presentSuicideCheckBox.Checked)
                dl.presentSuicide = "Y";
            else
                dl.presentSuicide = "N";
            if (emergencyContactCheckBox.Checked)
                dl.emergencyContact = "Y";
            else
                dl.emergencyContact = "N";
            dl.emergencyContactLName = emergencyContactLNameTextBox.Text;
            dl.emergencyContactFName = emergencyContactFNameTextBox.Text;
            dl.powAttorneyPhone = powAttorneyPhoneTextBox.Text;
            dl.powAttorneyRelat = powAttorneyRelatTextBox.Text;
            dl.powAttorneyLName = powAttorneyLNameTextBox.Text;
            dl.powAttorneyFName = powAttorneyFNameTextBox.Text;
            dl.guardianshipPhone = guardianshipPhoneTextBox.Text;
            dl.guardianshipRelat = guardianshipRelatTextBox.Text;
            dl.guardianshipFName = guardianshipFNameTextBox.Text;
            dl.guardianshipLName = guardianshipLNameTextBox.Text;
            dl.medEduRightsRelat = medEduRightsRelatTextBox.Text;
            dl.medEduRightsPhone = medEduRightsPhoneTextBox.Text;
            dl.medEduRightsLName = medEduRightsLNameTextBox.Text;
            dl.medEduRightsFName = medEduRightsFNameTextBox.Text;
            dl.emergencyContactPhone = emergencyContactPhoneTextBox.Text;
            dl.emergencyContactRelat = emergencyContactRelatTextBox.Text;
            dl.sexVictimDesc = sexVictimDescTextBox.Text;
            dl.prefLangDesc = prefLangDescTextBox.Text;
            dl.sexAggressDesc = sexAggressDescTextBox.Text;
            dl.callStartedTime = callStartedTimeTextBox.Text;
            dl.commitStatDesc = commitStatDescTextBox.Text;
            if (vitalsNotObtainCheckBox.Checked)
                dl.vitalsNotObtain = "Y";
            else
                dl.vitalsNotObtain = "N";
            if (schedAssessCheckBox.Checked)
                dl.schedAssess = "Y";
            else
                dl.schedAssess = "N";
            dl.medDiag = medDiagTextBox.Text;
            dl.admPsyDiag = admPsyDiagTextBox.Text;
            dl.timeAccepted = timeAcceptedDateTimePicker.Value;
            dl.nurseNotified = nurseNotifiedTextBox.Text;
            dl.physOnCall = physOnCallTextBox.Text;
            if (timeAcceptedNACheckBox.Checked)
                dl.timeAcceptedNA = "Y";
            else
                dl.timeAcceptedNA = "N";
            dl.transportDesc = transportDescTextBox.Text;
            dl.callEndedTime = callEndedTimeTextBox.Text;
        }

        private void setCallSheetInfo()
        {
            callerFNameTextBox.Text = dl.callerFName;
            callerZipTextBox.Text = dl.callerZip;
            callerLNameTextBox.Text = dl.callerLName;
            callerStateTextBox.Text = dl.callerState;
            callerRefNameTextBox.Text = dl.callerRefName;
            callerAgencyTextBox.Text = dl.callerAgency;
            callerCityTextBox.Text = dl.callerCity;
            phoneTextBox.Text = dl.phone;
            countyTextBox.Text = dl.county;
            zipTextBox.Text = dl.zip;
            stateTextBox.Text = dl.state;
            cityTextBox.Text = dl.city;
            addressTextBox.Text = dl.address;
            sSNTextBox.Text = dl.sSN;
            dOBDateTimePicker.Value = dl.dOB ?? DateTime.Today;
            ageTextBox.Text = dl.age;
            lastNameTextBox.Text = dl.lastName;
            middleInitialTextBox.Text = dl.middleInitial;
            firstNameTextBox.Text = dl.firstName;
            medConcernsTextBox.Text = dl.medConcerns;
            currentOutpatTextBox.Text = dl.currentOutpat;
            prevTxTextBox.Text = dl.prevTx;
            subMisuseTextBox.Text = dl.subMisuse;
            lethalMeansTextBox.Text = dl.lethalMeans;
            presentProbTextBox.Text = dl.presentProb;
            rTextBox.Text = dl.r;
            pTextBox.Text = dl.p;
            tTextBox.Text = dl.t;
            bloodPressureTextBox.Text = dl.bloodPressure;
            iQTextBox.Text = dl.iQ.ToString();
            primInsPhoneTextBox.Text = dl.primInsPhone;
            primInsNameTextBox.Text = dl.primInsName;
            nurseIntakeTextBox.Text = dl.nurseIntake;
            secInsPhoneTextBox.Text = dl.secInsPhone;
            secInsNameTextBox.Text = dl.secInsName;
            callEndedDateTimePicker.Value = dl.callEnded ?? DateTime.Today;
            callCollectedByTextBox.Text = dl.callCollectedBy;
            callNotesTextBox.Text = dl.callNotes;
            schedAssessTimeTextBox.Text = dl.schedAssessTime;
            schedAssessDateDateTimePicker.Value = dl.schedAssessDate ?? DateTime.Today;
            callStartedDateTimePicker.Value = dl.callStarted ?? DateTime.Today;
            callerPhoneTextBox.Text = dl.callerPhone;
            presentOtherDescTextBox.Text = dl.presentOtherDesc;
            if (dl.presentOther == "Y")
                presentOtherCheckBox.Checked = true;
            else
                presentOtherCheckBox.Checked = false;
            if (dl.presentPsychosis == "Y")
                presentPsychosisCheckBox.Checked = true;
            else
                presentPsychosisCheckBox.Checked = false;
            if (dl.presentHomicide == "Y")
                presentHomicideCheckBox.Checked = true;
            else
                presentHomicideCheckBox.Checked = false;
            if (dl.presentSelfHarm == "Y")
                presentSelfHarmCheckBox.Checked = true;
            else
                presentSelfHarmCheckBox.Checked = false;
            if (dl.presentSuicide == "Y")
                presentSuicideCheckBox.Checked = true;
            else
                presentSuicideCheckBox.Checked = false;
            if (dl.emergencyContact == "Y")
                emergencyContactCheckBox.Checked = true;
            else
                emergencyContactCheckBox.Checked = false;
            emergencyContactLNameTextBox.Text = dl.emergencyContactLName;
            emergencyContactFNameTextBox.Text = dl.emergencyContactFName;
            powAttorneyPhoneTextBox.Text = dl.powAttorneyPhone;
            powAttorneyRelatTextBox.Text = dl.powAttorneyRelat;
            powAttorneyLNameTextBox.Text = dl.powAttorneyLName;
            powAttorneyFNameTextBox.Text = dl.powAttorneyFName;
            guardianshipPhoneTextBox.Text = dl.guardianshipPhone;
            guardianshipRelatTextBox.Text = dl.guardianshipRelat;
            guardianshipFNameTextBox.Text = dl.guardianshipFName;
            guardianshipLNameTextBox.Text = dl.guardianshipLName;
            medEduRightsRelatTextBox.Text = dl.medEduRightsRelat;
            medEduRightsPhoneTextBox.Text = dl.medEduRightsPhone;
            medEduRightsLNameTextBox.Text = dl.medEduRightsLName;
            medEduRightsFNameTextBox.Text = dl.medEduRightsFName;
            emergencyContactPhoneTextBox.Text = dl.emergencyContactPhone;
            emergencyContactRelatTextBox.Text = dl.emergencyContactRelat;
            sexVictimDescTextBox.Text = dl.sexVictimDesc;
            prefLangDescTextBox.Text = dl.prefLangDesc;
            sexAggressDescTextBox.Text = dl.sexAggressDesc;
            callStartedTimeTextBox.Text = dl.callStartedTime;
            commitStatDescTextBox.Text = dl.commitStatDesc;
            if (dl.vitalsNotObtain == "Y")
                vitalsNotObtainCheckBox.Checked = true;
            else
                vitalsNotObtainCheckBox.Checked = false;
            if (dl.schedAssess == "Y")
                schedAssessCheckBox.Checked = true;
            else
                schedAssessCheckBox.Checked = false;
            medDiagTextBox.Text = dl.medDiag;
            admPsyDiagTextBox.Text = dl.admPsyDiag;
            timeAcceptedDateTimePicker.Value = dl.timeAccepted ?? DateTime.Today;
            nurseNotifiedTextBox.Text = dl.nurseNotified;
            physOnCallTextBox.Text = dl.physOnCall;
            if (dl.timeAcceptedNA == "Y")
                timeAcceptedNACheckBox.Checked = true;
            transportDescTextBox.Text = dl.transportDesc;
            callEndedTimeTextBox.Text = dl.callEndedTime;
        }

        private void grpBxPatientInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
