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
        DataLayer dl = new DataLayer();
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

        private void setNursing()
        {
            dl.bloodPressure = bloodPressureTextBox.Text;
            dl.waistCm = waistCmTextBox.Text;
            dl.waist = waistTextBox.Text;
            dl.weightKg = weightKgTextBox.Text;
            dl.weight = weightTextBox.Text;
            dl.heighCm = heighCmTextBox.Text;
            dl.height = heightTextBox.Text;
            dl.eyeColor = eyeColorTextBox.Text;
            dl.hairColor = hairColorTextBox.Text;
            dl.r = rTextBox.Text;
            dl.p = pTextBox.Text;
            dl.t = tTextBox.Text;
            dl.painOtherDesc = painOtherDescTextBox.Text;
            dl.painOther = painOtherCheckBox.Checked ? "Y" : "N";
            dl.medicationDesc = medicationDescTextBox.Text;
            dl.medication = medicationCheckBox.Checked ? "Y" : "N";
            dl.relaxation = relaxationCheckBox.Checked ? "Y" : "N";
            dl.deepBreathing = deepBreathingCheckBox.Checked ? "Y" : "N";
            dl.elevation = elevationCheckBox.Checked ? "Y" : "N";
            dl.resting = restingCheckBox.Checked ? "Y" : "N";
            dl.applyCold = applyColdCheckBox.Checked ? "Y" : "N";
            dl.applyHeat = applyHeatCheckBox.Checked ? "Y" : "N";
            dl.sTDHistDesc = sTDHistDescTextBox.Text;
            dl.sTDHist = sTDHistCheckBox.Checked ? "Y" : "N";
            dl.prefOther = prefOtherCheckBox.Checked ? "Y" : "N";
            dl.prefOtherDesc = prefOtherDescTextBox.Text;
            dl.prefPan = prefPanCheckBox.Checked ? "Y" : "N";
            dl.prefBi = prefBiCheckBox.Checked ? "Y" : "N";
            dl.prefFemale = prefFemaleCheckBox.Checked ? "Y" : "N";
            dl.prefMale = prefMaleCheckBox.Checked ? "Y" : "N";
            dl.denySex = denySexCheckBox.Checked ? "Y" : "N";
            dl.sexualActive = sexualActiveCheckBox.Checked ? "Y" : "N";
            dl.bowelOtherDesc = bowelOtherDescTextBox.Text;
            dl.bowelOther = bowelOtherCheckBox.Checked ? "Y" : "N";
            dl.antiDiarrheal = antiDiarrhealCheckBox.Checked ? "Y" : "N";
            dl.lax = laxCheckBox.Checked ? "Y" : "N";
            dl.incont = incontCheckBox.Checked ? "Y" : "N";
            dl.hemmoroids = hemmoroidsCheckBox.Checked ? "Y" : "N";
            dl.constipation = constipationCheckBox.Checked ? "Y" : "N";
            dl.diarrhea = diarrheaCheckBox.Checked ? "Y" : "N";
            dl.bowelDeny = bowelDenyCheckBox.Checked ? "Y" : "N";
            dl.gastroOtherDesc = gastroOtherDescTextBox.Text;
            dl.gastroOther = gastroOtherCheckBox.Checked ? "Y" : "N";
            dl.livDisease = livDiseaseCheckBox.Checked ? "Y" : "N";
            dl.hernia = herniaCheckBox.Checked ? "Y" : "N";
            dl.gERD = gERDCheckBox.Checked ? "Y" : "N";
            dl.gastroUlcers = gastroUlcersCheckBox.Checked ? "Y" : "N";
            dl.gastroPain = gastroPainCheckBox.Checked ? "Y" : "N";
            dl.nausea = nauseaCheckBox.Checked ? "Y" : "N";
            dl.gastroDeny = gastroDenyCheckBox.Checked ? "Y" : "N";
            dl.cardioOtherDesc = cardioOtherDescTextBox.Text;
            dl.cardioOther = cardioOtherCheckBox.Checked ? "Y" : "N";
            dl.heartFailure = heartFailureCheckBox.Checked ? "Y" : "N";
            dl.arrhythmia = arrhythmiaCheckBox.Checked ? "Y" : "N";
            dl.edema = edemaCheckBox.Checked ? "Y" : "N";
            dl.hypotension = hypotensionCheckBox.Checked ? "Y" : "N";
            dl.hypertension = hypertensionCheckBox.Checked ? "Y" : "N";
            dl.irregPulse = irregPulseCheckBox.Checked ? "Y" : "N";
            dl.palitations = palitationsCheckBox.Checked ? "Y" : "N";
            dl.pVD = pVDCheckBox.Checked ? "Y" : "N";
            dl.mI = mICheckBox.Checked ? "Y" : "N";
            dl.pacemaker = pacemakerCheckBox.Checked ? "Y" : "N";
            dl.chestPain = chestPainCheckBox.Checked ? "Y" : "N";
            dl.denyCardio = denyCardioCheckBox.Checked ? "Y" : "N";
            dl.lastBM = lastBMTextBox.Text;
            dl.dentalDeny = dentalDenyCheckBox.Checked ? "Y" : "N";
            dl.dentalOtherDesc = dentalOtherDescTextBox.Text;
            dl.dentalOther = dentalOtherCheckBox.Checked ? "Y" : "N";
            dl.extractions = extractionsCheckBox.Checked ? "Y" : "N";
            dl.bleedingGums = bleedingGumsCheckBox.Checked ? "Y" : "N";
            dl.dentalUlcers = dentalUlcersCheckBox.Checked ? "Y" : "N";
            dl.looseMissingTeeth = looseMissingTeethCheckBox.Checked ? "Y" : "N";
            dl.denturesPart = denturesPartCheckBox.Checked ? "Y" : "N";
            dl.denturesLow = denturesLowCheckBox.Checked ? "Y" : "N";
            dl.denturesUp = denturesUpCheckBox.Checked ? "Y" : "N";
            dl.respOtherDesc = respOtherDescTextBox.Text;
            dl.respOther = respOtherCheckBox.Checked ? "Y" : "N";
            dl.cPAP = cPAPCheckBox.Checked ? "Y" : "N";
            dl.sleepApnea = sleepApneaCheckBox.Checked ? "Y" : "N";
            dl.cOPD = cOPDCheckBox.Checked ? "Y" : "N";
            dl.cough = coughCheckBox.Checked ? "Y" : "N";
            dl.asthma = asthmaCheckBox.Checked ? "Y" : "N";
            dl.laboredBreath = laboredBreathCheckBox.Checked ? "Y" : "N";
            dl.shortBreath = shortBreathCheckBox.Checked ? "Y" : "N";
            dl.respDeny = respDenyCheckBox.Checked ? "Y" : "N";
            dl.noseThroatOtherDesc = noseThroatOtherDescTextBox.Text;
            dl.noseThroatOther = noseThroatOtherCheckBox.Checked ? "Y" : "N";
            dl.thrush = thrushCheckBox.Checked ? "Y" : "N";
            dl.coldSympt = coldSymptCheckBox.Checked ? "Y" : "N";
            dl.diffSwallow = diffSwallowCheckBox.Checked ? "Y" : "N";
            dl.hoarseness = hoarsenessCheckBox.Checked ? "Y" : "N";
            dl.soreThroat = soreThroatCheckBox.Checked ? "Y" : "N";
            dl.sinus = sinusCheckBox.Checked ? "Y" : "N";
            dl.noseThroatDeny = noseThroatDenyCheckBox.Checked ? "Y" : "N";
            dl.skinOtherDesc = skinOtherDescTextBox.Text;
            dl.skinOther = skinOtherCheckBox.Checked ? "Y" : "N";
            dl.staplesNum = staplesNumTextBox.Text;
            dl.staples = staplesCheckBox.Checked ? "Y" : "N";
            dl.numSutures = numSuturesTextBox.Text;
            dl.sutures = suturesCheckBox.Checked ? "Y" : "N";
            dl.wound = woundCheckBox.Checked ? "Y" : "N";
            dl.itching = itchingCheckBox.Checked ? "Y" : "N";
            dl.discolor = discolorCheckBox.Checked ? "Y" : "N";
            dl.rashHives = rashHivesCheckBox.Checked ? "Y" : "N";
            dl.bruises = bruisesCheckBox.Checked ? "Y" : "N";
            dl.scars = scarsCheckBox.Checked ? "Y" : "N";
            dl.skinUlcers = skinUlcersCheckBox.Checked ? "Y" : "N";
            dl.skinDeny = skinDenyCheckBox.Checked ? "Y" : "N";
            dl.neuroOtherDesc = neuroOtherDescTextBox.Text;
            dl.neuroOther = neuroOtherCheckBox.Checked ? "Y" : "N";
            dl.migraine = migraineCheckBox.Checked ? "Y" : "N";
            dl.tremors = tremorsCheckBox.Checked ? "Y" : "N";
            dl.dizziness = dizzinessCheckBox.Checked ? "Y" : "N";
            dl.headInjuryTrauma = headInjuryTraumaCheckBox.Checked ? "Y" : "N";
            dl.weakParalysis = weakParalysisCheckBox.Checked ? "Y" : "N";
            dl.neuroConfusion = neuroConfusionCheckBox.Checked ? "Y" : "N";
            dl.freqHeadache = freqHeadacheCheckBox.Checked ? "Y" : "N";
            dl.stroke = strokeCheckBox.Checked ? "Y" : "N";
            dl.lastSeizure = lastSeizureTextBox.Text;
            dl.seizures = seizuresCheckBox.Checked ? "Y" : "N";
            dl.neuroDeny = neuroDenyCheckBox.Checked ? "Y" : "N";
            dl.muscOtherDesc = muscOtherDescTextBox.Text;
            dl.muscOther = muscOtherCheckBox.Checked ? "Y" : "N";
            dl.muscWeakness = muscWeaknessCheckBox.Checked ? "Y" : "N";
            dl.boneDisease = boneDiseaseCheckBox.Checked ? "Y" : "N";
            dl.breaks = breaksCheckBox.Checked ? "Y" : "N";
            dl.muscRigid = muscRigidCheckBox.Checked ? "Y" : "N";
            dl.arthritis = arthritisCheckBox.Checked ? "Y" : "N";
            dl.jointPain = jointPainCheckBox.Checked ? "Y" : "N";
            dl.backPain = backPainCheckBox.Checked ? "Y" : "N";
            dl.muscDeny = muscDenyCheckBox.Checked ? "Y" : "N";
            dl.endoOtherDesc = endoOtherDescTextBox.Text;
            dl.endoOther = endoOtherCheckBox.Checked ? "Y" : "N";
            dl.diagEndoDisDesc = diagEndoDisDescTextBox.Text;
            dl.diagEndoDis = diagEndoDisCheckBox.Checked ? "Y" : "N";
            dl.dietControlled = dietControlledCheckBox.Checked ? "Y" : "N";
            dl.endoInsulin = endoInsulinCheckBox.Checked ? "Y" : "N";
            dl.endoDiabetes = endoDiabetesCheckBox.Checked ? "Y" : "N";
            dl.endoDeny = endoDenyCheckBox.Checked ? "Y" : "N";
            dl.genitOtherDesc = genitOtherDescTextBox.Text;
            dl.genitOther = genitOtherCheckBox.Checked ? "Y" : "N";
            dl.incontinence = incontCheckBox.Checked ? "Y" : "N";
            dl.hesitancy = hesitancyCheckBox.Checked ? "Y" : "N";
            dl.genitFreqDec = genitFreqDecCheckBox.Checked ? "Y" : "N";
            dl.genitFreqInc = genitFreqIncCheckBox.Checked ? "Y" : "N";
            dl.uTI = uTICheckBox.Checked ? "Y" : "N";
            dl.hematuria = hematuriaCheckBox.Checked ? "Y" : "N";
            dl.nocturia = nocturiaCheckBox.Checked ? "Y" : "N";
            dl.burning = burningCheckBox.Checked ? "Y" : "N";
            dl.genitDeny = genitDenyCheckBox.Checked ? "Y" : "N";
            dl.maleRepOtherDesc = maleRepOtherDescTextBox.Text;
            dl.maleRepOther = maleRepOtherCheckBox.Checked ? "Y" : "N";
            dl.maleProstateProb = maleProstateProbCheckBox.Checked ? "Y" : "N";
            dl.maleImpotent = maleImpotentCheckBox.Checked ? "Y" : "N";
            dl.maleHesitancy = maleHesitancyCheckBox.Checked ? "Y" : "N";
            dl.maleDischarge = maleDischargeCheckBox.Checked ? "Y" : "N";
            dl.maleRepDeny = maleRepDenyCheckBox.Checked ? "Y" : "N";
            dl.maleRepNA = maleRepNACheckBox.Checked ? "Y" : "N";
            dl.lMP = lMPTextBox.Text;
            dl.menstOtherDesc = menstOtherDescTextBox.Text;
            dl.menstOther = menstOtherCheckBox.Checked ? "Y" : "N";
            dl.amenorrhea = amenorrheaCheckBox.Checked ? "Y" : "N";
            dl.dysmen = dysmenCheckBox.Checked ? "Y" : "N";
            dl.regMenst = regMenstCheckBox.Checked ? "Y" : "N";
            dl.menstDeny = menstDenyCheckBox.Checked ? "Y" : "N";
            dl.menstNa = menstNaCheckBox.Checked ? "Y" : "N";
            dl.femRepOtherDesc = femRepOtherDescTextBox.Text;
            dl.femRepOther = femRepOtherCheckBox.Checked ? "Y" : "N";
            dl.birthControlType = birthControlTypeTextBox.Text;
            dl.birthControl = birthControlCheckBox.Checked ? "Y" : "N";
            dl.pregMonths = pregMonthsTextBox.Text;
            dl.preg = pregCheckBox.Checked ? "Y" : "N";
            dl.suspPreg = suspPregCheckBox.Checked ? "Y" : "N";
            dl.femRepDeny = femRepDenyCheckBox.Checked ? "Y" : "N";
            dl.femRepNA = femRepNACheckBox.Checked ? "Y" : "N";
            dl.physicalGenWeak = physicalGenWeakCheckBox.Checked ? "Y" : "N";
            dl.physicalAssistDev = physicalAssistDevCheckBox.Checked ? "Y" : "N";
            dl.physicalFatigue = physicalFatigueCheckBox.Checked ? "Y" : "N";
            dl.physicalStanding = physicalStandingCheckBox.Checked ? "Y" : "N";
            dl.physicalBedImm = physicalBedImmCheckBox.Checked ? "Y" : "N";
            dl.physicalTransDiff = physicalTransDiffCheckBox.Checked ? "Y" : "N";
            dl.physicalImpGait = physicalImpGaitCheckBox.Checked ? "Y" : "N";
            dl.physicalDeny = physicalDenyCheckBox.Checked ? "Y" : "N";
            dl.concernReturnResDesc = concernReturnResDescTextBox.Text;
            dl.occuDressing = occuDressingCheckBox.Checked ? "Y" : "N";
            dl.occuDeny = occuDenyCheckBox.Checked ? "Y" : "N";
            dl.sleepOtherDesc = sleepOtherDescTextBox.Text;
            dl.sleepOther = sleepOtherCheckBox.Checked ? "Y" : "N";
            dl.sleepNightmares = sleepNightmaresCheckBox.Checked ? "Y" : "N";
            dl.sleepReqMed = sleepReqMedCheckBox.Checked ? "Y" : "N";
            dl.sleepNightAwake = sleepNightAwakeCheckBox.Checked ? "Y" : "N";
            dl.sleepEarlyAwake = sleepEarlyAwakeCheckBox.Checked ? "Y" : "N";
            dl.sleepInsom = sleepInsomCheckBox.Checked ? "Y" : "N";
            dl.sleepDeny = sleepDenyCheckBox.Checked ? "Y" : "N";
            dl.sleepAvg = sleepAvgTextBox.Text;
            dl.swalOtherDesc = swalOtherDescTextBox.Text;
            dl.swalOther = swalOtherCheckBox.Checked ? "Y" : "N";
            dl.swalDrool = swalDroolCheckBox.Checked ? "Y" : "N";
            dl.swalHistAsp = swalHistAspCheckBox.Checked ? "Y" : "N";
            dl.swalCoughWhile = swalCoughWhileCheckBox.Checked ? "Y" : "N";
            dl.swalCoughAfter = swalCoughAfterCheckBox.Checked ? "Y" : "N";
            dl.swalDiffSwal = swalDiffSwalCheckBox.Checked ? "Y" : "N";
            dl.swalDeny = swalDenyCheckBox.Checked ? "Y" : "N";
            dl.occuOtherDesc = occuOtherDescTextBox.Text;
            dl.occuOther = occuOtherCheckBox.Checked ? "Y" : "N";
            dl.occuToilet = occuToiletCheckBox.Checked ? "Y" : "N";
            dl.occuGrooming = occuGroomingCheckBox.Checked ? "Y" : "N";
            dl.occuFeeding = occuFeedingCheckBox.Checked ? "Y" : "N";
            dl.occuBathing = occuBathingCheckBox.Checked ? "Y" : "N";
            dl.visOtherDesc = visOtherDescTextBox.Text;
            dl.visOther = visOtherCheckBox.Checked ? "Y" : "N";
            dl.visLegBlind = visLegBlindCheckBox.Checked ? "Y" : "N";
            dl.visImpair = visImpairCheckBox.Checked ? "Y" : "N";
            dl.visContacts = visContactsCheckBox.Checked ? "Y" : "N";
            dl.visGlasses = visGlassesCheckBox.Checked ? "Y" : "N";
            dl.visBlurry = visBlurryCheckBox.Checked ? "Y" : "N";
            dl.visDeny = visDenyCheckBox.Checked ? "Y" : "N";
            dl.hearRing = hearRingCheckBox.Checked ? "Y" : "N";
            dl.hearSignLang = hearSignLangCheckBox.Checked ? "Y" : "N";
            dl.hearDeaf = hearDeafCheckBox.Checked ? "Y" : "N";
            dl.hearImpair = hearImpairCheckBox.Checked ? "Y" : "N";
            dl.hearAid = hearAidCheckBox.Checked ? "Y" : "N";
            dl.hearEarPain = hearEarPainCheckBox.Checked ? "Y" : "N";
            dl.hearDeny = hearDenyCheckBox.Checked ? "Y" : "N";
            dl.learnChalPoorCop = learnChalPoorCopCheckBox.Checked ? "Y" : "N";
            dl.learnChalEmo = learnChalEmoCheckBox.Checked ? "Y" : "N";
            dl.learnChalCog = learnChalCogCheckBox.Checked ? "Y" : "N";
            dl.gradeYesNo = gradeYesNoCheckBox.Checked ? "Y" : "N";
            dl.degEarned = degEarnedTextBox.Text;
            dl.yearsCollegeDesc = yearsCollegeDescTextBox.Text;
            dl.yearsCollege = yearsCollegeCheckBox.Checked ? "Y" : "N";
            dl.gED = gEDCheckBox.Checked ? "Y" : "N";
            dl.gradeDesc = gradeDescTextBox.Text;
            dl.hearOtherDesc = hearOtherDescTextBox.Text;
            dl.hearOther = hearOtherCheckBox.Checked ? "Y" : "N";
            dl.learnPrefHands = learnPrefHandsCheckBox.Checked ? "Y" : "N";
            dl.learnPrefVideo = learnPrefVideoCheckBox.Checked ? "Y" : "N";
            dl.learnPrefDemo = learnPrefDemoCheckBox.Checked ? "Y" : "N";
            dl.learnPrefVerb = learnPrefVerbCheckBox.Checked ? "Y" : "N";
            dl.learnPrefWrit = learnPrefWritCheckBox.Checked ? "Y" : "N";
            dl.learnChalOtherDesc = learnChalOtherDescTextBox.Text;
            dl.learnChalOther = learnChalOtherCheckBox.Checked ? "Y" : "N";
            dl.learnChalDeny = learnChalDenyCheckBox.Checked ? "Y" : "N";
            dl.learnChalSenseImpair = learnChalSenseImpairCheckBox.Checked ? "Y" : "N";
            dl.learnChalLangBar = learnChalLangBarCheckBox.Checked ? "Y" : "N";
            dl.learnChalImpThought = learnChalImpThoughtCheckBox.Checked ? "Y" : "N";
            dl.spiritReligCultPracDesc = spiritReligCultPracDescTextBox.Text;
            dl.duringStayHelp = duringStayHelpTextBox.Text;
            dl.methSuccessManage = methSuccessManageTextBox.Text;
            dl.iDSuppLife = iDSuppLifeTextBox.Text;
            dl.issueBroughtHosp = issueBroughtHospTextBox.Text;
            dl.feelAboutHospitalized = feelAboutHospitalizedTextBox.Text;
            dl.suicideSrcOtherDesc = suicideSrcOtherDescTextBox.Text;
            dl.suicideSrcOther = suicideSrcOtherCheckBox.Checked ? "Y" : "N";
            dl.suicideSrcFamilyDesc = suicideSrcFamilyDescTextBox.Text;
            dl.suicideSrcFamily = suicideSrcFamilyCheckBox.Checked ? "Y" : "N";
            dl.suicideSrcPatient = suicideSrcPatientCheckBox.Checked ? "Y" : "N";
            dl.thoughtKillSelfHowDesc = thoughtKillSelfHowDescTextBox.Text;
            dl.thoughtKillSelfIntentDesc = thoughtKillSelfIntentDescTextBox.Text;
            dl.thoughtKillSelfDesc = thoughtKillSelfDescTextBox.Text;
            dl.wishDeadDesc = wishDeadDescTextBox.Text;
            dl.appearSelfInfDesc = appearSelfInfDescTextBox.Text;
            dl.presentSelfInjDesc = presentSelfInjDescTextBox.Text;
            dl.haveOwnLethalWho = haveOwnLethalWhoTextBox.Text;
            dl.haveOwnLethalWhere = haveOwnLethalWhereTextBox.Text;
            dl.haveOwnLethalType = haveOwnLethalTypeTextBox.Text;
            dl.thoughtsFrightenDesc = thoughtsFrightenDescTextBox.Text;
            dl.thinkActThoughtsDesc = thinkActThoughtsDescTextBox.Text;
            dl.workedOutKillSelfDesc = workedOutKillSelfDescTextBox.Text;
            dl.attemptAroundPplDesc = attemptAroundPplDescTextBox.Text;
            dl.stoppedAttemptDesc = stoppedAttemptDescTextBox.Text;
            dl.madeSuicideAttemptDesc = madeSuicideAttemptDescTextBox.Text;
            dl.closeAttemptSuicideDesc = closeAttemptSuicideDescTextBox.Text;
            dl.diagSchizDesc = diagSchizDescTextBox.Text;
            dl.histSexAbuseWho = histSexAbuseWhoTextBox.Text;
            dl.histSubAbuseDesc = histSubAbuseDescTextBox.Text;
            dl.withdrawnLatelyDesc = withdrawnLatelyDescTextBox.Text;
            dl.hopelessHelplessDesc = hopelessHelplessDescTextBox.Text;
            dl.highLevelStressDesc = highLevelStressDescTextBox.Text;
            dl.skillsProud = skillsProudTextBox.Text;
            dl.whoTellAnything = whoTellAnythingTextBox.Text;
            dl.importantPeople = importantPeopleTextBox.Text;
            dl.stressorsLossDig = stressorsLossDigTextBox.Text;
            dl.stressorsList = stressorsListTextBox.Text;
            dl.engageSeekHelp = engageSeekHelpCheckBox.Checked ? "Y" : "N";
            dl.engageRelieved = engageRelievedCheckBox.Checked ? "Y" : "N";
            dl.engageCoop = engageCoopCheckBox.Checked ? "Y" : "N";
            dl.engageCredible = engageCredibleCheckBox.Checked ? "Y" : "N";
            dl.clinPresOtherDesc = clinPresOtherDescTextBox.Text;
            dl.clinPresOther = clinPresOtherCheckBox.Checked ? "Y" : "N";
            dl.clinPresNeg = clinPresNegCheckBox.Checked ? "Y" : "N";
            dl.clinPresBurden = clinPresBurdenCheckBox.Checked ? "Y" : "N";
            dl.clinPresNoHope = clinPresNoHopeCheckBox.Checked ? "Y" : "N";
            dl.clinPresDep = clinPresDepCheckBox.Checked ? "Y" : "N";
            dl.clinPresStress = clinPresStressCheckBox.Checked ? "Y" : "N";
            dl.otherProtFact = otherProtFactTextBox.Text;
            dl.noResIdenOrAvail = noResIdenOrAvailCheckBox.Checked ? "Y" : "N";
            dl.seekStaff = seekStaffTextBox.Text;
            dl.talkLovedOut = talkLovedOutTextBox.Text;
            dl.activeDistract = activeDistractTextBox.Text;
            dl.internalCopeStrat = internalCopeStratTextBox.Text;
            dl.riskStateTrig = riskStateTrigTextBox.Text;
            dl.riskStateWhy = riskStateWhyTextBox.Text;
            dl.riskStatusWhy = riskStatusWhyTextBox.Text;
            dl.wdCocaineNausVom = wdCocaineNausVomCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineDistSleep = wdCocaineDistSleepCheckBox.Checked ? "Y" : "N";
            dl.wdCocainePain = wdCocainePainCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineCramps = wdCocaineCrampsCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineMuscAche = wdCocaineMuscAcheCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineTremors = wdCocaineTremorsCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineAngryBurst = wdCocaineAngryBurstCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineExFatigue = wdCocaineExFatigueCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineAnxiety = wdCocaineAnxietyCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineDep = wdCocaineDepCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineAgitated = wdCocaineAgitatedCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineDenySympt = wdCocaineDenySymptCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineAdmitRecent = wdCocaineAdmitRecentCheckBox.Checked ? "Y" : "N";
            dl.wdCocaineDeny7 = wdCocaineDeny7CheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzVisual = wdAlcBenzVisualCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzAuditory = wdAlcBenzAuditoryCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzTactile = wdAlcBenzTactileCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzDisoriented = wdAlcBenzDisorientedCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzAgitated = wdAlcBenzAgitatedCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzHeadAche = wdAlcBenzHeadAcheCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzAnxiety = wdAlcBenzAnxietyCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzSweats = wdAlcBenzSweatsCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzTremors = wdAlcBenzTremorsCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzNausVom = wdAlcBenzNausVomCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzDenySympt = wdAlcBenzDenySymptCheckBox.Checked ? "Y" : "N"; ;
            dl.wdAlcBenzAdmitRecent = wdAlcBenzAdmitRecentCheckBox.Checked ? "Y" : "N";
            dl.wdAlcBenzDeny7 = wdAlcBenzDeny7CheckBox.Checked ? "Y" : "N";
            dl.wdBenzo = wdBenzoCheckBox.Checked ? "Y" : "N";
            dl.wdAlcoh = wdAlcohCheckBox.Checked ? "Y" : "N";
            dl.wdOpiDiarrhea = wdOpiDiarrheaCheckBox.Checked ? "Y" : "N";
            dl.wdOpiNausVom = wdOpiNausVomCheckBox.Checked ? "Y" : "N";
            dl.wdOpiInsom = wdOpiInsomCheckBox.Checked ? "Y" : "N";
            dl.wdOpiMuscAche = wdOpiMuscAcheCheckBox.Checked ? "Y" : "N";
            dl.wdOpiGooseBmp = wdOpiGooseBmpCheckBox.Checked ? "Y" : "N";
            dl.wdOpiHighBP = wdOpiHighBPCheckBox.Checked ? "Y" : "N";
            dl.wdOpiSneezRunNose = wdOpiSneezRunNoseCheckBox.Checked ? "Y" : "N";
            dl.wdOpiWateryEyes = wdOpiWateryEyesCheckBox.Checked ? "Y" : "N";
            dl.wdOpiDialPupils = wdOpiDialPupilsCheckBox.Checked ? "Y" : "N";
            dl.wdOpiSweat = wdOpiSweatCheckBox.Checked ? "Y" : "N";
            dl.wdOpiDenySympt = wdOpiDenySymptCheckBox.Checked ? "Y" : "N";
            dl.wdOpiAdmitRecent = wdOpiAdmitRecentCheckBox.Checked ? "Y" : "N";
            dl.wdOpiDeny7 = wdOpiDeny7CheckBox.Checked ? "Y" : "N";
            dl.wdMethPsychSympt = wdMethPsychSymptCheckBox.Checked ? "Y" : "N";
            dl.wdMethAnxiety = wdMethAnxietyCheckBox.Checked ? "Y" : "N";
            dl.wdMethDepMood = wdMethDepMoodCheckBox.Checked ? "Y" : "N";
            dl.wdMethIrritable = wdMethIrritableCheckBox.Checked ? "Y" : "N";
            dl.wdMethDistSleep = wdMethDistSleepCheckBox.Checked ? "Y" : "N";
            dl.wdMethFatigue = wdMethFatigueCheckBox.Checked ? "Y" : "N";
            dl.wdMethDenySympt = wdMethDenySymptCheckBox.Checked ? "Y" : "N";
            dl.wdMethAdmitRecent = wdMethAdmitRecentCheckBox.Checked ? "Y" : "N";
            dl.wdMethDeny7 = wdMethDeny7CheckBox.Checked ? "Y" : "N";
            dl.wdMethIntenseHun = wdMethIntenseHunCheckBox.Checked ? "Y" : "N";
            dl.wdMarjAnxiety = wdMarjAnxietyCheckBox.Checked ? "Y" : "N";
            dl.wdMarjStrngeDream = wdMarjStrngeDreamCheckBox.Checked ? "Y" : "N";
            dl.wdMarjAnger = wdMarjAngerCheckBox.Checked ? "Y" : "N";
            dl.wdMarjAggresive = wdMarjAggresiveCheckBox.Checked ? "Y" : "N";
            dl.wdMarjInsom = wdMarjInsomCheckBox.Checked ? "Y" : "N";
            dl.wdMarjRestless = wdMarjRestlessCheckBox.Checked ? "Y" : "N";
            dl.wdMarjStomAche = wdMarjStomAcheCheckBox.Checked ? "Y" : "N";
            dl.wdMarjDepMood = wdMarjDepMoodCheckBox.Checked ? "Y" : "N";
            dl.wdMarjDecAppetite = wdMarjDecAppetiteCheckBox.Checked ? "Y" : "N";
            dl.wdMarjPhysicalTension = wdMarjPhysicalTensionCheckBox.Checked ? "Y" : "N";
            dl.wdMarjIrritable = wdMarjIrritableCheckBox.Checked ? "Y" : "N";
            dl.wdMarjDenySympt = wdMarjDenySymptCheckBox.Checked ? "Y" : "N";
            dl.wdMarjAdmitRecent = wdMarjAdmitRecentCheckBox.Checked ? "Y" : "N";
            dl.wdMarjDeny7 = wdMarjDeny7CheckBox.Checked ? "Y" : "N";
            dl.chew = chewCheckBox.Checked ? "Y" : "N";
            dl.pipeSmoke = pipeSmokeCheckBox.Checked ? "Y" : "N";
            dl.cigars = cigarsCheckBox.Checked ? "Y" : "N";
            dl.cigarettes = cigarettesCheckBox.Checked ? "Y" : "N";
            dl.bMIScore = bMIScoreTextBox.Text;
            dl.dehydrationOtherDesc = dehydrationOtherDescTextBox.Text;
            dl.dehydrationOther = dehydrationOtherCheckBox.Checked ? "Y" : "N";
            dl.sunkEyes = sunkEyesCheckBox.Checked ? "Y" : "N";
            dl.dryFlakySkin = dryFlakySkinCheckBox.Checked ? "Y" : "N";
            dl.lossSkin = lossSkinCheckBox.Checked ? "Y" : "N";
            dl.amberUrine = amberUrineCheckBox.Checked ? "Y" : "N";
            dl.stickyMembrane = stickyMembraneCheckBox.Checked ? "Y" : "N";
            dl.complaintThirst = complaintThirstCheckBox.Checked ? "Y" : "N";
            dl.dietConsultOrder = dietConsultOrderCheckBox.Checked ? "Y" : "N";
            dl.nutChewDiff = nutChewDiffCheckBox.Checked ? "Y" : "N";
            dl.nutCultDesc = nutCultDescTextBox.Text;
            dl.nutCultDiet = nutCultDietCheckBox.Checked ? "Y" : "N";
            dl.nutDiarr = nutDiarrCheckBox.Checked ? "Y" : "N";
            dl.nutVomit = nutVomitCheckBox.Checked ? "Y" : "N";
            dl.nutBingPurg = nutBingPurgCheckBox.Checked ? "Y" : "N";
            dl.nutUnderWei = nutUnderWeiCheckBox.Checked ? "Y" : "N";
            dl.nutDiabetes = nutDiabetesCheckBox.Checked ? "Y" : "N";
            dl.nutMedOtherDesc = nutMedOtherDescTextBox.Text;
            dl.nutMedOther = nutMedOtherCheckBox.Checked ? "Y" : "N";
            dl.nutMedHyperlip = nutMedHyperlipCheckBox.Checked ? "Y" : "N";
            dl.nutMedHyperten = nutMedHypertenCheckBox.Checked ? "Y" : "N";
            dl.nutMedHiv = nutMedHivCheckBox.Checked ? "Y" : "N";
            dl.nutMedCirr = nutMedCirrCheckBox.Checked ? "Y" : "N";
            dl.nutMedAnem = nutMedAnemCheckBox.Checked ? "Y" : "N";
            dl.nutMedPreg = nutMedPregCheckBox.Checked ? "Y" : "N";
            dl.nutDeny = nutDenyCheckBox.Checked ? "Y" : "N";
            dl.nutScore = nutScoreTextBox.Text;
            dl.sexActExplicit = sexActExplicitCheckBox.Checked ? "Y" : "N";
            dl.sexActPromis = sexActPromisCheckBox.Checked ? "Y" : "N";
            dl.sexActManic = sexActManicCheckBox.Checked ? "Y" : "N";
            dl.sexActImpulse = sexActImpulseCheckBox.Checked ? "Y" : "N";
            dl.sexActHist = sexActHistCheckBox.Checked ? "Y" : "N";
            dl.sexActPoorBound = sexActPoorBoundCheckBox.Checked ? "Y" : "N";
            dl.sexActHyper = sexActHyperCheckBox.Checked ? "Y" : "N";
            dl.sexActPredator = sexActPredatorCheckBox.Checked ? "Y" : "N";
            dl.sexActOutScore = sexActOutScoreTextBox.Text;
            dl.homAssultPsychotic = homAssultPsychoticCheckBox.Checked ? "Y" : "N";
            dl.homAssultUnpredict = homAssultUnpredictCheckBox.Checked ? "Y" : "N";
            dl.homAssultManic = homAssultManicCheckBox.Checked ? "Y" : "N";
            dl.homAssultParaDelus = homAssultParaDelusCheckBox.Checked ? "Y" : "N";
            dl.homAssultAdmitHI = homAssultAdmitHICheckBox.Checked ? "Y" : "N";
            dl.homAssultHist = homAssultHistCheckBox.Checked ? "Y" : "N";
            dl.homAssultVerbThreat = homAssultVerbThreatCheckBox.Checked ? "Y" : "N";
            dl.homAssultStrike = homAssultStrikeCheckBox.Checked ? "Y" : "N";
            dl.homAssultVioScore = homAssultVioScoreTextBox.Text;
            dl.elopePsychotic = elopePsychoticCheckBox.Checked ? "Y" : "N";
            dl.elopeInvolun = elopeInvolunCheckBox.Checked ? "Y" : "N";
            dl.elopeUnpredict = elopeUnpredictCheckBox.Checked ? "Y" : "N";
            dl.elopeSubAbuse = elopeSubAbuseCheckBox.Checked ? "Y" : "N";
            dl.elopeTest = elopeTestCheckBox.Checked ? "Y" : "N";
            dl.elopeHist = elopeHistCheckBox.Checked ? "Y" : "N";
            dl.elopeIntent = elopeIntentCheckBox.Checked ? "Y" : "N";
            dl.elopeScore = elopeScoreTextBox.Text;
            dl.vulnerRiskMobil = vulnerRiskMobilCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskVerbProv = vulnerRiskVerbProvCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskWand = vulnerRiskWandCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskFrail = vulnerRiskFrailCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskConfus = vulnerRiskConfusCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskHist = vulnerRiskHistCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskDelay = vulnerRiskDelayCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskVisHear = vulnerRiskVisHearCheckBox.Checked ? "Y" : "N";
            dl.vulnerRiskScore = vulnerRiskScoreTextBox.Text;
            dl.age = ageTextBox.Text;
            dl.berCat2Total = berCat2TotalTextBox.Text;
            dl.berNum8Occur = berNum8OccurTextBox.Text;
            dl.tobaccoOther = tobaccoOtherCheckBox.Checked ? "Y" : "N";
            dl.tobOtherDesc = tobOtherDescTextBox.Text;
            dl.tobPtRefused = tobPtRefusedCheckBox.Checked ? "Y" : "N";
            dl.tobNotOffered = tobNotOfferedCheckBox.Checked ? "Y" : "N";
            dl.tobOther = tobOtherCheckBox.Checked ? "Y" : "N";
            dl.tobRevInfo = tobRevInfoCheckBox.Checked ? "Y" : "N";
            dl.tobRevCop = tobRevCopCheckBox.Checked ? "Y" : "N";
            dl.tobRevDanger = tobRevDangerCheckBox.Checked ? "Y" : "N";
            dl.tobaccoOtherDesc = tobaccoOtherDescTextBox.Text;
            dl.tobMedContOtherDesc = tobMedContOtherDescTextBox.Text;
            dl.tobMedContOther = tobMedContOtherCheckBox.Checked ? "Y" : "N";
            dl.tobMedContDrugInter = tobMedContDrugInterCheckBox.Checked ? "Y" : "N";
            dl.tobMedContPatAllFDA = tobMedContPatAllFDACheckBox.Checked ? "Y" : "N";
            dl.histDevDelayDesc = histDevDelayDescTextBox.Text;
            dl.birthDefectsDesc = birthDefectsDescTextBox.Text;
            dl.yr1618ReasChoice = yr1618ReasChoiceCheckBox.Checked ? "Y" : "N";
            dl.yr1618InterestSex = yr1618InterestSexCheckBox.Checked ? "Y" : "N";
            dl.yr1618LessParents = yr1618LessParentsCheckBox.Checked ? "Y" : "N";
            dl.yr1618Interest = yr1618InterestCheckBox.Checked ? "Y" : "N";
            dl.yr1315GroupSports = yr1315GroupSportsCheckBox.Checked ? "Y" : "N";
            dl.yr1315CompThought = yr1315CompThoughtCheckBox.Checked ? "Y" : "N";
            dl.yr1315ExpressAff = yr1315ExpressAffCheckBox.Checked ? "Y" : "N";
            dl.yr1315ShowsConc = yr1315ShowsConcCheckBox.Checked ? "Y" : "N";
            dl.yr912RespSelf = yr912RespSelfCheckBox.Checked ? "Y" : "N";
            dl.yr912FamDec = yr912FamDecCheckBox.Checked ? "Y" : "N";
            dl.yr912Hobby = yr912HobbyCheckBox.Checked ? "Y" : "N";
            dl.yr912AttSpan = yr912AttSpanCheckBox.Checked ? "Y" : "N";
            dl.yr912BestFriend = yr912BestFriendCheckBox.Checked ? "Y" : "N";
            dl.yr58MinResp = yr58MinRespCheckBox.Checked ? "Y" : "N";
            dl.yr58Needs = yr58NeedsCheckBox.Checked ? "Y" : "N";
            dl.yr58Coop = yr58CoopCheckBox.Checked ? "Y" : "N";
            dl.yr58Chores = yr58ChoresCheckBox.Checked ? "Y" : "N";
            dl.yr58Bath = yr58BathCheckBox.Checked ? "Y" : "N";
            dl.nameRelatNurseAssess = nameRelatNurseAssessTextBox.Text;
            dl.parGuardExpect = parGuardExpectTextBox.Text;
            dl.nurseSigTime = nurseSigTimeTextBox.Text;
            dl.nurseSig2Date = nurseSig2DateDateTimePicker.Value;
            dl.nurseSig2 = nurseSig2TextBox.Text;
            dl.nurseSig1Time = nurseSig1TimeTextBox.Text;
            dl.nurseSig1Date = nurseSig1DateDateTimePicker.Value;
            dl.nurseSig1 = nurseSig1TextBox.Text;
            dl.nurseAdminNote = nurseAdminNoteTextBox.Text;
        }

        private void getNursing()
        {
            bloodPressureTextBox.Text = dl.bloodPressure;
            waistCmTextBox.Text = dl.waistCm;
            waistTextBox.Text = dl.waist;
            weightKgTextBox.Text = dl.weightKg;
            weightTextBox.Text = dl.weight;
            heighCmTextBox.Text = dl.heighCm;
            heightTextBox.Text = dl.height;
            eyeColorTextBox.Text = dl.eyeColor;
            hairColorTextBox.Text = dl.hairColor;
            rTextBox.Text = dl.r;
            pTextBox.Text = dl.p;
            tTextBox.Text = dl.t;
            painOtherDescTextBox.Text = dl.painOtherDesc;
            if (dl.painOther == "Y")
                painOtherCheckBox.Checked = true;
            else
                painOtherCheckBox.Checked = false;
            medicationDescTextBox.Text = dl.medicationDesc;
            if (dl.medication == "Y")
                medicationCheckBox.Checked = true;
            else
                medicationCheckBox.Checked = false;
            if (dl.relaxation == "Y")
                relaxationCheckBox.Checked = true;
            else
                relaxationCheckBox.Checked = false;
            if (dl.deepBreathing == "Y")
                deepBreathingCheckBox.Checked = true;
            else
                deepBreathingCheckBox.Checked = false;
            if (dl.elevation == "Y")
                elevationCheckBox.Checked = true;
            else
                elevationCheckBox.Checked = false;
            if (dl.resting == "Y")
                restingCheckBox.Checked = true;
            else
                restingCheckBox.Checked = false;
            if (dl.applyCold == "Y")
                applyColdCheckBox.Checked = true;
            else
                applyColdCheckBox.Checked = false;
            if (dl.applyHeat == "Y")
                applyHeatCheckBox.Checked = true;
            else
                applyHeatCheckBox.Checked = false;
            sTDHistDescTextBox.Text = dl.sTDHistDesc;
            if (dl.sTDHist == "Y")
                sTDHistCheckBox.Checked = true;
            else
                sTDHistCheckBox.Checked = false;
            if (dl.prefOther == "Y")
                prefOtherCheckBox.Checked = true;
            else
                prefOtherCheckBox.Checked = false;
            prefOtherDescTextBox.Text = dl.prefOtherDesc;
            if (dl.prefPan == "Y")
                prefPanCheckBox.Checked = true;
            else
                prefPanCheckBox.Checked = false;
            if (dl.prefBi == "Y")
                prefBiCheckBox.Checked = true;
            else
                prefBiCheckBox.Checked = false;
            if (dl.prefFemale == "Y")
                prefFemaleCheckBox.Checked = true;
            else
                prefFemaleCheckBox.Checked = false;
            if (dl.prefMale == "Y")
                prefMaleCheckBox.Checked = true;
            else
                prefMaleCheckBox.Checked = false;
            if (dl.denySex == "Y")
                denySexCheckBox.Checked = true;
            else
                denySexCheckBox.Checked = false;
            if (dl.sexualActive == "Y")
                sexualActiveCheckBox.Checked = true;
            else
                sexualActiveCheckBox.Checked = false;
            bowelOtherDescTextBox.Text = dl.bowelOtherDesc;
            if (dl.bowelOther == "Y")
                bowelOtherCheckBox.Checked = true;
            else
                bowelOtherCheckBox.Checked = false;
            if (dl.antiDiarrheal == "Y")
                antiDiarrhealCheckBox.Checked = true;
            else
                antiDiarrhealCheckBox.Checked = false;
            if (dl.lax == "Y")
                laxCheckBox.Checked = true;
            else
                laxCheckBox.Checked = false;
            if (dl.incont == "Y")
                incontCheckBox.Checked = true;
            else
                incontCheckBox.Checked = false;
            if (dl.hemmoroids == "Y")
                hemmoroidsCheckBox.Checked = true;
            else
                hemmoroidsCheckBox.Checked = false;
            if (dl.constipation == "Y")
                constipationCheckBox.Checked = true;
            else
                constipationCheckBox.Checked = false;
            if (dl.diarrhea == "Y")
                diarrheaCheckBox.Checked = true;
            else
                diarrheaCheckBox.Checked = false;
            if (dl.bowelDeny == "Y")
                bowelDenyCheckBox.Checked = true;
            else
                bowelDenyCheckBox.Checked = false;
            gastroOtherDescTextBox.Text = dl.gastroOtherDesc;
            if (dl.gastroOther == "Y")
                gastroOtherCheckBox.Checked = true;
            else
                gastroOtherCheckBox.Checked = false;
            if (dl.livDisease == "Y")
                livDiseaseCheckBox.Checked = true;
            else
                livDiseaseCheckBox.Checked = false;
            if (dl.hernia == "Y")
                herniaCheckBox.Checked = true;
            else
                herniaCheckBox.Checked = false;
            if (dl.gERD == "Y")
                gERDCheckBox.Checked = true;
            else
                gERDCheckBox.Checked = false;
            if (dl.gastroUlcers == "Y")
                gastroUlcersCheckBox.Checked = true;
            else
                gastroUlcersCheckBox.Checked = false;
            if (dl.gastroPain == "Y")
                gastroPainCheckBox.Checked = true;
            else
                gastroPainCheckBox.Checked = false;
            if (dl.nausea == "Y")
                nauseaCheckBox.Checked = true;
            else
                nauseaCheckBox.Checked = false;
            if (dl.gastroDeny == "Y")
                gastroDenyCheckBox.Checked = true;
            else
                gastroDenyCheckBox.Checked = false;
            cardioOtherDescTextBox.Text = dl.cardioOtherDesc;
            if (dl.cardioOther == "Y")
                cardioOtherCheckBox.Checked = true;
            else
                cardioOtherCheckBox.Checked = false;
            if (dl.heartFailure == "Y")
                heartFailureCheckBox.Checked = true;
            else
                heartFailureCheckBox.Checked = false;
            if (dl.arrhythmia == "Y")
                arrhythmiaCheckBox.Checked = true;
            else
                arrhythmiaCheckBox.Checked = false;
            if (dl.edema == "Y")
                edemaCheckBox.Checked = true;
            else
                edemaCheckBox.Checked = false;
            if (dl.hypotension == "Y")
                hypotensionCheckBox.Checked = true;
            else
                hypotensionCheckBox.Checked = false;
            if (dl.hypertension == "Y")
                hypertensionCheckBox.Checked = true;
            else
                hypertensionCheckBox.Checked = false;
            if (dl.irregPulse == "Y")
                irregPulseCheckBox.Checked = true;
            else
                irregPulseCheckBox.Checked = false;
            if (dl.palitations == "Y")
                palitationsCheckBox.Checked = true;
            else
                palitationsCheckBox.Checked = false;
            if (dl.pVD == "Y")
                pVDCheckBox.Checked = true;
            else
                pVDCheckBox.Checked = false;
            if (dl.mI == "Y")
                mICheckBox.Checked = true;
            else
                mICheckBox.Checked = false;
            if (dl.pacemaker == "Y")
                pacemakerCheckBox.Checked = true;
            else
                pacemakerCheckBox.Checked = false;
            if (dl.chestPain == "Y")
                chestPainCheckBox.Checked = true;
            else
                chestPainCheckBox.Checked = false;
            if (dl.denyCardio == "Y")
                denyCardioCheckBox.Checked = true;
            else
                denyCardioCheckBox.Checked = false;
            lastBMTextBox.Text = dl.lastBM;
            if (dl.dentalDeny == "Y")
                dentalDenyCheckBox.Checked = true;
            else
                dentalDenyCheckBox.Checked = false;
            dentalOtherDescTextBox.Text = dl.dentalOtherDesc;
            if (dl.dentalOther == "Y")
                dentalOtherCheckBox.Checked = true;
            else
                dentalOtherCheckBox.Checked = false;
            if (dl.extractions == "Y")
                extractionsCheckBox.Checked = true;
            else
                extractionsCheckBox.Checked = false;
            if (dl.bleedingGums == "Y")
                bleedingGumsCheckBox.Checked = true;
            else
                bleedingGumsCheckBox.Checked = false;
            if (dl.dentalUlcers == "Y")
                dentalUlcersCheckBox.Checked = true;
            else
                dentalUlcersCheckBox.Checked = false;
            if (dl.looseMissingTeeth == "Y")
                looseMissingTeethCheckBox.Checked = true;
            else
                looseMissingTeethCheckBox.Checked = false;
            if (dl.denturesPart == "Y")
                denturesPartCheckBox.Checked = true;
            else
                denturesPartCheckBox.Checked = false;
            if (dl.denturesLow == "Y")
                denturesLowCheckBox.Checked = true;
            else
                denturesLowCheckBox.Checked = false;
            if (dl.denturesUp == "Y")
                denturesUpCheckBox.Checked = true;
            else
                denturesUpCheckBox.Checked = false;
            respOtherDescTextBox.Text = dl.respOtherDesc;
            if (dl.respOther == "Y")
                respOtherCheckBox.Checked = true;
            else
                respOtherCheckBox.Checked = false;
            if (dl.cPAP == "Y")
                cPAPCheckBox.Checked = true;
            else
                cPAPCheckBox.Checked = false;
            if (dl.sleepApnea == "Y")
                sleepApneaCheckBox.Checked = true;
            else
                sleepApneaCheckBox.Checked = false;
            if (dl.cOPD == "Y")
                cOPDCheckBox.Checked = true;
            else
                cOPDCheckBox.Checked = false;
            if (dl.cough == "Y")
                coughCheckBox.Checked = true;
            else
                coughCheckBox.Checked = false;
            if (dl.asthma == "Y")
                asthmaCheckBox.Checked = true;
            else
                asthmaCheckBox.Checked = false;
            if (dl.laboredBreath == "Y")
                laboredBreathCheckBox.Checked = true;
            else
                laboredBreathCheckBox.Checked = false;
            if (dl.shortBreath == "Y")
                shortBreathCheckBox.Checked = true;
            else
                shortBreathCheckBox.Checked = false;
            if (dl.respDeny == "Y")
                respDenyCheckBox.Checked = true;
            else
                respDenyCheckBox.Checked = false;
            noseThroatOtherDescTextBox.Text = dl.noseThroatOtherDesc;
            if (dl.noseThroatOther == "Y")
                noseThroatOtherCheckBox.Checked = true;
            else
                noseThroatOtherCheckBox.Checked = false;
            if (dl.thrush == "Y")
                thrushCheckBox.Checked = true;
            else
                thrushCheckBox.Checked = false;
            if (dl.coldSympt == "Y")
                coldSymptCheckBox.Checked = true;
            else
                coldSymptCheckBox.Checked = false;
            if (dl.diffSwallow == "Y")
                diffSwallowCheckBox.Checked = true;
            else
                diffSwallowCheckBox.Checked = false;
            if (dl.hoarseness == "Y")
                hoarsenessCheckBox.Checked = true;
            else
                hoarsenessCheckBox.Checked = false;
            if (dl.soreThroat == "Y")
                soreThroatCheckBox.Checked = true;
            else
                soreThroatCheckBox.Checked = false;
            if (dl.sinus == "Y")
                sinusCheckBox.Checked = true;
            else
                sinusCheckBox.Checked = false;
            if (dl.noseThroatDeny == "Y")
                noseThroatDenyCheckBox.Checked = true;
            else
                noseThroatDenyCheckBox.Checked = false;
            skinOtherDescTextBox.Text = dl.skinOtherDesc;
            if (dl.skinOther == "Y")
                skinOtherCheckBox.Checked = true;
            else
                skinOtherCheckBox.Checked = false;
            staplesNumTextBox.Text = dl.staplesNum;
            if (dl.staples == "Y")
                staplesCheckBox.Checked = true;
            else
                staplesCheckBox.Checked = false;
            numSuturesTextBox.Text = dl.numSutures;
            if (dl.sutures == "Y")
                suturesCheckBox.Checked = true;
            else
                suturesCheckBox.Checked = false;
            if (dl.wound == "Y")
                woundCheckBox.Checked = true;
            else
                woundCheckBox.Checked = false;
            if (dl.itching == "Y")
                itchingCheckBox.Checked = true;
            else
                itchingCheckBox.Checked = false;
            if (dl.discolor == "Y")
                discolorCheckBox.Checked = true;
            else
                discolorCheckBox.Checked = false;
            if (dl.rashHives == "Y")
                rashHivesCheckBox.Checked = true;
            else
                rashHivesCheckBox.Checked = false;
            if (dl.bruises == "Y")
                bruisesCheckBox.Checked = true;
            else
                bruisesCheckBox.Checked = false;
            if (dl.scars == "Y")
                scarsCheckBox.Checked = true;
            else
                scarsCheckBox.Checked = false;
            if (dl.skinUlcers == "Y")
                skinUlcersCheckBox.Checked = true;
            else
                skinUlcersCheckBox.Checked = false;
            if (dl.skinDeny == "Y")
                skinDenyCheckBox.Checked = true;
            else
                skinDenyCheckBox.Checked = false;
            neuroOtherDescTextBox.Text = dl.neuroOtherDesc;
            if (dl.neuroOther == "Y")
                neuroOtherCheckBox.Checked = true;
            else
                neuroOtherCheckBox.Checked = false;
            if (dl.migraine == "Y")
                migraineCheckBox.Checked = true;
            else
                migraineCheckBox.Checked = false;
            if (dl.tremors == "Y")
                tremorsCheckBox.Checked = true;
            else
                tremorsCheckBox.Checked = false;
            if (dl.dizziness == "Y")
                dizzinessCheckBox.Checked = true;
            else
                dizzinessCheckBox.Checked = false;
            if (dl.headInjuryTrauma == "Y")
                headInjuryTraumaCheckBox.Checked = true;
            else
                headInjuryTraumaCheckBox.Checked = false;
            if (dl.weakParalysis == "Y")
                weakParalysisCheckBox.Checked = true;
            else
                weakParalysisCheckBox.Checked = false;
            if (dl.neuroConfusion == "Y")
                neuroConfusionCheckBox.Checked = true;
            else
                neuroConfusionCheckBox.Checked = false;
            if (dl.freqHeadache == "Y")
                freqHeadacheCheckBox.Checked = true;
            else
                freqHeadacheCheckBox.Checked = false;
            if (dl.stroke == "Y")
                strokeCheckBox.Checked = true;
            else
                strokeCheckBox.Checked = false;
            lastSeizureTextBox.Text = dl.lastSeizure;
            if (dl.seizures == "Y")
                seizuresCheckBox.Checked = true;
            else
                seizuresCheckBox.Checked = false;
            if (dl.neuroDeny == "Y")
                neuroDenyCheckBox.Checked = true;
            else
                neuroDenyCheckBox.Checked = false;
            muscOtherDescTextBox.Text = dl.muscOtherDesc;
            if (dl.muscOther == "Y")
                muscOtherCheckBox.Checked = true;
            else
                muscOtherCheckBox.Checked = false;
            if (dl.muscWeakness == "Y")
                muscWeaknessCheckBox.Checked = true;
            else
                muscWeaknessCheckBox.Checked = false;
            if (dl.boneDisease == "Y")
                boneDiseaseCheckBox.Checked = true;
            else
                boneDiseaseCheckBox.Checked = false;
            if (dl.breaks == "Y")
                breaksCheckBox.Checked = true;
            else
                breaksCheckBox.Checked = false;
            if (dl.muscRigid == "Y")
                muscRigidCheckBox.Checked = true;
            else
                muscRigidCheckBox.Checked = false;
            if (dl.arthritis == "Y")
                arthritisCheckBox.Checked = true;
            else
                arthritisCheckBox.Checked = false;
            if (dl.jointPain == "Y")
                jointPainCheckBox.Checked = true;
            else
                jointPainCheckBox.Checked = false;
            if (dl.backPain == "Y")
                backPainCheckBox.Checked = true;
            else
                backPainCheckBox.Checked = false;
            if (dl.muscDeny == "Y")
                muscDenyCheckBox.Checked = true;
            else
                muscDenyCheckBox.Checked = false;
            endoOtherDescTextBox.Text = dl.endoOtherDesc;
            if (dl.endoOther == "Y")
                endoOtherCheckBox.Checked = true;
            else
                endoOtherCheckBox.Checked = false;
            diagEndoDisDescTextBox.Text = dl.diagEndoDisDesc;
            if (dl.diagEndoDis == "Y")
                diagEndoDisCheckBox.Checked = true;
            else
                diagEndoDisCheckBox.Checked = false;
            if (dl.dietControlled == "Y")
                dietControlledCheckBox.Checked = true;
            else
                dietControlledCheckBox.Checked = false;
            if (dl.endoInsulin == "Y")
                endoInsulinCheckBox.Checked = true;
            else
                endoInsulinCheckBox.Checked = false;
            if (dl.endoDiabetes == "Y")
                endoDiabetesCheckBox.Checked = true;
            else
                endoDiabetesCheckBox.Checked = false;
            if (dl.endoDeny == "Y")
                endoDenyCheckBox.Checked = true;
            else
                endoDenyCheckBox.Checked = false;
            genitOtherDescTextBox.Text = dl.genitOtherDesc;
            if (dl.genitOther == "Y")
                genitOtherCheckBox.Checked = true;
            else
                genitOtherCheckBox.Checked = false;
            if (dl.incontinence == "Y")
                incontCheckBox.Checked = true;
            else
                incontCheckBox.Checked = false;
            if (dl.hesitancy == "Y")
                hesitancyCheckBox.Checked = true;
            else
                hesitancyCheckBox.Checked = false;
            if (dl.genitFreqDec == "Y")
                genitFreqDecCheckBox.Checked = true;
            else
                genitFreqDecCheckBox.Checked = false;
            if (dl.genitFreqInc == "Y")
                genitFreqIncCheckBox.Checked = true;
            else
                genitFreqIncCheckBox.Checked = false;
            if (dl.uTI == "Y")
                uTICheckBox.Checked = true;
            else
                uTICheckBox.Checked = false;
            if (dl.hematuria == "Y")
                hematuriaCheckBox.Checked = true;
            else
                hematuriaCheckBox.Checked = false;
            if (dl.nocturia == "Y")
                nocturiaCheckBox.Checked = true;
            else
                nocturiaCheckBox.Checked = false;
            if (dl.burning == "Y")
                burningCheckBox.Checked = true;
            else
                burningCheckBox.Checked = false;
            if (dl.genitDeny == "Y")
                genitDenyCheckBox.Checked = true;
            else
                genitDenyCheckBox.Checked = false;
            maleRepOtherDescTextBox.Text = dl.maleRepOtherDesc;
            if (dl.maleRepOther == "Y")
                maleRepOtherCheckBox.Checked = true;
            else
                maleRepOtherCheckBox.Checked = false;
            if (dl.maleProstateProb == "Y")
                maleProstateProbCheckBox.Checked = true;
            else
                maleProstateProbCheckBox.Checked = false;
            if (dl.maleImpotent == "Y")
                maleImpotentCheckBox.Checked = true;
            else
                maleImpotentCheckBox.Checked = false;
            if (dl.maleHesitancy == "Y")
                maleHesitancyCheckBox.Checked = true;
            else
                maleHesitancyCheckBox.Checked = false;
            if (dl.maleDischarge == "Y")
                maleDischargeCheckBox.Checked = true;
            else
                maleDischargeCheckBox.Checked = false;
            if (dl.maleRepDeny == "Y")
                maleRepDenyCheckBox.Checked = true;
            else
                maleRepDenyCheckBox.Checked = false;
            if (dl.maleRepNA == "Y")
                maleRepNACheckBox.Checked = true;
            else
                maleRepNACheckBox.Checked = false;
            lMPTextBox.Text = dl.lMP;
            menstOtherDescTextBox.Text = dl.menstOtherDesc;
            if (dl.menstOther == "Y")
                menstOtherCheckBox.Checked = true;
            else
                menstOtherCheckBox.Checked = false;
            if (dl.amenorrhea == "Y")
                amenorrheaCheckBox.Checked = true;
            else
                amenorrheaCheckBox.Checked = false;
            if (dl.dysmen == "Y")
                dysmenCheckBox.Checked = true;
            else
                dysmenCheckBox.Checked = false;
            if (dl.regMenst == "Y")
                regMenstCheckBox.Checked = true;
            else
                regMenstCheckBox.Checked = false;
            if (dl.menstDeny == "Y")
                menstDenyCheckBox.Checked = true;
            else
                menstDenyCheckBox.Checked = false;
            if (dl.menstNa == "Y")
                menstNaCheckBox.Checked = true;
            else
                menstNaCheckBox.Checked = false;
            femRepOtherDescTextBox.Text = dl.femRepOtherDesc;
            if (dl.femRepOther == "Y")
                femRepOtherCheckBox.Checked = true;
            else
                femRepOtherCheckBox.Checked = false;
            birthControlTypeTextBox.Text = dl.birthControlType;
            if (dl.birthControl == "Y")
                birthControlCheckBox.Checked = true;
            else
                birthControlCheckBox.Checked = false;
            pregMonthsTextBox.Text = dl.pregMonths;
            if (dl.preg == "Y")
                pregCheckBox.Checked = true;
            else
                pregCheckBox.Checked = false;
            if (dl.suspPreg == "Y")
                suspPregCheckBox.Checked = true;
            else
                suspPregCheckBox.Checked = false;
            if (dl.femRepDeny == "Y")
                femRepDenyCheckBox.Checked = true;
            else
                femRepDenyCheckBox.Checked = false;
            if (dl.femRepNA == "Y")
                femRepNACheckBox.Checked = true;
            else
                femRepNACheckBox.Checked = false;
            if (dl.physicalGenWeak == "Y")
                physicalGenWeakCheckBox.Checked = true;
            else
                physicalGenWeakCheckBox.Checked = false;
            if (dl.physicalAssistDev == "Y")
                physicalAssistDevCheckBox.Checked = true;
            else
                physicalAssistDevCheckBox.Checked = false;
            if (dl.physicalFatigue == "Y")
                physicalFatigueCheckBox.Checked = true;
            else
                physicalFatigueCheckBox.Checked = false;
            if (dl.physicalStanding == "Y")
                physicalStandingCheckBox.Checked = true;
            else
                physicalStandingCheckBox.Checked = false;
            if (dl.physicalBedImm == "Y")
                physicalBedImmCheckBox.Checked = true;
            else
                physicalBedImmCheckBox.Checked = false;
            if (dl.physicalTransDiff == "Y")
                physicalTransDiffCheckBox.Checked = true;
            else
                physicalTransDiffCheckBox.Checked = false;
            if (dl.physicalImpGait == "Y")
                physicalImpGaitCheckBox.Checked = true;
            else
                physicalImpGaitCheckBox.Checked = false;
            if (dl.physicalDeny == "Y")
                physicalDenyCheckBox.Checked = true;
            else
                physicalDenyCheckBox.Checked = false;
            concernReturnResDescTextBox.Text = dl.concernReturnResDesc;
            if (dl.occuDressing == "Y")
                occuDressingCheckBox.Checked = true;
            else
                occuDressingCheckBox.Checked = false;
            if (dl.occuDeny == "Y")
                occuDenyCheckBox.Checked = true;
            else
                occuDenyCheckBox.Checked = false;
            sleepOtherDescTextBox.Text = dl.sleepOtherDesc;
            if (dl.sleepOther == "Y")
                sleepOtherCheckBox.Checked = true;
            else
                sleepOtherCheckBox.Checked = false;
            if (dl.sleepNightmares == "Y")
                sleepNightmaresCheckBox.Checked = true;
            else
                sleepNightmaresCheckBox.Checked = false;
            if (dl.sleepReqMed == "Y")
                sleepReqMedCheckBox.Checked = true;
            else
                sleepReqMedCheckBox.Checked = false;
            if (dl.sleepNightAwake == "Y")
                sleepNightAwakeCheckBox.Checked = true;
            else
                sleepNightAwakeCheckBox.Checked = false;
            if (dl.sleepEarlyAwake == "Y")
                sleepEarlyAwakeCheckBox.Checked = true;
            else
                sleepEarlyAwakeCheckBox.Checked = false;
            if (dl.sleepInsom == "Y")
                sleepInsomCheckBox.Checked = true;
            else
                sleepInsomCheckBox.Checked = false;
            if (dl.sleepDeny == "Y")
                sleepDenyCheckBox.Checked = true;
            else
                sleepDenyCheckBox.Checked = false;
            sleepAvgTextBox.Text = dl.sleepAvg;
            swalOtherDescTextBox.Text = dl.swalOtherDesc;
            if (dl.swalOther == "Y")
                swalOtherCheckBox.Checked = true;
            else
                swalOtherCheckBox.Checked = false;
            if (dl.swalDrool == "Y")
                swalDroolCheckBox.Checked = true;
            else
                swalDroolCheckBox.Checked = false;
            if (dl.swalHistAsp == "Y")
                swalHistAspCheckBox.Checked = true;
            else
                swalHistAspCheckBox.Checked = false;
            if (dl.swalCoughWhile == "Y")
                swalCoughWhileCheckBox.Checked = true;
            else
                swalCoughWhileCheckBox.Checked = false;
            if (dl.swalCoughAfter == "Y")
                swalCoughAfterCheckBox.Checked = true;
            else
                swalCoughAfterCheckBox.Checked = false;
            if (dl.swalDiffSwal == "Y")
                swalDiffSwalCheckBox.Checked = true;
            else
                swalDiffSwalCheckBox.Checked = false;
            if (dl.swalDeny == "Y")
                swalDenyCheckBox.Checked = true;
            else
                swalDenyCheckBox.Checked = false;
            occuOtherDescTextBox.Text = dl.occuOtherDesc;
            if (dl.occuOther == "Y")
                occuOtherCheckBox.Checked = true;
            else
                occuOtherCheckBox.Checked = false;
            if (dl.occuToilet == "Y")
                occuToiletCheckBox.Checked = true;
            else
                occuToiletCheckBox.Checked = false;
            if (dl.occuGrooming == "Y")
                occuGroomingCheckBox.Checked = true;
            else
                occuGroomingCheckBox.Checked = false;
            if (dl.occuFeeding == "Y")
                occuFeedingCheckBox.Checked = true;
            else
                occuFeedingCheckBox.Checked = false;
            if (dl.occuBathing == "Y")
                occuBathingCheckBox.Checked = true;
            else
                occuBathingCheckBox.Checked = false;
            visOtherDescTextBox.Text = dl.visOtherDesc;
            if (dl.visOther == "Y")
                visOtherCheckBox.Checked = true;
            else
                visOtherCheckBox.Checked = false;
            if (dl.visLegBlind == "Y")
                visLegBlindCheckBox.Checked = true;
            else
                visLegBlindCheckBox.Checked = false;
            if (dl.visImpair == "Y")
                visImpairCheckBox.Checked = true;
            else
                visImpairCheckBox.Checked = false;
            if (dl.visContacts == "Y")
                visContactsCheckBox.Checked = true;
            else
                visContactsCheckBox.Checked = false;
            if (dl.visGlasses == "Y")
                visGlassesCheckBox.Checked = true;
            else
                visGlassesCheckBox.Checked = false;
            if (dl.visBlurry == "Y")
                visBlurryCheckBox.Checked = true;
            else
                visBlurryCheckBox.Checked = false;
            if (dl.visDeny == "Y")
                visDenyCheckBox.Checked = true;
            else
                visDenyCheckBox.Checked = false;
            if (dl.hearRing == "Y")
                hearRingCheckBox.Checked = true;
            else
                hearRingCheckBox.Checked = false;
            if (dl.hearSignLang == "Y")
                hearSignLangCheckBox.Checked = true;
            else
                hearSignLangCheckBox.Checked = false;
            if (dl.hearDeaf == "Y")
                hearDeafCheckBox.Checked = true;
            else
                hearDeafCheckBox.Checked = false;
            if (dl.hearImpair == "Y")
                hearImpairCheckBox.Checked = true;
            else
                hearImpairCheckBox.Checked = false;
            if (dl.hearAid == "Y")
                hearAidCheckBox.Checked = true;
            else
                hearAidCheckBox.Checked = false;
            if (dl.hearEarPain == "Y")
                hearEarPainCheckBox.Checked = true;
            else
                hearEarPainCheckBox.Checked = false;
            if (dl.hearDeny == "Y")
                hearDenyCheckBox.Checked = true;
            else
                hearDenyCheckBox.Checked = false;
            if (dl.learnChalPoorCop == "Y")
                learnChalPoorCopCheckBox.Checked = true;
            else
                learnChalPoorCopCheckBox.Checked = false;
            if (dl.learnChalEmo == "Y")
                learnChalEmoCheckBox.Checked = true;
            else
                learnChalEmoCheckBox.Checked = false;
            if (dl.learnChalCog == "Y")
                learnChalCogCheckBox.Checked = true;
            else
                learnChalCogCheckBox.Checked = false;
            if (dl.gradeYesNo == "Y")
                gradeYesNoCheckBox.Checked = true;
            else
                gradeYesNoCheckBox.Checked = false;
            degEarnedTextBox.Text = dl.degEarned;
            yearsCollegeDescTextBox.Text = dl.yearsCollegeDesc;
            if (dl.yearsCollege == "Y")
                yearsCollegeCheckBox.Checked = true;
            else
                yearsCollegeCheckBox.Checked = false;
            if (dl.gED == "Y")
                gEDCheckBox.Checked = true;
            else
                gEDCheckBox.Checked = false;
            gradeDescTextBox.Text = dl.gradeDesc;
            hearOtherDescTextBox.Text = dl.hearOtherDesc;
            if (dl.hearOther == "Y")
                hearOtherCheckBox.Checked = true;
            else
                hearOtherCheckBox.Checked = false;
            if (dl.learnPrefHands == "Y")
                learnPrefHandsCheckBox.Checked = true;
            else
                learnPrefHandsCheckBox.Checked = false;
            if (dl.learnPrefVideo == "Y")
                learnPrefVideoCheckBox.Checked = true;
            else
                learnPrefVideoCheckBox.Checked = false;
            if (dl.learnPrefDemo == "Y")
                learnPrefDemoCheckBox.Checked = true;
            else
                learnPrefDemoCheckBox.Checked = false;
            if (dl.learnPrefVerb == "Y")
                learnPrefVerbCheckBox.Checked = true;
            else
                learnPrefVerbCheckBox.Checked = false;
            if (dl.learnPrefWrit == "Y")
                learnPrefWritCheckBox.Checked = true;
            else
                learnPrefWritCheckBox.Checked = false;
            learnChalOtherDescTextBox.Text = dl.learnChalOtherDesc;
            if (dl.learnChalOther == "Y")
                learnChalOtherCheckBox.Checked = true;
            else
                learnChalOtherCheckBox.Checked = false;
            if (dl.learnChalDeny == "Y")
                learnChalDenyCheckBox.Checked = true;
            else
                learnChalDenyCheckBox.Checked = false;
            if (dl.learnChalSenseImpair == "Y")
                learnChalSenseImpairCheckBox.Checked = true;
            else
                learnChalSenseImpairCheckBox.Checked = false;
            if (dl.learnChalLangBar == "Y")
                learnChalLangBarCheckBox.Checked = true;
            else
                learnChalLangBarCheckBox.Checked = false;
            if (dl.learnChalImpThought == "Y")
                learnChalImpThoughtCheckBox.Checked = true;
            else
                learnChalImpThoughtCheckBox.Checked = false;
            spiritReligCultPracDescTextBox.Text = dl.spiritReligCultPracDesc;
            duringStayHelpTextBox.Text = dl.duringStayHelp;
            methSuccessManageTextBox.Text = dl.methSuccessManage;
            iDSuppLifeTextBox.Text = dl.iDSuppLife;
            issueBroughtHospTextBox.Text = dl.issueBroughtHosp;
            feelAboutHospitalizedTextBox.Text = dl.feelAboutHospitalized;
            suicideSrcOtherDescTextBox.Text = dl.suicideSrcOtherDesc;
            if (dl.suicideSrcOther == "Y")
                suicideSrcOtherCheckBox.Checked = true;
            else
                suicideSrcOtherCheckBox.Checked = false;
            suicideSrcFamilyDescTextBox.Text = dl.suicideSrcFamilyDesc;
            if (dl.suicideSrcFamily == "Y")
                suicideSrcFamilyCheckBox.Checked = true;
            else
                suicideSrcFamilyCheckBox.Checked = false;
            if (dl.suicideSrcPatient == "Y")
                suicideSrcPatientCheckBox.Checked = true;
            else
                suicideSrcPatientCheckBox.Checked = false;
            thoughtKillSelfHowDescTextBox.Text = dl.thoughtKillSelfHowDesc;
            thoughtKillSelfIntentDescTextBox.Text = dl.thoughtKillSelfIntentDesc;
            thoughtKillSelfDescTextBox.Text = dl.thoughtKillSelfDesc;
            wishDeadDescTextBox.Text = dl.wishDeadDesc;
            appearSelfInfDescTextBox.Text = dl.appearSelfInfDesc;
            presentSelfInjDescTextBox.Text = dl.presentSelfInjDesc;
            haveOwnLethalWhoTextBox.Text = dl.haveOwnLethalWho;
            haveOwnLethalWhereTextBox.Text = dl.haveOwnLethalWhere;
            haveOwnLethalTypeTextBox.Text = dl.haveOwnLethalType;
            thoughtsFrightenDescTextBox.Text = dl.thoughtsFrightenDesc;
            thinkActThoughtsDescTextBox.Text = dl.thinkActThoughtsDesc;
            workedOutKillSelfDescTextBox.Text = dl.workedOutKillSelfDesc;
            attemptAroundPplDescTextBox.Text = dl.attemptAroundPplDesc;
            stoppedAttemptDescTextBox.Text = dl.stoppedAttemptDesc;
            madeSuicideAttemptDescTextBox.Text = dl.madeSuicideAttemptDesc;
            closeAttemptSuicideDescTextBox.Text = dl.closeAttemptSuicideDesc;
            diagSchizDescTextBox.Text = dl.diagSchizDesc;
            histSexAbuseWhoTextBox.Text = dl.histSexAbuseWho;
            histSubAbuseDescTextBox.Text = dl.histSubAbuseDesc;
            withdrawnLatelyDescTextBox.Text = dl.withdrawnLatelyDesc;
            hopelessHelplessDescTextBox.Text = dl.hopelessHelplessDesc;
            highLevelStressDescTextBox.Text = dl.highLevelStressDesc;
            skillsProudTextBox.Text = dl.skillsProud;
            whoTellAnythingTextBox.Text = dl.whoTellAnything;
            importantPeopleTextBox.Text = dl.importantPeople;
            stressorsLossDigTextBox.Text = dl.stressorsLossDig;
            stressorsListTextBox.Text = dl.stressorsList;
            if (dl.engageSeekHelp == "Y")
                engageSeekHelpCheckBox.Checked = true;
            else
                engageSeekHelpCheckBox.Checked = false;
            if (dl.engageRelieved == "Y")
                engageRelievedCheckBox.Checked = true;
            else
                engageRelievedCheckBox.Checked = false;
            if (dl.engageCoop == "Y")
                engageCoopCheckBox.Checked = true;
            else
                engageCoopCheckBox.Checked = false;
            if (dl.engageCredible == "Y")
                engageCredibleCheckBox.Checked = true;
            else
                engageCredibleCheckBox.Checked = false;
            clinPresOtherDescTextBox.Text = dl.clinPresOtherDesc;
            if (dl.clinPresOther == "Y")
                clinPresOtherCheckBox.Checked = true;
            else
                clinPresOtherCheckBox.Checked = false;
            if (dl.clinPresNeg == "Y")
                clinPresNegCheckBox.Checked = true;
            else
                clinPresNegCheckBox.Checked = false;
            if (dl.clinPresBurden == "Y")
                clinPresBurdenCheckBox.Checked = true;
            else
                clinPresBurdenCheckBox.Checked = false;
            if (dl.clinPresNoHope == "Y")
                clinPresNoHopeCheckBox.Checked = true;
            else
                clinPresNoHopeCheckBox.Checked = false;
            if (dl.clinPresDep == "Y")
                clinPresDepCheckBox.Checked = true;
            else
                clinPresDepCheckBox.Checked = false;
            if (dl.clinPresStress == "Y")
                clinPresStressCheckBox.Checked = true;
            else
                clinPresStressCheckBox.Checked = false;
            otherProtFactTextBox.Text = dl.otherProtFact;
            if (dl.noResIdenOrAvail == "Y")
                noResIdenOrAvailCheckBox.Checked = true;
            else
                noResIdenOrAvailCheckBox.Checked = false;
            seekStaffTextBox.Text = dl.seekStaff;
            talkLovedOutTextBox.Text = dl.talkLovedOut;
            activeDistractTextBox.Text = dl.activeDistract;
            internalCopeStratTextBox.Text = dl.internalCopeStrat;
            riskStateTrigTextBox.Text = dl.riskStateTrig;
            riskStateWhyTextBox.Text = dl.riskStateWhy;
            riskStatusWhyTextBox.Text = dl.riskStatusWhy;
            if (dl.wdCocaineNausVom == "Y")
                wdCocaineNausVomCheckBox.Checked = true;
            else
                wdCocaineNausVomCheckBox.Checked = false;
            if (dl.wdCocaineDistSleep == "Y")
                wdCocaineDistSleepCheckBox.Checked = true;
            else
                wdCocaineDistSleepCheckBox.Checked = false;
            if (dl.wdCocainePain == "Y")
                wdCocainePainCheckBox.Checked = true;
            else
                wdCocainePainCheckBox.Checked = false;
            if (dl.wdCocaineCramps == "Y")
                wdCocaineCrampsCheckBox.Checked = true;
            else
                wdCocaineCrampsCheckBox.Checked = false;
            if (dl.wdCocaineMuscAche == "Y")
                wdCocaineMuscAcheCheckBox.Checked = true;
            else
                wdCocaineMuscAcheCheckBox.Checked = false;
            if (dl.wdCocaineTremors == "Y")
                wdCocaineTremorsCheckBox.Checked = true;
            else
                wdCocaineTremorsCheckBox.Checked = false;
            if (dl.wdCocaineAngryBurst == "Y")
                wdCocaineAngryBurstCheckBox.Checked = true;
            else
                wdCocaineAngryBurstCheckBox.Checked = false;
            if (dl.wdCocaineExFatigue == "Y")
                wdCocaineExFatigueCheckBox.Checked = true;
            else
                wdCocaineExFatigueCheckBox.Checked = false;
            if (dl.wdCocaineAnxiety == "Y")
                wdCocaineAnxietyCheckBox.Checked = true;
            else
                wdCocaineAnxietyCheckBox.Checked = false;
            if (dl.wdCocaineDep == "Y")
                wdCocaineDepCheckBox.Checked = true;
            else
                wdCocaineDepCheckBox.Checked = false;
            if (dl.wdCocaineAgitated == "Y")
                wdCocaineAgitatedCheckBox.Checked = true;
            else
                wdCocaineAgitatedCheckBox.Checked = false;
            if (dl.wdCocaineDenySympt == "Y")
                wdCocaineDenySymptCheckBox.Checked = true;
            else
                wdCocaineDenySymptCheckBox.Checked = false;
            if (dl.wdCocaineAdmitRecent == "Y")
                wdCocaineAdmitRecentCheckBox.Checked = true;
            else
                wdCocaineAdmitRecentCheckBox.Checked = false;
            if (dl.wdCocaineDeny7 == "Y")
                wdCocaineDeny7CheckBox.Checked = true;
            else
                wdCocaineDeny7CheckBox.Checked = false;
            if (dl.wdAlcBenzVisual == "Y")
                wdAlcBenzVisualCheckBox.Checked = true;
            else
                wdAlcBenzVisualCheckBox.Checked = false;
            if (dl.wdAlcBenzAuditory == "Y")
                wdAlcBenzAuditoryCheckBox.Checked = true;
            else
                wdAlcBenzAuditoryCheckBox.Checked = false;
            if (dl.wdAlcBenzTactile == "Y")
                wdAlcBenzTactileCheckBox.Checked = true;
            else
                wdAlcBenzTactileCheckBox.Checked = false;
            if (dl.wdAlcBenzDisoriented == "Y")
                wdAlcBenzDisorientedCheckBox.Checked = true;
            else
                wdAlcBenzDisorientedCheckBox.Checked = false;
            if (dl.wdAlcBenzAgitated == "Y")
                wdAlcBenzAgitatedCheckBox.Checked = true;
            else
                wdAlcBenzAgitatedCheckBox.Checked = false;
            if (dl.wdAlcBenzHeadAche == "Y")
                wdAlcBenzHeadAcheCheckBox.Checked = true;
            else
                wdAlcBenzHeadAcheCheckBox.Checked = false;
            if (dl.wdAlcBenzAnxiety == "Y")
                wdAlcBenzAnxietyCheckBox.Checked = true;
            else
                wdAlcBenzAnxietyCheckBox.Checked = false;
            if (dl.wdAlcBenzSweats == "Y")
                wdAlcBenzSweatsCheckBox.Checked = true;
            else
                wdAlcBenzSweatsCheckBox.Checked = false;
            if (dl.wdAlcBenzTremors == "Y")
                wdAlcBenzTremorsCheckBox.Checked = true;
            else
                wdAlcBenzTremorsCheckBox.Checked = false;
            if (dl.wdAlcBenzNausVom == "Y")
                wdAlcBenzNausVomCheckBox.Checked = true;
            else
                wdAlcBenzNausVomCheckBox.Checked = false;
            if (dl.wdAlcBenzDenySympt == "Y")
                wdAlcBenzDenySymptCheckBox.Checked = true;
            else
                wdAlcBenzDenySymptCheckBox.Checked = false;
            if (dl.wdAlcBenzAdmitRecent == "Y")
                wdAlcBenzAdmitRecentCheckBox.Checked = true;
            else
                wdAlcBenzAdmitRecentCheckBox.Checked = false;
            if (dl.wdAlcBenzDeny7 == "Y")
                wdAlcBenzDeny7CheckBox.Checked = true;
            else
                wdAlcBenzDeny7CheckBox.Checked = false;
            if (dl.wdBenzo == "Y")
                wdBenzoCheckBox.Checked = true;
            else
                wdBenzoCheckBox.Checked = false;
            if (dl.wdAlcoh == "Y")
                wdAlcohCheckBox.Checked = true;
            else
                wdAlcohCheckBox.Checked = false;
            if (dl.wdOpiDiarrhea == "Y")
                wdOpiDiarrheaCheckBox.Checked = true;
            else
                wdOpiDiarrheaCheckBox.Checked = false;
            if (dl.wdOpiNausVom == "Y")
                wdOpiNausVomCheckBox.Checked = true;
            else
                wdOpiNausVomCheckBox.Checked = false;
            if (dl.wdOpiInsom == "Y")
                wdOpiInsomCheckBox.Checked = true;
            else
                wdOpiInsomCheckBox.Checked = false;
            if (dl.wdOpiMuscAche == "Y")
                wdOpiMuscAcheCheckBox.Checked = true;
            else
                wdOpiMuscAcheCheckBox.Checked = false;
            if (dl.wdOpiGooseBmp == "Y")
                wdOpiGooseBmpCheckBox.Checked = true;
            else
                wdOpiGooseBmpCheckBox.Checked = false;
            if (dl.wdOpiHighBP == "Y")
                wdOpiHighBPCheckBox.Checked = true;
            else
                wdOpiHighBPCheckBox.Checked = false;
            if (dl.wdOpiSneezRunNose == "Y")
                wdOpiSneezRunNoseCheckBox.Checked = true;
            else
                wdOpiSneezRunNoseCheckBox.Checked = false;
            if (dl.wdOpiWateryEyes == "Y")
                wdOpiWateryEyesCheckBox.Checked = true;
            else
                wdOpiWateryEyesCheckBox.Checked = false;
            if (dl.wdOpiDialPupils == "Y")
                wdOpiDialPupilsCheckBox.Checked = true;
            else
                wdOpiDialPupilsCheckBox.Checked = false;
            if (dl.wdOpiSweat == "Y")
                wdOpiSweatCheckBox.Checked = true;
            else
                wdOpiSweatCheckBox.Checked = false;
            if (dl.wdOpiDenySympt == "Y")
                wdOpiDenySymptCheckBox.Checked = true;
            else
                wdOpiDenySymptCheckBox.Checked = false;
            if (dl.wdOpiAdmitRecent == "Y")
                wdOpiAdmitRecentCheckBox.Checked = true;
            else
                wdOpiAdmitRecentCheckBox.Checked = false;
            if (dl.wdOpiDeny7 == "Y")
                wdOpiDeny7CheckBox.Checked = true;
            else
                wdOpiDeny7CheckBox.Checked = false;
            if (dl.wdMethPsychSympt == "Y")
                wdMethPsychSymptCheckBox.Checked = true;
            else
                wdMethPsychSymptCheckBox.Checked = false;
            if (dl.wdMethAnxiety == "Y")
                wdMethAnxietyCheckBox.Checked = true;
            else
                wdMethAnxietyCheckBox.Checked = false;
            if (dl.wdMethDepMood == "Y")
                wdMethDepMoodCheckBox.Checked = true;
            else
                wdMethDepMoodCheckBox.Checked = false;
            if (dl.wdMethIrritable == "Y")
                wdMethIrritableCheckBox.Checked = true;
            else
                wdMethIrritableCheckBox.Checked = false;
            if (dl.wdMethDistSleep == "Y")
                wdMethDistSleepCheckBox.Checked = true;
            else
                wdMethDistSleepCheckBox.Checked = false;
            if (dl.wdMethFatigue == "Y")
                wdMethFatigueCheckBox.Checked = true;
            else
                wdMethFatigueCheckBox.Checked = false;
            if (dl.wdMethDenySympt == "Y")
                wdMethDenySymptCheckBox.Checked = true;
            else
                wdMethDenySymptCheckBox.Checked = false;
            if (dl.wdMethAdmitRecent == "Y")
                wdMethAdmitRecentCheckBox.Checked = true;
            else
                wdMethAdmitRecentCheckBox.Checked = false;
            if (dl.wdMethDeny7 == "Y")
                wdMethDeny7CheckBox.Checked = true;
            else
                wdMethDeny7CheckBox.Checked = false;
            if (dl.wdMethIntenseHun == "Y")
                wdMethIntenseHunCheckBox.Checked = true;
            else
                wdMethIntenseHunCheckBox.Checked = false;
            if (dl.wdMarjAnxiety == "Y")
                wdMarjAnxietyCheckBox.Checked = true;
            else
                wdMarjAnxietyCheckBox.Checked = false;
            if (dl.wdMarjStrngeDream == "Y")
                wdMarjStrngeDreamCheckBox.Checked = true;
            else
                wdMarjStrngeDreamCheckBox.Checked = false;
            if (dl.wdMarjAnger == "Y")
                wdMarjAngerCheckBox.Checked = true;
            else
                wdMarjAngerCheckBox.Checked = false;
            if (dl.wdMarjAggresive == "Y")
                wdMarjAggresiveCheckBox.Checked = true;
            else
                wdMarjAggresiveCheckBox.Checked = false;
            if (dl.wdMarjInsom == "Y")
                wdMarjInsomCheckBox.Checked = true;
            else
                wdMarjInsomCheckBox.Checked = false;
            if (dl.wdMarjRestless == "Y")
                wdMarjRestlessCheckBox.Checked = true;
            else
                wdMarjRestlessCheckBox.Checked = false;
            if (dl.wdMarjStomAche == "Y")
                wdMarjStomAcheCheckBox.Checked = true;
            else
                wdMarjStomAcheCheckBox.Checked = false;
            if (dl.wdMarjDepMood == "Y")
                wdMarjDepMoodCheckBox.Checked = true;
            else
                wdMarjDepMoodCheckBox.Checked = false;
            if (dl.wdMarjDecAppetite == "Y")
                wdMarjDecAppetiteCheckBox.Checked = true;
            else
                wdMarjDecAppetiteCheckBox.Checked = false;
            if (dl.wdMarjPhysicalTension == "Y")
                wdMarjPhysicalTensionCheckBox.Checked = true;
            else
                wdMarjPhysicalTensionCheckBox.Checked = false;
            if (dl.wdMarjIrritable == "Y")
                wdMarjIrritableCheckBox.Checked = true;
            else
                wdMarjIrritableCheckBox.Checked = false;
            if (dl.wdMarjDenySympt == "Y")
                wdMarjDenySymptCheckBox.Checked = true;
            else
                wdMarjDenySymptCheckBox.Checked = false;
            if (dl.wdMarjAdmitRecent == "Y")
                wdMarjAdmitRecentCheckBox.Checked = true;
            else
                wdMarjAdmitRecentCheckBox.Checked = false;
            if (dl.wdMarjDeny7 == "Y")
                wdMarjDeny7CheckBox.Checked = true;
            else
                wdMarjDeny7CheckBox.Checked = false;
            if (dl.chew == "Y")
                chewCheckBox.Checked = true;
            else
                chewCheckBox.Checked = false;
            if (dl.pipeSmoke == "Y")
                pipeSmokeCheckBox.Checked = true;
            else
                pipeSmokeCheckBox.Checked = false;
            if (dl.cigars == "Y")
                cigarsCheckBox.Checked = true;
            else
                cigarsCheckBox.Checked = false;
            if (dl.cigarettes == "Y")
                cigarettesCheckBox.Checked = true;
            else
                cigarettesCheckBox.Checked = false;
            //PictureBox pictureBox1 = 
            //dl.bMIL19G30 =
            bMIScoreTextBox.Text = dl.bMIScore;
            dehydrationOtherDescTextBox.Text = dl.dehydrationOtherDesc;
            if (dl.dehydrationOther == "Y")
                dehydrationOtherCheckBox.Checked = true;
            else
                dehydrationOtherCheckBox.Checked = false;
            if (dl.sunkEyes == "Y")
                sunkEyesCheckBox.Checked = true;
            else
                sunkEyesCheckBox.Checked = false;
            if (dl.dryFlakySkin == "Y")
                dryFlakySkinCheckBox.Checked = true;
            else
                dryFlakySkinCheckBox.Checked = false;
            if (dl.lossSkin == "Y")
                lossSkinCheckBox.Checked = true;
            else
                lossSkinCheckBox.Checked = false;
            if (dl.amberUrine == "Y")
                amberUrineCheckBox.Checked = true;
            else
                amberUrineCheckBox.Checked = false;
            if (dl.stickyMembrane == "Y")
                stickyMembraneCheckBox.Checked = true;
            else
                stickyMembraneCheckBox.Checked = false;
            if (dl.complaintThirst == "Y")
                complaintThirstCheckBox.Checked = true;
            else
                complaintThirstCheckBox.Checked = false;
            if (dl.dietConsultOrder == "Y")
                dietConsultOrderCheckBox.Checked = true;
            else
                dietConsultOrderCheckBox.Checked = false;
            if (dl.nutChewDiff == "Y")
                nutChewDiffCheckBox.Checked = true;
            else
                nutChewDiffCheckBox.Checked = false;
            nutCultDescTextBox.Text = dl.nutCultDesc;
            if (dl.nutCultDiet == "Y")
                nutCultDietCheckBox.Checked = true;
            else
                nutCultDietCheckBox.Checked = false;
            if (dl.nutDiarr == "Y")
                nutDiarrCheckBox.Checked = true;
            else
                nutDiarrCheckBox.Checked = false;
            if (dl.nutVomit == "Y")
                nutVomitCheckBox.Checked = true;
            else
                nutVomitCheckBox.Checked = false;
            if (dl.nutBingPurg == "Y")
                nutBingPurgCheckBox.Checked = true;
            else
                nutBingPurgCheckBox.Checked = false;
            if (dl.nutUnderWei == "Y")
                nutUnderWeiCheckBox.Checked = true;
            else
                nutUnderWeiCheckBox.Checked = false;
            if (dl.nutDiabetes == "Y")
                nutDiabetesCheckBox.Checked = true;
            else
                nutDiabetesCheckBox.Checked = false;
            nutMedOtherDescTextBox.Text = dl.nutMedOtherDesc;
            if (dl.nutMedOther == "Y")
                nutMedOtherCheckBox.Checked = true;
            else
                nutMedOtherCheckBox.Checked = false;
            if (dl.nutMedHyperlip == "Y")
                nutMedHyperlipCheckBox.Checked = true;
            else
                nutMedHyperlipCheckBox.Checked = false;
            if (dl.nutMedHyperten == "Y")
                nutMedHypertenCheckBox.Checked = true;
            else
                nutMedHypertenCheckBox.Checked = false;
            if (dl.nutMedHiv == "Y")
                nutMedHivCheckBox.Checked = true;
            else
                nutMedHivCheckBox.Checked = false;
            if (dl.nutMedCirr == "Y")
                nutMedCirrCheckBox.Checked = true;
            else
                nutMedCirrCheckBox.Checked = false;
            if (dl.nutMedAnem == "Y")
                nutMedAnemCheckBox.Checked = true;
            else
                nutMedAnemCheckBox.Checked = false;
            if (dl.nutMedPreg == "Y")
                nutMedPregCheckBox.Checked = true;
            else
                nutMedPregCheckBox.Checked = false;
            if (dl.nutDeny == "Y")
                nutDenyCheckBox.Checked = true;
            else
                nutDenyCheckBox.Checked = false;
            nutScoreTextBox.Text = dl.nutScore;
            if (dl.sexActExplicit == "Y")
                sexActExplicitCheckBox.Checked = true;
            else
                sexActExplicitCheckBox.Checked = false;
            if (dl.sexActPromis == "Y")
                sexActPromisCheckBox.Checked = true;
            else
                sexActPromisCheckBox.Checked = false;
            if (dl.sexActManic == "Y")
                sexActManicCheckBox.Checked = true;
            else
                sexActManicCheckBox.Checked = false;
            if (dl.sexActImpulse == "Y")
                sexActImpulseCheckBox.Checked = true;
            else
                sexActImpulseCheckBox.Checked = false;
            if (dl.sexActHist == "Y")
                sexActHistCheckBox.Checked = true;
            else
                sexActHistCheckBox.Checked = false;
            if (dl.sexActPoorBound == "Y")
                sexActPoorBoundCheckBox.Checked = true;
            else
                sexActPoorBoundCheckBox.Checked = false;
            if (dl.sexActHyper == "Y")
                sexActHyperCheckBox.Checked = true;
            else
                sexActHyperCheckBox.Checked = false;
            if (dl.sexActPredator == "Y")
                sexActPredatorCheckBox.Checked = true;
            else
                sexActPredatorCheckBox.Checked = false;
            sexActOutScoreTextBox.Text = dl.sexActOutScore;
            if (dl.homAssultPsychotic == "Y")
                homAssultPsychoticCheckBox.Checked = true;
            else
                homAssultPsychoticCheckBox.Checked = false;
            if (dl.homAssultUnpredict == "Y")
                homAssultUnpredictCheckBox.Checked = true;
            else
                homAssultUnpredictCheckBox.Checked = false;
            if (dl.homAssultManic == "Y")
                homAssultManicCheckBox.Checked = true;
            else
                homAssultManicCheckBox.Checked = false;
            if (dl.homAssultParaDelus == "Y")
                homAssultParaDelusCheckBox.Checked = true;
            else
                homAssultParaDelusCheckBox.Checked = false;
            if (dl.homAssultAdmitHI == "Y")
                homAssultAdmitHICheckBox.Checked = true;
            else
                homAssultAdmitHICheckBox.Checked = false;
            if (dl.homAssultHist == "Y")
                homAssultHistCheckBox.Checked = true;
            else
                homAssultHistCheckBox.Checked = false;
            if (dl.homAssultVerbThreat == "Y")
                homAssultVerbThreatCheckBox.Checked = true;
            else
                homAssultVerbThreatCheckBox.Checked = false;
            if (dl.homAssultStrike == "Y")
                homAssultStrikeCheckBox.Checked = true;
            else
                homAssultStrikeCheckBox.Checked = false;
            homAssultVioScoreTextBox.Text = dl.homAssultVioScore;
            if (dl.elopePsychotic == "Y")
                elopePsychoticCheckBox.Checked = true;
            else
                elopePsychoticCheckBox.Checked = false;
            if (dl.elopeInvolun == "Y")
                elopeInvolunCheckBox.Checked = true;
            else
                elopeInvolunCheckBox.Checked = false;
            if (dl.elopeUnpredict == "Y")
                elopeUnpredictCheckBox.Checked = true;
            else
                elopeUnpredictCheckBox.Checked = false;
            if (dl.elopeSubAbuse == "Y")
                elopeSubAbuseCheckBox.Checked = true;
            else
                elopeSubAbuseCheckBox.Checked = false;
            if (dl.elopeTest == "Y")
                elopeTestCheckBox.Checked = true;
            else
                elopeTestCheckBox.Checked = false;
            if (dl.elopeHist == "Y")
                elopeHistCheckBox.Checked = true;
            else
                elopeHistCheckBox.Checked = false;
            if (dl.elopeIntent == "Y")
                elopeIntentCheckBox.Checked = true;
            else
                elopeIntentCheckBox.Checked = false;
            elopeScoreTextBox.Text = dl.elopeScore;
            if (dl.vulnerRiskMobil == "Y")
                vulnerRiskMobilCheckBox.Checked = true;
            else
                vulnerRiskMobilCheckBox.Checked = false;
            if (dl.vulnerRiskVerbProv == "Y")
                vulnerRiskVerbProvCheckBox.Checked = true;
            else
                vulnerRiskVerbProvCheckBox.Checked = false;
            if (dl.vulnerRiskWand == "Y")
                vulnerRiskWandCheckBox.Checked = true;
            else
                vulnerRiskWandCheckBox.Checked = false;
            if (dl.vulnerRiskFrail == "Y")
                vulnerRiskFrailCheckBox.Checked = true;
            else
                vulnerRiskFrailCheckBox.Checked = false;
            if (dl.vulnerRiskConfus == "Y")
                vulnerRiskConfusCheckBox.Checked = true;
            else
                vulnerRiskConfusCheckBox.Checked = false;
            if (dl.vulnerRiskHist == "Y")
                vulnerRiskHistCheckBox.Checked = true;
            else
                vulnerRiskHistCheckBox.Checked = false;
            if (dl.vulnerRiskDelay == "Y")
                vulnerRiskDelayCheckBox.Checked = true;
            else
                vulnerRiskDelayCheckBox.Checked = false;
            if (dl.vulnerRiskVisHear == "Y")
                vulnerRiskVisHearCheckBox.Checked = true;
            else
                vulnerRiskVisHearCheckBox.Checked = false;
            vulnerRiskScoreTextBox.Text = dl.vulnerRiskScore;
            ageTextBox.Text = dl.age;
            //dl.weightKg1 =weight
            //dl.weight1 =
            //dl.heighCm1 =
            //dl.height1 =
            //dl.bMIScore1 = bmiscore
            berCat2TotalTextBox.Text = dl.berCat2Total;
            berNum8OccurTextBox.Text = dl.berNum8Occur;
            //dl.berCat1Total = 
            if (dl.tobaccoOther == "Y")
                tobaccoOtherCheckBox.Checked = true;
            else
                tobaccoOtherCheckBox.Checked = false;
            tobOtherDescTextBox.Text = dl.tobOtherDesc;
            if (dl.tobPtRefused == "Y")
                tobPtRefusedCheckBox.Checked = true;
            else
                tobPtRefusedCheckBox.Checked = false;
            if (dl.tobNotOffered == "Y")
                tobNotOfferedCheckBox.Checked = true;
            else
                tobNotOfferedCheckBox.Checked = false;
            if (dl.tobOther == "Y")
                tobOtherCheckBox.Checked = true;
            else
                tobOtherCheckBox.Checked = false;
            if (dl.tobRevInfo == "Y")
                tobRevInfoCheckBox.Checked = true;
            else
                tobRevInfoCheckBox.Checked = false;
            if (dl.tobRevCop == "Y")
                tobRevCopCheckBox.Checked = true;
            else
                tobRevCopCheckBox.Checked = false;
            if (dl.tobRevDanger == "Y")
                tobRevDangerCheckBox.Checked = true;
            else
                tobRevDangerCheckBox.Checked = false;
            tobaccoOtherDescTextBox.Text = dl.tobaccoOtherDesc;
            tobMedContOtherDescTextBox.Text = dl.tobMedContOtherDesc;
            if (dl.tobMedContOther == "Y")
                tobMedContOtherCheckBox.Checked = true;
            else
                tobMedContOtherCheckBox.Checked = false;
            if (dl.tobMedContDrugInter == "Y")
                tobMedContDrugInterCheckBox.Checked = true;
            else
                tobMedContDrugInterCheckBox.Checked = false;
            if (dl.tobMedContPatAllFDA == "Y")
                tobMedContPatAllFDACheckBox.Checked = true;
            else
                tobMedContPatAllFDACheckBox.Checked = false;
            histDevDelayDescTextBox.Text = dl.histDevDelayDesc;
            birthDefectsDescTextBox.Text = dl.birthDefectsDesc;
            if (dl.yr1618ReasChoice == "Y")
                yr1618ReasChoiceCheckBox.Checked = true;
            else
                yr1618ReasChoiceCheckBox.Checked = false;
            if (dl.yr1618InterestSex == "Y")
                yr1618InterestSexCheckBox.Checked = true;
            else
                yr1618InterestSexCheckBox.Checked = false;
            if (dl.yr1618LessParents == "Y")
                yr1618LessParentsCheckBox.Checked = true;
            else
                yr1618LessParentsCheckBox.Checked = false;
            if (dl.yr1618Interest == "Y")
                yr1618InterestCheckBox.Checked = true;
            else
                yr1618InterestCheckBox.Checked = false;
            if (dl.yr1315GroupSports == "Y")
                yr1315GroupSportsCheckBox.Checked = true;
            else
                yr1315GroupSportsCheckBox.Checked = false;
            if (dl.yr1315CompThought == "Y")
                yr1315CompThoughtCheckBox.Checked = true;
            else
                yr1315CompThoughtCheckBox.Checked = false;
            if (dl.yr1315ExpressAff == "Y")
                yr1315ExpressAffCheckBox.Checked = true;
            else
                yr1315ExpressAffCheckBox.Checked = false;
            if (dl.yr1315ShowsConc == "Y")
                yr1315ShowsConcCheckBox.Checked = true;
            else
                yr1315ShowsConcCheckBox.Checked = false;
            if (dl.yr912RespSelf == "Y")
                yr912RespSelfCheckBox.Checked = true;
            else
                yr912RespSelfCheckBox.Checked = false;
            if (dl.yr912FamDec == "Y")
                yr912FamDecCheckBox.Checked = true;
            else
                yr912FamDecCheckBox.Checked = false;
            if (dl.yr912Hobby == "Y")
                yr912HobbyCheckBox.Checked = true;
            else
                yr912HobbyCheckBox.Checked = false;
            if (dl.yr912AttSpan == "Y")
                yr912AttSpanCheckBox.Checked = true;
            else
                yr912AttSpanCheckBox.Checked = false;
            if (dl.yr912BestFriend == "Y")
                yr912BestFriendCheckBox.Checked = true;
            else
                yr912BestFriendCheckBox.Checked = false;
            if (dl.yr58MinResp == "Y")
                yr58MinRespCheckBox.Checked = true;
            else
                yr58MinRespCheckBox.Checked = false;
            if (dl.yr58Needs == "Y")
                yr58NeedsCheckBox.Checked = true;
            else
                yr58NeedsCheckBox.Checked = false;
            if (dl.yr58Coop == "Y")
                yr58CoopCheckBox.Checked = true;
            else
                yr58CoopCheckBox.Checked = false;
            if (dl.yr58Chores == "Y")
                yr58ChoresCheckBox.Checked = true;
            else
                yr58ChoresCheckBox.Checked = false;
            if (dl.yr58Bath == "Y")
                yr58BathCheckBox.Checked = true;
            else
                yr58BathCheckBox.Checked = false;
            nameRelatNurseAssessTextBox.Text = dl.nameRelatNurseAssess;
            parGuardExpectTextBox.Text = dl.parGuardExpect;
            nurseSigTimeTextBox.Text = dl.nurseSigTime;
            nurseSig2DateDateTimePicker.Value = dl.nurseSig2Date ?? DateTime.Today;
            nurseSig2TextBox.Text = dl.nurseSig2;
            nurseSig1TimeTextBox.Text = dl.nurseSig1Time;
            nurseSig1DateDateTimePicker.Value = dl.nurseSig1Date ?? DateTime.Today;
            nurseSig1TextBox.Text = dl.nurseSig1;
            nurseAdminNoteTextBox.Text = dl.nurseAdminNote;
        }

        private void feelAboutHospitalizedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpImpSelf_Enter(object sender, EventArgs e)
        {

        }
    }
}
