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
    
    public partial class AdmissionsWindow : Form
    {
        DataLayer dl = new DataLayer();
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

        //private void setAdmissionsWindow()
        //{
        //    dl.firstName = firstNameTextBox.Text;
        //    dl.mRNum = mRNumTextBox.Text;
        //    dOBDateTimePicker.Value = dl.dOB ?? DateTime.Today;
        //    dl.lastName = lastNameTextBox.Text;
        //    dl.commitStatDesc = commitStatDescTextBox.Text;
        //    dl.schedAssessTime = schedAssessTimeTextBox.Text;
        //    assessStartDateDateTimePicker.Value = dl.assessStartDate ?? DateTime.Today;
        //    dl.race = raceTextBox.Text;
        //    dl.maritalStat = maritalStatTextBox.Text;
        //    dl.age = ageTextBox.Text;
        //    dl.chiefComplaint = chiefComplaintTextBox.Text;
        //    dl.admPsyDiag = admPsyDiagTextBox.Text;
        //    dl.affTear = affTearCheckBox.Checked;
        //    dl.affLab = affLabCheckBox.Checked;
        //    dl.affRes = affResCheckBox.Checked;
        //    dl.affBlu = affBluCheckBox.Checked;
        //    dl.affIna = affInaCheckBox.Checked;
        //    dl.affApp = affAppCheckBox.Checked;
        //    dl.thoughtContHalType = thoughtContHalTypeTextBox.Text;
        //    dl.thoughtContHal = thoughtContHalCheckBox.Checked;
        //    dl.thoughtContSom = thoughtContSomCheckBox.Checked;
        //    dl.thoughtContDel = thoughtContDelCheckBox.Checked;
        //    dl.thoughtContPar = thoughtContParCheckBox.Checked;
        //    dl.thoughtContGra = thoughtContGraCheckBox.Checked;
        //    dl.thoughtContPre = thoughtContPreCheckBox.Checked;
        //    dl.thoughtContRea = thoughtContReaCheckBox.Checked;
        //    dl.thoughtProcDis = thoughtProcDisCheckBox.Checked;
        //    dl.thoughtProcBlo = thoughtProcBloCheckBox.Checked;
        //    dl.thoughtProcObs = thoughtProcObsCheckBox.Checked;
        //    dl.thoughtProcRac = thoughtProcRacCheckBox.Checked;
        //    dl.thoughtProcLoo = thoughtProcLooCheckBox.Checked;
        //    dl.thoughtProcTan = thoughtProcTanCheckBox.Checked;
        //    dl.thoughtProcCon = thoughtProcConCheckBox.Checked;
        //    dl.thoughtProcLog = thoughtProcLogCheckBox.Checked;
        //    dl.moodOtherVal = moodOtherValTextBox.Text;
        //    dl.moodOther = moodOtherCheckBox.Checked;
        //    dl.moodHos = moodHosCheckBox.Checked;
        //    dl.moodEup = moodEupCheckBox.Checked;
        //    dl.moodIrr = moodIrrCheckBox.Checked;
        //    dl.moodAnx = moodAnxCheckBox.Checked;
        //    dl.moodLab = moodLabCheckBox.Checked;
        //    dl.moodDep = moodDepCheckBox.Checked;
        //    dl.moodApp = moodAppCheckBox.Checked;
        //    dl.orientDis = orientDisCheckBox.Checked;
        //    dl.orientSit = orientSitCheckBox.Checked;
        //    dl.orientTim = orientTimCheckBox.Checked;
        //    dl.orientPla = orientPlaCheckBox.Checked;
        //    dl.orientPer = orientPerCheckBox.Checked;
        //    dl.speechOtherVal = speechOtherValTextBox.Text;
        //    dl.speechOther = speechOtherCheckBox.Checked;
        //    dl.speechMon = speechMonCheckBox.Checked;
        //    dl.speechHos = speechHosCheckBox.Checked;
        //    dl.speechLoud = speechLoudCheckBox.Checked;
        //    dl.speechRam = speechRamCheckBox.Checked;
        //    dl.speechPre = speechPreCheckBox.Checked;
        //    dl.speechApp = speechAppCheckBox.Checked;
        //    dl.appeUna = appeUnaCheckBox.Checked;
        //    dl.appeLosValue = appeLosValueTextBox.Text;
        //    dl.appeLos = appeLosCheckBox.Checked;
        //    dl.appeGai = appeGaiValueTextBox.Text;
        //    dl.appeInc = appeIncCheckBox.Checked;
        //    dl.appeGai = appeGaiCheckBox.Checked;
        //    dl.appeDec = appeDecCheckBox.Checked;
        //    dl.appeApp = appeAppCheckBox.Checked;
        //    dl.sleIncValue = sleIncValueTextBox.Text;
        //    dl.sleInc = sleIncCheckBox.Checked;
        //    dl.sleDecValue = sleDecValueTextBox.Text;
        //    dl.sleDec = sleDecCheckBox.Checked;
        //    dl.sleApp = sleAppCheckBox.Checked;
        //    dl.idData = idDataTextBox.Text;
        //    dl.sleUna = sleUnaCheckBox.Checked;
        //    dl.sleNig = sleNigCheckBox.Checked;
        //    dl.sleInt = sleIntCheckBox.Checked;
        //    dl.sleDif = sleDifCheckBox.Checked;
        //    dl.complTreatBarr = complTreatBarrTextBox.Text;
        //    dl.histMRSAExpl = histMRSAExplTextBox.Text;
        //    dl.dietRestExpl = dietRestExplTextBox.Text;
        //    dl.histFallsExpl = histFallsExplTextBox.Text;
        //    dl.pCPName = pCPNameTextBox.Text;
        //    dl.surgical = surgicalTextBox.Text;
        //    dl.medHistory = medHistoryTextBox.Text;
        //    dl.deniesLegal = deniesLegalCheckBox.Checked;
        //    iQTextBox.Text = dl.iQ.ToString();
        //    dl.prevDiag = prevDiagCheckBox.Checked;
        //    dl.prevDiagExpl = prevDiagExplTextBox.Text;
        //    dl.incarcExpl = incarcExplTextBox.Text;
        //    dl.charges = chargesTextBox.Text;
        //    dl.legalCounty = legalCountyTextBox.Text;
        //    dl.parole = paroleCheckBox.Checked;
        //    dl.probation = probationCheckBox.Checked;
        //    dl.currentLegal = currentLegalTextBox.Text;
        //    dl.assoSad = assoSadCheckBox.Checked;
        //    dl.assoHelpless = assoHelplessCheckBox.Checked;
        //    dl.AssoHopeless = assoHopelessCheckBox.Checked;
        //    dl.suicIdeaDesc = suicIdeaDescTextBox.Text;
        //    dl.suicIdeameans = suicIdeaMeansCheckBox.Checked;
        //    dl.suicIdeaIntent = suicIdeaIntentCheckBox.Checked;
        //    dl.suicIdeaPlan = suicIdeaPlanCheckBox.Checked;
        //    dl.suicIdeaMethod = suicIdeaMethodCheckBox.Checked;
        //    dl.suidIdeaNoPlan = suicIdeaNoPlanCheckBox.Checked;
        //    dl.suidIdeaYes = suicIdeaYesCheckBox.Checked;
        //    dl.deniesSuic = deniesSuicCheckBox.Checked;
        //    dl.homIdeaTarget = homIdeaTargetTextBox.Text;
        //    dl.homIdeaDesc = homIdeaDescTextBox.Text;
        //    dl.homIdeaMeans = homIdeaMeansCheckBox.Checked;
        //    dl.homIdeaIntent = homIdeaIntentCheckBox.Checked;
        //    dl.homIdeaNoPlan = homIdeaNoPlanCheckBox.Checked;
        //    dl.homIdeaPlan = homIdeaPlanCheckBox.Checked;
        //    dl.homIdeaYes = homIdeaYesCheckBox.Checked;
        //    dl.deniesHom = deniesHomCheckBox.Checked;
        //    dl.selfInjInpatientDesc = selfInjInpatientDescTextBox.Text;
        //    dl.selfInjLastAtt = selfInjLastAttTextBox.Text;
        //    dl.deniesSelfInj = deniesSelfInjCheckBox.Checked;
        //    dl.assoIsolative = assoIsolativeCheckBox.Checked;
        //    dl.assoImpulsive = assoImpulsiveCheckBox.Checked;
        //    dl.assoTearful = assoTearfulCheckBox.Checked;
        //    dl.transportDesc = transportDescTextBox.Text;
        //    dl.accessWeapDesc = accessWeapDescTextBox.Text;
        //    dl.expSelfDesc = expSelfDescTextBox.Text;
        //    dl.incPromDesc = incPromDescTextBox.Text;
        //    dl.combVicDesc = combVicDescTextBox.Text;
        //    dl.traumEveDesc = traumEveDescTextBox.Text;
        //    dl.deniesHistAbuse = deniesHistAbuseCheckBox.Checked;
        //    dl.psychFamDesc = psychFamDescTextBox.Text;
        //    dl.psychFam = psychFamCheckBox.Checked;
        //    dl.deniesPsychFam = deniesPsychFamCheckBox.Checked;
        //    dl.angerProbDesc = angerProbDescTextBox.Text;
        //    dl.hisAssaBehDesc = hisAssaBehDescTextBox.Text;
        //    dl.deniesAssa = deniesAssaCheckBox.Checked;
        //    dl.psychSexPreocc = psychSexPreoccCheckBox.Checked;
        //    dl.histCrimSex = histCrimSexCheckBox.Checked;
        //    dl.sexPreocc = sexPreoccCheckBox.Checked;
        //    dl.histSexAggBeh = histSexAggBehCheckBox.Checked;
        //    dl.medComp = medCompCheckBox.Checked;
        //    dl.vicSexAbuse = vicSexAbuseCheckBox.Checked;
        //    dl.physStatus = phyStatusCheckBox.Checked;
        //    dl.vicSexPreocc = vicSexPreoccCheckBox.Checked;
        //    dl.devDelay = devDelayCheckBox.Checked;
        //    dl.auditSubComplTotal = auditSubComplTotalTextBox.Text;
        //    dl.currentTobUseDesc = currentTobUseDescTextBox.Text;
        //    dl.famHistSubAbuDesc = famHistSubAbuDescTextBox.Text;
        //    dl.subLegalProbDesc = subLegalProbDescTextBox.Text;
        //    dl.longPerSoberDesc = longPerSoberDescTextBox.Text;
        //    dl.longPerSober = longPerSoberCheckBox.Checked;
        //    dl.histWIthdrawSympDesc = histWIthdrawSympDescTextBox.Text;
        //    dl.alcDrugHistDesc = alcDrugHistDescTextBox.Text;
        //    dl.alcDrugHist = alcDrugHistCheckBox.Checked;
        //    dl.currentAlcDrugTreatDesc = currentAlcDrugTreatDescTextBox.Text;
        //    dl.currentAlcDrugTreat = currentAlcDrugTreatCheckBox.Checked;
        //    dl.deniesAlcDrugTreat = deniesAlcDrugTreatCheckBox.Checked;
        //    dl.deniesMisuse = deniesMisuseCheckBox.Checked;
        //    dl.psychRelDesc = psychRelDescTextBox.Text;
        //    dl.psychDelDesc = psychDelDescTextBox.Text;
        //    dl.psychCommDesc = psychCommDescTextBox.Text;
        //    dl.psychHallDesc = psychHallDescTextBox.Text;
        //    dl.deniesPsychosis = deniesPsychosisCheckBox.Checked;
        //    dl.medNotes = medNotesTextBox.Text;
        //    dl.medCompliantDesc = medCompliantDescTextBox.Text;
        //    dl.strCopSkills = strCopSkillsTextBox.Text;
        //    dl.supports = supportsTextBox.Text;
        //    childUnd18CareTextBox.Text = dl.childUnd18Care;
        //    dl.childrenDesc = childrenDescTextBox.Text;
        //    dl.siblingsDesc = siblingsDescTextBox.Text;
        //    dl.disabilityDesc = disabilityDescTextBox.Text;
        //    dl.repPayeeDesc = repPayeeDescTextBox.Text;
        //    dl.employedDesc = employedDescTextBox.Text;
        //    dl.highLevEdu = highLevEduTextBox.Text;
        //    dl.encoEnurDesc = encoEnurDescTextBox.Text;
        //    dl.curSchoolNam = curSchoolNamTextBox.Text;
        //    dl.education = educationCheckBox.Checked;
        //    dl.probSchoolDesc = probSchoolDescTextBox.Text;
        //    dl.detSchPerDesc = detSchPerDescTextBox.Text;
        //    dl.rebelDesc = rebelDescTextBox.Text;
        //    dl.rebelHome = rebelHomeCheckBox.Checked;
        //    dl.rebelSchool = rebelSchoolCheckBox.Checked;
        //    dl.runAwayDesc = runAwayDescTextBox.Text;
        //    dl.lyingDesc = lyingDescTextBox.Text;
        //    dl.stealingDesc = stealingDescTextBox.Text;
        //    dl.fireSetDesc = fireSetDescTextBox.Text;
        //    dl.cruelAnimalsDesc = cruelAnimalsDescTextBox.Text;
        //    dl.bullyOthDesc = bullyOthDescTextBox.Text;
        //    dl.bulliedDesc = bulliedDescTextBox.Text;
        //    dl.schRefuDesc = schRefuDescTextBox.Text;
        //    dl.difMakeFriendsDesc = difMakeFriendsDescTextBox.Text;
        //    timeAcceptedDateTimePicker.Value = dl.timeAccepted ?? DateTime.Today;
        //    dl.physOnCall = physOnCallTextBox.Text;
        //    dl.physRecDesc = physRecDescTextBox.Text;
        //    dl.physRecAdmit = physRecAdmitCheckBox.Checked;
        //    dl.physRecRefer = physRecReferCheckBox.Checked;
        //    dl.admPsyDiag = admPsyDiagTextBox.Text;
        //    dl.provDiagNA = provDiagNACheckBox.Checked;
        //    dl.provDiagPartHosp = provDiagPartHospCheckBox.Checked;
        //    dl.provDiagInpatient = provDiagInpatientCheckBox.Checked;
        //    dl.metalDetectExpl = metalDetectExplTextBox.Text;
        //    staffPrepIntakeDocDateTimeDateTimePicker.Value = dl.staffPrepIntakeDocDateTime ?? DateTime.Today;
        //    dl.staffPrepIntakeDoc = staffPrepIntakeDocTextBox.Text;
        //    staffCompIntakeDateTimeDateTimePicker.Value = dl.staffCompIntakeDateTime ?? DateTime.Today;
        //    dl.staffCompIntake = staffCompIntakeTextBox.Text;
        //    dl.attPhys = attPsychTextBox.Text;
        //    dl.funcAssess = funcAssessTextBox.Text;
        //    dl.contextFactDesc = contextFactDescTextBox.Text;
        //    dl.contextFactCheck = contextFactCheckBox.Checked;
        //    dl.psychosocialFactDesc = psychosocialFactDescTextBox.Text;
        //    dl.psychosocialFact = psychosocialFactCheckBox.Checked;
        //    dl.medDiag = medDiagTextBox.Text;
        //    dl.medDiagNone = medDiagNoneCheckBox.Checked;
        //    dl.motorBehaviorDesc = motorBehaviorDescTextBox.Text;
        //    dl.famHistHomDesc = famHistHomDescTextBox.Text;
        //    dl.homPriorAttDesc = homPriorAttDescTextBox.Text;
        //    dl.violOtherHistDesc = violOtherHistDescTextBox.Text;
        //    violOthers6MoDescTextBox.Text = dl.violOthers6MoDesc;
        //    dl.attemptInpatDesc = attemptInpatDescTextBox.Text;
        //    dl.famHistSuicDesc = famHistSuicDescTextBox.Text;
        //    dl.suicPriorAttDesc = suicPriorAttDescTextBox.Text;
        //    violSelf6MoDescTextBox.Text = dl.violSelf6MoDesc;
        //    dl.livingSituationDesc = livingSituationDescTextBox.Text;
        //}

        //private void getAdmissionsWindow()
        //{
        //    firstNameTextBox.Text = dl.firstName;
        //    mRNumTextBox.Text = dl.mRNum;
        //    dOBDateTimePicker.Value = dl.dOB ?? DateTime.Today;
        //    lastNameTextBox.Text = dl.lastName;
        //    commitStatDescTextBox.Text = dl.commitStatDesc;
        //    schedAssessTimeTextBox.Text = dl.schedAssessTime;
        //    assessStartDateDateTimePicker.Value = dl.assessStartDate ?? DateTime.Today;
        //    raceTextBox.Text = dl.race;
        //    maritalStatTextBox.Text = dl.maritalStat;
        //    ageTextBox.Text = dl.age;
        //    chiefComplaintTextBox.Text = dl.chiefComplaint;
        //    admPsyDiagTextBox.Text = dl.admPsyDiag;
        //    affTearCheckBox.Checked = dl.affTear;
        //    affLabCheckBox.Checked = dl.affLab;
        //    affResCheckBox.Checked = dl.affRes;
        //    affBluCheckBox.Checked = dl.affBlu;
        //    affInaCheckBox.Checked = dl.affIna;
        //    affAppCheckBox.Checked = dl.affApp;
        //    thoughtContHalTypeTextBox.Text = dl.thoughtContHalType;
        //    thoughtContHalCheckBox.Checked = dl.thoughtContHal;
        //    thoughtContSomCheckBox.Checked = dl.thoughtContSom;
        //    thoughtContDelCheckBox.Checked = dl.thoughtContDel;
        //    thoughtContParCheckBox.Checked = dl.thoughtContPar;
        //    thoughtContGraCheckBox.Checked = dl.thoughtContGra;
        //    thoughtContPreCheckBox.Checked = dl.thoughtContPre;
        //    thoughtContReaCheckBox.Checked = dl.thoughtContRea;
        //    thoughtProcDisCheckBox.Checked = dl.thoughtProcDis;
        //    thoughtProcBloCheckBox.Checked = dl.thoughtProcBlo;
        //    thoughtProcObsCheckBox.Checked = dl.thoughtProcObs;
        //    thoughtProcRacCheckBox.Checked = dl.thoughtProcRac;
        //    thoughtProcLooCheckBox.Checked = dl.thoughtProcLoo;
        //    thoughtProcTanCheckBox.Checked = dl.thoughtProcTan;
        //    thoughtProcConCheckBox.Checked = dl.thoughtProcCon;
        //    thoughtProcLogCheckBox.Checked = dl.thoughtProcLog;
        //    moodOtherValTextBox.Text = dl.moodOtherVal;
        //    moodOtherCheckBox.Checked = dl.moodOther;
        //    moodHosCheckBox.Checked = dl.moodHos;
        //    moodEupCheckBox.Checked = dl.moodEup;
        //    moodIrrCheckBox.Checked = dl.moodIrr;
        //    moodAnxCheckBox.Checked = dl.moodAnx;
        //    moodLabCheckBox.Checked = dl.moodLab;
        //    moodDepCheckBox.Checked = dl.moodDep;
        //    moodAppCheckBox.Checked = dl.moodApp;
        //    orientDisCheckBox.Checked = dl.orientDis;
        //    orientSitCheckBox.Checked = dl.orientSit;
        //    orientTimCheckBox.Checked = dl.orientTim;
        //    orientPlaCheckBox.Checked = dl.orientPla;
        //    orientPerCheckBox.Checked = dl.orientPer;
        //    speechOtherValTextBox.Text = dl.speechOtherVal;
        //    speechOtherCheckBox.Checked = dl.speechOther;
        //    speechMonCheckBox.Checked = dl.speechMon;
        //    speechHosCheckBox.Checked = dl.speechHos;
        //    speechLoudCheckBox.Checked = dl.speechLoud;
        //    speechRamCheckBox.Checked = dl.speechRam;
        //    speechPreCheckBox.Checked = dl.speechPre;
        //    speechAppCheckBox.Checked = dl.speechApp;
        //    appeUnaCheckBox.Checked = dl.appeUna;
        //    appeLosValueTextBox.Text = dl.appeLosValue;
        //    appeLosCheckBox.Checked = dl.appeLos;
        //    appeGaiValueTextBox.Text = dl.appeGai;
        //    appeIncCheckBox.Checked = dl.appeInc;
        //    appeGaiCheckBox.Checked = dl.appeGai;
        //    appeDecCheckBox.Checked = dl.appeDec;
        //    appeAppCheckBox.Checked = dl.appeApp;
        //    sleIncValueTextBox.Text = dl.sleIncValue;
        //    sleIncCheckBox.Checked = dl.sleInc;
        //    sleDecValueTextBox.Text = dl.sleDecValue;
        //    sleDecCheckBox.Checked = dl.sleDec;
        //    sleAppCheckBox.Checked = dl.sleApp;
        //    idDataTextBox.Text = dl.idData;
        //    sleUnaCheckBox.Checked = dl.sleUna;
        //    sleNigCheckBox.Checked = dl.sleNig;
        //    sleIntCheckBox.Checked = dl.sleInt;
        //    sleDifCheckBox.Checked = dl.sleDif;
        //    complTreatBarrTextBox.Text = dl.complTreatBarr;
        //    histMRSAExplTextBox.Text = dl.histMRSAExpl;
        //    dietRestExplTextBox.Text = dl.dietRestExpl;
        //    histFallsExplTextBox.Text = dl.histFallsExpl;
        //    pCPNameTextBox.Text = dl.pCPName;
        //    surgicalTextBox.Text = dl.surgical;
        //    medHistoryTextBox.Text = dl.medHistory;
        //    deniesLegalCheckBox.Checked = dl.deniesLegal;
        //    iQTextBox.Text = dl.iQ.ToString();
        //    prevDiagCheckBox.Checked = dl.prevDiag;
        //    prevDiagExplTextBox.Text = dl.prevDiagExpl;
        //    incarcExplTextBox.Text = dl.incarcExpl;
        //    chargesTextBox.Text = dl.charges;
        //    legalCountyTextBox.Text = dl.legalCounty;
        //    paroleCheckBox.Checked = dl.parole;
        //    probationCheckBox.Checked = dl.probation;
        //    currentLegalTextBox.Text = dl.currentLegal;
        //    assoSadCheckBox.Checked = dl.assoSad;
        //    assoHelplessCheckBox.Checked = dl.assoHelpless;
        //    assoHopelessCheckBox.Checked = dl.AssoHopeless;
        //    suicIdeaDescTextBox.Text = dl.suicIdeaDesc;
        //    suicIdeaMeansCheckBox.Checked = dl.suicIdeameans;
        //    suicIdeaIntentCheckBox.Checked = dl.suicIdeaIntent;
        //    suicIdeaPlanCheckBox.Checked = dl.suicIdeaPlan;
        //    suicIdeaMethodCheckBox.Checked = dl.suicIdeaMethod;
        //    suicIdeaNoPlanCheckBox.Checked = dl.suidIdeaNoPlan;
        //    suicIdeaYesCheckBox.Checked = dl.suidIdeaYes;
        //    deniesSuicCheckBox.Checked = dl.deniesSuic;
        //    homIdeaTargetTextBox.Text = dl.homIdeaTarget;
        //    homIdeaDescTextBox.Text = dl.homIdeaDesc;
        //    homIdeaMeansCheckBox.Checked = dl.homIdeaMeans;
        //    homIdeaIntentCheckBox.Checked = dl.homIdeaIntent;
        //    homIdeaNoPlanCheckBox.Checked = dl.homIdeaNoPlan;
        //    homIdeaPlanCheckBox.Checked = dl.homIdeaPlan;
        //    homIdeaYesCheckBox.Checked = dl.homIdeaYes;
        //    deniesHomCheckBox.Checked = dl.deniesHom;
        //    selfInjInpatientDescTextBox.Text = dl.selfInjInpatientDesc;
        //    selfInjLastAttTextBox.Text = dl.selfInjLastAtt;
        //    deniesSelfInjCheckBox.Checked = dl.deniesSelfInj;
        //    assoIsolativeCheckBox.Checked = dl.assoIsolative;
        //    assoImpulsiveCheckBox.Checked = dl.assoImpulsive;
        //    assoTearfulCheckBox.Checked = dl.assoTearful;
        //    transportDescTextBox.Text = dl.transportDesc;
        //    accessWeapDescTextBox.Text = dl.accessWeapDesc;
        //    expSelfDescTextBox.Text = dl.expSelfDesc;
        //    incPromDescTextBox.Text = dl.incPromDesc;
        //    combVicDescTextBox.Text = dl.combVicDesc;
        //    traumEveDescTextBox.Text = dl.traumEveDesc;
        //    deniesHistAbuseCheckBox.Checked = dl.deniesHistAbuse;
        //    psychFamDescTextBox.Text = dl.psychFamDesc;
        //    psychFamCheckBox.Checked = dl.psychFam;
        //    deniesPsychFamCheckBox.Checked = dl.deniesPsychFam;
        //    angerProbDescTextBox.Text = dl.angerProbDesc;
        //    hisAssaBehDescTextBox.Text = dl.hisAssaBehDesc;
        //    deniesAssaCheckBox.Checked = dl.deniesAssa;
        //    psychSexPreoccCheckBox.Checked = dl.psychSexPreocc;
        //    histCrimSexCheckBox.Checked = dl.histCrimSex;
        //    sexPreoccCheckBox.Checked = dl.sexPreocc;
        //    histSexAggBehCheckBox.Checked = dl.histSexAggBeh;
        //    medCompCheckBox.Checked = dl.medComp;
        //    vicSexAbuseCheckBox.Checked = dl.vicSexAbuse;
        //    phyStatusCheckBox.Checked = dl.physStatus;
        //    vicSexPreoccCheckBox.Checked = dl.vicSexPreocc;
        //    devDelayCheckBox.Checked = dl.devDelay;
        //    auditSubComplTotalTextBox.Text = dl.auditSubComplTotal;
        //    currentTobUseDescTextBox.Text = dl.currentTobUseDesc;
        //    famHistSubAbuDescTextBox.Text = dl.famHistSubAbuDesc;
        //    subLegalProbDescTextBox.Text = dl.subLegalProbDesc;
        //    longPerSoberDescTextBox.Text = dl.longPerSoberDesc;
        //    longPerSoberCheckBox.Checked = dl.longPerSober;
        //    histWIthdrawSympDescTextBox.Text = dl.histWIthdrawSympDesc;
        //    alcDrugHistDescTextBox.Text = dl.alcDrugHistDesc;
        //    alcDrugHistCheckBox.Checked = dl.alcDrugHist;
        //    currentAlcDrugTreatDescTextBox.Text = dl.currentAlcDrugTreatDesc;
        //    currentAlcDrugTreatCheckBox.Checked = dl.currentAlcDrugTreat;
        //    deniesAlcDrugTreatCheckBox.Checked = dl.deniesAlcDrugTreat;
        //    deniesMisuseCheckBox.Checked = dl.deniesMisuse;
        //    psychRelDescTextBox.Text = dl.psychRelDesc;
        //    psychDelDescTextBox.Text = dl.psychDelDesc;
        //    psychCommDescTextBox.Text = dl.psychCommDesc;
        //    psychHallDescTextBox.Text = dl.psychHallDesc;
        //    deniesPsychosisCheckBox.Checked = dl.deniesPsychosis;
        //    medNotesTextBox.Text = dl.medNotes;
        //    medCompliantDescTextBox.Text = dl.medCompliantDesc;
        //    strCopSkillsTextBox.Text = dl.strCopSkills;
        //    supportsTextBox.Text = dl.supports;
        //    childUnd18CareTextBox.Text = dl.childUnd18Care;
        //    childrenDescTextBox.Text = dl.childrenDesc;
        //    siblingsDescTextBox.Text = dl.siblingsDesc;
        //    disabilityDescTextBox.Text = dl.disabilityDesc;
        //    repPayeeDescTextBox.Text = dl.repPayeeDesc;
        //    employedDescTextBox.Text = dl.employedDesc;
        //    highLevEduTextBox.Text = dl.highLevEdu;
        //    encoEnurDescTextBox.Text = dl.encoEnurDesc;
        //    curSchoolNamTextBox.Text = dl.curSchoolNam;
        //    educationCheckBox.Checked = dl.education;
        //    probSchoolDescTextBox.Text = dl.probSchoolDesc;
        //    detSchPerDescTextBox.Text = dl.detSchPerDesc;
        //    rebelDescTextBox.Text = dl.rebelDesc;
        //    rebelHomeCheckBox.Checked = dl.rebelHome;
        //    rebelSchoolCheckBox.Checked = dl.rebelSchool;
        //    runAwayDescTextBox.Text = dl.runAwayDesc;
        //    lyingDescTextBox.Text = dl.lyingDesc;
        //    stealingDescTextBox.Text = dl.stealingDesc;
        //    fireSetDescTextBox.Text = dl.fireSetDesc;
        //    cruelAnimalsDescTextBox.Text = dl.cruelAnimalsDesc;
        //    bullyOthDescTextBox.Text = dl.bullyOthDesc;
        //    bulliedDescTextBox.Text = dl.bulliedDesc;
        //    schRefuDescTextBox.Text = dl.schRefuDesc;
        //    difMakeFriendsDescTextBox.Text = dl.difMakeFriendsDesc;
        //    timeAcceptedDateTimePicker.Value = dl.timeAccepted ?? DateTime.Today;
        //    physOnCallTextBox.Text = dl.physOnCall;
        //    physRecDescTextBox.Text = dl.physRecDesc;
        //    physRecAdmitCheckBox.Checked = dl.physRecAdmit;
        //    physRecReferCheckBox.Checked = dl.physRecRefer;
        //    admPsyDiagTextBox.Text = dl.admPsyDiag;
        //    provDiagNACheckBox.Checked = dl.provDiagNA;
        //    provDiagPartHospCheckBox.Checked = dl.provDiagPartHosp;
        //    provDiagInpatientCheckBox.Checked = dl.provDiagInpatient;
        //    metalDetectExplTextBox.Text = dl.metalDetectExpl;
        //    staffPrepIntakeDocDateTimeDateTimePicker.Value = dl.staffPrepIntakeDocDateTime ?? DateTime.Today;
        //    staffPrepIntakeDocTextBox.Text = dl.staffPrepIntakeDoc;
        //    staffCompIntakeDateTimeDateTimePicker.Value = dl.staffCompIntakeDateTime ?? DateTime.Today;
        //    staffCompIntakeTextBox.Text = dl.staffCompIntake;
        //    attPsychTextBox.Text = dl.attPhys;
        //    funcAssessTextBox.Text = dl.funcAssess;
        //    contextFactDescTextBox.Text = dl.contextFactDesc;
        //    contextFactCheckBox.Checked = dl.contextFactCheck;
        //    psychosocialFactDescTextBox.Text = dl.psychosocialFactDesc;
        //    psychosocialFactCheckBox.Checked = dl.psychosocialFact;
        //    medDiagTextBox.Text = dl.medDiag;
        //    medDiagNoneCheckBox.Checked = dl.medDiagNone;
        //    motorBehaviorDescTextBox.Text = dl.motorBehaviorDesc;
        //    famHistHomDescTextBox.Text = dl.famHistHomDesc;
        //    homPriorAttDescTextBox.Text = dl.homPriorAttDesc;
        //    violOtherHistDescTextBox.Text = dl.violOtherHistDesc;
        //    violOthers6MoDescTextBox.Text = dl.violOthers6MoDesc;
        //    attemptInpatDescTextBox.Text = dl.attemptInpatDesc;
        //    famHistSuicDescTextBox.Text = dl.famHistSuicDesc;
        //    suicPriorAttDescTextBox.Text = dl.suicPriorAttDesc;
        //    violSelf6MoDescTextBox.Text = dl.violSelf6MoDesc;
        //    livingSituationDescTextBox.Text = dl.livingSituationDesc;
        //}

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
