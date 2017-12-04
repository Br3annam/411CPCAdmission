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

        private void setAdmissionsWindow()
        {
            dl.firstName = firstNameTextBox.Text;
            dl.mRNum = mRNumTextBox.Text;
            dl.dOB = dOBDateTimePicker.Value;
            dl.lastName = lastNameTextBox.Text;
            dl.commitStatDesc = commitStatDescTextBox.Text;
            dl.schedAssessTime = schedAssessTimeTextBox.Text;
            dl.assessStartDate = assessStartDateDateTimePicker.Value;
            dl.race = raceTextBox.Text;
            dl.maritalStat = maritalStatTextBox.Text;
            dl.age = ageTextBox.Text;
            dl.chiefComplaint = chiefComplaintTextBox.Text;
            dl.admPsyDiag = admPsyDiagTextBox.Text;
            dl.affTear = affTearCheckBox.Checked ? "Y" : "N";
            dl.affLab = affLabCheckBox.Checked ? "Y" : "N";
            dl.affRes = affResCheckBox.Checked ? "Y" : "N";
            dl.affBlu = affBluCheckBox.Checked ? "Y" : "N";
            dl.affIna = affInaCheckBox.Checked ? "Y" : "N";
            dl.affApp = affAppCheckBox.Checked ? "Y" : "N";
            dl.thoughtContHalType = thoughtContHalTypeTextBox.Text;
            dl.thoughtContHal = thoughtContHalCheckBox.Checked ? "Y" : "N";
            dl.thoughtContSom = thoughtContSomCheckBox.Checked ? "Y" : "N";
            dl.thoughtContDel = thoughtContDelCheckBox.Checked ? "Y" : "N";
            dl.thoughtContPar = thoughtContParCheckBox.Checked ? "Y" : "N";
            dl.thoughtContGra = thoughtContGraCheckBox.Checked ? "Y" : "N";
            dl.thoughtContPre = thoughtContPreCheckBox.Checked ? "Y" : "N";
            dl.thoughtContRea = thoughtContReaCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcDis = thoughtProcDisCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcBlo = thoughtProcBloCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcObs = thoughtProcObsCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcRac = thoughtProcRacCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcLoo = thoughtProcLooCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcTan = thoughtProcTanCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcCon = thoughtProcConCheckBox.Checked ? "Y" : "N";
            dl.thoughtProcLog = thoughtProcLogCheckBox.Checked ? "Y" : "N";
            dl.moodOtherVal = moodOtherValTextBox.Text;
            dl.moodOther = moodOtherCheckBox.Checked ? "Y" : "N";
            dl.moodHos = moodHosCheckBox.Checked ? "Y" : "N";
            dl.moodEup = moodEupCheckBox.Checked ? "Y" : "N";
            dl.moodIrr = moodIrrCheckBox.Checked ? "Y" : "N";
            dl.moodAnx = moodAnxCheckBox.Checked ? "Y" : "N";
            dl.moodLab = moodLabCheckBox.Checked ? "Y" : "N";
            dl.moodDep = moodDepCheckBox.Checked ? "Y" : "N";
            dl.moodApp = moodAppCheckBox.Checked ? "Y" : "N";
            dl.orientDis = orientDisCheckBox.Checked ? "Y" : "N";
            dl.orientSit = orientSitCheckBox.Checked ? "Y" : "N";
            dl.orientTim = orientTimCheckBox.Checked ? "Y" : "N";
            dl.orientPla = orientPlaCheckBox.Checked ? "Y" : "N";
            dl.orientPer = orientPerCheckBox.Checked ? "Y" : "N";
            dl.speechOtherVal = speechOtherValTextBox.Text;
            dl.speechOther = speechOtherCheckBox.Checked ? "Y" : "N";
            dl.speechMon = speechMonCheckBox.Checked ? "Y" : "N";
            dl.speechHos = speechHosCheckBox.Checked ? "Y" : "N";
            dl.speechLoud = speechLoudCheckBox.Checked ? "Y" : "N";
            dl.speechRam = speechRamCheckBox.Checked ? "Y" : "N";
            dl.speechPre = speechPreCheckBox.Checked ? "Y" : "N";
            dl.speechApp = speechAppCheckBox.Checked ? "Y" : "N";
            dl.appeUna = appeUnaCheckBox.Checked ? "Y" : "N";
            dl.appeLosValue = appeLosValueTextBox.Text;
            dl.appeLos = appeLosCheckBox.Checked ? "Y" : "N";
            dl.appeGai = appeGaiValueTextBox.Text;
            dl.appeInc = appeIncCheckBox.Checked ? "Y" : "N";
            dl.appeGai = appeGaiCheckBox.Checked ? "Y" : "N";
            dl.appeDec = appeDecCheckBox.Checked ? "Y" : "N";
            dl.appeApp = appeAppCheckBox.Checked ? "Y" : "N";
            dl.sleIncValue = sleIncValueTextBox.Text;
            dl.sleInc = sleIncCheckBox.Checked ? "Y" : "N";
            dl.sleDecValue = sleDecValueTextBox.Text;
            dl.sleDec = sleDecCheckBox.Checked ? "Y" : "N";
            dl.sleApp = sleAppCheckBox.Checked ? "Y" : "N";
            dl.idData = idDataTextBox.Text;
            dl.sleUna = sleUnaCheckBox.Checked ? "Y" : "N";
            dl.sleNig = sleNigCheckBox.Checked ? "Y" : "N";
            dl.sleInt = sleIntCheckBox.Checked ? "Y" : "N";
            dl.sleDif = sleDifCheckBox.Checked ? "Y" : "N";
            dl.complTreatBarr = complTreatBarrTextBox.Text;
            dl.histMRSAExpl = histMRSAExplTextBox.Text;
            dl.dietRestExpl = dietRestExplTextBox.Text;
            dl.histFallsExpl = histFallsExplTextBox.Text;
            dl.pCPName = pCPNameTextBox.Text;
            dl.surgical = surgicalTextBox.Text;
            dl.medHistory = medHistoryTextBox.Text;
            dl.deniesLegal = deniesLegalCheckBox.Checked ? "Y" : "N";
            dl.iQ  = int.Parse(iQTextBox.Text);
            dl.prevDiag = prevDiagCheckBox.Checked ? "Y" : "N";
            dl.prevDiagExpl = prevDiagExplTextBox.Text;
            dl.incarcExpl = incarcExplTextBox.Text;
            dl.charges = chargesTextBox.Text;
            dl.legalCounty = legalCountyTextBox.Text;
            dl.parole = paroleCheckBox.Checked ? "Y" : "N";
            dl.probation = probationCheckBox.Checked ? "Y" : "N";
            dl.currentLegal = currentLegalTextBox.Text;
            dl.assoSad = assoSadCheckBox.Checked ? "Y" : "N";
            dl.assoHelpless = assoHelplessCheckBox.Checked ? "Y" : "N";
            dl.assoHopeless = assoHopelessCheckBox.Checked ? "Y" : "N";
            dl.suicIdeaDesc = suicIdeaDescTextBox.Text;
            dl.suicIdeaMeans = suicIdeaMeansCheckBox.Checked ? "Y" : "N";
            dl.suicIdeaIntent = suicIdeaIntentCheckBox.Checked ? "Y" : "N";
            dl.suicIdeaPlan = suicIdeaPlanCheckBox.Checked ? "Y" : "N";
            dl.suicIdeaMethod = suicIdeaMethodCheckBox.Checked ? "Y" : "N";
            dl.suicIdeaNoPlan = suicIdeaNoPlanCheckBox.Checked ? "Y" : "N";
            dl.suicIdeaYes = suicIdeaYesCheckBox.Checked ? "Y" : "N";
            dl.deniesSuic = deniesSuicCheckBox.Checked ? "Y" : "N";
            dl.homIdeaTarget = homIdeaTargetTextBox.Text;
            dl.homIdeaDesc = homIdeaDescTextBox.Text;
            dl.homIdeaMeans = homIdeaMeansCheckBox.Checked ? "Y" : "N";
            dl.homIdeaIntent = homIdeaIntentCheckBox.Checked ? "Y" : "N";
            dl.homIdeaNoPlan = homIdeaNoPlanCheckBox.Checked ? "Y" : "N";
            dl.homIdeaPlan = homIdeaPlanCheckBox.Checked ? "Y" : "N";
            dl.homIdeaYes = homIdeaYesCheckBox.Checked ? "Y" : "N";
            dl.DeniesHom = deniesHomCheckBox.Checked ? "Y" : "N";
            dl.selfInjInpatientDesc = selfInjInpatientDescTextBox.Text;
            dl.selfInjLastAtt = selfInjLastAttTextBox.Text;
            dl.DeniesSelfInj = deniesSelfInjCheckBox.Checked ? "Y" : "N";
            dl.assoIsolative = assoIsolativeCheckBox.Checked ? "Y" : "N";
            dl.assoImpulsive = assoImpulsiveCheckBox.Checked ? "Y" : "N";
            dl.assoTearful = assoTearfulCheckBox.Checked ? "Y" : "N";
            dl.transportDesc = transportDescTextBox.Text;
            dl.accessWeapDesc = accessWeapDescTextBox.Text;
            dl.expSelfDesc = expSelfDescTextBox.Text;
            dl.incPromDesc = incPromDescTextBox.Text;
            dl.combVicDesc = combVicDescTextBox.Text;
            dl.traumEveDesc = traumEveDescTextBox.Text;
            dl.DeniesHistAbuse = deniesHistAbuseCheckBox.Checked ? "Y" : "N";
            dl.psychFamDesc = psychFamDescTextBox.Text;
            dl.psychFam = psychFamCheckBox.Checked ? "Y" : "N";
            dl.DeniesPsychFam = deniesPsychFamCheckBox.Checked ? "Y" : "N";
            dl.angerProbDesc = angerProbDescTextBox.Text;
            dl.hisAssaBehDesc = hisAssaBehDescTextBox.Text;
            dl.DeniesAssa = deniesAssaCheckBox.Checked ? "Y" : "N";
            dl.psychSexPreocc = psychSexPreoccCheckBox.Checked ? "Y" : "N";
            dl.histCrimSex = histCrimSexCheckBox.Checked ? "Y" : "N";
            dl.sexPreocc = sexPreoccCheckBox.Checked ? "Y" : "N";
            dl.histSexAggBeh = histSexAggBehCheckBox.Checked ? "Y" : "N";
            dl.medComp = medCompCheckBox.Checked ? "Y" : "N";
            dl.vicSexAbuse = vicSexAbuseCheckBox.Checked ? "Y" : "N";
            dl.phyStatus = phyStatusCheckBox.Checked ? "Y" : "N";
            dl.vicSexPreocc = vicSexPreoccCheckBox.Checked ? "Y" : "N";
            dl.DevDelay = devDelayCheckBox.Checked ? "Y" : "N";
            dl.auditSubComplTotal = auditSubComplTotalTextBox.Text;
            dl.currentTobUseDesc = currentTobUseDescTextBox.Text;
            dl.famHistSubAbuDesc = famHistSubAbuDescTextBox.Text;
            dl.subLegalProbDesc = subLegalProbDescTextBox.Text;
            dl.longPerSoberDesc = longPerSoberDescTextBox.Text;
            dl.longPerSober = longPerSoberCheckBox.Checked ? "Y" : "N";
            dl.histWIthdrawSympDesc = histWIthdrawSympDescTextBox.Text;
            dl.alcDrugHistDesc = alcDrugHistDescTextBox.Text;
            dl.alcDrugHist = alcDrugHistCheckBox.Checked ? "Y" : "N";
            dl.currentAlcDrugTreatDesc = currentAlcDrugTreatDescTextBox.Text;
            dl.currentAlcDrugTreat = currentAlcDrugTreatCheckBox.Checked ? "Y" : "N";
            dl.deniesAlcDrugTreat = deniesAlcDrugTreatCheckBox.Checked ? "Y" : "N";
            dl.DeniesMisuse = deniesMisuseCheckBox.Checked ? "Y" : "N";
            dl.psychRelDesc = psychRelDescTextBox.Text;
            dl.psychDelDesc = psychDelDescTextBox.Text;
            dl.psychCommDesc = psychCommDescTextBox.Text;
            dl.psychHallDesc = psychHallDescTextBox.Text;
            dl.deniesPsychosis = deniesPsychosisCheckBox.Checked ? "Y" : "N";
            dl.medNotes = medNotesTextBox.Text;
            dl.medCompliantDesc = medCompliantDescTextBox.Text;
            dl.strCopSkills = strCopSkillsTextBox.Text;
            dl.supports = supportsTextBox.Text;
            dl.childUnd18Care = childUnd18CareTextBox.Text;
            dl.childrenDesc = childrenDescTextBox.Text;
            dl.siblingsDesc = siblingsDescTextBox.Text;
            dl.disabilityDesc = disabilityDescTextBox.Text;
            dl.repPayeeDesc = repPayeeDescTextBox.Text;
            dl.employedDesc = employedDescTextBox.Text;
            dl.highLevEdu = highLevEduTextBox.Text;
            dl.encoEnurDesc = encoEnurDescTextBox.Text;
            dl.curSchoolNam = curSchoolNamTextBox.Text;
            dl.education = educationCheckBox.Checked ? "Y" : "N";
            dl.probSchoolDesc = probSchoolDescTextBox.Text;
            dl.detSchPerDesc = detSchPerDescTextBox.Text;
            dl.rebelDesc = rebelDescTextBox.Text;
            dl.rebelHome = rebelHomeCheckBox.Checked ? "Y" : "N";
            dl.rebelSchool = rebelSchoolCheckBox.Checked ? "Y" : "N";
            dl.runAwayDesc = runAwayDescTextBox.Text;
            dl.lyingDesc = lyingDescTextBox.Text;
            dl.stealingDesc = stealingDescTextBox.Text;
            dl.fireSetDesc = fireSetDescTextBox.Text;
            dl.cruelAnimalsDesc = cruelAnimalsDescTextBox.Text;
            dl.bullyOthDesc = bullyOthDescTextBox.Text;
            dl.bulliedDesc = bulliedDescTextBox.Text;
            dl.schRefuDesc = schRefuDescTextBox.Text;
            dl.difMakeFriendsDesc = difMakeFriendsDescTextBox.Text;
            dl.timeAccepted = timeAcceptedDateTimePicker.Value;
            dl.physOnCall = physOnCallTextBox.Text;
            dl.physRecDesc = physRecDescTextBox.Text;
            dl.physRecAdmit = physRecAdmitCheckBox.Checked ? "Y" : "N";
            dl.physRecRefer = physRecReferCheckBox.Checked ? "Y" : "N";
            dl.admPsyDiag = admPsyDiagTextBox.Text;
            dl.provDiagNA = provDiagNACheckBox.Checked ? "Y" : "N";
            dl.provDiagPartHosp = provDiagPartHospCheckBox.Checked ? "Y" : "N";
            dl.provDiagInpatient = provDiagInpatientCheckBox.Checked ? "Y" : "N";
            dl.metalDetectExpl = metalDetectExplTextBox.Text;
            dl.staffPrepIntakeDocDateTime = staffPrepIntakeDocDateTimeDateTimePicker.Value;
            dl.staffPrepIntakeDoc = staffPrepIntakeDocTextBox.Text;
            dl.staffCompIntakeDateTime = staffCompIntakeDateTimeDateTimePicker.Value;
            dl.staffCompIntake = staffCompIntakeTextBox.Text;
            dl.attPhys = attPsychTextBox.Text;
            dl.funcAssess = funcAssessTextBox.Text;
            dl.contextFactDesc = contextFactDescTextBox.Text;
            dl.contextFact = contextFactCheckBox.Checked ? "Y" : "N";
            dl.psychosocialFactDesc = psychosocialFactDescTextBox.Text;
            dl.psychosocialFact = psychosocialFactCheckBox.Checked ? "Y" : "N";
            dl.medDiag = medDiagTextBox.Text;
            dl.medDiagNone = medDiagNoneCheckBox.Checked ? "Y" : "N";
            dl.motorBehaviorDesc = motorBehaviorDescTextBox.Text;
            dl.famHistHomDesc = famHistHomDescTextBox.Text;
            dl.homPriorAttDesc = homPriorAttDescTextBox.Text;
            dl.violOtherHistDesc = violOtherHistDescTextBox.Text;
            dl.violOthers6MoDesc = violOthers6MoDescTextBox.Text;
            dl.attemptInpatDesc = attemptInpatDescTextBox.Text;
            dl.famHistSuicDesc = famHistSuicDescTextBox.Text;
            dl.suicPriorAttDesc = suicPriorAttDescTextBox.Text;
            dl.violSelf6MoDesc = violSelf6MoDescTextBox.Text;
            dl.livingSituationDesc = livingSituationDescTextBox.Text;
            dl.commitStat = commitStatComboBox.SelectedIndex.ToString();
            dl.gender = genderComboBox.SelectedIndex.ToString();
            dl.genderID = genderIDComboBox.SelectedIndex.ToString();
            dl.complTreat = complTreatComboBox.SelectedIndex.ToString();
            dl.outMentHealth = outMentHealthComboBox.SelectedIndex.ToString();
            dl.histFalls = histFallsComboBox.SelectedIndex.ToString();
            dl.pCP = pCPComboBox.SelectedIndex.ToString();
            dl.dietRest = dietRestComboBox.SelectedIndex.ToString();
            dl.histMRSA = histMRSAComboBox.SelectedIndex.ToString();
            dl.psychHosp = psychHospComboBox.SelectedIndex.ToString();
            dl.autismSpecDis = autismSpecDisComboBox.SelectedIndex.ToString();
            dl.intelDisable = intelDisableComboBox.SelectedIndex.ToString();
            dl.reHospNonComp = reHospNonCompComboBox.SelectedIndex.ToString();
            dl.histNonCompMed = histNonCompMedComboBox.SelectedIndex.ToString();
            dl.incarc = incarcComboBox.SelectedIndex.ToString();
            dl.selfInjInpatient = selfInjInpatientComboBox.SelectedIndex.ToString();
            dl.transport = transportComboBox.SelectedIndex.ToString();
            dl.accessWeap = accessWeapComboBox.SelectedIndex.ToString();
            dl.expSelf = expSelfComboBox.SelectedIndex.ToString();
            dl.incProm = incPromComboBox.SelectedIndex.ToString();
            dl.combVic = combVicComboBox.SelectedIndex.ToString();
            dl.traumEve = traumEveComboBox.SelectedIndex.ToString();
            dl.angerProb = angerProbComboBox.SelectedIndex.ToString();
            dl.histAssaBeh = histAssaBehComboBox.SelectedIndex.ToString();
            dl.sexAggRiskBeh = sexAggRiskBehComboBox.SelectedIndex.ToString();
            dl.megLaw = megLawComboBox.SelectedIndex.ToString();
            dl.secVicRisk = secVicRiskComboBox.SelectedIndex.ToString();
            dl.howOftenSix = howOftenSixComboBox.SelectedIndex.ToString();
            dl.howManyAlcTyp = howManyAlcTypComboBox.SelectedIndex.ToString();
            dl.howOftenAlc = howOftenAlcComboBox.SelectedIndex.ToString();
            dl.currentTobUse = currentTobUseComboBox.SelectedIndex.ToString();
            dl.famHistSubAbu = famHistSubAbuComboBox.SelectedIndex.ToString();
            dl.subLegalProb = subLegalProbComboBox.SelectedIndex.ToString();
            dl.delTrem = delTremComboBox.SelectedIndex.ToString();
            dl.histWithdrawSymp = histWithdrawSympComboBox.SelectedIndex.ToString();
            dl.psychRel = psychRelComboBox.SelectedIndex.ToString();
            dl.psychDel = psychDelComboBox.SelectedIndex.ToString();
            dl.psychComm = psychCommComboBox.SelectedIndex.ToString();
            dl.psychHall = psychHallComboBox.SelectedIndex.ToString();
            dl.medCompliant = medCompliantComboBox.SelectedIndex.ToString();
            dl.children = childrenComboBox.SelectedIndex.ToString();
            dl.siblings = siblingsComboBox.SelectedIndex.ToString();
            dl.disability = disabilityComboBox.SelectedIndex.ToString();
            dl.repPayee = repPayeeComboBox.SelectedIndex.ToString();
            dl.employed = employedComboBox.SelectedIndex.ToString();
            dl.cruelAnimals = cruelAnimalsComboBox.SelectedIndex.ToString();
            dl.encoEnur = encoEnurComboBox.SelectedIndex.ToString();
            dl.indivEduProg = indivEduProgComboBox.SelectedIndex.ToString();
            dl.probSchool = probSchoolComboBox.SelectedIndex.ToString();
            dl.detSchPer = detSchPerComboBox.SelectedIndex.ToString();
            dl.rebel = rebelComboBox.SelectedIndex.ToString();
            dl.runAway = runAwayComboBox.SelectedIndex.ToString();
            dl.lying = lyingComboBox.SelectedIndex.ToString();
            dl.stealing = stealingComboBox.SelectedIndex.ToString();
            dl.fireSet = fireSetComboBox.SelectedIndex.ToString();
            dl.bullyOth = bullyOthComboBox.SelectedIndex.ToString();
            dl.bullied = bulliedComboBox.SelectedIndex.ToString();
            dl.schRefu = schRefuComboBox.SelectedIndex.ToString();
            dl.difMakeFriends = difMakeFriendsComboBox.SelectedIndex.ToString();
            dl.anxRelOCDTho = anxRelOCDThoComboBox.SelectedIndex.ToString();
            dl.anxRelOCDBeh = anxRelOCDBehComboBox.SelectedIndex.ToString();
            dl.anxRelHand = anxRelHandComboBox.SelectedIndex.ToString();
            dl.anxRelPhys = anxRelPhysComboBox.SelectedIndex.ToString();
            dl.moodLabPoor = moodLabPoorComboBox.SelectedIndex.ToString();
            dl.moodLabGrand = moodLabGrandComboBox.SelectedIndex.ToString();
            dl.moodLabEsc = moodLabEscComboBox.SelectedIndex.ToString();
            dl.moodLabAggBeh = moodLabAggBehComboBox.SelectedIndex.ToString();
            dl.moodLabSwings = moodLabSwingsComboBox.SelectedIndex.ToString();
            dl.depSympIrritable = depSympIrritableComboBox.SelectedIndex.ToString();
            dl.depSympIsolative = depSympIsolativeComboBox.SelectedIndex.ToString();
            dl.depSympWithdrawn = depSympWithdrawnComboBox.SelectedIndex.ToString();
            dl.depSympHelpless = depSympHelplessComboBox.SelectedIndex.ToString();
            dl.depSympHopeless = depSympHopelessComboBox.SelectedIndex.ToString();
            dl.depSympCrying = depSympCryingComboBox.SelectedIndex.ToString();
            dl.depSympSad = depSympSadComboBox.SelectedIndex.ToString();
            dl.metalDetect = metalDetectComboBox.SelectedIndex.ToString();
            dl.motorBehavior = motorBehaviorComboBox.SelectedIndex.ToString();
            dl.appearance = appearanceComboBox.SelectedIndex.ToString();
            dl.judgement = judgementComboBox.SelectedIndex.ToString();
            dl.insight = insightComboBox.SelectedIndex.ToString();
            dl.famHistHom = famHistHomComboBox.SelectedIndex.ToString();
            dl.homPriorAtt = homPriorAttComboBox.SelectedIndex.ToString();
            dl.violOtherHist = violOtherHistComboBox.SelectedIndex.ToString();
            dl.violOthers6Mo = violOthers6MoComboBox.SelectedIndex.ToString(); 
            dl.attemptInpat = attemptInpatComboBox.SelectedIndex.ToString();
            dl.famHistSuic = famHistSuicComboBox.SelectedIndex.ToString();
            dl.suicPriorAtt = suicPriorAttComboBox.SelectedIndex.ToString();
            dl.violSelf6Mo = violSelf6MoComboBox.SelectedIndex.ToString();
            dl.livingSituation = livingSituationComboBox.SelectedIndex.ToString();
        }

        private void getAdmissionsWindow()
        {
            firstNameTextBox.Text = dl.firstName;
            mRNumTextBox.Text = dl.mRNum;
            dOBDateTimePicker.Value = dl.dOB ?? DateTime.Today;
            lastNameTextBox.Text = dl.lastName;
            commitStatDescTextBox.Text = dl.commitStatDesc;
            schedAssessTimeTextBox.Text = dl.schedAssessTime;
            assessStartDateDateTimePicker.Value = dl.assessStartDate ?? DateTime.Today;
            raceTextBox.Text = dl.race;
            maritalStatTextBox.Text = dl.maritalStat;
            ageTextBox.Text = dl.age;
            chiefComplaintTextBox.Text = dl.chiefComplaint;
            admPsyDiagTextBox.Text = dl.admPsyDiag;
            if (dl.affTear == "Y")
                affTearCheckBox.Checked = true;
            else
                affTearCheckBox.Checked = false;
            if (dl.affLab == "Y")
                affLabCheckBox.Checked = true;
            else
                affLabCheckBox.Checked = false;
            if (dl.affRes == "Y")
                affResCheckBox.Checked = true;
            else
                affResCheckBox.Checked = false;
            if (dl.affBlu == "Y")
                affBluCheckBox.Checked = true;
            else
                affBluCheckBox.Checked = false;
            if (dl.affIna == "Y")
                affInaCheckBox.Checked = true;
            else
                affInaCheckBox.Checked = false;
            if (dl.affApp == "Y")
                affAppCheckBox.Checked = true;
            else
                affAppCheckBox.Checked = false;
            thoughtContHalTypeTextBox.Text = dl.thoughtContHalType;
            if (dl.thoughtContHal == "Y")
                thoughtContHalCheckBox.Checked = true;
            else
                thoughtContHalCheckBox.Checked = false;
            if (dl.thoughtContSom == "Y")
                thoughtContSomCheckBox.Checked = true;
            else
                thoughtContSomCheckBox.Checked = false;
            if (dl.thoughtContDel == "Y")
                thoughtContDelCheckBox.Checked = true;
            else
                thoughtContDelCheckBox.Checked = false;
            if (dl.thoughtContPar == "Y")
                thoughtContParCheckBox.Checked = true;
            else
                thoughtContParCheckBox.Checked = false;
            if (dl.thoughtContGra == "Y")
                thoughtContGraCheckBox.Checked = true;
            else
                thoughtContGraCheckBox.Checked = false;
            if (dl.thoughtContPre == "Y")
                thoughtContPreCheckBox.Checked = true;
            else
                thoughtContPreCheckBox.Checked = false;
            if (dl.thoughtContRea == "Y")
                thoughtContReaCheckBox.Checked = true;
            else
                thoughtContReaCheckBox.Checked = false;
            if (dl.thoughtProcDis == "Y")
                thoughtProcDisCheckBox.Checked = true;
            else
                thoughtProcDisCheckBox.Checked = false;
            if (dl.thoughtProcBlo == "Y")
                thoughtProcBloCheckBox.Checked = true;
            else
                thoughtProcBloCheckBox.Checked = false;
            if (dl.thoughtProcObs == "Y")
                thoughtProcObsCheckBox.Checked = true;
            else
                thoughtProcObsCheckBox.Checked = false;
            if (dl.thoughtProcRac == "Y")
                thoughtProcRacCheckBox.Checked = true;
            else
                thoughtProcRacCheckBox.Checked = false;
            if (dl.thoughtProcLoo == "Y")
                thoughtProcLooCheckBox.Checked = true;
            else
                thoughtProcLooCheckBox.Checked = false;
            if (dl.thoughtProcTan == "Y")
                thoughtProcTanCheckBox.Checked = true;
            else
                thoughtProcTanCheckBox.Checked = false;
            if (dl.thoughtProcCon == "Y")
                thoughtProcConCheckBox.Checked = true;
            else
                thoughtProcConCheckBox.Checked = false;
            if (dl.thoughtProcLog == "Y")
                thoughtProcLogCheckBox.Checked = true;
            else
                thoughtProcLogCheckBox.Checked = false;
            moodOtherValTextBox.Text = dl.moodOtherVal;
            if (dl.moodOther == "Y")
                moodOtherCheckBox.Checked = true;
            else
                moodOtherCheckBox.Checked = false;
            if (dl.moodHos == "Y")
                moodHosCheckBox.Checked = true;
            else
                moodHosCheckBox.Checked = false;
            if (dl.moodEup == "Y")
                moodEupCheckBox.Checked = true;
            else
                moodEupCheckBox.Checked = false;
            if (dl.moodIrr == "Y")
                moodIrrCheckBox.Checked = true;
            else
                moodIrrCheckBox.Checked = false;
            if (dl.moodAnx == "Y")
                moodAnxCheckBox.Checked = true;
            else
                moodAnxCheckBox.Checked = false;
            if (dl.moodLab == "Y")
                moodLabCheckBox.Checked = true;
            else
                moodLabCheckBox.Checked = false;
            if (dl.moodDep == "Y")
                moodDepCheckBox.Checked = true;
            else
                moodDepCheckBox.Checked = false;
            if (dl.moodApp == "Y")
                moodAppCheckBox.Checked = true;
            else
                moodAppCheckBox.Checked = false;
            if (dl.orientDis == "Y")
                orientDisCheckBox.Checked = true;
            else
                orientDisCheckBox.Checked = false;
            if (dl.orientSit == "Y")
                orientSitCheckBox.Checked = true;
            else
                orientSitCheckBox.Checked = false;
            if (dl.orientTim == "Y")
                orientTimCheckBox.Checked = true;
            else
                orientTimCheckBox.Checked = false;
            if (dl.orientPla == "Y")
                orientPlaCheckBox.Checked = true;
            else
                orientPlaCheckBox.Checked = false;
            if (dl.orientPer == "Y")
                orientPerCheckBox.Checked = true;
            else
                orientPerCheckBox.Checked = false;
            speechOtherValTextBox.Text = dl.speechOtherVal;
            if (dl.speechOther == "Y")
                speechOtherCheckBox.Checked = true;
            else
                speechOtherCheckBox.Checked = false;
            if (dl.speechMon == "Y")
                speechMonCheckBox.Checked = true;
            else
                speechMonCheckBox.Checked = false;
            if (dl.speechHos == "Y")
                speechHosCheckBox.Checked = true;
            else
                speechHosCheckBox.Checked = false;
            if (dl.speechLoud == "Y")
                speechLoudCheckBox.Checked = true;
            else
                speechLoudCheckBox.Checked = false;
            if (dl.speechRam == "Y")
                speechRamCheckBox.Checked = true;
            else
                speechRamCheckBox.Checked = false;
            if (dl.speechPre == "Y")
                speechPreCheckBox.Checked = true;
            else
                speechPreCheckBox.Checked = false;
            if (dl.speechApp == "Y")
                speechAppCheckBox.Checked = true;
            else
                speechAppCheckBox.Checked = false;
            if (dl.appeUna == "Y")
                appeUnaCheckBox.Checked = true;
            else
                appeUnaCheckBox.Checked = false;
            appeLosValueTextBox.Text = dl.appeLosValue;
            if (dl.appeLos == "Y")
                appeLosCheckBox.Checked = true;
            else
                appeLosCheckBox.Checked = false;
            appeGaiValueTextBox.Text = dl.appeGai;
            if (dl.appeInc == "Y")
                appeIncCheckBox.Checked = true;
            else
                appeIncCheckBox.Checked = false;
            if (dl.appeGai == "Y")
                appeGaiCheckBox.Checked = true;
            else
                appeGaiCheckBox.Checked = false;
            if (dl.appeDec == "Y")
                appeDecCheckBox.Checked = true;
            else
                appeDecCheckBox.Checked = false;
            if (dl.appeApp == "Y")
                appeAppCheckBox.Checked = true;
            else
                appeAppCheckBox.Checked = false;
            sleIncValueTextBox.Text = dl.sleIncValue;
            if (dl.sleInc == "Y")
                sleIncCheckBox.Checked = true;
            else
                sleIncCheckBox.Checked = false;
            sleDecValueTextBox.Text = dl.sleDecValue;
            if (dl.sleDec == "Y")
                sleDecCheckBox.Checked = true;
            else
                sleDecCheckBox.Checked = false;
            if (dl.sleApp == "Y")
                sleAppCheckBox.Checked = true;
            else
                sleAppCheckBox.Checked = false;
            idDataTextBox.Text = dl.idData;
            if (dl.sleUna == "Y")
                sleUnaCheckBox.Checked = true;
            else
                sleUnaCheckBox.Checked = false;
            if (dl.sleNig == "Y")
                sleNigCheckBox.Checked = true;
            else
                sleNigCheckBox.Checked = false;
            if (dl.sleInt == "Y")
                sleIntCheckBox.Checked = true;
            else
                sleIntCheckBox.Checked = false;
            if (dl.sleDif == "Y")
                sleDifCheckBox.Checked = true;
            else
                sleDifCheckBox.Checked = false;
            complTreatBarrTextBox.Text = dl.complTreatBarr;
            histMRSAExplTextBox.Text = dl.histMRSAExpl;
            dietRestExplTextBox.Text = dl.dietRestExpl;
            histFallsExplTextBox.Text = dl.histFallsExpl;
            pCPNameTextBox.Text = dl.pCPName;
            surgicalTextBox.Text = dl.surgical;
            medHistoryTextBox.Text = dl.medHistory;
            if (dl.deniesLegal == "Y")
                deniesLegalCheckBox.Checked = true;
            else
                deniesLegalCheckBox.Checked = false;
            iQTextBox.Text = dl.iQ.ToString();
            if (dl.prevDiag == "Y")
                prevDiagCheckBox.Checked = true;
            else
                prevDiagCheckBox.Checked = false;
            prevDiagExplTextBox.Text = dl.prevDiagExpl;
            incarcExplTextBox.Text = dl.incarcExpl;
            chargesTextBox.Text = dl.charges;
            legalCountyTextBox.Text = dl.legalCounty;
            if (dl.parole == "Y")
                paroleCheckBox.Checked = true;
            else
                paroleCheckBox.Checked = false;
            if (dl.probation == "Y")
                probationCheckBox.Checked = true;
            else
                probationCheckBox.Checked = false;
            currentLegalTextBox.Text = dl.currentLegal;
            if (dl.assoSad == "Y")
                assoSadCheckBox.Checked = true;
            else
                assoSadCheckBox.Checked = false;
            if (dl.assoHelpless == "Y")
                assoHelplessCheckBox.Checked = true;
            else
                assoHelplessCheckBox.Checked = false;
            if (dl.assoHopeless == "Y")
                assoHopelessCheckBox.Checked = true;
            else
                assoHopelessCheckBox.Checked = false;
            suicIdeaDescTextBox.Text = dl.suicIdeaDesc;
            if (dl.suicIdeaMeans == "Y")
                suicIdeaMeansCheckBox.Checked = true;
            else
                suicIdeaMeansCheckBox.Checked = false;
            if (dl.suicIdeaIntent == "Y")
                suicIdeaIntentCheckBox.Checked = true;
            else
                suicIdeaIntentCheckBox.Checked = false;
            if (dl.suicIdeaPlan == "Y")
                suicIdeaPlanCheckBox.Checked = true;
            else
                suicIdeaPlanCheckBox.Checked = false;
            if (dl.suicIdeaMethod == "Y")
                suicIdeaMethodCheckBox.Checked = true;
            else
                suicIdeaMethodCheckBox.Checked = false;
            if (dl.suicIdeaNoPlan == "Y")
                suicIdeaNoPlanCheckBox.Checked = true;
            else
                suicIdeaNoPlanCheckBox.Checked = false;
            if (dl.suicIdeaYes == "Y")
                suicIdeaYesCheckBox.Checked = true;
            else
                suicIdeaYesCheckBox.Checked = false;
            if (dl.deniesSuic == "Y")
                deniesSuicCheckBox.Checked = true;
            else
                deniesSuicCheckBox.Checked = false;
            homIdeaTargetTextBox.Text = dl.homIdeaTarget;
            homIdeaDescTextBox.Text = dl.homIdeaDesc;
            if (dl.homIdeaMeans == "Y")
                homIdeaMeansCheckBox.Checked = true;
            else
                homIdeaMeansCheckBox.Checked = false;
            if (dl.homIdeaIntent == "Y")
                homIdeaIntentCheckBox.Checked = true;
            else
                homIdeaIntentCheckBox.Checked = false;
            if (dl.homIdeaNoPlan == "Y")
                homIdeaNoPlanCheckBox.Checked = true;
            else
                homIdeaNoPlanCheckBox.Checked = false;
            if (dl.homIdeaPlan == "Y")
                homIdeaPlanCheckBox.Checked = true;
            else
                homIdeaPlanCheckBox.Checked = false;
            if (dl.homIdeaYes == "Y")
                homIdeaYesCheckBox.Checked = true;
            else
                homIdeaYesCheckBox.Checked = false;
            if (dl.DeniesHom == "Y")
                deniesHomCheckBox.Checked = true;
            else
                deniesHomCheckBox.Checked = false;
            selfInjInpatientDescTextBox.Text = dl.selfInjInpatientDesc;
            selfInjLastAttTextBox.Text = dl.selfInjLastAtt;
            if (dl.DeniesSelfInj == "Y")
                deniesSelfInjCheckBox.Checked = true;
            else
                deniesSelfInjCheckBox.Checked = false;
            if (dl.assoIsolative == "Y")
                assoIsolativeCheckBox.Checked = true;
            else
                assoIsolativeCheckBox.Checked = false;
            if (dl.assoImpulsive == "Y")
                assoImpulsiveCheckBox.Checked = true;
            else
                assoImpulsiveCheckBox.Checked = false;
            if (dl.assoTearful == "Y")
                assoTearfulCheckBox.Checked = true;
            else
                assoTearfulCheckBox.Checked = false;
            transportDescTextBox.Text = dl.transportDesc;
            accessWeapDescTextBox.Text = dl.accessWeapDesc;
            expSelfDescTextBox.Text = dl.expSelfDesc;
            incPromDescTextBox.Text = dl.incPromDesc;
            combVicDescTextBox.Text = dl.combVicDesc;
            traumEveDescTextBox.Text = dl.traumEveDesc;
            if (dl.DeniesHistAbuse == "Y")
                deniesHistAbuseCheckBox.Checked = true;
            else
                deniesHistAbuseCheckBox.Checked = false;
            psychFamDescTextBox.Text = dl.psychFamDesc;
            if (dl.psychFam == "Y")
                psychFamCheckBox.Checked = true;
            else
                psychFamCheckBox.Checked = false;
            if (dl.DeniesPsychFam == "Y")
                deniesPsychFamCheckBox.Checked = true;
            else
                deniesPsychFamCheckBox.Checked = false;
            angerProbDescTextBox.Text = dl.angerProbDesc;
            hisAssaBehDescTextBox.Text = dl.hisAssaBehDesc;
            if (dl.DeniesAssa == "Y")
                deniesAssaCheckBox.Checked = true;
            else
                deniesAssaCheckBox.Checked = false;
            if (dl.psychSexPreocc == "Y")
                psychSexPreoccCheckBox.Checked = true;
            else
                psychSexPreoccCheckBox.Checked = false;
            if (dl.histCrimSex == "Y")
                histCrimSexCheckBox.Checked = true;
            else
                histCrimSexCheckBox.Checked = false;
            if (dl.sexPreocc == "Y")
                sexPreoccCheckBox.Checked = true;
            else
                sexPreoccCheckBox.Checked = false;
            if (dl.histSexAggBeh == "Y")
                histSexAggBehCheckBox.Checked = true;
            else
                histSexAggBehCheckBox.Checked = false;
            if (dl.medComp == "Y")
                medCompCheckBox.Checked = true;
            else
                medCompCheckBox.Checked = false;
            if (dl.vicSexAbuse == "Y")
                vicSexAbuseCheckBox.Checked = true;
            else
                vicSexAbuseCheckBox.Checked = false;
            if (dl.phyStatus == "Y")
                phyStatusCheckBox.Checked = true;
            else
                phyStatusCheckBox.Checked = false;
            if (dl.vicSexPreocc == "Y")
                vicSexPreoccCheckBox.Checked = true;
            else
                vicSexPreoccCheckBox.Checked = false;
            if (dl.DevDelay == "Y")
                devDelayCheckBox.Checked = true;
            else
                devDelayCheckBox.Checked = false;
            auditSubComplTotalTextBox.Text = dl.auditSubComplTotal;
            currentTobUseDescTextBox.Text = dl.currentTobUseDesc;
            famHistSubAbuDescTextBox.Text = dl.famHistSubAbuDesc;
            subLegalProbDescTextBox.Text = dl.subLegalProbDesc;
            longPerSoberDescTextBox.Text = dl.longPerSoberDesc;
            if (dl.longPerSober == "Y")
                longPerSoberCheckBox.Checked = true;
            else
                longPerSoberCheckBox.Checked = false;
            histWIthdrawSympDescTextBox.Text = dl.histWIthdrawSympDesc;
            alcDrugHistDescTextBox.Text = dl.alcDrugHistDesc;
            if (dl.alcDrugHist == "Y")
                alcDrugHistCheckBox.Checked = true;
            else
                alcDrugHistCheckBox.Checked = false;
            currentAlcDrugTreatDescTextBox.Text = dl.currentAlcDrugTreatDesc;
            if (dl.currentAlcDrugTreat == "Y")
                currentAlcDrugTreatCheckBox.Checked = true;
            else
                currentAlcDrugTreatCheckBox.Checked = false;
            if (dl.deniesAlcDrugTreat == "Y")
                deniesAlcDrugTreatCheckBox.Checked = true;
            else
                deniesAlcDrugTreatCheckBox.Checked = false;
            if (dl.DeniesMisuse == "Y")
                deniesMisuseCheckBox.Checked = true;
            else
                deniesMisuseCheckBox.Checked = false;
            psychRelDescTextBox.Text = dl.psychRelDesc;
            psychDelDescTextBox.Text = dl.psychDelDesc;
            psychCommDescTextBox.Text = dl.psychCommDesc;
            psychHallDescTextBox.Text = dl.psychHallDesc;
            if (dl.deniesPsychosis == "Y")
                deniesPsychosisCheckBox.Checked = true;
            else
                deniesPsychosisCheckBox.Checked = false;
            medNotesTextBox.Text = dl.medNotes;
            medCompliantDescTextBox.Text = dl.medCompliantDesc;
            strCopSkillsTextBox.Text = dl.strCopSkills;
            supportsTextBox.Text = dl.supports;
            childUnd18CareTextBox.Text = dl.childUnd18Care;
            childrenDescTextBox.Text = dl.childrenDesc;
            siblingsDescTextBox.Text = dl.siblingsDesc;
            disabilityDescTextBox.Text = dl.disabilityDesc;
            repPayeeDescTextBox.Text = dl.repPayeeDesc;
            employedDescTextBox.Text = dl.employedDesc;
            highLevEduTextBox.Text = dl.highLevEdu;
            encoEnurDescTextBox.Text = dl.encoEnurDesc;
            curSchoolNamTextBox.Text = dl.curSchoolNam;
            if (dl.education == "Y")
                educationCheckBox.Checked = true;
            else
                educationCheckBox.Checked = false;
            probSchoolDescTextBox.Text = dl.probSchoolDesc;
            detSchPerDescTextBox.Text = dl.detSchPerDesc;
            rebelDescTextBox.Text = dl.rebelDesc;
            if (dl.rebelHome == "Y")
                rebelHomeCheckBox.Checked = true;
            else
                rebelHomeCheckBox.Checked = false;
            if (dl.rebelSchool == "Y")
                rebelSchoolCheckBox.Checked = true;
            else
                rebelSchoolCheckBox.Checked = false;
            runAwayDescTextBox.Text = dl.runAwayDesc;
            lyingDescTextBox.Text = dl.lyingDesc;
            stealingDescTextBox.Text = dl.stealingDesc;
            fireSetDescTextBox.Text = dl.fireSetDesc;
            cruelAnimalsDescTextBox.Text = dl.cruelAnimalsDesc;
            bullyOthDescTextBox.Text = dl.bullyOthDesc;
            bulliedDescTextBox.Text = dl.bulliedDesc;
            schRefuDescTextBox.Text = dl.schRefuDesc;
            difMakeFriendsDescTextBox.Text = dl.difMakeFriendsDesc;
            timeAcceptedDateTimePicker.Value = dl.timeAccepted ?? DateTime.Today;
            physOnCallTextBox.Text = dl.physOnCall;
            physRecDescTextBox.Text = dl.physRecDesc;
            if (dl.physRecAdmit == "Y")
                physRecAdmitCheckBox.Checked = true;
            else
                physRecAdmitCheckBox.Checked = false;
            if (dl.physRecRefer == "Y")
                physRecReferCheckBox.Checked = true;
            else
                physRecReferCheckBox.Checked = false;
            admPsyDiagTextBox.Text = dl.admPsyDiag;
            if (dl.provDiagNA == "Y")
                provDiagNACheckBox.Checked = true;
            else
                provDiagNACheckBox.Checked = false;
            if (dl.provDiagPartHosp == "Y")
                provDiagPartHospCheckBox.Checked = true;
            else
                provDiagPartHospCheckBox.Checked = false;
            if (dl.provDiagInpatient == "Y")
                provDiagInpatientCheckBox.Checked = true;
            else
                provDiagInpatientCheckBox.Checked = false;
            metalDetectExplTextBox.Text = dl.metalDetectExpl;
            staffPrepIntakeDocDateTimeDateTimePicker.Value = dl.staffPrepIntakeDocDateTime ?? DateTime.Today;
            staffPrepIntakeDocTextBox.Text = dl.staffPrepIntakeDoc;
            staffCompIntakeDateTimeDateTimePicker.Value = dl.staffCompIntakeDateTime ?? DateTime.Today;
            staffCompIntakeTextBox.Text = dl.staffCompIntake;
            attPsychTextBox.Text = dl.attPhys;
            funcAssessTextBox.Text = dl.funcAssess;
            contextFactDescTextBox.Text = dl.contextFactDesc;
            if (dl.contextFact == "Y")
                contextFactCheckBox.Checked = true;
            else
                contextFactCheckBox.Checked = false;
            psychosocialFactDescTextBox.Text = dl.psychosocialFactDesc;
            if (dl.psychosocialFact == "Y")
                psychosocialFactCheckBox.Checked = true;
            else
                psychosocialFactCheckBox.Checked = false;
            medDiagTextBox.Text = dl.medDiag;
            if (dl.medDiagNone == "Y")
                medDiagNoneCheckBox.Checked = true;
            else
                medDiagNoneCheckBox.Checked = false;
            motorBehaviorDescTextBox.Text = dl.motorBehaviorDesc;
            famHistHomDescTextBox.Text = dl.famHistHomDesc;
            homPriorAttDescTextBox.Text = dl.homPriorAttDesc;
            violOtherHistDescTextBox.Text = dl.violOtherHistDesc;
            violOthers6MoDescTextBox.Text = dl.violOthers6MoDesc;
            attemptInpatDescTextBox.Text = dl.attemptInpatDesc;
            famHistSuicDescTextBox.Text = dl.famHistSuicDesc;
            suicPriorAttDescTextBox.Text = dl.suicPriorAttDesc;
            violSelf6MoDescTextBox.Text = dl.violSelf6MoDesc;
            livingSituationDescTextBox.Text = dl.livingSituationDesc;
            commitStatComboBox.SelectedIndex = int.Parse(dl.commitStat);
            commitStatComboBox.SelectedIndex = int.Parse(dl.commitStat);
            genderComboBox.SelectedIndex = int.Parse(dl.gender);
            genderIDComboBox.SelectedIndex = int.Parse(dl.genderID);
            complTreatComboBox.SelectedIndex = int.Parse(dl.complTreat);
            outMentHealthComboBox.SelectedIndex = int.Parse(dl.outMentHealth);
            histFallsComboBox.SelectedIndex = int.Parse(dl.histFalls);
            pCPComboBox.SelectedIndex = int.Parse(dl.pCP);
            dietRestComboBox.SelectedIndex = int.Parse(dl.dietRest);
            histMRSAComboBox.SelectedIndex = int.Parse(dl.histMRSA);
            psychHospComboBox.SelectedIndex = int.Parse(dl.psychHosp);
            autismSpecDisComboBox.SelectedIndex = int.Parse(dl.autismSpecDis);
            intelDisableComboBox.SelectedIndex = int.Parse(dl.intelDisable);
            reHospNonCompComboBox.SelectedIndex = int.Parse(dl.reHospNonComp);
            histNonCompMedComboBox.SelectedIndex = int.Parse(dl.histNonCompMed);
            incarcComboBox.SelectedIndex = int.Parse(dl.incarc);
            selfInjInpatientComboBox.SelectedIndex = int.Parse(dl.selfInjInpatient);
            transportComboBox.SelectedIndex = int.Parse(dl.transport);
            accessWeapComboBox.SelectedIndex = int.Parse(dl.accessWeap);
            expSelfComboBox.SelectedIndex = int.Parse(dl.expSelf);
            incPromComboBox.SelectedIndex = int.Parse(dl.incProm);
            combVicComboBox.SelectedIndex = int.Parse(dl.combVic);
            traumEveComboBox.SelectedIndex = int.Parse(dl.traumEve);
            angerProbComboBox.SelectedIndex = int.Parse(dl.angerProb);
            histAssaBehComboBox.SelectedIndex = int.Parse(dl.histAssaBeh);
            sexAggRiskBehComboBox.SelectedIndex = int.Parse(dl.sexAggRiskBeh);
            megLawComboBox.SelectedIndex = int.Parse(dl.megLaw);
            secVicRiskComboBox.SelectedIndex = int.Parse(dl.secVicRisk);
            howOftenSixComboBox.SelectedIndex = int.Parse(dl.howOftenSix);
            howManyAlcTypComboBox.SelectedIndex = int.Parse(dl.howManyAlcTyp);
            howOftenAlcComboBox.SelectedIndex = int.Parse(dl.howOftenAlc);
            currentTobUseComboBox.SelectedIndex = int.Parse(dl.currentTobUse);
            famHistSubAbuComboBox.SelectedIndex = int.Parse(dl.famHistSubAbu);
            subLegalProbComboBox.SelectedIndex = int.Parse(dl.subLegalProb);
            delTremComboBox.SelectedIndex = int.Parse(dl.delTrem);
            histWithdrawSympComboBox.SelectedIndex = int.Parse(dl.histWithdrawSymp);
            psychRelComboBox.SelectedIndex = int.Parse(dl.psychRel);
            psychDelComboBox.SelectedIndex = int.Parse(dl.psychDel);
            psychCommComboBox.SelectedIndex = int.Parse(dl.psychComm);
            psychHallComboBox.SelectedIndex = int.Parse(dl.psychHall);
            medCompliantComboBox.SelectedIndex = int.Parse(dl.medCompliant);
            childrenComboBox.SelectedIndex = int.Parse(dl.children);
            siblingsComboBox.SelectedIndex = int.Parse(dl.siblings);
            disabilityComboBox.SelectedIndex = int.Parse(dl.disability);
            repPayeeComboBox.SelectedIndex = int.Parse(dl.repPayee);
            employedComboBox.SelectedIndex = int.Parse(dl.employed);
            cruelAnimalsComboBox.SelectedIndex = int.Parse(dl.cruelAnimals);
            encoEnurComboBox.SelectedIndex = int.Parse(dl.encoEnur);
            indivEduProgComboBox.SelectedIndex = int.Parse(dl.indivEduProg);
            probSchoolComboBox.SelectedIndex = int.Parse(dl.probSchool);
            detSchPerComboBox.SelectedIndex = int.Parse(dl.detSchPer);
            rebelComboBox.SelectedIndex = int.Parse(dl.rebel);
            runAwayComboBox.SelectedIndex = int.Parse(dl.runAway);
            lyingComboBox.SelectedIndex = int.Parse(dl.lying);
            stealingComboBox.SelectedIndex = int.Parse(dl.stealing);
            fireSetComboBox.SelectedIndex = int.Parse(dl.fireSet);
            bullyOthComboBox.SelectedIndex = int.Parse(dl.bullyOth);
            bulliedComboBox.SelectedIndex = int.Parse(dl.bullied);
            schRefuComboBox.SelectedIndex = int.Parse(dl.schRefu);
            difMakeFriendsComboBox.SelectedIndex = int.Parse(dl.difMakeFriends);
            anxRelOCDThoComboBox.SelectedIndex = int.Parse(dl.anxRelOCDTho);
            anxRelOCDBehComboBox.SelectedIndex = int.Parse(dl.anxRelOCDBeh);
            anxRelHandComboBox.SelectedIndex = int.Parse(dl.anxRelHand);
            anxRelPhysComboBox.SelectedIndex = int.Parse(dl.anxRelPhys);
            moodLabPoorComboBox.SelectedIndex = int.Parse(dl.moodLabPoor);
            moodLabGrandComboBox.SelectedIndex = int.Parse(dl.moodLabGrand);
            moodLabEscComboBox.SelectedIndex = int.Parse(dl.moodLabEsc);
            moodLabAggBehComboBox.SelectedIndex = int.Parse(dl.moodLabAggBeh);
            moodLabSwingsComboBox.SelectedIndex = int.Parse(dl.moodLabSwings);
            depSympIrritableComboBox.SelectedIndex = int.Parse(dl.depSympIrritable);
            depSympIsolativeComboBox.SelectedIndex = int.Parse(dl.depSympIsolative);
            depSympWithdrawnComboBox.SelectedIndex = int.Parse(dl.depSympWithdrawn);
            depSympHelplessComboBox.SelectedIndex = int.Parse(dl.depSympHelpless);
            depSympHopelessComboBox.SelectedIndex = int.Parse(dl.depSympHopeless);
            depSympCryingComboBox.SelectedIndex = int.Parse(dl.depSympCrying);
            depSympSadComboBox.SelectedIndex = int.Parse(dl.depSympSad);
            metalDetectComboBox.SelectedIndex = int.Parse(dl.metalDetect);
            motorBehaviorComboBox.SelectedIndex = int.Parse(dl.motorBehavior);
            appearanceComboBox.SelectedIndex = int.Parse(dl.appearance);
            judgementComboBox.SelectedIndex = int.Parse(dl.judgement);
            insightComboBox.SelectedIndex = int.Parse(dl.insight);
            famHistHomComboBox.SelectedIndex = int.Parse(dl.famHistHom);
            homPriorAttComboBox.SelectedIndex = int.Parse(dl.homPriorAtt);
            violOtherHistComboBox.SelectedIndex = int.Parse(dl.violOtherHist);
            violOthers6MoComboBox.SelectedIndex = int.Parse(dl.violOthers6Mo);
            attemptInpatComboBox.SelectedIndex = int.Parse(dl.attemptInpat);
            famHistSuicComboBox.SelectedIndex = int.Parse(dl.famHistSuic);
            suicPriorAttComboBox.SelectedIndex = int.Parse(dl.suicPriorAtt);
            violSelf6MoComboBox.SelectedIndex = int.Parse(dl.violSelf6Mo);
            livingSituationComboBox.SelectedIndex = int.Parse(dl.livingSituation);
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
