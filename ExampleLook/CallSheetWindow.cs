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
        patient_admission dl = new patient_admission();
        public CallSheetWindow()
        {
            InitializeComponent();
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
            //lastNameTextBox.Text = dl.LastName;
            //if (dl.Gender == 'f')
            //    genderComboBox.Text = "Female";
            //dOBDateTimePicker.Text = dl.DOB.ToString();
            //if (dl.PresentSuicide == 'y')
            //    presentSuicideCheckBox.Checked = true;
        }

        private void grpBxCommitStat_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setCallSheetInfo();
            //this.getCallSheetInfo();//gets the pat info
            //dl oldPatient = new Patient();//create old pat
            //dl.insert();//updates the new patient
            //setCallSheetInfo();//sets the patient info
            //dl.read();//reads the new pat
            //checkChange(oldPatient);//checks the change
            //resetButtons();//restes the button

            //dl.DOB = dOBDateTimePicker.Value;
            //if (genderComboBox.Text == "Male")
            //{
            //    dl.Gender = 'm';
            //}
            //else if (genderComboBox.Text == "Female")
            //{
            //    dl.Gender = 'm';
            //}
            //dl.LastName = lastNameTextBox.Text;
            //if (presentSuicideCheckBox.Checked)
            //    dl.PresentSuicide = 'y';
            //else
            //    dl.PresentSuicide = 'n';

            //MessageBox.Show(dl.DOB.ToString() + " " + dl.Gender + " " + dl.LastName + " " + dl.PresentSuicide);
        }

        private void grpBxPatientInfo_Enter(object sender, EventArgs e)
        {

        }

        private void getCallSheetInfo()
        {
            dl.CallerFName = callerFNameTextBox.Text;
            dl.CallerZip = callerZipTextBox.Text;
            dl.CallerLName = callerLNameTextBox.Text;
            dl.CallerState = callerStateTextBox.Text;
            dl.CallerRefName = callerRefNameTextBox.Text;
            dl.CallerAgency = callerAgencyTextBox.Text;
            dl.CallerCity = callerCityTextBox.Text;
            dl.Phone = phoneTextBox.Text;
            dl.County = countyTextBox.Text;
            dl.Zip = zipTextBox.Text;
            dl.State = stateTextBox.Text;
            dl.City = cityTextBox.Text;
            dl.Address = addressTextBox.Text;
            dl.SSN = sSNTextBox.Text;
            dl.DOB = dOBDateTimePicker.Value;
            dl.Age = ageTextBox.Text;
            dl.LastName = lastNameTextBox.Text;
            dl.MiddleInitial = middleInitialTextBox.Text;
            dl.FirstName = firstNameTextBox.Text;
            dl.MedConcerns = medConcernsTextBox.Text;
            dl.CurrentOutpat = currentOutpatTextBox.Text;
            dl.PrevTx = prevTxTextBox.Text;
            dl.SubMisuse = subMisuseTextBox.Text;
            dl.LethalMeans = lethalMeansTextBox.Text;
            dl.PresentProb = presentProbTextBox.Text;
            dl.R = rTextBox.Text;
            dl.P = pTextBox.Text;
            dl.T = tTextBox.Text;
            dl.BloodPressure = bloodPressureTextBox.Text;
            dl.IQ = int.Parse(iQTextBox.Text);
            dl.PrimInsPhone = primInsPhoneTextBox.Text;
            dl.PrimInsName = primInsNameTextBox.Text;
            dl.NurseIntake = nurseIntakeTextBox.Text;
            dl.SecInsPhone = secInsPhoneTextBox.Text;
            dl.SecInsName = secInsNameTextBox.Text;
            dl.CallEnded = callEndedDateTimePicker.Value;
            dl.CallCollectedBy = callCollectedByTextBox.Text;
            dl.CallNotes = callNotesTextBox.Text;
            dl.SchedAssessTime = schedAssessTimeTextBox.Text;
            dl.SchedAssessDate = schedAssessDateDateTimePicker.Value;
            dl.CallStarted = callStartedDateTimePicker.Value;
            dl.CallerPhone = callerPhoneTextBox.Text;
            dl.PresentOtherDesc = presentOtherDescTextBox.Text;
            if (presentOtherCheckBox.Checked)
                dl.PresentOther = "Y";
            if (presentPsychosisCheckBox.Checked)
                dl.PresentPsychosis = "Y";
            if (presentHomicideCheckBox.Checked)
                dl.PresentHomicide = "Y";
            if (presentSelfHarmCheckBox.Checked)
                dl.PresentSelfHarm = "Y";
            if (presentSuicideCheckBox.Checked)
                dl.PresentSuicide = "Y";
            if (emergencyContactCheckBox.Checked)
                dl.EmergencyContact = "Y";
            dl.EmergencyContactLName = emergencyContactLNameTextBox.Text;
            dl.EmergencyContactFName = emergencyContactFNameTextBox.Text;
            dl.PowAttorneyPhone = powAttorneyPhoneTextBox.Text;
            dl.PowAttorneyRelat = powAttorneyRelatTextBox.Text;
            dl.PowAttorneyLName = powAttorneyLNameTextBox.Text;
            dl.PowAttorneyFName = powAttorneyFNameTextBox.Text;
            dl.GuardianshipPhone = guardianshipPhoneTextBox.Text;
            dl.GuardianshipRelat = guardianshipRelatTextBox.Text;
            dl.GuardianshipFName = guardianshipFNameTextBox.Text;
            dl.GuardianshipLName = guardianshipLNameTextBox.Text;
            dl.MedEduRightsRelat = medEduRightsRelatTextBox.Text;
            dl.MedEduRightsPhone = medEduRightsPhoneTextBox.Text;
            dl.MedEduRightsLName = medEduRightsLNameTextBox.Text;
            dl.MedEduRightsFName = medEduRightsFNameTextBox.Text;
            dl.EmergencyContactPhone = emergencyContactPhoneTextBox.Text;
            dl.EmergencyContactRelat = emergencyContactRelatTextBox.Text;
            dl.SexVictimDesc = sexVictimDescTextBox.Text;
            dl.PrefLangDesc = prefLangDescTextBox.Text;
            dl.SexAggressDesc = sexAggressDescTextBox.Text;
            dl.CallStartedTime = callStartedTimeTextBox.Text;
            dl.CommitStatDesc = commitStatDescTextBox.Text;
            if (vitalsNotObtainCheckBox.Checked)
                dl.VitalsNotObtain = "Y";
            if (schedAssessCheckBox.Checked)
                dl.SchedAssess = "Y";
            dl.MedDiag = medDiagTextBox.Text;
            dl.AdmPsyDiag = admPsyDiagTextBox.Text;
            dl.TimeAccepted = timeAcceptedDateTimePicker.Value;
            dl.NurseNotified = nurseNotifiedTextBox.Text;
            dl.PhysOnCall = physOnCallTextBox.Text;
            if (timeAcceptedNACheckBox.Checked)
                dl.TimeAcceptedNA = "Y";
            dl.TransportDesc = transportDescTextBox.Text;
            dl.CallEndedTime = callEndedTimeTextBox.Text;
        }

        private void setCallSheetInfo()
        {
            using (CPCAppEntities context = new CPCAppEntities())
            {
                callerFNameTextBox.Text = dl.CallerFName;
                callerZipTextBox.Text = dl.CallerZip;
                callerLNameTextBox.Text = dl.CallerLName;
                callerStateTextBox.Text = dl.CallerState;
                callerRefNameTextBox.Text = dl.CallerRefName;
                callerAgencyTextBox.Text = dl.CallerAgency;
                callerCityTextBox.Text = dl.CallerCity;
                phoneTextBox.Text = dl.Phone;
                countyTextBox.Text = dl.County;
                zipTextBox.Text = dl.Zip;
                stateTextBox.Text = dl.State;
                cityTextBox.Text = dl.City;
                addressTextBox.Text = dl.Address;
                sSNTextBox.Text = dl.SSN;
                dOBDateTimePicker.Value = dl.DOB ?? DateTime.Today;
                ageTextBox.Text = dl.Age;
                lastNameTextBox.Text = dl.LastName;
                middleInitialTextBox.Text = dl.MiddleInitial;
                firstNameTextBox.Text = dl.FirstName;
                medConcernsTextBox.Text = dl.MedConcerns;
                currentOutpatTextBox.Text = dl.CurrentOutpat;
                prevTxTextBox.Text = dl.PrevTx;
                subMisuseTextBox.Text = dl.SubMisuse;
                lethalMeansTextBox.Text = dl.LethalMeans;
                presentProbTextBox.Text = dl.PresentProb;
                rTextBox.Text = dl.R;
                pTextBox.Text = dl.P;
                tTextBox.Text = dl.T;
                bloodPressureTextBox.Text = dl.BloodPressure;
                iQTextBox.Text = dl.IQ.ToString();
                primInsPhoneTextBox.Text = dl.PrimInsPhone;
                primInsNameTextBox.Text = dl.PrimInsName;
                nurseIntakeTextBox.Text = dl.NurseIntake;
                secInsPhoneTextBox.Text = dl.SecInsPhone;
                secInsNameTextBox.Text = dl.SecInsName;
                callEndedDateTimePicker.Value = dl.CallEnded ?? DateTime.Today;
                callCollectedByTextBox.Text = dl.CallCollectedBy;
                callNotesTextBox.Text = dl.CallNotes;
                schedAssessTimeTextBox.Text = dl.SchedAssessTime;
                schedAssessDateDateTimePicker.Value = dl.SchedAssessDate ?? DateTime.Today;
                callStartedDateTimePicker.Value = dl.CallStarted ?? DateTime.Today;
                callerPhoneTextBox.Text = dl.CallerPhone;
                presentOtherDescTextBox.Text = dl.PresentOtherDesc;
                if (dl.PresentOther == "Y")
                    presentOtherCheckBox.Checked = true;
                if (dl.PresentPsychosis == "Y")
                    presentPsychosisCheckBox.Checked = true;
                if (dl.PresentHomicide == "Y")
                    presentHomicideCheckBox.Checked = true;
                if (dl.PresentSelfHarm == "Y")
                    presentSelfHarmCheckBox.Checked = true;
                if (dl.PresentSuicide == "Y")
                    presentSuicideCheckBox.Checked = true;
                if (dl.EmergencyContact == "Y")
                    emergencyContactCheckBox.Checked = true;
                emergencyContactLNameTextBox.Text = dl.EmergencyContactLName;
                emergencyContactFNameTextBox.Text = dl.EmergencyContactFName;
                powAttorneyPhoneTextBox.Text = dl.PowAttorneyPhone;
                powAttorneyRelatTextBox.Text = dl.PowAttorneyRelat;
                powAttorneyLNameTextBox.Text = dl.PowAttorneyLName;
                powAttorneyFNameTextBox.Text = dl.PowAttorneyFName;
                guardianshipPhoneTextBox.Text = dl.GuardianshipPhone;
                guardianshipRelatTextBox.Text = dl.GuardianshipRelat;
                guardianshipFNameTextBox.Text = dl.GuardianshipFName;
                guardianshipLNameTextBox.Text = dl.GuardianshipLName;
                medEduRightsRelatTextBox.Text = dl.MedEduRightsRelat;
                medEduRightsPhoneTextBox.Text = dl.MedEduRightsPhone;
                medEduRightsLNameTextBox.Text = dl.MedEduRightsLName;
                medEduRightsFNameTextBox.Text = dl.MedEduRightsFName;
                emergencyContactPhoneTextBox.Text = dl.EmergencyContactPhone;
                emergencyContactRelatTextBox.Text = dl.EmergencyContactRelat;
                sexVictimDescTextBox.Text = dl.SexVictimDesc;
                prefLangDescTextBox.Text = dl.PrefLangDesc;
                sexAggressDescTextBox.Text = dl.SexAggressDesc;
                callStartedTimeTextBox.Text = dl.CallStartedTime;
                commitStatDescTextBox.Text = dl.CommitStatDesc;
                if (dl.VitalsNotObtain == "Y")
                    vitalsNotObtainCheckBox.Checked = true;
                if (dl.SchedAssess == "Y")
                    schedAssessCheckBox.Checked = true;
                medDiagTextBox.Text = dl.MedDiag;
                admPsyDiagTextBox.Text = dl.AdmPsyDiag;
                timeAcceptedDateTimePicker.Value = dl.TimeAccepted ?? DateTime.Today;
                nurseNotifiedTextBox.Text = dl.NurseNotified;
                physOnCallTextBox.Text = dl.PhysOnCall;
                if (dl.TimeAcceptedNA == "Y")
                    timeAcceptedNACheckBox.Checked = true;
                transportDescTextBox.Text = dl.TransportDesc;
                callEndedTimeTextBox.Text = dl.CallEndedTime;

                context.patient_admission.Add(dl);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString(), ex);
                }
            }
        }
    }
}
