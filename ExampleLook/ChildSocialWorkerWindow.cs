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
        DataLayer dl = new DataLayer();
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

        private void getChildSocial()
        {
            cSWSocialWorkerTextBox.Text = dl.cSWSocialWorker;
            cSWDateCompleteDateTimePicker.Value = dl.cSWDateComplete ?? DateTime.Today;
            assessStartDateDateTimePicker.Value = dl.assessStartDate ?? DateTime.Today;
            lastNameTextBox.Text = dl.lastName;
            firstNameTextBox.Text = dl.firstName;
            cSWCommInvTextBox.Text = dl.cSWCommInv;
            cSWCareDescPatTextBox.Text = dl.cSWCareDescPat;
            cSWPatDescElseTextBox.Text = dl.cSWPatDescElse;
            cSWLevFuncDifTypTextBox.Text = dl.aSWCurLevFuncDifTypFunc;
            cSWNaturePresProbTextBox.Text = dl.cSWNaturePresProb;
            cSWSrcReliabDescTextBox.Text = dl.cSWSrcReliabDesc;
            cSWSrcInfoTextBox.Text = dl.cSWSrcInfo;
            cSWLegStatDescTextBox.Text = dl.cSWLegStatDesc;
            cSWLegalGardDescTextBox.Text = dl.cSWLegalGardDesc;
            if (dl.cSWLegalGardNa == "Y")
                cSWLegalGardNaCheckBox.Checked = true;
            else
                cSWLegalGardNaCheckBox.Checked = false;
            cSWWeapPlanDescTextBox.Text = dl.cSWWeapPlanDesc;
            cSWPastSelfInjDescTextBox.Text = dl.cSWPastSelfInjDesc;
            cSWLethPriorMeanTextBox.Text = dl.cSWLethPriorMean;
            cSWDanDescTextBox.Text = dl.cSWDanDesc;
            if (dl.cSWDanOthInte == "Y")
                cSWDanOthInteCheckBox.Checked = true;
            else
                cSWDanOthInteCheckBox.Checked = false;
            if (dl.cSWDanOthAtt == "Y")
                cSWDanOthAttCheckBox.Checked = true;
            else
                cSWDanOthAttCheckBox.Checked = false;
            if (dl.cSWDanOthPlan == "Y")
                cSWDanOthPlanCheckBox.Checked = true;
            else
                cSWDanOthPlanCheckBox.Checked = false;
            if (dl.cSWDanOthIdea == "Y")
                cSWDanOthIdeaCheckBox.Checked = true;
            else
                cSWDanOthIdeaCheckBox.Checked = false;
            if (dl.cSWDanOthHist == "Y")
                cSWDanOthHistCheckBox.Checked = true;
            else
                cSWDanOthHistCheckBox.Checked = false;
            if (dl.cSWDanOthCurr == "Y")
                cSWDanOthCurrCheckBox.Checked = true;
            else
                cSWDanOthCurrCheckBox.Checked = false;
            if (dl.cSWDanOthNot == "Y")
                cSWDanOthNotCheckBox.Checked = true;
            else
                cSWDanOthNotCheckBox.Checked = false;
            if (dl.cSWDanSelfInte == "Y")
                cSWDanSelfInteCheckBox.Checked = true;
            else
                cSWDanSelfInteCheckBox.Checked = false;
            if (dl.cSWDanSelfAtt == "Y")
                cSWDanSelfAttCheckBox.Checked = true;
            else
                cSWDanSelfAttCheckBox.Checked = false;
            if (dl.cSWDanSelfPlan == "Y")
                cSWDanSelfPlanCheckBox.Checked = true;
            else
                cSWDanSelfPlanCheckBox.Checked = false;
            if (dl.cSWDanSelfIdea == "Y")
                cSWDanSelfIdeaCheckBox.Checked = true;
            else
                cSWDanSelfIdeaCheckBox.Checked = false;
            if (dl.cSWDanSelfHist == "Y")
                cSWDanSelfHistCheckBox.Checked = true;
            else
                cSWDanSelfHistCheckBox.Checked = false;
            if (dl.cSWDanSelfCurr == "Y")
                cSWDanSelfCurrCheckBox.Checked = true;
            else
                cSWDanSelfCurrCheckBox.Checked = false;
            if (dl.cSWDanSelfNot == "Y")
                cSWDanSelfNotCheckBox.Checked = true;
            else
                cSWDanSelfNotCheckBox.Checked = false;
            cSWVerifTimeTextBox.Text = dl.cSWVerifTime;
            cSWVerifDateDateTimePicker.Value = dl.cSWVerifDate ?? DateTime.Today;
            cSWVerifTextBox.Text = dl.cSWVerif;
            cSWRespTimePtTextBox.Text = dl.cSWRespTimePt;
            cSWRespDatePtDateTimePicker.Value = dl.cSWRespDatePt ?? DateTime.Today;
            cSWRespPtTextBox.Text = dl.cSWRespPt;
            cSWPsyAbuseReportDescTextBox.Text = dl.cSWPsyAbuseReportDesc;
            cSWPsyAbuseWitnessDescTextBox.Text = dl.cSWPsyAbuseWitnessDesc;
            cSWSexAbuseReportDescTextBox.Text = dl.cSWSexAbuseReportDesc;
            cSWSexAbuseWitnessDescTextBox.Text = dl.cSWSexAbuseWitnessDesc;
            cSWEmoNegAbuseReportDescTextBox.Text = dl.cSWEmoNegAbuseReportDesc;
            cSWEmoNegAbuseWitnessDescTextBox.Text = dl.cSWEmoNegAbuseWitnessDesc;
            cSWOthTraumaExpTextBox.Text = dl.cSWOthTraumaExp;
            cSWSexActPregNumChiTextBox.Text = dl.cSWSexActPregNumChi;
            cSWSexActPregTimesTextBox.Text = dl.cSWSexActPregTimes;
            cSWSexActNumPartTextBox.Text = dl.cSWSexActNumPart;
            cSWSexActAgeTextBox.Text = dl.cSWSexActAge;
            cSWSafeHomeDescTextBox.Text = dl.cSWSafeHomeDesc;
            cSWCarePlanDischTextBox.Text = dl.cSWCarePlanDisch;
            cSWRetHomeWhenTextBox.Text = dl.cSWRetHomeWhen;
            cSWRetHomeWhomTextBox.Text = dl.cSWRetHomeWhom;
            cSWHomePriorAdminTextBox.Text = dl.cSWHomePriorAdmin;
            cSWPrimeCaregiverTextBox.Text = dl.cSWPrimeCaregiver;
            cSWParentMaritStatDateDateTimePicker.Value = dl.cSWParentMaritStatDate ?? DateTime.Today;
            cSWSigRelatTextBox.Text = dl.cSWSigRelat;
            cSWVisitArrangeTextBox.Text = dl.cSWVisitArrange;
            cSWMemHelpPatDescTextBox.Text = dl.cSWMemHelpPatDesc;
            cSWRecommFamInvAfterTextBox.Text = dl.cSWRecommFamInvAfter;
            cSWLevFamInvPriorTextBox.Text = dl.cSWLevFamInvPrior;
            cSWFamSessDeclineReasonTextBox.Text = dl.cSWFamSessDeclineReason;
            cSWFamSessInviteTextBox.Text = dl.cSWFamSessInvite;
            cSWFamSessDateDateTimePicker.Value = dl.cSWFamSessDate ?? DateTime.Today;
            cSWRelatProbMemTextBox.Text = dl.cSWRelatProbMem;
            cSWHistCYSDescTextBox.Text = dl.cSWHistCYSDesc;
            cSWCarFeelPatDifBehavDescTextBox.Text = dl.cSWCarFeelPatDifBehavDesc;
            if (dl.cSWSubResultNone == "Y")
                cSWSubResultNoneCheckBox.Checked = true;
            else
                cSWSubResultNoneCheckBox.Checked = false;
            cSWSubResultOtherDescTextBox.Text = dl.cSWSubResultOtherDesc;
            if (dl.cSWSubResultOther == "Y")
                cSWSubResultOtherCheckBox.Checked = true;
            else
                cSWSubResultOtherCheckBox.Checked = false;
            if (dl.cSWSubResultPromisc == "Y")
                cSWSubResultPromiscCheckBox.Checked = true;
            else
                cSWSubResultPromiscCheckBox.Checked = false;
            if (dl.cSWSubResultWorkProb == "Y")
                cSWSubResultWorkProbCheckBox.Checked = true;
            else
                cSWSubResultWorkProbCheckBox.Checked = false;
            if (dl.cSWSubResultBlackout == "Y")
                cSWSubResultBlackoutCheckBox.Checked = true;
            else
                cSWSubResultBlackoutCheckBox.Checked = false;
            if (dl.cSWSubResultThoughtSelfHarm == "Y")
                cSWSubResultThoughtSelfHarmCheckBox.Checked = true;
            else
                cSWSubResultThoughtSelfHarmCheckBox.Checked = false;
            if (dl.cSWSubResultUnpaidBills == "Y")
                cSWSubResultUnpaidBillsCheckBox.Checked = true;
            else
                cSWSubResultUnpaidBillsCheckBox.Checked = false;
            if (dl.cSWSubResultRelatProb == "Y")
                cSWSubResultRelatProbCheckBox.Checked = true;
            else
                cSWSubResultRelatProbCheckBox.Checked = false;
            if (dl.cSWSubResultArrest == "Y")
                cSWSubResultArrestCheckBox.Checked = true;
            else
                cSWSubResultArrestCheckBox.Checked = false;
            cSWEffIneffTreatHistTextBox.Text = dl.cSWEffIneffTreatHist;
            cSWHosp30ContribReadminTextBox.Text = dl.cSWHosp30ContribReadmin;
            cSWHospPrevHelpCommInvoTextBox.Text = dl.cSWHospPrevHelpCommInvo;
            cSWPatPartTreatTextBox.Text = dl.cSWPatPartTreat;
            cSWHistHomSuicDescTextBox.Text = dl.cSWHistHomSuicDesc;
            cSWFamMemAbuImpDescTextBox.Text = dl.cSWFamMemAbuImpDesc;
            cSWInterventionsTextBox.Text = dl.cSWInterventions;
            cSWSubAbuseTreatHistTextBox.Text = dl.cSWSubAbuseTreatHist;
            cSWReasonUseTextBox.Text = dl.cSWReasonUse;
            cSWDrugChoiceTextBox.Text = dl.cSWDrugChoice;
            cSWHistArrestDescTextBox.Text = dl.cSWHistArrestDesc;
            cSWReferMadeDescTextBox.Text = dl.cSWReferMadeDesc;
            if (dl.cSWReferMade == "Y")
                cSWReferMadeCheckBox.Checked = true;
            else
                cSWReferMadeCheckBox.Checked = false;
            if (dl.cSWEduProvFam == "Y")
                cSWEduProvFamCheckBox.Checked = true;
            else
                cSWEduProvFamCheckBox.Checked = false;
            if (dl.cSWFamInformRecomm == "Y")
                cSWFamInformRecommCheckBox.Checked = true;
            else
                cSWFamInformRecommCheckBox.Checked = false;
            if (dl.cSWEduProvPat == "Y")
                cSWEduProvPatCheckBox.Checked = true;
            else
                cSWEduProvPatCheckBox.Checked = false;
            if (dl.cSWPatInformRecomm == "Y")
                cSWPatInformRecommCheckBox.Checked = true;
            else
                cSWPatInformRecommCheckBox.Checked = false;
            cSWSubAbuseRecommDescTextBox.Text = dl.cSWSubAbuseRecommDesc;
            if (dl.cSWSubAbuseRecommNA == "Y")
                cSWSubAbuseRecommNACheckBox.Checked = true;
            else
                cSWSubAbuseRecommNACheckBox.Checked = false;
            cSWOthLegIssDescTextBox.Text = dl.cSWOthLegIssDesc;
            cSWPatFeelClassmatesTextBox.Text = dl.cSWPatFeelClassmates;
            cSWPatFeelSchTeachTextBox.Text = dl.cSWPatFeelSchTeach;
            cSWNumSchoolAttTextBox.Text = dl.cSWNumSchoolAtt;
            cSWTimeCurrSchoolTextBox.Text = dl.cSWTimeCurrSchool;
            cSWCultOtherDescTextBox.Text = dl.cSWCultOtherDesc;
            cSWCultIssContribProbDescTextBox.Text = dl.cSWCultIssContribProbDesc;
            cSWChangeReligInvolvDescTextBox.Text = dl.cSWChangeReligInvolvDesc;
            cSWCurrStatedFeelBodyTextBox.Text = dl.cSWCurrStatedFeelBody;
            cSWEatDepBoredDescTextBox.Text = dl.cSWEatDepBoredDesc;
            cSWHistSigMedIssDescTextBox.Text = dl.cSWHistSigMedIssDesc;
            cSWChronPainDisabImpFunctDescTextBox.Text = dl.cSWChronPainDisabImpFunctDesc;
            cSWMedIssContribDescTextBox.Text = dl.cSWMedIssContribDesc;
            cSWParMilitDeployTextBox.Text = dl.cSWParMilitDeploy;
            cSWParMilitDescTextBox.Text = dl.cSWParMilitDesc;
            cSWWorkingFeelingsTextBox.Text = dl.cSWWorkingFeelings;
            cSWWorkingHoursWeekTextBox.Text = dl.cSWWorkingHoursWeek;
            cSWDetSuspensTruancyDescTextBox.Text = dl.cSWDetSuspensTruancyDesc;
            cSWSigChanSocAcaDescTextBox.Text = dl.cSWSigChanSocAcaDesc;
            cSWHowArriveSchedAppointTextBox.Text = dl.cSWHowArriveSchedAppoint;
            cSWPrefPharmTextBox.Text = dl.cSWPrefPharm;
            cSWObtMedTextBox.Text = dl.cSWObtMed;
            cSWMACommSuppServResponseTextBox.Text = dl.cSWMACommSuppServResponse;
            cSWMACommSuppServWhenTextBox.Text = dl.cSWMACommSuppServWhen;
            cSWAssessNeedTextBox.Text = dl.cSWAssessNeed;
            cSWStaffSigTimeTextBox.Text = dl.cSWStaffSigTime;
            cSWStaffSigDateDateTimePicker.Value = dl.cSWStaffSigDate ?? DateTime.Today;
            cSWPreDischTextBox.Text = dl.cSWPreDisch;
            cSWSWOtherDescTextBox.Text = dl.cSWSWOtherDesc;
            if (dl.cSWSWOther == "Y")
                cSWSWOtherCheckBox.Checked = true;
            else
                cSWSWOtherCheckBox.Checked = false;
            if (dl.cSWSWAftercare == "Y")
                cSWSWAftercareCheckBox.Checked = true;
            else
                cSWSWAftercareCheckBox.Checked = false;
            if (dl.cSWSWFamily == "Y")
                cSWSWFamilyCheckBox.Checked = true;
            else
                cSWSWFamilyCheckBox.Checked = false;
            if (dl.cSWSWIndiv == "Y")
                cSWSWIndivCheckBox.Checked = true;
            else
                cSWSWIndivCheckBox.Checked = false;
            if (dl.cSWSWGroup == "Y")
                cSWSWGroupCheckBox.Checked = true;
            else
                cSWSWGroupCheckBox.Checked = false;
            cSWClinConcRecommTextBox.Text = dl.cSWClinConcRecomm;
            if (dl.cSWRefNone == "Y")
                cSWRefNoneCheckBox.Checked = true;
            else
                cSWRefNoneCheckBox.Checked = false;
            cSWRefOtherDescTextBox.Text = dl.cSWRefOtherDesc;
            if (dl.cSWRefOther == "Y")
                cSWRefOtherCheckBox.Checked = true;
            else
                cSWRefOtherCheckBox.Checked = false;
            if (dl.cSWRefNeuro == "Y")
                cSWRefNeuroCheckBox.Checked = true;
            else
                cSWRefNeuroCheckBox.Checked = false;
            if (dl.cSWRefOutpatDA == "Y")
                cSWRefOutpatDACheckBox.Checked = true;
            else
                cSWRefOutpatDACheckBox.Checked = false;
            if (dl.cSWRefPCP == "Y")
                cSWRefPCPCheckBox.Checked = true;
            else
                cSWRefPCPCheckBox.Checked = false;
            if (dl.cSWRefInpatDA == "Y")
                cSWRefInpatDACheckBox.Checked = true;
            else
                cSWRefInpatDACheckBox.Checked = false;
            if (dl.cSWRefCMBCM == "Y")
                cSWRefCMBCMCheckBox.Checked = true;
            else
                cSWRefCMBCMCheckBox.Checked = false;
            if (dl.cSWRefMST == "Y")
                cSWRefMSTCheckBox.Checked = true;
            else
                cSWRefMSTCheckBox.Checked = false;
            if (dl.cSWRefFB == "Y")
                cSWRefFBCheckBox.Checked = true;
            else
                cSWRefFBCheckBox.Checked = false;
            if (dl.cSWRefBHRS == "Y")
                cSWRefBHRSCheckBox.Checked = true;
            else
                cSWRefBHRSCheckBox.Checked = false;
            if (dl.cSWRefRTF == "Y")
                cSWRefRTFCheckBox.Checked = true;
            else
                cSWRefRTFCheckBox.Checked = false;
            if (dl.cSWRefTFCCRR == "Y")
                cSWRefTFCCRRCheckBox.Checked = true;
            else
                cSWRefTFCCRRCheckBox.Checked = false;
            if (dl.cSWRefPHP == "Y")
                cSWRefPHPCheckBox.Checked = true;
            else
                cSWRefPHPCheckBox.Checked = false;
            if (dl.cSWRefPsychia == "Y")
                cSWRefPsychiaCheckBox.Checked = true;
            else
                cSWRefPsychiaCheckBox.Checked = false;
            if (dl.cSWRefOutpat == "Y")
                cSWRefOutpatCheckBox.Checked = true;
            else
                cSWRefOutpatCheckBox.Checked = false;
            if (dl.cSWBarNone == "Y")
                cSWBarNoneCheckBox.Checked = true;
            else
                cSWBarNoneCheckBox.Checked = false;
            cSWBarOtherDescTextBox.Text = dl.cSWBarOtherDesc;
            if (dl.cSWBarOther == "Y")
                cSWBarOtherCheckBox.Checked = true;
            else
                cSWBarOtherCheckBox.Checked = false;
            if (dl.cSWBarAbsFacSpecNeed == "Y")
                cSWBarAbsFacSpecNeedCheckBox.Checked = true;
            else
                cSWBarAbsFacSpecNeedCheckBox.Checked = false;
            if (dl.cSWBarHisNonComp == "Y")
                cSWBarHisNonCompCheckBox.Checked = true;
            else
                cSWBarHisNonCompCheckBox.Checked = false;
            if (dl.cSWBarHousing == "Y")
                cSWBarHousingCheckBox.Checked = true;
            else
                cSWBarHousingCheckBox.Checked = false;
            if (dl.cSWBarCostMed == "Y")
                cSWBarCostMedCheckBox.Checked = true;
            else
                cSWBarCostMedCheckBox.Checked = false;
            if (dl.cSWBarTransport == "Y")
                cSWBarTransportCheckBox.Checked = true;
            else
                cSWBarTransportCheckBox.Checked = false;
        }

        private void setChildSocial()
        {
            dl.cSWSocialWorker = cSWSocialWorkerTextBox.Text;
            dl.cSWDateComplete = cSWDateCompleteDateTimePicker.Value;
            dl.assessStartDate = assessStartDateDateTimePicker.Value;
            dl.lastName = lastNameTextBox.Text;
            dl.firstName = firstNameTextBox.Text;
            dl.cSWCommInv = cSWCommInvTextBox.Text;
            dl.cSWCareDescPat = cSWCareDescPatTextBox.Text;
            dl.cSWPatDescElse = cSWPatDescElseTextBox.Text;
            dl.cSWLevFuncDifTyp = cSWLevFuncDifTypTextBox.Text;
            dl.cSWNaturePresProb = cSWNaturePresProbTextBox.Text;
            dl.cSWSrcReliabDesc = cSWSrcReliabDescTextBox.Text;
            dl.cSWSrcInfo = cSWSrcInfoTextBox.Text;
            dl.cSWLegStatDesc = cSWLegStatDescTextBox.Text;
            dl.cSWLegalGardDesc = cSWLegalGardDescTextBox.Text;
            dl.cSWLegalGardNa = cSWLegalGardNaCheckBox.Checked ? "Y" : "N";
            dl.cSWWeapPlanDesc = cSWWeapPlanDescTextBox.Text;
            dl.cSWPastSelfInjDesc = cSWPastSelfInjDescTextBox.Text;
            dl.cSWLethPriorMean = cSWLethPriorMeanTextBox.Text;
            dl.cSWDanDesc = cSWDanDescTextBox.Text;
            dl.cSWDanOthInte = cSWDanOthInteCheckBox.Checked ? "Y" : "N";
            dl.cSWDanOthAtt = cSWDanOthAttCheckBox.Checked ? "Y" : "N";
            dl.cSWDanOthPlan = cSWDanOthPlanCheckBox.Checked ? "Y" : "N";
            dl.cSWDanOthIdea = cSWDanOthIdeaCheckBox.Checked ? "Y" : "N";
            dl.cSWDanOthHist = cSWDanOthHistCheckBox.Checked ? "Y" : "N";
            dl.cSWDanOthCurr = cSWDanOthCurrCheckBox.Checked ? "Y" : "N";
            dl.cSWDanOthNot = cSWDanOthNotCheckBox.Checked ? "Y" : "N";
            dl.cSWDanSelfInte = cSWDanSelfInteCheckBox.Checked ? "Y" : "N";
            dl.cSWDanSelfAtt = cSWDanSelfAttCheckBox.Checked ? "Y" : "N";
            dl.cSWDanSelfPlan = cSWDanSelfPlanCheckBox.Checked ? "Y" : "N";
            dl.cSWDanSelfIdea = cSWDanSelfIdeaCheckBox.Checked ? "Y" : "N";
            dl.cSWDanSelfHist = cSWDanSelfHistCheckBox.Checked ? "Y" : "N";
            dl.cSWDanSelfCurr = cSWDanSelfCurrCheckBox.Checked ? "Y" : "N";
            dl.cSWDanSelfNot = cSWDanSelfNotCheckBox.Checked ? "Y" : "N";
            dl.cSWVerifTime = cSWVerifTimeTextBox.Text;
            dl.cSWVerifDate = cSWVerifDateDateTimePicker.Value;
            dl.cSWVerif = cSWVerifTextBox.Text;
            dl.cSWRespTimePt = cSWRespTimePtTextBox.Text;
            dl.cSWRespDatePt = cSWRespDatePtDateTimePicker.Value;
            dl.cSWRespPt = cSWRespPtTextBox.Text;
            dl.cSWPsyAbuseReportDesc = cSWPsyAbuseReportDescTextBox.Text;
            dl.cSWPsyAbuseWitnessDesc = cSWPsyAbuseWitnessDescTextBox.Text;
            dl.cSWSexAbuseReportDesc = cSWSexAbuseReportDescTextBox.Text;
            dl.cSWSexAbuseWitnessDesc = cSWSexAbuseWitnessDescTextBox.Text;
            dl.cSWEmoNegAbuseReportDesc = cSWEmoNegAbuseReportDescTextBox.Text;
            dl.cSWEmoNegAbuseWitnessDesc = cSWEmoNegAbuseWitnessDescTextBox.Text;
            dl.cSWOthTraumaExp = cSWOthTraumaExpTextBox.Text;
            dl.cSWSexActPregNumChi = cSWSexActPregNumChiTextBox.Text;
            dl.cSWSexActPregTimes = cSWSexActPregTimesTextBox.Text;
            dl.cSWSexActNumPart = cSWSexActNumPartTextBox.Text;
            dl.cSWSexActAge = cSWSexActAgeTextBox.Text;
            dl.cSWSafeHomeDesc = cSWSafeHomeDescTextBox.Text;
            dl.cSWCarePlanDisch = cSWCarePlanDischTextBox.Text;
            dl.cSWRetHomeWhen = cSWRetHomeWhenTextBox.Text;
            dl.cSWRetHomeWhom = cSWRetHomeWhomTextBox.Text;
            dl.cSWHomePriorAdmin = cSWHomePriorAdminTextBox.Text;
            dl.cSWPrimeCaregiver = cSWPrimeCaregiverTextBox.Text;
            dl.cSWParentMaritStatDate = cSWParentMaritStatDateDateTimePicker.Value;
            dl.cSWSigRelat = cSWSigRelatTextBox.Text;
            dl.cSWVisitArrange = cSWVisitArrangeTextBox.Text;
            dl.cSWMemHelpPatDesc = cSWMemHelpPatDescTextBox.Text;
            dl.cSWRecommFamInvAfter = cSWRecommFamInvAfterTextBox.Text;
            dl.cSWLevFamInvPrior = cSWLevFamInvPriorTextBox.Text;
            dl.cSWFamSessDeclineReason = cSWFamSessDeclineReasonTextBox.Text;
            dl.cSWFamSessInvite = cSWFamSessInviteTextBox.Text;
            dl.cSWFamSessDate = cSWFamSessDateDateTimePicker.Value;
            dl.cSWRelatProbMem = cSWRelatProbMemTextBox.Text;
            dl.cSWHistCYSDesc = cSWHistCYSDescTextBox.Text;
            dl.cSWCarFeelPatDifBehavDesc = cSWCarFeelPatDifBehavDescTextBox.Text;
            dl.cSWSubResultNone = cSWSubResultNoneCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultOtherDesc = cSWSubResultOtherDescTextBox.Text;
            dl.cSWSubResultOther = cSWSubResultOtherCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultPromisc = cSWSubResultPromiscCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultWorkProb = cSWSubResultWorkProbCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultBlackout = cSWSubResultBlackoutCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultThoughtSelfHarm = cSWSubResultThoughtSelfHarmCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultUnpaidBills = cSWSubResultUnpaidBillsCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultRelatProb = cSWSubResultRelatProbCheckBox.Checked ? "Y" : "N";
            dl.cSWSubResultArrest = cSWSubResultArrestCheckBox.Checked ? "Y" : "N";
            dl.cSWEffIneffTreatHist = cSWEffIneffTreatHistTextBox.Text;
            dl.cSWHosp30ContribReadmin = cSWHosp30ContribReadminTextBox.Text;
            dl.cSWHospPrevHelpCommInvo = cSWHospPrevHelpCommInvoTextBox.Text;
            dl.cSWPatPartTreat = cSWPatPartTreatTextBox.Text;
            dl.cSWHistHomSuicDesc = cSWHistHomSuicDescTextBox.Text;
            dl.cSWFamMemAbuImpDesc = cSWFamMemAbuImpDescTextBox.Text;
            dl.cSWInterventions = cSWInterventionsTextBox.Text;
            dl.cSWSubAbuseTreatHist = cSWSubAbuseTreatHistTextBox.Text;
            dl.cSWReasonUse = cSWReasonUseTextBox.Text;
            dl.cSWDrugChoice = cSWDrugChoiceTextBox.Text;
            dl.cSWHistArrestDesc = cSWHistArrestDescTextBox.Text;
            dl.cSWReferMadeDesc = cSWReferMadeDescTextBox.Text;
            dl.cSWReferMade = cSWReferMadeCheckBox.Checked ? "Y" : "N";
            dl.cSWEduProvFam = cSWEduProvFamCheckBox.Checked ? "Y" : "N";
            dl.cSWFamInformRecomm = cSWFamInformRecommCheckBox.Checked ? "Y" : "N";
            dl.cSWEduProvPat = cSWEduProvPatCheckBox.Checked ? "Y" : "N";
            dl.cSWPatInformRecomm = cSWPatInformRecommCheckBox.Checked ? "Y" : "N";
            dl.cSWSubAbuseRecommDesc = cSWSubAbuseRecommDescTextBox.Text;
            dl.cSWSubAbuseRecommNA = cSWSubAbuseRecommNACheckBox.Checked ? "Y" : "N";
            dl.cSWOthLegIssDesc = cSWOthLegIssDescTextBox.Text;
            dl.cSWPatFeelClassmates = cSWPatFeelClassmatesTextBox.Text;
            dl.cSWPatFeelSchTeach = cSWPatFeelSchTeachTextBox.Text;
            dl.cSWNumSchoolAtt = cSWNumSchoolAttTextBox.Text;
            dl.cSWTimeCurrSchool = cSWTimeCurrSchoolTextBox.Text;
            dl.cSWCultOtherDesc = cSWCultOtherDescTextBox.Text;
            dl.cSWCultIssContribProbDesc = cSWCultIssContribProbDescTextBox.Text;
            dl.cSWChangeReligInvolvDesc = cSWChangeReligInvolvDescTextBox.Text;
            dl.cSWCurrStatedFeelBody = cSWCurrStatedFeelBodyTextBox.Text;
            dl.cSWEatDepBoredDesc = cSWEatDepBoredDescTextBox.Text;
            dl.cSWHistSigMedIssDesc = cSWHistSigMedIssDescTextBox.Text;
            dl.cSWChronPainDisabImpFunctDesc = cSWChronPainDisabImpFunctDescTextBox.Text;
            dl.cSWMedIssContribDesc = cSWMedIssContribDescTextBox.Text;
            dl.cSWParMilitDeploy = cSWParMilitDeployTextBox.Text;
            dl.cSWParMilitDesc = cSWParMilitDescTextBox.Text;
            dl.cSWWorkingFeelings = cSWWorkingFeelingsTextBox.Text;
            dl.cSWWorkingHoursWeek = cSWWorkingHoursWeekTextBox.Text;
            dl.cSWDetSuspensTruancyDesc = cSWDetSuspensTruancyDescTextBox.Text;
            dl.cSWSigChanSocAcaDesc = cSWSigChanSocAcaDescTextBox.Text;
            dl.cSWHowArriveSchedAppoint = cSWHowArriveSchedAppointTextBox.Text;
            dl.cSWPrefPharm = cSWPrefPharmTextBox.Text;
            dl.cSWObtMed = cSWObtMedTextBox.Text;
            dl.cSWMACommSuppServResponse = cSWMACommSuppServResponseTextBox.Text;
            dl.cSWMACommSuppServWhen = cSWMACommSuppServWhenTextBox.Text;
            dl.cSWAssessNeed = cSWAssessNeedTextBox.Text;
            dl.cSWStaffSigTime = cSWStaffSigTimeTextBox.Text;
            dl.cSWStaffSigDate = cSWStaffSigDateDateTimePicker.Value;
            dl.cSWPreDisch = cSWPreDischTextBox.Text;
            dl.cSWSWOtherDesc = cSWSWOtherDescTextBox.Text;
            dl.cSWSWOther = cSWSWOtherCheckBox.Checked ? "Y" : "N";
            dl.cSWSWAftercare = cSWSWAftercareCheckBox.Checked ? "Y" : "N";
            dl.cSWSWFamily = cSWSWFamilyCheckBox.Checked ? "Y" : "N";
            dl.cSWSWIndiv = cSWSWIndivCheckBox.Checked ? "Y" : "N";
            dl.cSWSWGroup = cSWSWGroupCheckBox.Checked ? "Y" : "N";
            dl.cSWClinConcRecomm = cSWClinConcRecommTextBox.Text;
            dl.cSWRefNone = cSWRefNoneCheckBox.Checked ? "Y" : "N";
            dl.cSWRefOtherDesc = cSWRefOtherDescTextBox.Text;
            dl.cSWRefOther = cSWRefOtherCheckBox.Checked ? "Y" : "N";
            dl.cSWRefNeuro = cSWRefNeuroCheckBox.Checked ? "Y" : "N";
            dl.cSWRefOutpatDA = cSWRefOutpatDACheckBox.Checked ? "Y" : "N";
            dl.cSWRefPCP = cSWRefPCPCheckBox.Checked ? "Y" : "N";
            dl.cSWRefInpatDA = cSWRefInpatDACheckBox.Checked ? "Y" : "N";
            dl.cSWRefCMBCM = cSWRefCMBCMCheckBox.Checked ? "Y" : "N";
            dl.cSWRefMST = cSWRefMSTCheckBox.Checked ? "Y" : "N";
            dl.cSWRefFB = cSWRefFBCheckBox.Checked ? "Y" : "N";
            dl.cSWRefBHRS = cSWRefBHRSCheckBox.Checked ? "Y" : "N";
            dl.cSWRefRTF = cSWRefRTFCheckBox.Checked ? "Y" : "N";
            dl.cSWRefTFCCRR = cSWRefTFCCRRCheckBox.Checked ? "Y" : "N";
            dl.cSWRefPHP = cSWRefPHPCheckBox.Checked ? "Y" : "N";
            dl.cSWRefPsychia = cSWRefPsychiaCheckBox.Checked ? "Y" : "N";
            dl.cSWRefOutpat = cSWRefOutpatCheckBox.Checked ? "Y" : "N";
            dl.cSWBarNone = cSWBarNoneCheckBox.Checked ? "Y" : "N";
            dl.cSWBarOtherDesc = cSWBarOtherDescTextBox.Text;
            dl.cSWBarOther = cSWBarOtherCheckBox.Checked ? "Y" : "N";
            dl.cSWBarAbsFacSpecNeed = cSWBarAbsFacSpecNeedCheckBox.Checked ? "Y" : "N";
            dl.cSWBarHisNonComp = cSWBarHisNonCompCheckBox.Checked ? "Y" : "N";
            dl.cSWBarHousing = cSWBarHousingCheckBox.Checked ? "Y" : "N";
            dl.cSWBarCostMed = cSWBarCostMedCheckBox.Checked ? "Y" : "N";
            dl.cSWBarTransport = cSWBarTransportCheckBox.Checked ? "Y" : "N";
        }

        private void cSWPsyAbuseReportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cSWSubResultOtherDescTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
