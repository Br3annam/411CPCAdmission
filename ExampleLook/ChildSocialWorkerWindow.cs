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

        //private void getChildSocial()
        //{
        //    cSWSocialWorkerTextBox.Text = dl.cSWSocialWorker;
        //    cSWDateCompleteDateTimePicker.Value = dl.cSWDateComplete;
        //    assessStartDateDateTimePicker.Value = dl.assessStateDate;
        //    lastNameTextBox.Text = dl.lastName;
        //    firstNameTextBox.Text = dl.firstName;
        //    cSWCommInvTextBox.Text = dl.cSWCommInv;
        //    cSWCareDescPatTextBox.Text = dl.cSWCareDescPat;
        //    cSWPatDescElseTextBox.Text = dl.cSWPatDescElse;
        //    cSWLevFuncDifTypTextBox.Text = dl.cSWLevFuncDifTypText;
        //    cSWNaturePresProbTextBox.Text = dl.cSWNaturePresProb;
        //    cSWSrcReliabDescTextBox.Text = dl.cSWSrcReliabDesc;
        //    cSWSrcInfoTextBox.Text = dl.cSWSrcInfo;
        //    cSWLegStatDescTextBox.Text = dl.cSWLegStatDesc;
        //    cSWLegalGardDescTextBox.Text = dl.cSWLegalGardDesc;
        //    cSWLegalGardNaCheckBox.Checked = dl.cSWLegalGardNa;
        //    cSWWeapPlanDescTextBox.Text = dl.cSWWeapPlanDesc;
        //    cSWPastSelfInjDescTextBox.Text = dl.cSWPastSelfInjDesc;
        //    cSWLethPriorMeanTextBox.Text = dl.cSWLethPriorMean;
        //    cSWDanDescTextBox.Text = dl.cSWDanDesc;
        //    cSWDanOthInteCheckBox.Checked = dl.cSWDanOthInte;
        //    cSWDanOthAttCheckBox.Checked = dl.cSWDanOthAtt;
        //    cSWDanOthPlanCheckBox.Checked = dl.cSWDanOthPlan;
        //    cSWDanOthIdeaCheckBox.Checked = dl.cSWDanOthIdea;
        //    cSWDanOthHistCheckBox.Checked = dl.cSWDanOthHist;
        //    cSWDanOthCurrCheckBox.Checked = dl.cSWDanOthCurr;
        //    cSWDanOthNotCheckBox.Checked = dl.cSWDanOthNot;
        //    cSWDanSelfInteCheckBox.Checked = dl.cSWDanSelfInte;
        //    cSWDanSelfAttCheckBox.Checked = dl.cSWDanSelfAtt;
        //    cSWDanSelfPlanCheckBox.Checked = dl.cSWDanSelfPlan;
        //    cSWDanSelfIdeaCheckBox.Checked = dl.cSWDanSelfIdea;
        //    cSWDanSelfHistCheckBox.Checked = dl.cSWDanSelfHist;
        //    cSWDanSelfCurrCheckBox.Checked = dl.cSWDanSelfCurr;
        //    cSWDanSelfNotCheckBox.Checked = dl.cSWDanSelfNot;
        //    cSWVerifTimeTextBox.Text = dl.cSWVerifTime;
        //    cSWVerifDateDateTimePicker.Value = dl.cSWVerifDate;
        //    cSWVerifTextBox.Text = dl.cSWVerif;
        //    cSWRespTimePtTextBox.Text = dl.cSWRespTimePt;
        //    cSWRespDatePtDateTimePicker.Value = dl.cSWRespDatePt;
        //    cSWRespPtTextBox.Text = dl.cSWRespPt;
        //    cSWPsyAbuseReportDescTextBox.Text = dl.cSWPsyAbuseReportDesc;
        //    cSWPsyAbuseWitnessDescTextBox.Text = dl.cSWPsyAbuseWitnessDesc;
        //    cSWSexAbuseReportDescTextBox.Text = dl.cSWSexAbuseReportDesc;
        //    cSWSexAbuseWitnessDescTextBox.Text = dl.cSWSexAbuseWitnessDesc;
        //    cSWEmoNegAbuseReportDescTextBox.Text = dl.cSWEmoNegAbuseReportDesc;
        //    cSWEmoNegAbuseWitnessDescTextBox.Text = dl.cSWEmoNegAbuseWitnessDesc;
        //    cSWOthTraumaExpTextBox.Text = dl.cSWOthTraumaExp;
        //    cSWSexActPregNumChiTextBox.Text = dl.cSWSexActPregNumChi;
        //    cSWSexActPregTimesTextBox.Text = dl.cSWSexActPregTimes;
        //    cSWSexActNumPartTextBox.Text = dl.cSWSexActNumPart;
        //    cSWSexActAgeTextBox.Text = dl.cSWSexActAge;
        //    cSWSafeHomeDescTextBox.Text = dl.cSWSafeHomeDesc;
        //    cSWCarePlanDischTextBox.Text = dl.cSWCarePlanDisch;
        //    cSWRetHomeWhenTextBox.Text = dl.cSWRetHomeWhen;
        //    cSWRetHomeWhomTextBox.Text = dl.cSWRetHomeWhom;
        //    cSWHomePriorAdminTextBox.Text = dl.cSWHomePriorAdmin;
        //    cSWPrimeCaregiverTextBox.Text = dl.cSWPrimeCaregiver;
        //    cSWParentMaritStatDateDateTimePicker.Value = dl.cSWParentMaritStatDate;
        //    cSWSigRelatTextBox.Text = dl.cSWSigRelat;
        //    cSWVisitArrangeTextBox.Text = dl.cSWVisitArrange;
        //    cSWMemHelpPatDescTextBox.Text = dl.cSWMemHelpPatDesc;
        //    cSWRecommFamInvAfterTextBox.Text = dl.cSWRecommFamInvAfter;
        //    cSWLevFamInvPriorTextBox.Text = dl.cSWLevFamInvPrior;
        //    cSWFamSessDeclineReasonTextBox.Text = dl.cSWFamSessDeclineReason;
        //    cSWFamSessInviteTextBox.Text = dl.cSWFamSessInvite;
        //    cSWFamSessDateDateTimePicker.Value = dl.cSWFamSessDate;
        //    cSWRelatProbMemTextBox.Text = dl.cSWRelatProbMem;
        //    cSWHistCYSDescTextBox.Text = dl.cSWHistCYSDesc;
        //    cSWCarFeelPatDifBehavDescTextBox.Text = dl.cSWCarFeelPatDefBehavDesc;
        //    cSWSubResultNoneCheckBox.Checked = dl.cSWSubResultNone;
        //    cSWSubResultOtherDescTextBox.Text = dl.cSWSubResultOtherDesc;
        //    cSWSubResultOtherCheckBox.Checked = dl.cSWSubResultOther;
        //    cSWSubResultPromiscCheckBox.Checked = dl.cSWSubResultPromisc;
        //    cSWSubResultWorkProbCheckBox.Checked = dl.cSWSubResultWorkProb;
        //    cSWSubResultBlackoutCheckBox.Checked = dl.cSWSubResultBlackout;
        //    cSWSubResultThoughtSelfHarmCheckBox.Checked = dl.cSWSubResultThoughtSelfHarm;
        //    cSWSubResultUnpaidBillsCheckBox.Checked = dl.cSWSubResultUnpaidBills;
        //    cSWSubResultRelatProbCheckBox.Checked = dl.cSWSubResultRelatProb;
        //    cSWSubResultArrestCheckBox.Checked = dl.cSWSubResultArrest;
        //    cSWEffIneffTreatHistTextBox.Text = dl.cSWEffIneffTreatHist;
        //    cSWHosp30ContribReadminTextBox.Text = dl.cSWHosp30ContribReadmin;
        //    cSWHospPrevHelpCommInvoTextBox.Text = dl.cSWHospPrevHelpCommInvo;
        //    cSWPatPartTreatTextBox.Text = dl.cSWPatPartTreat;
        //    cSWHistHomSuicDescTextBox.Text = dl.cSWHistHomSuicDesc;
        //    cSWFamMemAbuImpDescTextBox.Text = dl.cSWFamMemAbuImpDesc;
        //    cSWInterventionsTextBox.Text = dl.cSWInterventions;
        //    cSWSubAbuseTreatHistTextBox.Text = dl.cSWSubABuseTreatHist;
        //    cSWReasonUseTextBox.Text = dl.cSWReasonUse;
        //    cSWDrugChoiceTextBox.Text = dl.cSWDrugChoice;
        //    cSWHistArrestDescTextBox.Text = dl.cSWHistArrestDesc;
        //    cSWReferMadeDescTextBox.Text = dl.cSWReferMadeDesc;
        //    cSWReferMadeCheckBox.Checked = dl.cSWReferMade;
        //    cSWEduProvFamCheckBox.Checked = dl.cSWEduProvFam;
        //    cSWFamInformRecommCheckBox.Checked = dl.cSWFamInformRecomm;
        //    cSWEduProvPatCheckBox.Checked = dl.cSWEduProvPat;
        //    cSWPatInformRecommCheckBox.Checked = dl.cSWPatInformRecomm;
        //    cSWSubAbuseRecommDescTextBox.Text = dl.cSWSubAbuseRecommDesc;
        //    cSWSubAbuseRecommNACheckBox.Checked = dl.cSWSubAbuseRecommNA;
        //    cSWOthLegIssDescTextBox.Text = dl.cSWOthLegIssDesc;
        //    cSWPatFeelClassmatesTextBox.Text = dl.cSWPatFeelClassmates;
        //    cSWPatFeelSchTeachTextBox.Text = dl.cSWPatFeelSchTeach;
        //    cSWNumSchoolAttTextBox.Text = dl.cSWNumSchoolAtt;
        //    cSWTimeCurrSchoolTextBox.Text = dl.cSWTimeCurrSchool;
        //    cSWCultOtherDescTextBox.Text = dl.cSWCultOtherDesc;
        //    cSWCultIssContribProbDescTextBox.Text = dl.cSWCultIssContribProbDesc;
        //    cSWChangeReligInvolvDescTextBox.Text = dl.cSWChangeReligInvolvDesc;
        //    cSWCurrStatedFeelBodyTextBox.Text = dl.cSWCurrStatedFeelBody;
        //    cSWEatDepBoredDescTextBox.Text = dl.cSWEatDepBoredDesc;
        //    cSWHistSigMedIssDescTextBox.Text = dl.cSWHistSigMedIssDesc;
        //    cSWChronPainDisabImpFunctDescTextBox.Text = dl.cSWChronPainDisabImpFunctDesc;
        //    cSWMedIssContribDescTextBox.Text = dl.cSWMedIssContribDesc;
        //    cSWParMilitDeployTextBox.Text = dl.cSWParMilitDeploy;
        //    cSWParMilitDescTextBox.Text = dl.cSWParMilitDesc;
        //    cSWWorkingFeelingsTextBox.Text = dl.cSWWorkingFeelings;
        //    cSWWorkingHoursWeekTextBox.Text = dl.cSWWorkingHoursWeek;
        //    cSWDetSuspensTruancyDescTextBox.Text = dl.cSWDetSuspensTruancyDesc;
        //    cSWSigChanSocAcaDescTextBox.Text = dl.cSWSigChanSocAcaDesc;
        //    cSWHowArriveSchedAppointTextBox.Text = dl.cSWHowArriveSchedAppoint;
        //    cSWPrefPharmTextBox.Text = dl.cSWPrefPharm;
        //    cSWObtMedTextBox.Text = dl.cSWObtMed;
        //    cSWMACommSuppServResponseTextBox.Text = dl.cSWMACommSuppServResponse;
        //    cSWMACommSuppServWhenTextBox.Text = dl.cSWMACommSuppServWhen;
        //    cSWAssessNeedTextBox.Text = dl.cSWAssessNeed;
        //    cSWStaffSigTimeTextBox.Text = dl.cSWStaffSigTime;
        //    cSWStaffSigDateDateTimePicker.Value = dl.cSWStaffSigDate;
        //    cSWPreDischTextBox.Text = dl.cSWPreDisch;
        //    cSWSWOtherDescTextBox.Text = dl.cSWSWOtherDesc;
        //    cSWSWOtherCheckBox.Checked = dl.cSWSWOTher;
        //    cSWSWAftercareCheckBox.Checked = dl.cSWSWAftercare;
        //    cSWSWFamilyCheckBox.Checked = dl.cSWSWFamily;
        //    cSWSWIndivCheckBox.Checked = dl.cSWSWIndiv;
        //    cSWSWGroupCheckBox.Checked = dl.cSWSWGroup;
        //    cSWClinConcRecommTextBox.Text = dl.cSWClinConcRecomm;
        //    cSWRefNoneCheckBox.Checked = dl.cSWRefNone;
        //    cSWRefOtherDescTextBox.Text = dl.cSWRefOtherDesc;
        //    cSWRefOtherCheckBox.Checked = dl.cSWRefOther;
        //    cSWRefNeuroCheckBox.Checked = dl.cSWRefNeuro;
        //    cSWRefOutpatDACheckBox.Checked = dl.cSWRefOutpatDA;
        //    cSWRefPCPCheckBox.Checked = dl.cSWRefPCP;
        //    cSWRefInpatDACheckBox.Checked = dl.cSWRefInpatDA;
        //    cSWRefCMBCMCheckBox.Checked = dl.cSWRefCMBC;
        //    cSWRefMSTCheckBox.Checked = dl.cSWREfMST;
        //    cSWRefFBCheckBox.Checked = dl.cSWRefFB;
        //    cSWRefBHRSCheckBox.Checked = dl.cSWRefBHRS;
        //    cSWRefRTFCheckBox.Checked = dl.cSWRefRTF;
        //    cSWRefTFCCRRCheckBox.Checked = dl.cSWRefTFCCRR;
        //    cSWRefPHPCheckBox.Checked = dl.cSWRefPHP;
        //    cSWRefPsychiaCheckBox.Checked = dl.cSWRefPsychia;
        //    cSWRefOutpatCheckBox.Checked = dl.cSWRefOutpat;
        //    cSWBarNoneCheckBox.Checked = dl.cSWBarNone;
        //    cSWBarOtherDescTextBox.Text = dl.cSWBarOtherDesc;
        //    cSWBarOtherCheckBox.Checked = dl.cSWBarOther;
        //    cSWBarAbsFacSpecNeedCheckBox.Checked = dl.cSWBarAbsFacSpecNeed;
        //    cSWBarHisNonCompCheckBox.Checked = dl.cSWBarHisNonComp;
        //    cSWBarHousingCheckBox.Checked = dl.cSWBarHousing;
        //    cSWBarCostMedCheckBox.Checked = dl.cSWBarCostMed;
        //    cSWBarTransportCheckBox.Checked = dl.cSWBarTransport;
        //}

        //private void setChildSocial()
        //{
        //    dl.cSWSocialWorker = cSWSocialWorkerTextBox.Text;
        //    dl.cSWDateComplete = cSWDateCompleteDateTimePicker.Value;
        //    dl.assessStateDate = assessStartDateDateTimePicker.Value;
        //    dl.lastName = lastNameTextBox.Text;
        //    dl.firstName = firstNameTextBox.Text;
        //    dl.cSWCommInv = cSWCommInvTextBox.Text;
        //    dl.cSWCareDescPat = cSWCareDescPatTextBox.Text;
        //    dl.cSWPatDescElse = cSWPatDescElseTextBox.Text;
        //    dl.cSWLevFuncDifTypText = cSWLevFuncDifTypTextBox.Text;
        //    dl.cSWNaturePresProb = cSWNaturePresProbTextBox.Text;
        //    dl.cSWSrcReliabDesc = cSWSrcReliabDescTextBox.Text;
        //    dl.cSWSrcInfo = cSWSrcInfoTextBox.Text;
        //    dl.cSWLegStatDesc = cSWLegStatDescTextBox.Text;
        //    dl.cSWLegalGardDesc = cSWLegalGardDescTextBox.Text;
        //    dl.cSWLegalGardNa = cSWLegalGardNaCheckBox.Checked;
        //    dl.cSWWeapPlanDesc = cSWWeapPlanDescTextBox.Text;
        //    dl.cSWPastSelfInjDesc = cSWPastSelfInjDescTextBox.Text;
        //    dl.cSWLethPriorMean = cSWLethPriorMeanTextBox.Text;
        //    dl.cSWDanDesc = cSWDanDescTextBox.Text;
        //    dl.cSWDanOthInte = cSWDanOthInteCheckBox.Checked;
        //    dl.cSWDanOthAtt = cSWDanOthAttCheckBox.Checked;
        //    dl.cSWDanOthPlan = cSWDanOthPlanCheckBox.Checked;
        //    dl.cSWDanOthIdea = cSWDanOthIdeaCheckBox.Checked;
        //    dl.cSWDanOthHist = cSWDanOthHistCheckBox.Checked;
        //    dl.cSWDanOthCurr = cSWDanOthCurrCheckBox.Checked;
        //    dl.cSWDanOthNot = cSWDanOthNotCheckBox.Checked;
        //    dl.cSWDanSelfInte = cSWDanSelfInteCheckBox.Checked;
        //    dl.cSWDanSelfAtt = cSWDanSelfAttCheckBox.Checked;
        //    dl.cSWDanSelfPlan = cSWDanSelfPlanCheckBox.Checked;
        //    dl.cSWDanSelfIdea = cSWDanSelfIdeaCheckBox.Checked;
        //    dl.cSWDanSelfHist = cSWDanSelfHistCheckBox.Checked;
        //    dl.cSWDanSelfCurr = cSWDanSelfCurrCheckBox.Checked;
        //    dl.cSWDanSelfNot = cSWDanSelfNotCheckBox.Checked;
        //    dl.cSWVerifTime = cSWVerifTimeTextBox.Text;
        //    dl.cSWVerifDate = cSWVerifDateDateTimePicker.Value;
        //    dl.cSWVerif = cSWVerifTextBox.Text;
        //    dl.cSWRespTimePt = cSWRespTimePtTextBox.Text;
        //    dl.cSWRespDatePt = cSWRespDatePtDateTimePicker.Value;
        //    dl.cSWRespPt = cSWRespPtTextBox.Text;
        //    dl.cSWPsyAbuseReportDesc = cSWPsyAbuseReportDescTextBox.Text;
        //    dl.cSWPsyAbuseWitnessDesc = cSWPsyAbuseWitnessDescTextBox.Text;
        //    dl.cSWSexAbuseReportDesc = cSWSexAbuseReportDescTextBox.Text;
        //    dl.cSWSexAbuseWitnessDesc = cSWSexAbuseWitnessDescTextBox.Text;
        //    dl.cSWEmoNegAbuseReportDesc = cSWEmoNegAbuseReportDescTextBox.Text;
        //    dl.cSWEmoNegAbuseWitnessDesc = cSWEmoNegAbuseWitnessDescTextBox.Text;
        //    dl.cSWOthTraumaExp = cSWOthTraumaExpTextBox.Text;
        //    dl.cSWSexActPregNumChi = cSWSexActPregNumChiTextBox.Text;
        //    dl.cSWSexActPregTimes = cSWSexActPregTimesTextBox.Text;
        //    dl.cSWSexActNumPart = cSWSexActNumPartTextBox.Text;
        //    dl.cSWSexActAge = cSWSexActAgeTextBox.Text;
        //    dl.cSWSafeHomeDesc = cSWSafeHomeDescTextBox.Text;
        //    dl.cSWCarePlanDisch = cSWCarePlanDischTextBox.Text;
        //    dl.cSWRetHomeWhen = cSWRetHomeWhenTextBox.Text;
        //    dl.cSWRetHomeWhom = cSWRetHomeWhomTextBox.Text;
        //    dl.cSWHomePriorAdmin = cSWHomePriorAdminTextBox.Text;
        //    dl.cSWPrimeCaregiver = cSWPrimeCaregiverTextBox.Text;
        //    dl.cSWParentMaritStatDate = cSWParentMaritStatDateDateTimePicker.Value;
        //    dl.cSWSigRelat = cSWSigRelatTextBox.Text;
        //    dl.cSWVisitArrange = cSWVisitArrangeTextBox.Text;
        //    dl.cSWMemHelpPatDesc = cSWMemHelpPatDescTextBox.Text;
        //    dl.cSWRecommFamInvAfter = cSWRecommFamInvAfterTextBox.Text;
        //    dl.cSWLevFamInvPrior = cSWLevFamInvPriorTextBox.Text;
        //    dl.cSWFamSessDeclineReason = cSWFamSessDeclineReasonTextBox.Text;
        //    dl.cSWFamSessInvite = cSWFamSessInviteTextBox.Text;
        //    dl.cSWFamSessDate = cSWFamSessDateDateTimePicker.Value;
        //    dl.cSWRelatProbMem = cSWRelatProbMemTextBox.Text;
        //    dl.cSWHistCYSDesc = cSWHistCYSDescTextBox.Text;
        //    dl.cSWCarFeelPatDefBehavDesc = cSWCarFeelPatDifBehavDescTextBox.Text;
        //    dl.cSWSubResultNone = cSWSubResultNoneCheckBox.Checked;
        //    dl.cSWSubResultOtherDesc = cSWSubResultOtherDescTextBox.Text;
        //    dl.cSWSubResultOther = cSWSubResultOtherCheckBox.Checked;
        //    dl.cSWSubResultPromisc = cSWSubResultPromiscCheckBox.Checked;
        //    dl.cSWSubResultWorkProb = cSWSubResultWorkProbCheckBox.Checked;
        //    dl.cSWSubResultBlackout = cSWSubResultBlackoutCheckBox.Checked;
        //    dl.cSWSubResultThoughtSelfHarm = cSWSubResultThoughtSelfHarmCheckBox.Checked;
        //    dl.cSWSubResultUnpaidBills = cSWSubResultUnpaidBillsCheckBox.Checked;
        //    dl.cSWSubResultRelatProb = cSWSubResultRelatProbCheckBox.Checked;
        //    dl.cSWSubResultArrest = cSWSubResultArrestCheckBox.Checked;
        //    dl.cSWEffIneffTreatHist = cSWEffIneffTreatHistTextBox.Text;
        //    dl.cSWHosp30ContribReadminTextBox.Text = cSWHosp30ContribReadmin;
        //    dl.cSWHospPrevHelpCommInvo = cSWHospPrevHelpCommInvoTextBox.Text;
        //    dl.cSWPatPartTreat = cSWPatPartTreatTextBox.Text;
        //    dl.cSWHistHomSuicDesc = cSWHistHomSuicDescTextBox.Text;
        //    dl.cSWFamMemAbuImpDesc = cSWFamMemAbuImpDescTextBox.Text;
        //    dl.cSWInterventions = cSWInterventionsTextBox.Text;
        //    dl.cSWSubABuseTreatHist = cSWSubAbuseTreatHistTextBox.Text;
        //    dl.cSWReasonUse = cSWReasonUseTextBox.Text;
        //    dl.cSWDrugChoice = cSWDrugChoiceTextBox.Text;
        //    dl.cSWHistArrestDesc = cSWHistArrestDescTextBox.Text;
        //    dl.cSWReferMadeDesc = cSWReferMadeDescTextBox.Text;
        //    dl.cSWReferMade = cSWReferMadeCheckBox.Checked;
        //    dl.cSWEduProvFam = cSWEduProvFamCheckBox.Checked;
        //    dl.cSWFamInformRecomm = cSWFamInformRecommCheckBox.Checked;
        //    dl.cSWEduProvPat = cSWEduProvPatCheckBox.Checked;
        //    dl.cSWPatInformRecomm = cSWPatInformRecommCheckBox.Checked;
        //    dl.cSWSubAbuseRecommDesc = cSWSubAbuseRecommDescTextBox.Text;
        //    dl.cSWSubAbuseRecommNA = cSWSubAbuseRecommNACheckBox.Checked;
        //    dl.cSWOthLegIssDesc = cSWOthLegIssDescTextBox.Text;
        //    dl.cSWPatFeelClassmates = cSWPatFeelClassmatesTextBox.Text;
        //    dl.cSWPatFeelSchTeach = cSWPatFeelSchTeachTextBox.Text;
        //    dl.cSWNumSchoolAtt = cSWNumSchoolAttTextBox.Text;
        //    dl.cSWTimeCurrSchool = cSWTimeCurrSchoolTextBox.Text;
        //    dl.cSWCultOtherDesc = cSWCultOtherDescTextBox.Text;
        //    dl.cSWCultIssContribProbDesc = cSWCultIssContribProbDescTextBox.Text;
        //    dl.cSWChangeReligInvolvDesc = cSWChangeReligInvolvDescTextBox.Text;
        //    dl.cSWCurrStatedFeelBody = cSWCurrStatedFeelBodyTextBox.Text;
        //    dl.cSWEatDepBoredDesc = cSWEatDepBoredDescTextBox.Text;
        //    dl.cSWHistSigMedIssDesc = cSWHistSigMedIssDescTextBox.Text;
        //    dl.cSWChronPainDisabImpFunctDesc = cSWChronPainDisabImpFunctDescTextBox.Text;
        //    dl.cSWMedIssContribDesc = cSWMedIssContribDescTextBox.Text;
        //    dl.cSWParMilitDeploy = cSWParMilitDeployTextBox.Text;
        //    dl.cSWParMilitDesc = cSWParMilitDescTextBox.Text;
        //    dl.cSWWorkingFeelings = cSWWorkingFeelingsTextBox.Text;
        //    dl.cSWWorkingHoursWeek = cSWWorkingHoursWeekTextBox.Text;
        //    dl.cSWDetSuspensTruancyDesc = cSWDetSuspensTruancyDescTextBox.Text;
        //    dl.cSWSigChanSocAcaDesc = cSWSigChanSocAcaDescTextBox.Text;
        //    dl.cSWHowArriveSchedAppoint = cSWHowArriveSchedAppointTextBox.Text;
        //    dl.cSWPrefPharm = cSWPrefPharmTextBox.Text;
        //    dl.cSWObtMed = cSWObtMedTextBox.Text;
        //    dl.cSWMACommSuppServResponse = cSWMACommSuppServResponseTextBox.Text;
        //    dl.cSWMACommSuppServWhen = cSWMACommSuppServWhenTextBox.Text;
        //    dl.cSWAssessNeed = cSWAssessNeedTextBox.Text;
        //    dl.cSWStaffSigTime = cSWStaffSigTimeTextBox.Text;
        //    dl.cSWStaffSigDate = cSWStaffSigDateDateTimePicker.Value;
        //    dl.cSWPreDisch = cSWPreDischTextBox.Text;
        //    dl.cSWSWOtherDesc = cSWSWOtherDescTextBox.Text;
        //    dl.cSWSWOTher = cSWSWOtherCheckBox.Checked;
        //    dl.cSWSWAftercare = cSWSWAftercareCheckBox.Checked;
        //    dl.cSWSWFamily = cSWSWFamilyCheckBox.Checked;
        //    dl.cSWSWIndiv = cSWSWIndivCheckBox.Checked;
        //    dl.cSWSWGroup = cSWSWGroupCheckBox.Checked;
        //    dl.cSWClinConcRecomm = cSWClinConcRecommTextBox.Text;
        //    dl.cSWRefNone = cSWRefNoneCheckBox.Checked;
        //    dl.cSWRefOtherDesc = cSWRefOtherDescTextBox.Text;
        //    dl.cSWRefOther = cSWRefOtherCheckBox.Checked;
        //    dl.cSWRefNeuro = cSWRefNeuroCheckBox.Checked;
        //    dl.cSWRefOutpatDA = cSWRefOutpatDACheckBox.Checked;
        //    dl.cSWRefPCP = cSWRefPCPCheckBox.Checked;
        //    dl.cSWRefInpatDA = cSWRefInpatDACheckBox.Checked;
        //    dl.cSWRefCMBC = cSWRefCMBCMCheckBox.Checked;
        //    dl.cSWREfMST = cSWRefMSTCheckBox.Checked;
        //    dl.cSWRefFB = cSWRefFBCheckBox.Checked;
        //    dl.cSWRefBHRS = cSWRefBHRSCheckBox.Checked;
        //    dl.cSWRefRTF = cSWRefRTFCheckBox.Checked;
        //    dl.cSWRefTFCCRR = cSWRefTFCCRRCheckBox.Checked;
        //    dl.cSWRefPHP = cSWRefPHPCheckBox.Checked;
        //    dl.cSWRefPsychia = cSWRefPsychiaCheckBox.Checked;
        //    dl.cSWRefOutpat = cSWRefOutpatCheckBox.Checked;
        //    dl.cSWBarNone = cSWBarNoneCheckBox.Checked;
        //    dl.cSWBarOtherDesc = cSWBarOtherDescTextBox.Text;
        //    dl.cSWBarOther = cSWBarOtherCheckBox.Checked;
        //    dl.cSWBarAbsFacSpecNeed = cSWBarAbsFacSpecNeedCheckBox.Checked;
        //    dl.cSWBarHisNonComp = cSWBarHisNonCompCheckBox.Checked;
        //    dl.cSWBarHousing = cSWBarHousingCheckBox.Checked;
        //    dl.cSWBarCostMed = cSWBarCostMedCheckBox.Checked;
        //    dl.cSWBarTransport = cSWBarTransportCheckBox.Checked;
        //}

        private void cSWPsyAbuseReportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cSWSubResultOtherDescTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
