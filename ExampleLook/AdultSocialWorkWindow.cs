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
        DataLayer dl = new DataLayer();
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

        private void setAdultSocialWork()
        {
            dl.aSWAssignWorker = aSWAssignWorkerTextBox.Text;
            dl.powAttorneyLName = powAttorneyLNameTextBox.Text;
            dl.powAttorneyFName = powAttorneyFNameTextBox.Text;
            dl.guardianshipLName = guardianshipLNameTextBox.Text;
            dl.guardianshipFName = guardianshipFNameTextBox.Text;
            dl.lastName = lastNameTextBox.Text;
            dl.firstName = firstNameTextBox.Text;
            dl.aSWDateComplete = aSWDateCompleteDateTimePicker.Value;
            dl.assessStartDate = assessStartDateDateTimePicker.Value;
            dl.aSWCommInvolve = aSWCommInvolveTextBox.Text;
            dl.aSWFamSupDescPat = aSWFamSupDescPatTextBox.Text;
            dl.aSWPatDescSelfSomeone = aSWPatDescSelfSomeoneTextBox.Text;
            dl.aSWCurLevFuncDifTypFunc = aSWCurLevFuncDifTypFuncTextBox.Text;
            dl.aSWNaturePresProb = aSWNaturePresProbTextBox.Text;
            dl.aSWReliableSrcDesc = aSWReliableSrcDescTextBox.Text;
            dl.aSWSrcInfo = aSWSrcInfoTextBox.Text;
            dl.aSWLegStatDesc = aSWLegStatDescTextBox.Text;
            dl.aSWDangerSelfIntent = aSWDangerSelfIntentCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerSelfAttempt = aSWDangerSelfAttemptCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerSelfPlan = aSWDangerSelfPlanCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerSelfIdeation = aSWDangerSelfIdeationCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerSelfHistory = aSWDangerSelfHistoryCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerSelfCurrent = aSWDangerSelfCurrentCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerSelfNotPres = aSWDangerSelfNotPresCheckBox.Checked ? "Y" : "N";
            dl.aSWWeaponLethMeansRemovePlan = aSWWeaponLethMeansRemovePlanTextBox.Text;
            dl.aSWPastSelfInjDesc = aSWPastSelfInjDescTextBox.Text;
            dl.aSWLethPriorMeans = aSWLethPriorMeansTextBox.Text;
            dl.aSWDangerDesc = aSWDangerDescTextBox.Text;
            dl.aSWDangerOthersNotPres = aSWDangerOthersNotPresCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerOthersIntent = aSWDangerOthersIntentCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerOthersAttempt = aSWDangerOthersAttemptCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerOthersPlan = aSWDangerOthersPlanCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerOthersIdeation = aSWDangerOthersIdeationCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerOthersHistory = aSWDangerOthersHistoryCheckBox.Checked ? "Y" : "N";
            dl.aSWDangerOthersCurrent = aSWDangerOthersCurrentCheckBox.Checked ? "Y" : "N";
            dl.aSWVerifyTime = aSWVerifyTimeTextBox.Text;
            dl.aSWVerifyDate = aSWVerifyDateDateTimePicker.Value;
            dl.aSWVerify = aSWVerifyTextBox.Text;
            dl.aSWResponsePatTime = aSWResponsePatTimeTextBox.Text;
            dl.aSWResponsePatDate = aSWResponsePatDateDateTimePicker.Value;
            dl.aSWResponsePat = aSWResponsePatTextBox.Text;
            dl.aSWEmoNegAbuseReportedDesc = aSWEmoNegAbuseReportedDescTextBox.Text;
            dl.aSWEmoNegAbuseWitnessDesc = aSWEmoNegAbuseWitnessDescTextBox.Text;
            dl.aSWPhsyAbuseReportDesc = aSWPhsyAbuseReportDescTextBox.Text;
            dl.aSWPhsyAbuseWitnessDesc = aSWPhsyAbuseWitnessDescTextBox.Text;
            dl.aSWSexAbuseReportDesc = aSWSexAbuseReportDescTextBox.Text;
            dl.aSWSexAbuseWitnessDesc = aSWSexAbuseWitnessDescTextBox.Text;
            dl.aSWOtherTraumaExp = aSWOtherTraumaExpTextBox.Text;
            dl.aSWTermPregDesc = aSWTermPregDescTextBox.Text;
            dl.aSWDateChange = aSWDateChangeDateTimePicker.Value;
            dl.aSWSafeHomeDesc = aSWSafeHomeDescTextBox.Text;
            dl.aSWHomePlanDisch = aSWHomePlanDischTextBox.Text;
            dl.aSWRetHomeWhen = aSWRetHomeWhenTextBox.Text;
            dl.aSWRetHomeWhom = aSWRetHomeWhomTextBox.Text;
            dl.aSWHomePrior = aSWHomePriorTextBox.Text;
            dl.aSWRecFamInvolve = aSWRecFamInvolveTextBox.Text;
            dl.aSWFamDeclineReason = aSWFamDeclineReasonTextBox.Text;
            dl.aSWFamSessInvite = aSWFamSessInviteTextBox.Text;
            dl.aSWDateFamSess = aSWDateFamSessDateTimePicker.Value;
            dl.aSWRelatProb = aSWRelatProbTextBox.Text;
            dl.aSWMemHelpfulDesc = aSWMemHelpfulDescTextBox.Text;
            dl.aSWPriorFamInvolve = aSWPriorFamInvolveTextBox.Text;
            dl.aSWDvlpExplain = aSWDvlpExplainTextBox.Text;
            dl.aSWDvlpOtherDesc = aSWDvlpOtherDescTextBox.Text;
            dl.aSWDvlpOther = aSWDvlpOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWDvlpHoardCollect = aSWDvlpHoardCollectCheckBox.Checked ? "Y" : "N";
            dl.aSWDvlpCleanOrg = aSWDvlpCleanOrgCheckBox.Checked ? "Y" : "N";
            dl.aSWDvlpEmoEat = aSWDvlpEmoEatCheckBox.Checked ? "Y" : "N";
            dl.aSWDvlpShopping = aSWDvlpShoppingCheckBox.Checked ? "Y" : "N";
            dl.aSWDvlpGambling = aSWDvlpGamblingCheckBox.Checked ? "Y" : "N";
            dl.aSWDvlpNone = aSWDvlpNoneCheckBox.Checked ? "Y" : "N";
            dl.aSWEffIneffTreatment = aSWEffIneffTreatmentTextBox.Text;
            dl.aSWHospPrevRemainComm = aSWHospPrevRemainCommTextBox.Text;
            dl.aSWHistHomSuicDesc = aSWHistHomSuicDescTextBox.Text;
            dl.aSWProbImpactFamDesc = aSWProbImpactFamDescTextBox.Text;
            dl.aSWOtherLegalDesc = aSWOtherLegalDescTextBox.Text;
            dl.aSWHistArrestDesc = aSWHistArrestDescTextBox.Text;
            dl.aSWHighestEduComplete = aSWHighestEduCompleteTextBox.Text;
            dl.aSWSchoolStressDesc = aSWSchoolStressDescTextBox.Text;
            dl.aSWCurrSchoolWhere = aSWCurrSchoolWhereTextBox.Text;
            dl.auditSubComplTotal = auditSubComplTotalTextBox.Text;
            dl.aSWSubAbuseResultNone = aSWSubAbuseResultNoneCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultOtherDesc = aSWSubAbuseResultOtherDescTextBox.Text;
            dl.aSWSubAbuseResultOther = aSWSubAbuseResultOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultPromis = aSWSubAbuseResultPromisCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultWorkProb = aSWSubAbuseResultWorkProbCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultBlackout = aSWSubAbuseResultBlackoutCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultThoughtSelfHarm = aSWSubAbuseResultThoughtSelfHarmCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultUnpBills = aSWSubAbuseResultUnpBillsCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultRelatProb = aSWSubAbuseResultRelatProbCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseResultArrest = aSWSubAbuseResultArrestCheckBox.Checked ? "Y" : "N";
            dl.aSWSubAbuseNA = aSWSubAbuseNACheckBox.Checked ? "Y" : "N";
            dl.aSWReferMadeDesc = aSWReferMadeDescTextBox.Text;
            dl.aSWReferMade = aSWReferMadeCheckBox.Checked ? "Y" : "N";
            dl.aSWEduProvPat = aSWEduProvPatCheckBox.Checked ? "Y" : "N";
            dl.aSWPatInformRecom = aSWPatInformRecomCheckBox.Checked ? "Y" : "N";
            dl.aSWRecomDesc = aSWRecomDescTextBox.Text;
            dl.aSWRecom = aSWRecomCheckBox.Checked ? "Y" : "N";
            dl.aSWInterventionOtherDesc = aSWInterventionOtherDescTextBox.Text;
            dl.aSWInterventionOther = aSWInterventionOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWAdvAbstain = aSWAdvAbstainCheckBox.Checked ? "Y" : "N";
            dl.aSWMotDisc = aSWMotDiscCheckBox.Checked ? "Y" : "N";
            dl.aSWDiscSeverity = aSWDiscSeverityCheckBox.Checked ? "Y" : "N";
            dl.aSWDiscNegCons = aSWDiscNegConsCheckBox.Checked ? "Y" : "N";
            dl.aSWFeedback = aSWFeedbackCheckBox.Checked ? "Y" : "N";
            dl.aSWSubTreatHistDesc = aSWSubTreatHistDescTextBox.Text;
            dl.aSWSubTreatHist = aSWSubTreatHistCheckBox.Checked ? "Y" : "N";
            dl.aSWBenefitUse = aSWBenefitUseTextBox.Text;
            dl.aSWDrugChoice = aSWDrugChoiceTextBox.Text;
            dl.aSWMilSigEvents = aSWMilSigEventsTextBox.Text;
            dl.aSWMilDischar = aSWMilDischarTextBox.Text;
            dl.aSWMilDates = aSWMilDatesTextBox.Text;
            dl.aSWMilBranch = aSWMilBranchTextBox.Text;
            dl.aSWSrcIncome = aSWSrcIncomeTextBox.Text;
            dl.aSWAvgMonIncome = aSWAvgMonIncomeTextBox.Text;
            dl.aSWFeelCurrWorkDesc = aSWFeelCurrWorkDescTextBox.Text;
            dl.aSWFeelCurrWork = aSWFeelCurrWorkCheckBox.Checked ? "Y" : "N";
            dl.aSWWeNeedKnowDesc = aSWWeNeedKnowDescTextBox.Text;
            dl.aSWCultIssContribDesc = aSWCultIssContribDescTextBox.Text;
            dl.aSWCurrReligInvo = aSWCurrReligInvoTextBox.Text;
            dl.aSWChronDisabImpFunctDesc = aSWChronDisabImpFunctDescTextBox.Text;
            dl.aSWHistSigMedIssDesc = aSWHistSigMedIssDescTextBox.Text;
            dl.aSWMedIssContribDesc = aSWMedIssContribDescTextBox.Text;
            dl.aSWFinanceStressDesc = aSWFinanceStressDescTextBox.Text;
            dl.aSWObtMedNeedDesc = aSWObtMedNeedDescTextBox.Text;
            dl.aSWObtMedNeed = aSWObtMedNeedCheckBox.Checked ? "Y" : "N";
            dl.aSWObtMedIncome = aSWObtMedIncomeCheckBox.Checked ? "Y" : "N";
            dl.aSWObtMedTrans = aSWObtMedTransCheckBox.Checked ? "Y" : "N";
            dl.aSWMAPartCommSuppResp = aSWMAPartCommSuppRespTextBox.Text;
            dl.aSWMAPartCommSuppWhen = aSWMAPartCommSuppWhenTextBox.Text;
            dl.aSWReadmOtherDesc = aSWReadmOtherDescTextBox.Text;
            dl.aSWReadmOther = aSWReadmOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWReadmCompli = aSWReadmCompliCheckBox.Checked ? "Y" : "N";
            dl.aSWReadmPriorAuthor = aSWReadmPriorAuthorCheckBox.Checked ? "Y" : "N";
            dl.aSWReadmMedStab = aSWReadmMedStabCheckBox.Checked ? "Y" : "N";
            dl.aSWReadmNA = aSWReadmNACheckBox.Checked ? "Y" : "N";
            dl.aSWCareNone = aSWCareNoneCheckBox.Checked ? "Y" : "N";
            dl.aSWCareOtherDesc = aSWCareOtherDescTextBox.Text;
            dl.aSWCareOther = aSWCareOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWCareAcuteMed = aSWCareAcuteMedCheckBox.Checked ? "Y" : "N";
            dl.aSWCareTrans = aSWCareTransCheckBox.Checked ? "Y" : "N";
            dl.aSWCarePetsUnsup = aSWCarePetsUnsupCheckBox.Checked ? "Y" : "N";
            dl.aSWCareHouse = aSWCareHouseCheckBox.Checked ? "Y" : "N";
            dl.aSWCareHIstNonComp = aSWCareHIstNonCompCheckBox.Checked ? "Y" : "N";
            dl.aSWArrSchedNeedDesc = aSWArrSchedNeedDescTextBox.Text;
            dl.aSWArrSchedNeed = aSWArrSchedNeedCheckBox.Checked ? "Y" : "N";
            dl.aSWArrSchedMATP = aSWArrSchedMATPCheckBox.Checked ? "Y" : "N";
            dl.aSWArrSchedFamFri = aSWArrSchedFamFriCheckBox.Checked ? "Y" : "N";
            dl.aSWArrSchedPersVeh = aSWArrSchedPersVehCheckBox.Checked ? "Y" : "N";
            dl.aSWPrelimDischargePlan = aSWPrelimDischargePlanTextBox.Text;
            dl.aSWRoleOtherDesc = aSWRoleOtherDescTextBox.Text;
            dl.aSWRoleOther = aSWRoleOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWRoleAftercare = aSWRoleAftercareCheckBox.Checked ? "Y" : "N";
            dl.aSWRoleFamTher = aSWRoleFamTherCheckBox.Checked ? "Y" : "N";
            dl.aSWRoleIndivTher = aSWRoleIndivTherCheckBox.Checked ? "Y" : "N";
            dl.aSWRoleGrpTher = aSWRoleGrpTherCheckBox.Checked ? "Y" : "N";
            dl.aSWConcRecom = aSWConcRecomTextBox.Text;
            dl.aSWReferNone = aSWReferNoneCheckBox.Checked ? "Y" : "N";
            dl.aSWReferOtherDesc = aSWReferOtherDescTextBox.Text;
            dl.aSWReferOther = aSWReferOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWReferPeerSpec = aSWReferPeerSpecCheckBox.Checked ? "Y" : "N";
            dl.aSWReferOutpatDA = aSWReferOutpatDACheckBox.Checked ? "Y" : "N";
            dl.aSWReferPCP = aSWReferPCPCheckBox.Checked ? "Y" : "N";
            dl.aSWReferInpatDA = aSWReferInpatDACheckBox.Checked ? "Y" : "N";
            dl.aSWReferCMBCM = aSWReferCMBCMCheckBox.Checked ? "Y" : "N";
            dl.aSWReferStateHosp = aSWReferStateHospCheckBox.Checked ? "Y" : "N";
            dl.aSWReferEAC = aSWReferEACCheckBox.Checked ? "Y" : "N";
            dl.aSWReferLTSRCRR = aSWReferLTSRCRRCheckBox.Checked ? "Y" : "N";
            dl.aSWReferIOP = aSWReferIOPCheckBox.Checked ? "Y" : "N";
            dl.aSWReferPsychRehab = aSWReferPsychRehabCheckBox.Checked ? "Y" : "N";
            dl.aSWReferPHP = aSWReferPHPCheckBox.Checked ? "Y" : "N";
            dl.aSWReferPsych = aSWReferPsychCheckBox.Checked ? "Y" : "N";
            dl.aSWReferOutpat = aSWReferOutpatCheckBox.Checked ? "Y" : "N";
            dl.aSWBarNone = aSWBarNoneCheckBox.Checked ? "Y" : "N";
            dl.aSWBarOtherDesc = aSWBarOtherDescTextBox.Text;
            dl.aSWBarOther = aSWBarOtherCheckBox.Checked ? "Y" : "N";
            dl.aSWBarAbsFacAccSpecNeed = aSWBarAbsFacAccSpecNeedCheckBox.Checked ? "Y" : "N";
            dl.aSWBarNonComp = aSWBarNonCompCheckBox.Checked ? "Y" : "N";
            dl.aSWBarHouse = aSWBarHouseCheckBox.Checked ? "Y" : "N";
            dl.aSWBarMeds = aSWBarMedsCheckBox.Checked ? "Y" : "N";
            dl.aSWBarTrans = aSWBarTransCheckBox.Checked ? "Y" : "N";
            dl.aSWPrefPharm = aSWPrefPharmTextBox.Text;
            dl.aSWEduPosRisk = aSWEduPosRiskComboBox.SelectedIndex.ToString();
            dl.aSWWeaponLethMeans = aSWWeaponLethMeansComboBox.SelectedIndex.ToString();
            dl.aSWPastSelfInj = aSWPastSelfInjComboBox.SelectedIndex.ToString();
            dl.aSWReliableSrc = aSWReliableSrcComboBox.SelectedIndex.ToString();
            dl.aSWLegStat = aSWLegStatComboBox.SelectedIndex.ToString();
            dl.aSWMemHelpful = aSWMemHelpfulComboBox.SelectedIndex.ToString();
            dl.aSWTermPreg = aSWTermPregComboBox.SelectedIndex.ToString();
            dl.aSWCurrPreg = aSWCurrPregComboBox.SelectedIndex.ToString();
            dl.aSWMaritStat = aSWMaritStatComboBox.SelectedIndex.ToString();
            dl.aSWSafeHome = aSWSafeHomeComboBox.SelectedIndex.ToString();
            dl.aSWRetHome = aSWRetHomeComboBox.SelectedIndex.ToString();
            dl.combVic = combVicComboBox.SelectedIndex.ToString();
            dl.aSWEmoNegAbuseReported = aSWEmoNegAbuseReportedComboBox.SelectedIndex.ToString();
            dl.aSWEmoNegAbuseWitness = aSWEmoNegAbuseWitnessComboBox.SelectedIndex.ToString();
            dl.aSWEmoNegAbusePerp = aSWEmoNegAbusePerpComboBox.SelectedIndex.ToString();
            dl.aSWEmoNegAbuseVict = aSWEmoNegAbuseVictComboBox.SelectedIndex.ToString();
            dl.aSWPhsyAbuseReport = aSWPhsyAbuseReportComboBox.SelectedIndex.ToString();
            dl.aSWPhysAbuseWitness = aSWPhysAbuseWitnessComboBox.SelectedIndex.ToString();
            dl.aSWPhysAbusePerp = aSWPhysAbusePerpComboBox.SelectedIndex.ToString();
            dl.aSWPhysAbuseVict = aSWPhysAbuseVictComboBox.SelectedIndex.ToString();
            dl.aSWSexAbuseReport = aSWSexAbuseReportComboBox.SelectedIndex.ToString();
            dl.aSWSexAbuseWitness = aSWSexAbuseWitnessComboBox.SelectedIndex.ToString();
            dl.aSWSexAbusePerp = aSWSexAbusePerpComboBox.SelectedIndex.ToString();
            dl.aSWSexAbuseVict = aSWSexAbuseVictComboBox.SelectedIndex.ToString();
            dl.aSWDesireFutEdu = aSWDesireFutEduComboBox.SelectedIndex.ToString();
            dl.aSWSchoolStress = aSWSchoolStressComboBox.SelectedIndex.ToString();
            dl.aSWCurrSchool = aSWCurrSchoolComboBox.SelectedIndex.ToString();
            dl.aSWOtherLegal = aSWOtherLegalComboBox.SelectedIndex.ToString();
            dl.aSWHistArrest = aSWHistArrestComboBox.SelectedIndex.ToString();
            dl.aSWHospPrev = aSWHospPrevComboBox.SelectedIndex.ToString();
            dl.aSWMedAdhTreat = aSWMedAdhTreatComboBox.SelectedIndex.ToString();
            dl.aSWMedAdhPat = aSWMedAdhPatComboBox.SelectedIndex.ToString();
            dl.aSWHistHomSuic = aSWHistHomSuicComboBox.SelectedIndex.ToString();
            dl.aSWProbImpactFam = aSWProbImpactFamComboBox.SelectedIndex.ToString();
            dl.aSWSeeUseProb = aSWSeeUseProbComboBox.SelectedIndex.ToString();
            dl.aSWIncDrugAlc = aSWIncDrugAlcComboBox.SelectedIndex.ToString();
            dl.aSWWeNeedKnow = aSWWeNeedKnowComboBox.SelectedIndex.ToString();
            dl.aSWCultIssContrib = aSWCultIssContribComboBox.SelectedIndex.ToString();
            dl.aSWChangReligInvo = aSWChangReligInvoComboBox.SelectedIndex.ToString();
            dl.aSWChronDisabImpFunct = aSWChronDisabImpFunctComboBox.SelectedIndex.ToString();
            dl.aSWHistSigMedIss = aSWHistSigMedIssComboBox.SelectedIndex.ToString();
            dl.aSWMedIssContrib = aSWMedIssContribComboBox.SelectedIndex.ToString();
            dl.aSWMeetBasicNeeds = aSWMeetBasicNeedsComboBox.SelectedIndex.ToString();
            dl.aSWFinanceStress = aSWFinanceStressComboBox.SelectedIndex.ToString();
            dl.aSWInvolvMilitary = aSWInvolvMilitaryComboBox.SelectedIndex.ToString();
            dl.aSWEligVABenefits = aSWEligVABenefitsComboBox.SelectedIndex.ToString();
            dl.aSWMilEngageCombat = aSWMilEngageCombatComboBox.SelectedIndex.ToString();
            dl.aSWMilDepAwayHome = aSWMilDepAwayHomeComboBox.SelectedIndex.ToString();
            dl.aSWEmpStress = aSWEmpStressComboBox.SelectedIndex.ToString();
            dl.aSWConcernFollowPlan = aSWConcernFollowPlanComboBox.SelectedIndex.ToString();
            dl.aSWMAPartCommSupp = aSWMAPartCommSuppComboBox.SelectedIndex.ToString();
        }

        private void getAdultSocialWork()
        {
            aSWAssignWorkerTextBox.Text = dl.aSWAssignWorker;
            powAttorneyLNameTextBox.Text = dl.powAttorneyLName;
            powAttorneyFNameTextBox.Text = dl.powAttorneyFName;
            guardianshipLNameTextBox.Text = dl.guardianshipLName;
            guardianshipFNameTextBox.Text = dl.guardianshipFName;
            lastNameTextBox.Text = dl.lastName;
            firstNameTextBox.Text = dl.firstName;
            aSWDateCompleteDateTimePicker.Value = dl.aSWDateComplete ?? DateTime.Today;
            assessStartDateDateTimePicker.Value = dl.assessStartDate ?? DateTime.Today;
            aSWCommInvolveTextBox.Text = dl.aSWCommInvolve;
            aSWFamSupDescPatTextBox.Text = dl.aSWFamSupDescPat;
            aSWPatDescSelfSomeoneTextBox.Text = dl.aSWPatDescSelfSomeone;
            aSWCurLevFuncDifTypFuncTextBox.Text = dl.aSWCurLevFuncDifTypFunc;
            aSWNaturePresProbTextBox.Text = dl.aSWNaturePresProb;
            aSWReliableSrcDescTextBox.Text = dl.aSWReliableSrcDesc;
            aSWSrcInfoTextBox.Text = dl.aSWSrcInfo;
            aSWLegStatDescTextBox.Text = dl.aSWLegStatDesc;
            if (dl.aSWDangerSelfIntent == "Y")
                aSWDangerSelfIntentCheckBox.Checked = true;
            else
                aSWDangerSelfIntentCheckBox.Checked = false;
            if (dl.aSWDangerSelfAttempt == "Y")
                aSWDangerSelfAttemptCheckBox.Checked = true;
            else
                aSWDangerSelfAttemptCheckBox.Checked = false;
            if (dl.aSWDangerSelfPlan == "Y")
                aSWDangerSelfPlanCheckBox.Checked = true;
            else
                aSWDangerSelfPlanCheckBox.Checked = false;
            if (dl.aSWDangerSelfIdeation == "Y")
                aSWDangerSelfIdeationCheckBox.Checked = true;
            else
                aSWDangerSelfIdeationCheckBox.Checked = false;
            if (dl.aSWDangerSelfHistory == "Y")
                aSWDangerSelfHistoryCheckBox.Checked = true;
            else
                aSWDangerSelfHistoryCheckBox.Checked = false;
            if (dl.aSWDangerSelfCurrent == "Y")
                aSWDangerSelfCurrentCheckBox.Checked = true;
            else
                aSWDangerSelfCurrentCheckBox.Checked = false;
            if (dl.aSWDangerSelfNotPres == "Y")
                aSWDangerSelfNotPresCheckBox.Checked = true;
            else
                aSWDangerSelfNotPresCheckBox.Checked = false;
            aSWWeaponLethMeansRemovePlanTextBox.Text = dl.aSWWeaponLethMeansRemovePlan;
            aSWPastSelfInjDescTextBox.Text = dl.aSWPastSelfInjDesc;
            aSWLethPriorMeansTextBox.Text = dl.aSWLethPriorMeans;
            aSWDangerDescTextBox.Text = dl.aSWDangerDesc;
            if (dl.aSWDangerOthersNotPres == "Y")
                aSWDangerOthersNotPresCheckBox.Checked = true;
            else
                aSWDangerOthersNotPresCheckBox.Checked = false;
            if (dl.aSWDangerOthersIntent == "Y")
                aSWDangerOthersIntentCheckBox.Checked = true;
            else
                aSWDangerOthersIntentCheckBox.Checked = false;
            if (dl.aSWDangerOthersAttempt == "Y")
                aSWDangerOthersAttemptCheckBox.Checked = true;
            else
                aSWDangerOthersAttemptCheckBox.Checked = false;
            if (dl.aSWDangerOthersPlan == "Y")
                aSWDangerOthersPlanCheckBox.Checked = true;
            else
                aSWDangerOthersPlanCheckBox.Checked = false;
            if (dl.aSWDangerOthersIdeation == "Y")
                aSWDangerOthersIdeationCheckBox.Checked = true;
            else
                aSWDangerOthersIdeationCheckBox.Checked = false;
            if (dl.aSWDangerOthersHistory == "Y")
                aSWDangerOthersHistoryCheckBox.Checked = true;
            else
                aSWDangerOthersHistoryCheckBox.Checked = false;
            if (dl.aSWDangerOthersCurrent == "Y")
                aSWDangerOthersCurrentCheckBox.Checked = true;
            else
                aSWDangerOthersCurrentCheckBox.Checked = false;
            aSWVerifyTimeTextBox.Text = dl.aSWVerifyTime;
            aSWVerifyDateDateTimePicker.Value = dl.aSWVerifyDate ?? DateTime.Today;
            aSWVerifyTextBox.Text = dl.aSWVerify;
            aSWResponsePatTimeTextBox.Text = dl.aSWResponsePatTime;
            aSWResponsePatDateDateTimePicker.Value = dl.aSWResponsePatDate ?? DateTime.Today;
            aSWResponsePatTextBox.Text = dl.aSWResponsePat;
            aSWEmoNegAbuseReportedDescTextBox.Text = dl.aSWEmoNegAbuseReportedDesc;
            aSWEmoNegAbuseWitnessDescTextBox.Text = dl.aSWEmoNegAbuseWitnessDesc;
            aSWPhsyAbuseReportDescTextBox.Text = dl.aSWPhsyAbuseReportDesc;
            aSWPhsyAbuseWitnessDescTextBox.Text = dl.aSWPhsyAbuseWitnessDesc;
            aSWSexAbuseReportDescTextBox.Text = dl.aSWSexAbuseReportDesc;
            aSWSexAbuseWitnessDescTextBox.Text = dl.aSWSexAbuseWitnessDesc;
            aSWOtherTraumaExpTextBox.Text = dl.aSWOtherTraumaExp;
            aSWTermPregDescTextBox.Text = dl.aSWTermPregDesc;
            aSWDateChangeDateTimePicker.Value = dl.aSWDateChange ?? DateTime.Today;
            aSWSafeHomeDescTextBox.Text = dl.aSWSafeHomeDesc;
            aSWHomePlanDischTextBox.Text = dl.aSWHomePlanDisch;
            aSWRetHomeWhenTextBox.Text = dl.aSWRetHomeWhen;
            aSWRetHomeWhomTextBox.Text = dl.aSWRetHomeWhom;
            aSWHomePriorTextBox.Text = dl.aSWHomePrior;
            aSWRecFamInvolveTextBox.Text = dl.aSWRecFamInvolve;
            aSWFamDeclineReasonTextBox.Text = dl.aSWFamDeclineReason;
            aSWFamSessInviteTextBox.Text = dl.aSWFamSessInvite;
            aSWDateFamSessDateTimePicker.Value = dl.aSWDateFamSess ?? DateTime.Today;
            aSWRelatProbTextBox.Text = dl.aSWRelatProb;
            aSWMemHelpfulDescTextBox.Text = dl.aSWMemHelpfulDesc;
            aSWPriorFamInvolveTextBox.Text = dl.aSWPriorFamInvolve;
            aSWDvlpExplainTextBox.Text = dl.aSWDvlpExplain;
            aSWDvlpOtherDescTextBox.Text = dl.aSWDvlpOtherDesc;
            if (dl.aSWDvlpOther == "Y")
                aSWDvlpOtherCheckBox.Checked = true;
            else
                aSWDvlpOtherCheckBox.Checked = false;
            if (dl.aSWDvlpHoardCollect == "Y")
                aSWDvlpHoardCollectCheckBox.Checked = true;
            else
                aSWDvlpHoardCollectCheckBox.Checked = false;
            if (dl.aSWDvlpCleanOrg == "Y")
                aSWDvlpCleanOrgCheckBox.Checked = true;
            else
                aSWDvlpCleanOrgCheckBox.Checked = false;
            if (dl.aSWDvlpEmoEat == "Y")
                aSWDvlpEmoEatCheckBox.Checked = true;
            else
                aSWDvlpEmoEatCheckBox.Checked = false;
            if (dl.aSWDvlpShopping == "Y")
                aSWDvlpShoppingCheckBox.Checked = true;
            else
                aSWDvlpShoppingCheckBox.Checked = false;
            if (dl.aSWDvlpGambling == "Y")
                aSWDvlpGamblingCheckBox.Checked = true;
            else
                aSWDvlpGamblingCheckBox.Checked = false;
            if (dl.aSWDvlpNone == "Y")
                aSWDvlpNoneCheckBox.Checked = true;
            else
                aSWDvlpNoneCheckBox.Checked = false;
            aSWEffIneffTreatmentTextBox.Text = dl.aSWEffIneffTreatment;
            aSWHospPrevRemainCommTextBox.Text = dl.aSWHospPrevRemainComm;
            aSWHistHomSuicDescTextBox.Text = dl.aSWHistHomSuicDesc;
            aSWProbImpactFamDescTextBox.Text = dl.aSWProbImpactFamDesc;
            aSWOtherLegalDescTextBox.Text = dl.aSWOtherLegalDesc;
            aSWHistArrestDescTextBox.Text = dl.aSWHistArrestDesc;
            aSWHighestEduCompleteTextBox.Text = dl.aSWHighestEduComplete;
            aSWSchoolStressDescTextBox.Text = dl.aSWSchoolStressDesc;
            aSWCurrSchoolWhereTextBox.Text = dl.aSWCurrSchoolWhere;
            auditSubComplTotalTextBox.Text = dl.auditSubComplTotal;
            if (dl.aSWSubAbuseResultNone == "Y")
                aSWSubAbuseResultNoneCheckBox.Checked = true;
            else
                aSWSubAbuseResultNoneCheckBox.Checked = false;
            aSWSubAbuseResultOtherDescTextBox.Text = dl.aSWSubAbuseResultOtherDesc;
            if (dl.aSWSubAbuseResultOther == "Y")
                aSWSubAbuseResultOtherCheckBox.Checked = true;
            else
                aSWSubAbuseResultOtherCheckBox.Checked = false;
            if (dl.aSWSubAbuseResultPromis == "Y")
                aSWSubAbuseResultPromisCheckBox.Checked = true;
            else
                aSWSubAbuseResultPromisCheckBox.Checked = false;
            if (dl.aSWSubAbuseResultWorkProb == "Y")
                aSWSubAbuseResultWorkProbCheckBox.Checked = true;
            else
                aSWSubAbuseResultWorkProbCheckBox.Checked = false;
            if (dl.aSWSubAbuseResultBlackout == "Y")
                aSWSubAbuseResultBlackoutCheckBox.Checked = true;
            else
                aSWSubAbuseResultBlackoutCheckBox.Checked = false;
            if (dl.aSWSubAbuseResultThoughtSelfHarm == "Y")
                aSWSubAbuseResultThoughtSelfHarmCheckBox.Checked = true;
            else
                aSWSubAbuseResultThoughtSelfHarmCheckBox.Checked = false;
            if (dl.aSWSubAbuseResultUnpBills == "Y")
                aSWSubAbuseResultUnpBillsCheckBox.Checked = true;
            else
                aSWSubAbuseResultUnpBillsCheckBox.Checked = false;
            if (dl.aSWSubAbuseResultRelatProb == "Y")
                aSWSubAbuseResultRelatProbCheckBox.Checked = true;
            else
                aSWSubAbuseResultRelatProbCheckBox.Checked = false;
            if (dl.aSWSubAbuseResultArrest == "Y")
                aSWSubAbuseResultArrestCheckBox.Checked = true;
            else
                aSWSubAbuseResultArrestCheckBox.Checked = false;
            if (dl.aSWSubAbuseNA == "Y")
                aSWSubAbuseNACheckBox.Checked = true;
            else
                aSWSubAbuseNACheckBox.Checked = false;
            aSWReferMadeDescTextBox.Text = dl.aSWReferMadeDesc;
            if (dl.aSWReferMade == "Y")
                aSWReferMadeCheckBox.Checked = true;
            else
                aSWReferMadeCheckBox.Checked = false;
            if (dl.aSWEduProvPat == "Y")
                aSWEduProvPatCheckBox.Checked = true;
            else
                aSWEduProvPatCheckBox.Checked = false;
            if (dl.aSWPatInformRecom == "Y")
                aSWPatInformRecomCheckBox.Checked = true;
            else
                aSWPatInformRecomCheckBox.Checked = false;
            aSWRecomDescTextBox.Text = dl.aSWRecomDesc;
            if (dl.aSWRecom == "Y")
                aSWRecomCheckBox.Checked = true;
            else
                aSWRecomCheckBox.Checked = false;
            aSWInterventionOtherDescTextBox.Text = dl.aSWInterventionOtherDesc;
            if (dl.aSWInterventionOther == "Y")
                aSWInterventionOtherCheckBox.Checked = true;
            else
                aSWInterventionOtherCheckBox.Checked = false;
            if (dl.aSWAdvAbstain == "Y")
                aSWAdvAbstainCheckBox.Checked = true;
            else
                aSWAdvAbstainCheckBox.Checked = false;
            if (dl.aSWMotDisc == "Y")
                aSWMotDiscCheckBox.Checked = true;
            else
                aSWMotDiscCheckBox.Checked = false;
            if (dl.aSWDiscSeverity == "Y")
                aSWDiscSeverityCheckBox.Checked = true;
            else
                aSWDiscSeverityCheckBox.Checked = false;
            if (dl.aSWDiscNegCons == "Y")
                aSWDiscNegConsCheckBox.Checked = true;
            else
                aSWDiscNegConsCheckBox.Checked = false;
            if (dl.aSWFeedback == "Y")
                aSWFeedbackCheckBox.Checked = true;
            else
                aSWFeedbackCheckBox.Checked = false;
            aSWSubTreatHistDescTextBox.Text = dl.aSWSubTreatHistDesc;
            if (dl.aSWSubTreatHist == "Y")
                aSWSubTreatHistCheckBox.Checked = true;
            else
                aSWSubTreatHistCheckBox.Checked = false;
            aSWBenefitUseTextBox.Text = dl.aSWBenefitUse;
            aSWDrugChoiceTextBox.Text = dl.aSWDrugChoice;
            aSWMilSigEventsTextBox.Text = dl.aSWMilSigEvents;
            aSWMilDischarTextBox.Text = dl.aSWMilDischar;
            aSWMilDatesTextBox.Text = dl.aSWMilDates;
            aSWMilBranchTextBox.Text = dl.aSWMilBranch;
            aSWSrcIncomeTextBox.Text = dl.aSWSrcIncome;
            aSWAvgMonIncomeTextBox.Text = dl.aSWAvgMonIncome;
            aSWFeelCurrWorkDescTextBox.Text = dl.aSWFeelCurrWorkDesc;
            if (dl.aSWFeelCurrWork == "Y")
                aSWFeelCurrWorkCheckBox.Checked = true;
            else
                aSWFeelCurrWorkCheckBox.Checked = false;
            aSWWeNeedKnowDescTextBox.Text = dl.aSWWeNeedKnowDesc;
            aSWCultIssContribDescTextBox.Text = dl.aSWCultIssContribDesc;
            aSWCurrReligInvoTextBox.Text = dl.aSWCurrReligInvo;
            aSWChronDisabImpFunctDescTextBox.Text = dl.aSWChronDisabImpFunctDesc;
            aSWHistSigMedIssDescTextBox.Text = dl.aSWHistSigMedIssDesc;
            aSWMedIssContribDescTextBox.Text = dl.aSWMedIssContribDesc;
            aSWFinanceStressDescTextBox.Text = dl.aSWFinanceStressDesc;
            aSWObtMedNeedDescTextBox.Text = dl.aSWObtMedNeedDesc;
            if (dl.aSWObtMedNeed == "Y")
                aSWObtMedNeedCheckBox.Checked = true;
            else
                aSWObtMedNeedCheckBox.Checked = false;
            if (dl.aSWObtMedIncome == "Y")
                aSWObtMedIncomeCheckBox.Checked = true;
            else
                aSWObtMedIncomeCheckBox.Checked = false;
            if (dl.aSWObtMedTrans == "Y")
                aSWObtMedTransCheckBox.Checked = true;
            else
                aSWObtMedTransCheckBox.Checked = false;
            aSWMAPartCommSuppRespTextBox.Text = dl.aSWMAPartCommSuppResp;
            aSWMAPartCommSuppWhenTextBox.Text = dl.aSWMAPartCommSuppWhen;
            aSWReadmOtherDescTextBox.Text = dl.aSWReadmOtherDesc;
            if (dl.aSWReadmOther == "Y")
                aSWReadmOtherCheckBox.Checked = true;
            else
                aSWReadmOtherCheckBox.Checked = false;
            if (dl.aSWReadmCompli == "Y")
                aSWReadmCompliCheckBox.Checked = true;
            else
                aSWReadmCompliCheckBox.Checked = false;
            if (dl.aSWReadmPriorAuthor == "Y")
                aSWReadmPriorAuthorCheckBox.Checked = true;
            else
                aSWReadmPriorAuthorCheckBox.Checked = false;
            if (dl.aSWReadmMedStab == "Y")
                aSWReadmMedStabCheckBox.Checked = true;
            else
                aSWReadmMedStabCheckBox.Checked = false;
            if (dl.aSWReadmNA == "Y")
                aSWReadmNACheckBox.Checked = true;
            else
                aSWReadmNACheckBox.Checked = false;
            if (dl.aSWCareNone == "Y")
                aSWCareNoneCheckBox.Checked = true;
            else
                aSWCareNoneCheckBox.Checked = false;
            aSWCareOtherDescTextBox.Text = dl.aSWCareOtherDesc;
            if (dl.aSWCareOther == "Y")
                aSWCareOtherCheckBox.Checked = true;
            else
                aSWCareOtherCheckBox.Checked = false;
            if (dl.aSWCareAcuteMed == "Y")
                aSWCareAcuteMedCheckBox.Checked = true;
            else
                aSWCareAcuteMedCheckBox.Checked = false;
            if (dl.aSWCareTrans == "Y")
                aSWCareTransCheckBox.Checked = true;
            else
                aSWCareTransCheckBox.Checked = false;
            if (dl.aSWCarePetsUnsup == "Y")
                aSWCarePetsUnsupCheckBox.Checked = true;
            else
                aSWCarePetsUnsupCheckBox.Checked = false;
            if (dl.aSWCareHouse == "Y")
                aSWCareHouseCheckBox.Checked = true;
            else
                aSWCareHouseCheckBox.Checked = false;
            if (dl.aSWCareHIstNonComp == "Y")
                aSWCareHIstNonCompCheckBox.Checked = true;
            else
                aSWCareHIstNonCompCheckBox.Checked = false;
            aSWArrSchedNeedDescTextBox.Text = dl.aSWArrSchedNeedDesc;
            if (dl.aSWArrSchedNeed == "Y")
                aSWArrSchedNeedCheckBox.Checked = true;
            else
                aSWArrSchedNeedCheckBox.Checked = false;
            if (dl.aSWArrSchedMATP == "Y")
                aSWArrSchedMATPCheckBox.Checked = true;
            else
                aSWArrSchedMATPCheckBox.Checked = false;
            if (dl.aSWArrSchedFamFri == "Y")
                aSWArrSchedFamFriCheckBox.Checked = true;
            else
                aSWArrSchedFamFriCheckBox.Checked = false;
            if (dl.aSWArrSchedPersVeh == "Y")
                aSWArrSchedPersVehCheckBox.Checked = true;
            else
                aSWArrSchedPersVehCheckBox.Checked = false;
            aSWPrelimDischargePlanTextBox.Text = dl.aSWPrelimDischargePlan;
            aSWRoleOtherDescTextBox.Text = dl.aSWRoleOtherDesc;
            if (dl.aSWRoleOther == "Y")
                aSWRoleOtherCheckBox.Checked = true;
            else
                aSWRoleOtherCheckBox.Checked = false;
            if (dl.aSWRoleAftercare == "Y")
                aSWRoleAftercareCheckBox.Checked = true;
            else
                aSWRoleAftercareCheckBox.Checked = false;
            if (dl.aSWRoleFamTher == "Y")
                aSWRoleFamTherCheckBox.Checked = true;
            else
                aSWRoleFamTherCheckBox.Checked = false;
            if (dl.aSWRoleIndivTher == "Y")
                aSWRoleIndivTherCheckBox.Checked = true;
            else
                aSWRoleIndivTherCheckBox.Checked = false;
            if (dl.aSWRoleGrpTher == "Y")
                aSWRoleGrpTherCheckBox.Checked = true;
            else
                aSWRoleGrpTherCheckBox.Checked = false;
            aSWConcRecomTextBox.Text = dl.aSWConcRecom;
            if (dl.aSWReferNone == "Y")
                aSWReferNoneCheckBox.Checked = true;
            else
                aSWReferNoneCheckBox.Checked = false;
            aSWReferOtherDescTextBox.Text = dl.aSWReferOtherDesc;
            if (dl.aSWReferOther == "Y")
                aSWReferOtherCheckBox.Checked = true;
            else
                aSWReferOtherCheckBox.Checked = false;
            if (dl.aSWReferPeerSpec == "Y")
                aSWReferPeerSpecCheckBox.Checked = true;
            else
                aSWReferPeerSpecCheckBox.Checked = false;
            if (dl.aSWReferOutpatDA == "Y")
                aSWReferOutpatDACheckBox.Checked = true;
            else
                aSWReferOutpatDACheckBox.Checked = false;
            if (dl.aSWReferPCP == "Y")
                aSWReferPCPCheckBox.Checked = true;
            else
                aSWReferPCPCheckBox.Checked = false;
            if (dl.aSWReferInpatDA == "Y")
                aSWReferInpatDACheckBox.Checked = true;
            else
                aSWReferInpatDACheckBox.Checked = false;
            if (dl.aSWReferCMBCM == "Y")
                aSWReferCMBCMCheckBox.Checked = true;
            else
                aSWReferCMBCMCheckBox.Checked = false;
            if (dl.aSWReferStateHosp == "Y")
                aSWReferStateHospCheckBox.Checked = true;
            else
                aSWReferStateHospCheckBox.Checked = false;
            if (dl.aSWReferEAC == "Y")
                aSWReferEACCheckBox.Checked = true;
            else
                aSWReferEACCheckBox.Checked = false;
            if (dl.aSWReferLTSRCRR == "Y")
                aSWReferLTSRCRRCheckBox.Checked = true;
            else
                aSWReferLTSRCRRCheckBox.Checked = false;
            if (dl.aSWReferIOP == "Y")
                aSWReferIOPCheckBox.Checked = true;
            else
                aSWReferIOPCheckBox.Checked = false;
            if (dl.aSWReferPsychRehab == "Y")
                aSWReferPsychRehabCheckBox.Checked = true;
            else
                aSWReferPsychRehabCheckBox.Checked = false;
            if (dl.aSWReferPHP == "Y")
                aSWReferPHPCheckBox.Checked = true;
            else
                aSWReferPHPCheckBox.Checked = false;
            if (dl.aSWReferPsych == "Y")
                aSWReferPsychCheckBox.Checked = true;
            else
                aSWReferPsychCheckBox.Checked = false;
            if (dl.aSWReferOutpat == "Y")
                aSWReferOutpatCheckBox.Checked = true;
            else
                aSWReferOutpatCheckBox.Checked = false;
            if (dl.aSWBarNone == "Y")
                aSWBarNoneCheckBox.Checked = true;
            else
                aSWBarNoneCheckBox.Checked = false;
            aSWBarOtherDescTextBox.Text = dl.aSWBarOtherDesc;
            if (dl.aSWBarOther == "Y")
                aSWBarOtherCheckBox.Checked = true;
            else
                aSWBarOtherCheckBox.Checked = false;
            if (dl.aSWBarAbsFacAccSpecNeed == "Y")
                aSWBarAbsFacAccSpecNeedCheckBox.Checked = true;
            else
                aSWBarAbsFacAccSpecNeedCheckBox.Checked = false;
            if (dl.aSWBarNonComp == "Y")
                aSWBarNonCompCheckBox.Checked = true;
            else
                aSWBarNonCompCheckBox.Checked = false;
            if (dl.aSWBarHouse == "Y")
                aSWBarHouseCheckBox.Checked = true;
            else
                aSWBarHouseCheckBox.Checked = false;
            if (dl.aSWBarMeds == "Y")
                aSWBarMedsCheckBox.Checked = true;
            else
                aSWBarMedsCheckBox.Checked = false;
            if (dl.aSWBarTrans == "Y")
                aSWBarTransCheckBox.Checked = true;
            else
                aSWBarTransCheckBox.Checked = false;
            aSWPrefPharmTextBox.Text = dl.aSWPrefPharm;
            aSWEduPosRiskComboBox.SelectedIndex = int.Parse(dl.aSWEduPosRisk);
            aSWWeaponLethMeansComboBox.SelectedIndex = int.Parse(dl.aSWWeaponLethMeans);
            aSWPastSelfInjComboBox.SelectedIndex = int.Parse(dl.aSWPastSelfInj);
            aSWReliableSrcComboBox.SelectedIndex = int.Parse(dl.aSWReliableSrc);
            aSWLegStatComboBox.SelectedIndex = int.Parse(dl.aSWLegStat);
            aSWMemHelpfulComboBox.SelectedIndex = int.Parse(dl.aSWMemHelpful);
            aSWTermPregComboBox.SelectedIndex = int.Parse(dl.aSWTermPreg);
            aSWCurrPregComboBox.SelectedIndex = int.Parse(dl.aSWCurrPreg);
            aSWMaritStatComboBox.SelectedIndex = int.Parse(dl.aSWMaritStat);
            aSWSafeHomeComboBox.SelectedIndex = int.Parse(dl.aSWSafeHome);
            aSWRetHomeComboBox.SelectedIndex = int.Parse(dl.aSWRetHome);
            combVicComboBox.SelectedIndex = int.Parse(dl.combVic);
            aSWEmoNegAbuseReportedComboBox.SelectedIndex = int.Parse(dl.aSWEmoNegAbuseReported);
            aSWEmoNegAbuseWitnessComboBox.SelectedIndex = int.Parse(dl.aSWEmoNegAbuseWitness);
            aSWEmoNegAbusePerpComboBox.SelectedIndex = int.Parse(dl.aSWEmoNegAbusePerp);
            aSWEmoNegAbuseVictComboBox.SelectedIndex = int.Parse(dl.aSWEmoNegAbuseVict);
            aSWPhsyAbuseReportComboBox.SelectedIndex = int.Parse(dl.aSWPhsyAbuseReport);
            aSWPhysAbuseWitnessComboBox.SelectedIndex = int.Parse(dl.aSWPhysAbuseWitness);
            aSWPhysAbusePerpComboBox.SelectedIndex = int.Parse(dl.aSWPhysAbusePerp);
            aSWPhysAbuseVictComboBox.SelectedIndex = int.Parse(dl.aSWPhysAbuseVict);
            aSWSexAbuseReportComboBox.SelectedIndex = int.Parse(dl.aSWSexAbuseReport);
            aSWSexAbuseWitnessComboBox.SelectedIndex = int.Parse(dl.aSWSexAbuseWitness);
            aSWSexAbusePerpComboBox.SelectedIndex = int.Parse(dl.aSWSexAbusePerp);
            aSWSexAbuseVictComboBox.SelectedIndex = int.Parse(dl.aSWSexAbuseVict);
            aSWDesireFutEduComboBox.SelectedIndex = int.Parse(dl.aSWDesireFutEdu);
            aSWSchoolStressComboBox.SelectedIndex = int.Parse(dl.aSWSchoolStress);
            aSWCurrSchoolComboBox.SelectedIndex = int.Parse(dl.aSWCurrSchool);
            aSWOtherLegalComboBox.SelectedIndex = int.Parse(dl.aSWOtherLegal);
            aSWHistArrestComboBox.SelectedIndex = int.Parse(dl.aSWHistArrest);
            aSWHospPrevComboBox.SelectedIndex = int.Parse(dl.aSWHospPrev);
            aSWMedAdhTreatComboBox.SelectedIndex = int.Parse(dl.aSWMedAdhTreat);
            aSWMedAdhPatComboBox.SelectedIndex = int.Parse(dl.aSWMedAdhPat);
            aSWHistHomSuicComboBox.SelectedIndex = int.Parse(dl.aSWHistHomSuic);
            aSWProbImpactFamComboBox.SelectedIndex = int.Parse(dl.aSWProbImpactFam);
            aSWSeeUseProbComboBox.SelectedIndex = int.Parse(dl.aSWSeeUseProb);
            aSWIncDrugAlcComboBox.SelectedIndex = int.Parse(dl.aSWIncDrugAlc);
            aSWWeNeedKnowComboBox.SelectedIndex = int.Parse(dl.aSWWeNeedKnow);
            aSWCultIssContribComboBox.SelectedIndex = int.Parse(dl.aSWCultIssContrib);
            aSWChangReligInvoComboBox.SelectedIndex = int.Parse(dl.aSWChangReligInvo);
            aSWChronDisabImpFunctComboBox.SelectedIndex = int.Parse(dl.aSWChronDisabImpFunct);
            aSWHistSigMedIssComboBox.SelectedIndex = int.Parse(dl.aSWHistSigMedIss);
            aSWMedIssContribComboBox.SelectedIndex = int.Parse(dl.aSWMedIssContrib);
            aSWMeetBasicNeedsComboBox.SelectedIndex = int.Parse(dl.aSWMeetBasicNeeds);
            aSWFinanceStressComboBox.SelectedIndex = int.Parse(dl.aSWFinanceStress);
            aSWInvolvMilitaryComboBox.SelectedIndex = int.Parse(dl.aSWInvolvMilitary);
            aSWEligVABenefitsComboBox.SelectedIndex = int.Parse(dl.aSWEligVABenefits);
            aSWMilEngageCombatComboBox.SelectedIndex = int.Parse(dl.aSWMilEngageCombat);
            aSWMilDepAwayHomeComboBox.SelectedIndex = int.Parse(dl.aSWMilDepAwayHome);
            aSWEmpStressComboBox.SelectedIndex = int.Parse(dl.aSWEmpStress);
            aSWConcernFollowPlanComboBox.SelectedIndex = int.Parse(dl.aSWConcernFollowPlan);
            aSWMAPartCommSuppComboBox.SelectedIndex = int.Parse(dl.aSWMAPartCommSupp);
        }

        private void grpRiskAssess_Enter(object sender, EventArgs e)
        {

        }
    }
}
