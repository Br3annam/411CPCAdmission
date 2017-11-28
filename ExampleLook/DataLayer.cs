//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExampleLook
//{
//    public class DataLayer
//    {
//        //connection string to the database
//        private String connectionString;

//        //String to represent SQL statement which will be an insert statement
//        private String sqlStatement;

//        //SQLConnection object that creates a connection to the database
//        private SqlConnection connection;

//        //SQLCommand object to execute the insert statement
//        private SqlCommand command;

//        private SqlDataReader reader = null;

//        //short hand get and set
//        public int patientID { get; set; }
//        public string callerFName { get; set; }
//        public string callerZip { get; set; }
//        public string callerLName { get; set; }
//        public string callerState { get; set; }
//        public string callerRefName { get; set; }
//        public string callerAgency { get; set; }
//        public string callerCity { get; set; }
//        public string phone { get; set; }
//        public string county { get; set; }
//        public string zip { get; set; }
//        public string state { get; set; }
//        public string city { get; set; }
//        public string address { get; set; }
//        public string sSN { get; set; }
//        public DateTime dOB { get; set; }
//        public string age { get; set; }
//        public string lastName { get; set; }
//        public string middleInitial { get; set; }
//        public string firstName { get; set; }
//        public string medConcerns { get; set; }
//        public string currentOutpat { get; set; }
//        public string prevTx { get; set; }
//        public string subMisuse { get; set; }
//        public string lethalMeans { get; set; }
//        public string presentProb { get; set; }
//        public string r { get; set; }
//        public string p { get; set; }
//        public string t { get; set; }
//        public string bloodPressure { get; set; }
//        public string iQ { get; set; }
//        public string primInsPhone { get; set; }
//        public string primInsName { get; set; }
//        public string nurseIntake { get; set; }
//        public string secInsPhone { get; set; }
//        public string secInsName { get; set; }
//        public DateTime callEnded { get; set; }
//        public string callCollectedBy { get; set; }
//        public string callNotes { get; set; }
//        public string schedAssessTime { get; set; }
//        public DateTime schedAssessDate { get; set; }
//        public DateTime callStarted { get; set; }
//        public string callerPhone { get; set; }
//        public string presentOtherDesc { get; set; }
//        public Char presentOther { get; set; }
//        public Char presentPsychosis { get; set; }
//        public Char presentHomicide { get; set; }
//        public Char presentSelfHarm { get; set; }
//        public Char presentSuicide { get; set; }
//        public Char emergencyContact { get; set; }
//        public string emergencyContactLName { get; set; }
//        public string emergencyContactFName { get; set; }
//        public string powAttorneyPhone { get; set; }
//        public string powAttorneyRelat { get; set; }
//        public string powAttorneyLName { get; set; }
//        public string powAttorneyFName { get; set; }
//        public string guardianshipPhone { get; set; }
//        public string guardianshipRelat { get; set; }
//        public string guardianshipFName { get; set; }
//        public string guardianshipLName { get; set; }
//        public string medEduRightsRelat { get; set; }
//        public string medEduRightsPhone { get; set; }
//        public string medEduRightsLName { get; set; }
//        public string medEduRightsFName { get; set; }
//        public string emergencyContactPhone { get; set; }
//        public string emergencyContactRelat { get; set; }
//        public string sexVictimDesc { get; set; }
//        public string prefLangDesc { get; set; }
//        public string sexAggressDesc { get; set; }
//        public string callStartedTime { get; set; }
//        public string commitStatDesc { get; set; }
//        public Char vitalsNotObtain { get; set; }
//        public Char schedAssess { get; set; }
//        public string medDiag { get; set; }
//        public string admPsyDiag { get; set; }
//        public DateTime timeAccepted { get; set; }
//        public string nurseNotified { get; set; }
//        public string physOnCall { get; set; }
//        public Char timeAcceptedNA { get; set; }
//        public string transportDesc { get; set; }
//        public string callEndedTime { get; set; }

//        //constructor with default fields
//        public DataLayer()
//        {
//            connectionString = "Data Source=DESKTOP-ICKHK9P;Initial Catalog = CPCApp; Integrated Security = True";
//            connection = new SqlConnection(connectionString);
//        }

//        public void insert()
//        {
//            connection.Open();
//            sqlStatement = "INSERT into patient_admission(CallerFName, CallerLName, CallerCity, CallerState, CallerZip, CallerPhone, CallerRefName, CallerAgency, FirstName, MiddleInitial, LastName)" +
//                           " Values (@CallerFName, @CallerLName, @CallerCity, @CallerState, @CallerZip, @CallerPhone, @CallerRefName, @CallerAgency, @FirstName, @MiddleInitial, @LastName)";        
//            command = new SqlCommand(sqlStatement, connection);

//            //command.Parameters.AddWithValue("@inactive", inactive);
//            //command.Parameters.AddWithValue("@currentPatient", currentPatient);
//            command.Parameters.AddWithValue("@callerFName", callerFName);
//            command.Parameters.AddWithValue("@callerLName", callerLName);
//            command.Parameters.AddWithValue("@callerCity", callerCity);
//            command.Parameters.AddWithValue("@callerState", callerState);
//            command.Parameters.AddWithValue("@callerZip", callerZip);
//            command.Parameters.AddWithValue("@callerPhone", callerPhone);
//            command.Parameters.AddWithValue("@callerRefName", callerRefName);
//            command.Parameters.AddWithValue("@callerAgency", callerAgency);
//            command.Parameters.AddWithValue("@firstName", firstName);
//            command.Parameters.AddWithValue("@middleInitial", middleInitial);
//            command.Parameters.AddWithValue("@lastName", lastName);
//            //command.Parameters.AddWithValue("@prefLang", prefLang);
//            //command.Parameters.AddWithValue("@prefLangDesc", prefLangDesc);
//            //command.Parameters.AddWithValue("@age", age);
//            //command.Parameters.AddWithValue("@dOB", dOB);
//            ////command.Parameters.AddWithValue("@gender", gender);
//            //command.Parameters.AddWithValue("@sSN", sSN);
//            //command.Parameters.AddWithValue("@address", address);
//            //command.Parameters.AddWithValue("@city", city);
//            //command.Parameters.AddWithValue("@state", state);
//            //command.Parameters.AddWithValue("@zip", zip);
//            //command.Parameters.AddWithValue("@county", county);
//            //command.Parameters.AddWithValue("@phone", phone);
//            ////command.Parameters.AddWithValue("@genderID", genderID);
//            ////command.Parameters.AddWithValue("@commitStat", commitStat);
//            //command.Parameters.AddWithValue("@commitStatDesc", commitStatDesc);
//            //command.Parameters.AddWithValue("@presentProb", presentProb);
//            //command.Parameters.AddWithValue("@presentSuicide", presentSuicide);
//            //command.Parameters.AddWithValue("@presentSelfHarm", presentSelfHarm);
//            //command.Parameters.AddWithValue("@presentHomicide", presentHomicide);
//            //command.Parameters.AddWithValue("@presentPsychosis", presentPsychosis);
//            //command.Parameters.AddWithValue("@presentOther", presentOther);
//            //command.Parameters.AddWithValue("@presentOtherDesc", presentOtherDesc);
//            //command.Parameters.AddWithValue("@lethalMeans", lethalMeans);
//            //command.Parameters.AddWithValue("@subMisuse", subMisuse);
//            //command.Parameters.AddWithValue("@prevTx", prevTx);
//            //command.Parameters.AddWithValue("@currentOutpat", currentOutpat);
//            //command.Parameters.AddWithValue("@medConcerns", medConcerns);
//            ////command.Parameters.AddWithValue("@potentialPreg", potentialPreg);
//            ////command.Parameters.AddWithValue("@intelDisable", intelDisable);
//            //command.Parameters.AddWithValue("@iQ", iQ); 
//            ////command.Parameters.AddWithValue("@sexVictim", sexVictim);
//            //command.Parameters.AddWithValue("@sexVictimDesc", sexVictimDesc);
//            ////command.Parameters.AddWithValue("@sexAggress", sexAggress);
//            //command.Parameters.AddWithValue("@sexAggressDesc", sexAggressDesc);
//            ////command.Parameters.AddWithValue("@allergies", allergies);
//            //command.Parameters.AddWithValue("@bloodPressure", bloodPressure);
//            //command.Parameters.AddWithValue("@t", t);
//            //command.Parameters.AddWithValue("@p", p);
//            //command.Parameters.AddWithValue("@r", r);
//            //command.Parameters.AddWithValue("@vitalsNotObtain", vitalsNotObtain);
//            ////command.Parameters.AddWithValue("@stableTrans", stableTrans);
//            //command.Parameters.AddWithValue("@nurseIntake", nurseIntake);
//            ////command.Parameters.AddWithValue("@milStat", milStat);
//            //command.Parameters.AddWithValue("@primInsName", primInsName);
//            //command.Parameters.AddWithValue("@primInsPhone", primInsPhone);
//            //command.Parameters.AddWithValue("@secInsName", secInsName);
//            //command.Parameters.AddWithValue("@secInsPhone", secInsPhone);
//            ////command.Parameters.AddWithValue("@medEduRights", medEduRights);
//            //command.Parameters.AddWithValue("@medEduRightsFName", medEduRightsFName);
//            //command.Parameters.AddWithValue("@medEduRightsLName", medEduRightsLName);
//            //command.Parameters.AddWithValue("@medEduRightsRelat", medEduRightsRelat);
//            //command.Parameters.AddWithValue("@medEduRightsPhone", medEduRightsPhone);
//            ////command.Parameters.AddWithValue("@guardianship", guardianship);
//            //command.Parameters.AddWithValue("@guardianshipFName", guardianshipFName);
//            //command.Parameters.AddWithValue("@guardianshipLName", guardianshipLName);
//            //command.Parameters.AddWithValue("@guardianshipRelat", guardianshipRelat);
//            //command.Parameters.AddWithValue("@guardianshipPhone", guardianshipPhone);
//            ////command.Parameters.AddWithValue("@powAttorney", powAttorney);
//            //command.Parameters.AddWithValue("@powAttorneyFName", powAttorneyFName);
//            //command.Parameters.AddWithValue("@powAttorneyLName", powAttorneyLName);
//            //command.Parameters.AddWithValue("@powAttorneyRelat", powAttorneyRelat);
//            //command.Parameters.AddWithValue("@powAttorneyPhone", powAttorneyPhone);
//            //command.Parameters.AddWithValue("@emergencyContact", emergencyContact);
//            //command.Parameters.AddWithValue("@emergencyContactFName", emergencyContactFName);
//            //command.Parameters.AddWithValue("@emergencyContactLName", emergencyContactLName);
//            //command.Parameters.AddWithValue("@emergencyContactRelat", emergencyContactRelat);
//            //command.Parameters.AddWithValue("@emergencyContactPhone", emergencyContactPhone);
//            //command.Parameters.AddWithValue("@schedAssess", schedAssess);
//            //command.Parameters.AddWithValue("@schedAssessDate", schedAssessDate);
//            //command.Parameters.AddWithValue("@schedAssessTime", schedAssessTime);
//            ////command.Parameters.AddWithValue("@faxLab", faxLab);
//            //command.Parameters.AddWithValue("@physOnCall", physOnCall);
//            //command.Parameters.AddWithValue("@nurseNotified", nurseNotified);
//            //command.Parameters.AddWithValue("@timeAcceptedNA", timeAcceptedNA);
//            //command.Parameters.AddWithValue("@timeAccepted", timeAccepted);
//            //command.Parameters.AddWithValue("@admPsyDiag", admPsyDiag);
//            //command.Parameters.AddWithValue("@medDiag", medDiag);
//            ////command.Parameters.AddWithValue("@transport", transport);
//            //command.Parameters.AddWithValue("@transportDesc", transportDesc);
//            //command.Parameters.AddWithValue("@callNotes", callNotes);
//            //command.Parameters.AddWithValue("@callCollectedBy", callCollectedBy);
//            //command.Parameters.AddWithValue("@callEndedTime", callEndedTime);
//            //command.Parameters.AddWithValue("@callEnded", callEnded);
//            //command.Parameters.AddWithValue("@callStartedTime", callStartedTime);
//            //command.Parameters.AddWithValue("@callStarted", callStarted);
//            //command.Parameters.AddWithValue("@mRNum", mRNum);
//            //command.Parameters.AddWithValue("@maritalStat", maritalStat);
//            //command.Parameters.AddWithValue("@race", race);
//            //command.Parameters.AddWithValue("@assessStartDate", assessStartDate);
//            //command.Parameters.AddWithValue("@assessStartTime", assessStartTime);
//            //command.Parameters.AddWithValue("@srcInfo", srcInfo);
//            //command.Parameters.AddWithValue("@chiefComplaint", chiefComplaint);
//            //command.Parameters.AddWithValue("@moodApp", moodApp);
//            //command.Parameters.AddWithValue("@moodDep", moodDep);
//            //command.Parameters.AddWithValue("@moodLab", moodLab);
//            //command.Parameters.AddWithValue("@moodAnx", moodAnx);
//            //command.Parameters.AddWithValue("@moodIrr", moodIrr);
//            //command.Parameters.AddWithValue("@moodEup", moodEup);
//            //command.Parameters.AddWithValue("@moodHos", moodHos);
//            //command.Parameters.AddWithValue("@moodOther", moodOther);
//            //command.Parameters.AddWithValue("@moodOtherVal", moodOtherVal);
//            //command.Parameters.AddWithValue("@thoughtProcLog", thoughtProcLog);
//            //command.Parameters.AddWithValue("@thoughtProcCon", thoughtProcCon);
//            //command.Parameters.AddWithValue("@thoughtProcTan", thoughtProcTan);
//            //command.Parameters.AddWithValue("@thoughtProcLoo", thoughtProcLoo);
//            //command.Parameters.AddWithValue("@thoughtProcRac", thoughtProcRac);
//            //command.Parameters.AddWithValue("@thoughtProcObs", thoughtProcObs);
//            //command.Parameters.AddWithValue("@thoughtProcBlo", thoughtProcBlo);
//            //command.Parameters.AddWithValue("@thoughtProcDis", thoughtProcDis);
//            //command.Parameters.AddWithValue("@thoughtContRea", thoughtContRea);
//            //command.Parameters.AddWithValue("@thoughtContPre", thoughtContPre);
//            //command.Parameters.AddWithValue("@thoughtContGra", thoughtContGra);
//            //command.Parameters.AddWithValue("@thoughtContPar", thoughtContPar);
//            //command.Parameters.AddWithValue("@thoughtContDel", thoughtContDel);
//            //command.Parameters.AddWithValue("@thoughtContSom", thoughtContSom);
//            //command.Parameters.AddWithValue("@thoughtContHal", thoughtContHal);
//            //command.Parameters.AddWithValue("@thoughtContHalType", thoughtContHalType);
//            //command.Parameters.AddWithValue("@affApp", affApp);
//            //command.Parameters.AddWithValue("@affIna", affIna);
//            //command.Parameters.AddWithValue("@affBlu", affBlu);
//            //command.Parameters.AddWithValue("@affRes", affRes);
//            //command.Parameters.AddWithValue("@affLab", affLab);
//            //command.Parameters.AddWithValue("@affTear", affTear);
//            //command.Parameters.AddWithValue("@affCon", affCon);
//            //command.Parameters.AddWithValue("@affIncon", affIncon);
//            //command.Parameters.AddWithValue("@insight", insight);
//            //command.Parameters.AddWithValue("@judgement", judgement);
//            //command.Parameters.AddWithValue("@speechApp", speechApp);
//            //command.Parameters.AddWithValue("@speechPre", speechPre);
//            //command.Parameters.AddWithValue("@speechRam", speechRam);
//            //command.Parameters.AddWithValue("@speechLoud", speechLoud);
//            //command.Parameters.AddWithValue("@speechHos", speechHos);
//            //command.Parameters.AddWithValue("@speechMon", speechMon);
//            //command.Parameters.AddWithValue("@speechOther", speechOther);
//            //command.Parameters.AddWithValue("@speechOtherVal", speechOtherVal);
//            //command.Parameters.AddWithValue("@orientPer", orientPer);
//            //command.Parameters.AddWithValue("@orientPla", orientPla);
//            //command.Parameters.AddWithValue("@orientTim", orientTim);
//            //command.Parameters.AddWithValue("@orientSit", orientSit);
//            //command.Parameters.AddWithValue("@orientDis", orientDis);
//            //command.Parameters.AddWithValue("@appearance", appearance);
//            //command.Parameters.AddWithValue("@motorBehavior", motorBehavior);
//            //command.Parameters.AddWithValue("@motorBehaviorDesc", motorBehaviorDesc);
//            //command.Parameters.AddWithValue("@appeApp", appeApp);
//            //command.Parameters.AddWithValue("@appeDec", appeDec);
//            //command.Parameters.AddWithValue("@appeInc", appeInc);
//            //command.Parameters.AddWithValue("@appeGai", appeGai);
//            //command.Parameters.AddWithValue("@appeGaiValue", appeGaiValue);
//            //command.Parameters.AddWithValue("@appeLos", appeLos);
//            //command.Parameters.AddWithValue("@appeLosValue", appeLosValue);
//            //command.Parameters.AddWithValue("@appeUna", appeUna);
//            //command.Parameters.AddWithValue("@sleApp", sleApp);
//            //command.Parameters.AddWithValue("@sleDec", sleDec);
//            //command.Parameters.AddWithValue("@sleDecValue", sleDecValue);
//            //command.Parameters.AddWithValue("@sleInc", sleInc);
//            //command.Parameters.AddWithValue("@sleIncValue", sleIncValue);
//            //command.Parameters.AddWithValue("@sleDif", sleDif);
//            //command.Parameters.AddWithValue("@sleInt", sleInt);
//            //command.Parameters.AddWithValue("@sleNig", sleNig);
//            //command.Parameters.AddWithValue("@sleUna", sleUna);
//            //command.Parameters.AddWithValue("@idData", idData);
//            //command.Parameters.AddWithValue("@medHistory", medHistory);
//            //command.Parameters.AddWithValue("@surgical", surgical);
//            //command.Parameters.AddWithValue("@histMRSA", histMRSA);
//            //command.Parameters.AddWithValue("@histMRSAExpl", histMRSAExpl);
//            //command.Parameters.AddWithValue("@dietRest", dietRest);
//            //command.Parameters.AddWithValue("@dietRestExpl", dietRestExpl);
//            //command.Parameters.AddWithValue("@histFalls", histFalls);
//            //command.Parameters.AddWithValue("@histFallsExpl", histFallsExpl);
//            //command.Parameters.AddWithValue("@pCP", pCP);
//            //command.Parameters.AddWithValue("@pCPName", pCPName);
//            //command.Parameters.AddWithValue("@outMentHealth", outMentHealth);
//            //command.Parameters.AddWithValue("@complTreat", complTreat);
//            //command.Parameters.AddWithValue("@complTreatBarr", complTreatBarr);
//            //command.Parameters.AddWithValue("@psychHosp", psychHosp);
//            //command.Parameters.AddWithValue("@histNonCompMed", histNonCompMed);
//            //command.Parameters.AddWithValue("@reHospNonComp", reHospNonComp);
//            //command.Parameters.AddWithValue("@prevDiag", prevDiag);
//            //command.Parameters.AddWithValue("@prevDiagExpl", prevDiagExpl);
//            //command.Parameters.AddWithValue("@autismSpecDis", autismSpecDis);
//            //command.Parameters.AddWithValue("@deniesLegal", deniesLegal);
//            //command.Parameters.AddWithValue("@currentLegal", currentLegal);
//            //command.Parameters.AddWithValue("@probation", probation);
//            //command.Parameters.AddWithValue("@parole", parole);
//            //command.Parameters.AddWithValue("@legalCounty", legalCounty);
//            //command.Parameters.AddWithValue("@charges", charges);
//            //command.Parameters.AddWithValue("@incarc", incarc);
//            //command.Parameters.AddWithValue("@incarcExpl", incarcExpl);
//            //command.Parameters.AddWithValue("@deniesSuic", deniesSuic);
//            //command.Parameters.AddWithValue("@suicIdeaYes", suicIdeaYes);
//            //command.Parameters.AddWithValue("@suicIdeaNoPlan", suicIdeaNoPlan);
//            //command.Parameters.AddWithValue("@suicIdeaMethod", suicIdeaMethod);
//            //command.Parameters.AddWithValue("@suicIdeaPlan", suicIdeaPlan);
//            //command.Parameters.AddWithValue("@suicIdeaIntent", suicIdeaIntent);
//            //command.Parameters.AddWithValue("@suicIdeaMeans", suicIdeaMeans);
//            //command.Parameters.AddWithValue("@suicIdeaDesc", suicIdeaDesc);
//            //command.Parameters.AddWithValue("@violSelf6Mo", violSelf6Mo);
//            //command.Parameters.AddWithValue("@violSelf6MoDesc", violSelf6MoDesc);
//            //command.Parameters.AddWithValue("@suicPriorAtt", suicPriorAtt);
//            //command.Parameters.AddWithValue("@suicPriorAttDesc", suicPriorAttDesc);
//            //command.Parameters.AddWithValue("@famHistSuic", famHistSuic);
//            //command.Parameters.AddWithValue("@famHistSuicDesc", famHistSuicDesc);
//            //command.Parameters.AddWithValue("@attemptInpat", attemptInpat);
//            //command.Parameters.AddWithValue("@attemptInpatDesc", attemptInpatDesc);
//            //command.Parameters.AddWithValue("@assoHopeless", assoHopeless);
//            //command.Parameters.AddWithValue("@assoHelpless", assoHelpless);
//            //command.Parameters.AddWithValue("@assoSad", assoSad);
//            //command.Parameters.AddWithValue("@assoTearful", assoTearful);
//            //command.Parameters.AddWithValue("@assoImpulsive", assoImpulsive);
//            //command.Parameters.AddWithValue("@assoIsolative", assoIsolative);
//            //command.Parameters.AddWithValue("@suicAttInpatient", suicAttInpatient);
//            //command.Parameters.AddWithValue("@suicAttInpatientDesc", suicAttInpatientDesc);
//            //command.Parameters.AddWithValue("@deniesSelfInj", deniesSelfInj);
//            //command.Parameters.AddWithValue("@selfInjLastAtt", selfInjLastAtt);
//            //command.Parameters.AddWithValue("@selfInjInpatient", selfInjInpatient);
//            //command.Parameters.AddWithValue("@selfInjInpatientDesc", selfInjInpatientDesc);
//            //command.Parameters.AddWithValue("@deniesHom", deniesHom);
//            //command.Parameters.AddWithValue("@homIdeaYes", homIdeaYes);
//            //command.Parameters.AddWithValue("@homIdeaPlan", homIdeaPlan);
//            //command.Parameters.AddWithValue("@homIdeaNoPlan", homIdeaNoPlan);
//            //command.Parameters.AddWithValue("@homIdeaIntent", homIdeaIntent);
//            //command.Parameters.AddWithValue("@homIdeaMeans", homIdeaMeans);
//            //command.Parameters.AddWithValue("@homIdeaDesc", homIdeaDesc);
//            //command.Parameters.AddWithValue("@homIdeaTarget", homIdeaTarget);
//            //command.Parameters.AddWithValue("@violOthers6Mo", violOthers6Mo);
//            //command.Parameters.AddWithValue("@violOthers6MoDesc", violOthers6MoDesc);
//            //command.Parameters.AddWithValue("@violOtherHist", violOtherHist);
//            //command.Parameters.AddWithValue("@violOtherHistDesc", violOtherHistDesc);
//            //command.Parameters.AddWithValue("@homPriorAtt", homPriorAtt);
//            //command.Parameters.AddWithValue("@homPriorAttDesc", homPriorAttDesc);
//            //command.Parameters.AddWithValue("@famHistHom", famHistHom);
//            //command.Parameters.AddWithValue("@famHistHomDesc", famHistHomDesc);
//            //command.Parameters.AddWithValue("@accessWeap", accessWeap);
//            //command.Parameters.AddWithValue("@accessWeapDesc", accessWeapDesc);
//            //command.Parameters.AddWithValue("@deniesAssa", deniesAssa);
//            //command.Parameters.AddWithValue("@histAssaBeh", histAssaBeh);
//            //command.Parameters.AddWithValue("@hisAssaBehDesc", hisAssaBehDesc);
//            //command.Parameters.AddWithValue("@angerProb", angerProb);
//            //command.Parameters.AddWithValue("@angerProbDesc", angerProbDesc);
//            //command.Parameters.AddWithValue("@deniesPsychFam", deniesPsychFam);
//            //command.Parameters.AddWithValue("@psychFam", psychFam);
//            //command.Parameters.AddWithValue("@psychFamDesc", psychFamDesc);
//            //command.Parameters.AddWithValue("@deniesHistAbuse", deniesHistAbuse);
//            //command.Parameters.AddWithValue("@traumEve", traumEve);
//            //command.Parameters.AddWithValue("@traumEveDesc", traumEveDesc);
//            //command.Parameters.AddWithValue("@combVic", combVic);
//            //command.Parameters.AddWithValue("@combVicDesc", combVicDesc);
//            //command.Parameters.AddWithValue("@incProm", incProm);
//            //command.Parameters.AddWithValue("@incPromDesc", incPromDesc);
//            //command.Parameters.AddWithValue("@expSelf", expSelf);
//            //command.Parameters.AddWithValue("@expSelfDesc", expSelfDesc);
//            //command.Parameters.AddWithValue("@megLaw", megLaw);
//            //command.Parameters.AddWithValue("@sexAggRiskBeh", sexAggRiskBeh);
//            //command.Parameters.AddWithValue("@histSexAggBeh", histSexAggBeh);
//            //command.Parameters.AddWithValue("@sexPreocc", sexPreocc);
//            //command.Parameters.AddWithValue("@histCrimSex", histCrimSex);
//            //command.Parameters.AddWithValue("@psychSexPreocc", psychSexPreocc);
//            //command.Parameters.AddWithValue("@secVicRisk", secVicRisk);
//            //command.Parameters.AddWithValue("@devDelay", devDelay);
//            //command.Parameters.AddWithValue("@vicSexPreocc", vicSexPreocc);
//            //command.Parameters.AddWithValue("@phyStatus", phyStatus);
//            //command.Parameters.AddWithValue("@vicSexAbuse", vicSexAbuse);
//            //command.Parameters.AddWithValue("@medComp", medComp);
//            //command.Parameters.AddWithValue("@deniesMisuse", deniesMisuse);
//            //command.Parameters.AddWithValue("@deniesAlcDrugTreat", deniesAlcDrugTreat);
//            //command.Parameters.AddWithValue("@currentAlcDrugTreat", currentAlcDrugTreat);
//            //command.Parameters.AddWithValue("@currentAlcDrugTreatDesc", currentAlcDrugTreatDesc);
//            //command.Parameters.AddWithValue("@alcDrugHist", alcDrugHist);
//            //command.Parameters.AddWithValue("@alcDrugHistDesc", alcDrugHistDesc);
//            //command.Parameters.AddWithValue("@histWithdrawSymp", histWithdrawSymp);
//            //command.Parameters.AddWithValue("@histWIthdrawSympDesc", histWIthdrawSympDesc);
//            //command.Parameters.AddWithValue("@delTrem", delTrem);
//            //command.Parameters.AddWithValue("@longPerSober", longPerSober);
//            //command.Parameters.AddWithValue("@longPerSoberDesc", longPerSoberDesc);
//            //command.Parameters.AddWithValue("@subLegalProb", subLegalProb);
//            //command.Parameters.AddWithValue("@subLegalProbDesc", subLegalProbDesc);
//            //command.Parameters.AddWithValue("@famHistSubAbu", famHistSubAbu);
//            //command.Parameters.AddWithValue("@famHistSubAbuDesc", famHistSubAbuDesc);
//            //command.Parameters.AddWithValue("@currentTobUse", currentTobUse);
//            //command.Parameters.AddWithValue("@currentTobUseDesc", currentTobUseDesc);
//            //command.Parameters.AddWithValue("@howOftenAlc", howOftenAlc);
//            //command.Parameters.AddWithValue("@howManyAlcTyp", howManyAlcTyp);
//            //command.Parameters.AddWithValue("@howOftenSix", howOftenSix);
//            //command.Parameters.AddWithValue("@auditSubComplTotal", auditSubComplTotal);
//            //command.Parameters.AddWithValue("@deniesPsychosis", deniesPsychosis);
//            //command.Parameters.AddWithValue("@psychHall", psychHall);
//            //command.Parameters.AddWithValue("@psychHallDesc", psychHallDesc);
//            //command.Parameters.AddWithValue("@psychComm", psychComm);
//            //command.Parameters.AddWithValue("@psychCommDesc", psychCommDesc);
//            //command.Parameters.AddWithValue("@psychDel", psychDel);
//            //command.Parameters.AddWithValue("@psychDelDesc", psychDelDesc);
//            //command.Parameters.AddWithValue("@psychRel", psychRel);
//            //command.Parameters.AddWithValue("@psychRelDesc", psychRelDesc);
//            //command.Parameters.AddWithValue("@highLevEdu", highLevEdu);
//            //command.Parameters.AddWithValue("@employed", employed);
//            //command.Parameters.AddWithValue("@employedDesc", employedDesc);
//            //command.Parameters.AddWithValue("@repPayee", repPayee);
//            //command.Parameters.AddWithValue("@repPayeeDesc", repPayeeDesc);
//            //command.Parameters.AddWithValue("@disability", disability);
//            //command.Parameters.AddWithValue("@disabilityDesc", disabilityDesc);
//            //command.Parameters.AddWithValue("@siblings", siblings);
//            //command.Parameters.AddWithValue("@siblingsDesc", siblingsDesc);
//            //command.Parameters.AddWithValue("@children", children);
//            //command.Parameters.AddWithValue("@childrenDesc", childrenDesc);
//            //command.Parameters.AddWithValue("@childUnd18Care", childUnd18Care);
//            //command.Parameters.AddWithValue("@livingSituation", livingSituation);
//            //command.Parameters.AddWithValue("@livingSituationDesc", livingSituationDesc);
//            //command.Parameters.AddWithValue("@supports", supports);
//            //command.Parameters.AddWithValue("@strCopSkills", strCopSkills);
//            //command.Parameters.AddWithValue("@medCompliant", medCompliant);
//            //command.Parameters.AddWithValue("@medCompliantDesc", medCompliantDesc);
//            //command.Parameters.AddWithValue("@medNotes", medNotes);
//            //command.Parameters.AddWithValue("@education", education);
//            //command.Parameters.AddWithValue("@curSchoolNam", curSchoolNam);
//            //command.Parameters.AddWithValue("@encoEnur", encoEnur);
//            //command.Parameters.AddWithValue("@encoEnurDesc", encoEnurDesc);
//            //command.Parameters.AddWithValue("@cruelAnimals", cruelAnimals);
//            //command.Parameters.AddWithValue("@cruelAnimalsDesc", cruelAnimalsDesc);
//            //command.Parameters.AddWithValue("@fireSet", fireSet);
//            //command.Parameters.AddWithValue("@fireSetDesc", fireSetDesc);
//            //command.Parameters.AddWithValue("@stealing", stealing);
//            //command.Parameters.AddWithValue("@stealingDesc", stealingDesc);
//            //command.Parameters.AddWithValue("@lying", lying);
//            //command.Parameters.AddWithValue("@lyingDesc", lyingDesc);
//            //command.Parameters.AddWithValue("@runAway", runAway);
//            //command.Parameters.AddWithValue("@runAwayDesc", runAwayDesc);
//            //command.Parameters.AddWithValue("@rebel", rebel);
//            //command.Parameters.AddWithValue("@rebelHome", rebelHome);
//            //command.Parameters.AddWithValue("@rebelSchool", rebelSchool);
//            //command.Parameters.AddWithValue("@rebelDesc", rebelDesc);
//            //command.Parameters.AddWithValue("@detSchPer", detSchPer);
//            //command.Parameters.AddWithValue("@detSchPerDesc", detSchPerDesc);
//            //command.Parameters.AddWithValue("@probSchool", probSchool);
//            //command.Parameters.AddWithValue("@probSchoolDesc", probSchoolDesc);
//            //command.Parameters.AddWithValue("@indivEduProg", indivEduProg);
//            //command.Parameters.AddWithValue("@indivEduProgLearnSup", indivEduProgLearnSup);
//            //command.Parameters.AddWithValue("@indivEduProgEmoSup", indivEduProgEmoSup);
//            //command.Parameters.AddWithValue("@difMakeFriends", difMakeFriends);
//            //command.Parameters.AddWithValue("@difMakeFriendsDesc", difMakeFriendsDesc);
//            //command.Parameters.AddWithValue("@schRefu", schRefu);
//            //command.Parameters.AddWithValue("@schRefuDesc", schRefuDesc);
//            //command.Parameters.AddWithValue("@bullied", bullied);
//            //command.Parameters.AddWithValue("@bulliedDesc", bulliedDesc);
//            //command.Parameters.AddWithValue("@bullyOth", bullyOth);
//            //command.Parameters.AddWithValue("@bullyOthDesc", bullyOthDesc);
//            //command.Parameters.AddWithValue("@depSympSad", depSympSad);
//            //command.Parameters.AddWithValue("@depSympCrying", depSympCrying);
//            //command.Parameters.AddWithValue("@depSympHopeless", depSympHopeless);
//            //command.Parameters.AddWithValue("@depSympHelpless", depSympHelpless);
//            //command.Parameters.AddWithValue("@depSympWithdrawn", depSympWithdrawn);
//            //command.Parameters.AddWithValue("@depSympIsolative", depSympIsolative);
//            //command.Parameters.AddWithValue("@depSympIrritable", depSympIrritable);
//            //command.Parameters.AddWithValue("@moodLabSwings", moodLabSwings);
//            //command.Parameters.AddWithValue("@moodLabAggBeh", moodLabAggBeh);
//            //command.Parameters.AddWithValue("@moodLabEsc", moodLabEsc);
//            //command.Parameters.AddWithValue("@moodLabGrand", moodLabGrand);
//            //command.Parameters.AddWithValue("@moodLabPoor", moodLabPoor);
//            //command.Parameters.AddWithValue("@anxRelPhys", anxRelPhys);
//            //command.Parameters.AddWithValue("@anxRelHand", anxRelHand);
//            //command.Parameters.AddWithValue("@anxRelOCDTho", anxRelOCDTho);
//            //command.Parameters.AddWithValue("@anxRelOCDBeh", anxRelOCDBeh);
//            //command.Parameters.AddWithValue("@physContact", physContact);
//            //command.Parameters.AddWithValue("@timeReviewed", timeReviewed);
//            //command.Parameters.AddWithValue("@physRecAdmit", physRecAdmit);
//            //command.Parameters.AddWithValue("@physRecRefer", physRecRefer);
//            //command.Parameters.AddWithValue("@physRecDesc", physRecDesc);
//            //command.Parameters.AddWithValue("@attPhys", attPhys);
//            //command.Parameters.AddWithValue("@staffCompIntake", staffCompIntake);
//            //command.Parameters.AddWithValue("@staffCompIntake", staffCompIntake);
//            //command.Parameters.AddWithValue("@staffPrepIntakeDoc", staffPrepIntakeDoc);
//            //command.Parameters.AddWithValue("@staffPrepIntakeDoc", staffPrepIntakeDoc);
//            //command.Parameters.AddWithValue("@metalDetect", metalDetect);
//            //command.Parameters.AddWithValue("@metalDetectExpl", metalDetectExpl);
//            //command.Parameters.AddWithValue("@provDiagInpatient", provDiagInpatient);
//            //command.Parameters.AddWithValue("@provDiagPartHosp", provDiagPartHosp);
//            //command.Parameters.AddWithValue("@provDiagNA", provDiagNA);
//            //command.Parameters.AddWithValue("@medDiagNone", medDiagNone);
//            //command.Parameters.AddWithValue("@psychosocialFact", psychosocialFact);
//            //command.Parameters.AddWithValue("@psychosocialFactDesc", psychosocialFactDesc);
//            //command.Parameters.AddWithValue("@contextFact", contextFact);
//            //command.Parameters.AddWithValue("@contextFactDesc", contextFactDesc);
//            //command.Parameters.AddWithValue("@funcAssess", funcAssess);
//            //command.Parameters.AddWithValue("@physician", physician);
//            //command.Parameters.AddWithValue("@fifteenMinChecks", fifteenMinChecks);
//            //command.Parameters.AddWithValue("@oneToOneChecks", oneToOneChecks);
//            //command.Parameters.AddWithValue("@unitRestriction", unitRestriction);
//            //command.Parameters.AddWithValue("@gymRestriction", gymRestriction);
//            //command.Parameters.AddWithValue("@precautionSuicide", precautionSuicide);
//            //command.Parameters.AddWithValue("@precautionSexAgg", precautionSexAgg);
//            //command.Parameters.AddWithValue("@precautionSexVic", precautionSexVic);
//            //command.Parameters.AddWithValue("@precautionAssault", precautionAssault);
//            //command.Parameters.AddWithValue("@precautionElope", precautionElope);
//            //command.Parameters.AddWithValue("@precautionMedRisk", precautionMedRisk);
//            //command.Parameters.AddWithValue("@precautionFall", precautionFall);
//            //command.Parameters.AddWithValue("@precautionSelfHarm", precautionSelfHarm);
//            //command.Parameters.AddWithValue("@precautionNone", precautionNone);
//            //command.Parameters.AddWithValue("@arcStaffName", arcStaffName);
//            //command.Parameters.AddWithValue("@unitStaffName", unitStaffName);
//            //command.Parameters.AddWithValue("@hairColor", hairColor);
//            //command.Parameters.AddWithValue("@eyeColor", eyeColor);
//            //command.Parameters.AddWithValue("@height", height);
//            //command.Parameters.AddWithValue("@heighCm", heighCm);
//            //command.Parameters.AddWithValue("@weight", weight);
//            //command.Parameters.AddWithValue("@weightKg", weightKg);
//            //command.Parameters.AddWithValue("@waist", waist);
//            //command.Parameters.AddWithValue("@waistCm", waistCm);
//            //command.Parameters.AddWithValue("@currentReportPain", currentReportPain);
//            //command.Parameters.AddWithValue("@yesFullAssess", yesFullAssess);
//            //command.Parameters.AddWithValue("@noSkipPain", noSkipPain);
//            //command.Parameters.AddWithValue("@applyHeat", applyHeat);
//            //command.Parameters.AddWithValue("@applyCold", applyCold);
//            //command.Parameters.AddWithValue("@resting", resting);
//            //command.Parameters.AddWithValue("@elevation", elevation);
//            //command.Parameters.AddWithValue("@deepBreathing", deepBreathing);
//            //command.Parameters.AddWithValue("@relaxation", relaxation);
//            //command.Parameters.AddWithValue("@medication", medication);
//            //command.Parameters.AddWithValue("@medicationDesc", medicationDesc);
//            //command.Parameters.AddWithValue("@painOther", painOther);
//            //command.Parameters.AddWithValue("@painOtherDesc", painOtherDesc);
//            //command.Parameters.AddWithValue("@sexualActive", sexualActive);
//            //command.Parameters.AddWithValue("@denySex", denySex);
//            //command.Parameters.AddWithValue("@prefMale", prefMale);
//            //command.Parameters.AddWithValue("@prefFemale", prefFemale);
//            //command.Parameters.AddWithValue("@prefBi", prefBi);
//            //command.Parameters.AddWithValue("@prefPan", prefPan);
//            //command.Parameters.AddWithValue("@prefOther", prefOther);
//            //command.Parameters.AddWithValue("@prefOtherDesc", prefOtherDesc);
//            //command.Parameters.AddWithValue("@sTDHist", sTDHist);
//            //command.Parameters.AddWithValue("@sTDHistDesc", sTDHistDesc);
//            //command.Parameters.AddWithValue("@denyCardio", denyCardio);
//            //command.Parameters.AddWithValue("@chestPain", chestPain);
//            //command.Parameters.AddWithValue("@pacemaker", pacemaker);
//            //command.Parameters.AddWithValue("@mI", mI);
//            //command.Parameters.AddWithValue("@pVD", pVD);
//            //command.Parameters.AddWithValue("@palitations", palitations);
//            //command.Parameters.AddWithValue("@irregPulse", irregPulse);
//            //command.Parameters.AddWithValue("@hypertension", hypertension);
//            //command.Parameters.AddWithValue("@hypotension", hypotension);
//            //command.Parameters.AddWithValue("@edema", edema);
//            //command.Parameters.AddWithValue("@arrhythmia", arrhythmia);
//            //command.Parameters.AddWithValue("@heartFailure", heartFailure);
//            //command.Parameters.AddWithValue("@cardioOther", cardioOther);
//            //command.Parameters.AddWithValue("@cardioOtherDesc", cardioOtherDesc);
//            //command.Parameters.AddWithValue("@gastroDeny", gastroDeny);
//            //command.Parameters.AddWithValue("@nausea", nausea);
//            //command.Parameters.AddWithValue("@gastroPain", gastroPain);
//            //command.Parameters.AddWithValue("@gERD", gERD);
//            //command.Parameters.AddWithValue("@gastroUlcers", gastroUlcers);
//            //command.Parameters.AddWithValue("@hernia", hernia);
//            //command.Parameters.AddWithValue("@livDisease", livDisease);
//            //command.Parameters.AddWithValue("@gastroOther", gastroOther);
//            //command.Parameters.AddWithValue("@gastroOtherDesc", gastroOtherDesc);
//            //command.Parameters.AddWithValue("@bowelDeny", bowelDeny);
//            //command.Parameters.AddWithValue("@diarrhea", diarrhea);
//            //command.Parameters.AddWithValue("@constipation", constipation);
//            //command.Parameters.AddWithValue("@hemmoroids", hemmoroids);
//            //command.Parameters.AddWithValue("@incont", incont);
//            //command.Parameters.AddWithValue("@lax", lax);
//            //command.Parameters.AddWithValue("@antiDiarrheal", antiDiarrheal);
//            //command.Parameters.AddWithValue("@bowelOther", bowelOther);
//            //command.Parameters.AddWithValue("@bowelOtherDesc", bowelOtherDesc);
//            //command.Parameters.AddWithValue("@lastBM", lastBM);
//            //command.Parameters.AddWithValue("@dentalDeny", dentalDeny);
//            //command.Parameters.AddWithValue("@denturesUp", denturesUp);
//            //command.Parameters.AddWithValue("@denturesLow", denturesLow);
//            //command.Parameters.AddWithValue("@denturesPart", denturesPart);
//            //command.Parameters.AddWithValue("@looseMissingTeeth", looseMissingTeeth);
//            //command.Parameters.AddWithValue("@dentalUlcers", dentalUlcers);
//            //command.Parameters.AddWithValue("@bleedingGums", bleedingGums);
//            //command.Parameters.AddWithValue("@extractions", extractions);
//            //command.Parameters.AddWithValue("@dentalOther", dentalOther);
//            //command.Parameters.AddWithValue("@dentalOtherDesc", dentalOtherDesc);
//            //command.Parameters.AddWithValue("@noseThroatDeny", noseThroatDeny);
//            //command.Parameters.AddWithValue("@sinus", sinus);
//            //command.Parameters.AddWithValue("@soreThroat", soreThroat);
//            //command.Parameters.AddWithValue("@hoarseness", hoarseness);
//            //command.Parameters.AddWithValue("@diffSwallow", diffSwallow);
//            //command.Parameters.AddWithValue("@coldSympt", coldSympt);
//            //command.Parameters.AddWithValue("@thrush", thrush);
//            //command.Parameters.AddWithValue("@noseThroatOther", noseThroatOther);
//            //command.Parameters.AddWithValue("@noseThroatOtherDesc", noseThroatOtherDesc);
//            //command.Parameters.AddWithValue("@respDeny", respDeny);
//            //command.Parameters.AddWithValue("@shortBreath", shortBreath);
//            //command.Parameters.AddWithValue("@laboredBreath", laboredBreath);
//            //command.Parameters.AddWithValue("@asthma", asthma);
//            //command.Parameters.AddWithValue("@cough", cough);
//            //command.Parameters.AddWithValue("@cOPD", cOPD);
//            //command.Parameters.AddWithValue("@sleepApnea", sleepApnea);
//            //command.Parameters.AddWithValue("@cPAP", cPAP);
//            //command.Parameters.AddWithValue("@respOther", respOther);
//            //command.Parameters.AddWithValue("@respOtherDesc", respOtherDesc);
//            //command.Parameters.AddWithValue("@neuroDeny", neuroDeny);
//            //command.Parameters.AddWithValue("@seizures", seizures);
//            //command.Parameters.AddWithValue("@lastSeizure", lastSeizure);
//            //command.Parameters.AddWithValue("@stroke", stroke);
//            //command.Parameters.AddWithValue("@freqHeadache", freqHeadache);
//            //command.Parameters.AddWithValue("@neuroConfusion", neuroConfusion);
//            //command.Parameters.AddWithValue("@weakParalysis", weakParalysis);
//            //command.Parameters.AddWithValue("@headInjuryTrauma", headInjuryTrauma);
//            //command.Parameters.AddWithValue("@dizziness", dizziness);
//            //command.Parameters.AddWithValue("@tremors", tremors);
//            //command.Parameters.AddWithValue("@migraine", migraine);
//            //command.Parameters.AddWithValue("@neuroOther", neuroOther);
//            //command.Parameters.AddWithValue("@neuroOtherDesc", neuroOtherDesc);
//            //command.Parameters.AddWithValue("@skinDeny", skinDeny);
//            //command.Parameters.AddWithValue("@skinUlcers", skinUlcers);
//            //command.Parameters.AddWithValue("@scars", scars);
//            //command.Parameters.AddWithValue("@bruises", bruises);
//            //command.Parameters.AddWithValue("@rashHives", rashHives);
//            //command.Parameters.AddWithValue("@discolor", discolor);
//            //command.Parameters.AddWithValue("@itching", itching);
//            //command.Parameters.AddWithValue("@wound", wound);
//            //command.Parameters.AddWithValue("@sutures", sutures);
//            //command.Parameters.AddWithValue("@numSutures", numSutures);
//            //command.Parameters.AddWithValue("@staples", staples);
//            //command.Parameters.AddWithValue("@staplesNum", staplesNum);
//            //command.Parameters.AddWithValue("@skinOther", skinOther);
//            //command.Parameters.AddWithValue("@skinOtherDesc", skinOtherDesc);
//            //command.Parameters.AddWithValue("@genitDeny", genitDeny);
//            //command.Parameters.AddWithValue("@burning", burning);
//            //command.Parameters.AddWithValue("@nocturia", nocturia);
//            //command.Parameters.AddWithValue("@hematuria", hematuria);
//            //command.Parameters.AddWithValue("@uTI", uTI);
//            //command.Parameters.AddWithValue("@genitFreqInc", genitFreqInc);
//            //command.Parameters.AddWithValue("@genitFreqDec", genitFreqDec);
//            //command.Parameters.AddWithValue("@hesitancy", hesitancy);
//            //command.Parameters.AddWithValue("@incontinence", incontinence);
//            //command.Parameters.AddWithValue("@genitOther", genitOther);
//            //command.Parameters.AddWithValue("@genitOtherDesc", genitOtherDesc);
//            //command.Parameters.AddWithValue("@endoDeny", endoDeny);
//            //command.Parameters.AddWithValue("@endoDiabetes", endoDiabetes);
//            //command.Parameters.AddWithValue("@endoInsulin", endoInsulin);
//            //command.Parameters.AddWithValue("@dietControlled", dietControlled);
//            //command.Parameters.AddWithValue("@diagEndoDis", diagEndoDis);
//            //command.Parameters.AddWithValue("@diagEndoDisDesc", diagEndoDisDesc);
//            //command.Parameters.AddWithValue("@endoOther", endoOther);
//            //command.Parameters.AddWithValue("@endoOtherDesc", endoOtherDesc);
//            //command.Parameters.AddWithValue("@muscDeny", muscDeny);
//            //command.Parameters.AddWithValue("@backPain", backPain);
//            //command.Parameters.AddWithValue("@jointPain", jointPain);
//            //command.Parameters.AddWithValue("@arthritis", arthritis);
//            //command.Parameters.AddWithValue("@muscRigid", muscRigid);
//            //command.Parameters.AddWithValue("@breaks", breaks);
//            //command.Parameters.AddWithValue("@boneDisease", boneDisease);
//            //command.Parameters.AddWithValue("@muscWeakness", muscWeakness);
//            //command.Parameters.AddWithValue("@muscOther", muscOther);
//            //command.Parameters.AddWithValue("@muscOtherDesc", muscOtherDesc);
//            //command.Parameters.AddWithValue("@femRepNA", femRepNA);
//            //command.Parameters.AddWithValue("@femRepDeny", femRepDeny);
//            //command.Parameters.AddWithValue("@suspPreg", suspPreg);
//            //command.Parameters.AddWithValue("@preg", preg);
//            //command.Parameters.AddWithValue("@pregMonths", pregMonths);
//            //command.Parameters.AddWithValue("@birthControl", birthControl);
//            //command.Parameters.AddWithValue("@birthControlType", birthControlType);
//            //command.Parameters.AddWithValue("@femRepOther", femRepOther);
//            //command.Parameters.AddWithValue("@femRepOtherDesc", femRepOtherDesc);
//            //command.Parameters.AddWithValue("@menstNa", menstNa);
//            //command.Parameters.AddWithValue("@menstDeny", menstDeny);
//            //command.Parameters.AddWithValue("@regMenst", regMenst);
//            //command.Parameters.AddWithValue("@dysmen", dysmen);
//            //command.Parameters.AddWithValue("@amenorrhea", amenorrhea);
//            //command.Parameters.AddWithValue("@menstOther", menstOther);
//            //command.Parameters.AddWithValue("@menstOtherDesc", menstOtherDesc);
//            //command.Parameters.AddWithValue("@lMP", lMP);
//            //command.Parameters.AddWithValue("@maleRepNA", maleRepNA);
//            //command.Parameters.AddWithValue("@maleRepDeny", maleRepDeny);
//            //command.Parameters.AddWithValue("@maleDischarge", maleDischarge);
//            //command.Parameters.AddWithValue("@maleHesitancy", maleHesitancy);
//            //command.Parameters.AddWithValue("@maleImpotent", maleImpotent);
//            //command.Parameters.AddWithValue("@maleProstateProb", maleProstateProb);
//            //command.Parameters.AddWithValue("@maleRepOther", maleRepOther);
//            //command.Parameters.AddWithValue("@maleRepOtherDesc", maleRepOtherDesc);
//            //command.Parameters.AddWithValue("@concernReturnRes", concernReturnRes);
//            //command.Parameters.AddWithValue("@concernReturnResDesc", concernReturnResDesc);
//            //command.Parameters.AddWithValue("@physicalDeny", physicalDeny);
//            //command.Parameters.AddWithValue("@physicalImpGait", physicalImpGait);
//            //command.Parameters.AddWithValue("@physicalTransDiff", physicalTransDiff);
//            //command.Parameters.AddWithValue("@physicalBedImm", physicalBedImm);
//            //command.Parameters.AddWithValue("@physicalStanding", physicalStanding);
//            //command.Parameters.AddWithValue("@physicalFatigue", physicalFatigue);
//            //command.Parameters.AddWithValue("@physicalAssistDev", physicalAssistDev);
//            //command.Parameters.AddWithValue("@physicalGenWeak", physicalGenWeak);
//            //command.Parameters.AddWithValue("@occuDeny", occuDeny);
//            //command.Parameters.AddWithValue("@occuDressing", occuDressing);
//            //command.Parameters.AddWithValue("@occuBathing", occuBathing);
//            //command.Parameters.AddWithValue("@occuFeeding", occuFeeding);
//            //command.Parameters.AddWithValue("@occuGrooming", occuGrooming);
//            //command.Parameters.AddWithValue("@occuToilet", occuToilet);
//            //command.Parameters.AddWithValue("@occuOther", occuOther);
//            //command.Parameters.AddWithValue("@occuOtherDesc", occuOtherDesc);
//            //command.Parameters.AddWithValue("@swalDeny", swalDeny);
//            //command.Parameters.AddWithValue("@swalDiffSwal", swalDiffSwal);
//            //command.Parameters.AddWithValue("@swalCoughAfter", swalCoughAfter);
//            //command.Parameters.AddWithValue("@swalCoughWhile", swalCoughWhile);
//            //command.Parameters.AddWithValue("@swalHistAsp", swalHistAsp);
//            //command.Parameters.AddWithValue("@swalDrool", swalDrool);
//            //command.Parameters.AddWithValue("@swalOther", swalOther);
//            //command.Parameters.AddWithValue("@swalOtherDesc", swalOtherDesc);
//            //command.Parameters.AddWithValue("@sleepAvg", sleepAvg);
//            //command.Parameters.AddWithValue("@sleepDeny", sleepDeny);
//            //command.Parameters.AddWithValue("@sleepInsom", sleepInsom);
//            //command.Parameters.AddWithValue("@sleepEarlyAwake", sleepEarlyAwake);
//            //command.Parameters.AddWithValue("@sleepNightAwake", sleepNightAwake);
//            //command.Parameters.AddWithValue("@sleepReqMed", sleepReqMed);
//            //command.Parameters.AddWithValue("@sleepNightmares", sleepNightmares);
//            //command.Parameters.AddWithValue("@sleepOther", sleepOther);
//            //command.Parameters.AddWithValue("@sleepOtherDesc", sleepOtherDesc);
//            //command.Parameters.AddWithValue("@visDeny", visDeny);
//            //command.Parameters.AddWithValue("@visBlurry", visBlurry);
//            //command.Parameters.AddWithValue("@visGlasses", visGlasses);
//            //command.Parameters.AddWithValue("@visContacts", visContacts);
//            //command.Parameters.AddWithValue("@visImpair", visImpair);
//            //command.Parameters.AddWithValue("@visLegBlind", visLegBlind);
//            //command.Parameters.AddWithValue("@visOther", visOther);
//            //command.Parameters.AddWithValue("@visOtherDesc", visOtherDesc);
//            //command.Parameters.AddWithValue("@hearDeny", hearDeny);
//            //command.Parameters.AddWithValue("@hearEarPain", hearEarPain);
//            //command.Parameters.AddWithValue("@hearAid", hearAid);
//            //command.Parameters.AddWithValue("@hearImpair", hearImpair);
//            //command.Parameters.AddWithValue("@hearDeaf", hearDeaf);
//            //command.Parameters.AddWithValue("@hearSignLang", hearSignLang);
//            //command.Parameters.AddWithValue("@hearRing", hearRing);
//            //command.Parameters.AddWithValue("@hearOther", hearOther);
//            //command.Parameters.AddWithValue("@hearOtherDesc", hearOtherDesc);
//            //command.Parameters.AddWithValue("@canPatRead", canPatRead);
//            //command.Parameters.AddWithValue("@canPatWrite", canPatWrite);
//            //command.Parameters.AddWithValue("@gradeYesNo", gradeYesNo);
//            //command.Parameters.AddWithValue("@gradeDesc", gradeDesc);
//            //command.Parameters.AddWithValue("@gED", gED);
//            //command.Parameters.AddWithValue("@yearsCollege", yearsCollege);
//            //command.Parameters.AddWithValue("@yearsCollegeDesc", yearsCollegeDesc);
//            //command.Parameters.AddWithValue("@degEarned", degEarned);
//            //command.Parameters.AddWithValue("@learnChalCog", learnChalCog);
//            //command.Parameters.AddWithValue("@learnChalEmo", learnChalEmo);
//            //command.Parameters.AddWithValue("@learnChalPoorCop", learnChalPoorCop);
//            //command.Parameters.AddWithValue("@learnChalImpThought", learnChalImpThought);
//            //command.Parameters.AddWithValue("@learnChalLangBar", learnChalLangBar);
//            //command.Parameters.AddWithValue("@learnChalSenseImpair", learnChalSenseImpair);
//            //command.Parameters.AddWithValue("@learnChalDeny", learnChalDeny);
//            //command.Parameters.AddWithValue("@learnChalOther", learnChalOther);
//            //command.Parameters.AddWithValue("@learnChalOtherDesc", learnChalOtherDesc);
//            //command.Parameters.AddWithValue("@learnPrefWrit", learnPrefWrit);
//            //command.Parameters.AddWithValue("@learnPrefVerb", learnPrefVerb);
//            //command.Parameters.AddWithValue("@learnPrefDemo", learnPrefDemo);
//            //command.Parameters.AddWithValue("@learnPrefVideo", learnPrefVideo);
//            //command.Parameters.AddWithValue("@learnPrefAudio", learnPrefAudio);
//            //command.Parameters.AddWithValue("@learnPrefHands", learnPrefHands);
//            //command.Parameters.AddWithValue("@feelAboutHospitalized", feelAboutHospitalized);
//            //command.Parameters.AddWithValue("@issueBroughtHosp", issueBroughtHosp);
//            //command.Parameters.AddWithValue("@iDSuppLife", iDSuppLife);
//            //command.Parameters.AddWithValue("@methSuccessManage", methSuccessManage);
//            //command.Parameters.AddWithValue("@duringStayHelp", duringStayHelp);
//            //command.Parameters.AddWithValue("@spiritReligCultPrac", spiritReligCultPrac);
//            //command.Parameters.AddWithValue("@spiritReligCultPracDesc", spiritReligCultPracDesc);
//            //command.Parameters.AddWithValue("@nutScore", nutScore); 
//            //command.Parameters.AddWithValue("@dietConsultOrder", dietConsultOrder);
//            //command.Parameters.AddWithValue("@fluidIntake", fluidIntake);
//            //command.Parameters.AddWithValue("@complaintThirst", complaintThirst);
//            //command.Parameters.AddWithValue("@stickyMembrane", stickyMembrane);
//            //command.Parameters.AddWithValue("@amberUrine", amberUrine);
//            //command.Parameters.AddWithValue("@lossSkin", lossSkin);
//            //command.Parameters.AddWithValue("@dryFlakySkin", dryFlakySkin);
//            //command.Parameters.AddWithValue("@sunkEyes", sunkEyes);
//            //command.Parameters.AddWithValue("@dehydrationOther", dehydrationOther);
//            //command.Parameters.AddWithValue("@dehydrationOtherDesc", dehydrationOtherDesc);
//            //command.Parameters.AddWithValue("@bMIScore", bMIScore);
//            //command.Parameters.AddWithValue("@bMIL19G30", bMIL19G30);
//            //command.Parameters.AddWithValue("@bMIAgreeAssess", bMIAgreeAssess);
//            //command.Parameters.AddWithValue("@suicideSrcPatient", suicideSrcPatient);
//            //command.Parameters.AddWithValue("@suicideSrcFamily", suicideSrcFamily);
//            //command.Parameters.AddWithValue("@suicideSrcFamilyDesc", suicideSrcFamilyDesc);
//            //command.Parameters.AddWithValue("@suicideSrcOther", suicideSrcOther);
//            //command.Parameters.AddWithValue("@suicideSrcOtherDesc", suicideSrcOtherDesc);
//            //command.Parameters.AddWithValue("@presentSelfInj", presentSelfInj);
//            //command.Parameters.AddWithValue("@presentSelfInjDesc", presentSelfInjDesc);
//            //command.Parameters.AddWithValue("@appearSelfInf", appearSelfInf);
//            //command.Parameters.AddWithValue("@appearSelfInfDesc", appearSelfInfDesc);
//            //command.Parameters.AddWithValue("@wishDead", wishDead);
//            //command.Parameters.AddWithValue("@wishDeadDesc", wishDeadDesc);
//            //command.Parameters.AddWithValue("@thoughtKillSelf", thoughtKillSelf);
//            //command.Parameters.AddWithValue("@thoughtKillSelfDesc", thoughtKillSelfDesc);
//            //command.Parameters.AddWithValue("@thoughtKillsSelfIntent", thoughtKillsSelfIntent);
//            //command.Parameters.AddWithValue("@thoughtKillSelfIntentDesc", thoughtKillSelfIntentDesc);
//            //command.Parameters.AddWithValue("@thoughtKillSelfHow", thoughtKillSelfHow);
//            //command.Parameters.AddWithValue("@thoughtKillSelfHowDesc", thoughtKillSelfHowDesc);
//            //command.Parameters.AddWithValue("@workedOutKillSelf", workedOutKillSelf);
//            //command.Parameters.AddWithValue("@workedOutKillSelfDesc", workedOutKillSelfDesc);
//            //command.Parameters.AddWithValue("@thinkActThoughts", thinkActThoughts);
//            //command.Parameters.AddWithValue("@thinkActThoughtsDesc", thinkActThoughtsDesc);
//            //command.Parameters.AddWithValue("@thoughtsFrighten", thoughtsFrighten);
//            //command.Parameters.AddWithValue("@thoughtsFrightenDesc", thoughtsFrightenDesc);
//            //command.Parameters.AddWithValue("@haveOwnLethal", haveOwnLethal);
//            //command.Parameters.AddWithValue("@haveOwnLethalType", haveOwnLethalType);
//            //command.Parameters.AddWithValue("@haveOwnLethalWhere", haveOwnLethalWhere);
//            //command.Parameters.AddWithValue("@haveOwnLethalWho", haveOwnLethalWho);
//            //command.Parameters.AddWithValue("@madeSuicideAttempt", madeSuicideAttempt);
//            //command.Parameters.AddWithValue("@madeSuicideAttemptDesc", madeSuicideAttemptDesc);
//            //command.Parameters.AddWithValue("@stoppedAttempt", stoppedAttempt);
//            //command.Parameters.AddWithValue("@stoppedAttemptDesc", stoppedAttemptDesc);
//            //command.Parameters.AddWithValue("@attemptAroundPpl", attemptAroundPpl);
//            //command.Parameters.AddWithValue("@attemptAroundPplDesc", attemptAroundPplDesc);
//            //command.Parameters.AddWithValue("@diagSchiz", diagSchiz);
//            //command.Parameters.AddWithValue("@diagSchizDesc", diagSchizDesc);
//            //command.Parameters.AddWithValue("@closeAttemptSuicide", closeAttemptSuicide);
//            //command.Parameters.AddWithValue("@closeAttemptSuicideDesc", closeAttemptSuicideDesc);
//            //command.Parameters.AddWithValue("@histSexAbuse", histSexAbuse);
//            //command.Parameters.AddWithValue("@histSexAbuseWho", histSexAbuseWho);
//            //command.Parameters.AddWithValue("@histSexAbuseWhen", histSexAbuseWhen);
//            //command.Parameters.AddWithValue("@histSubAbuse", histSubAbuse);
//            //command.Parameters.AddWithValue("@histSubAbuseDesc", histSubAbuseDesc);
//            //command.Parameters.AddWithValue("@intentHurtUpset", intentHurtUpset);
//            //command.Parameters.AddWithValue("@intentHurtUpsetDesc", intentHurtUpsetDesc);
//            //command.Parameters.AddWithValue("@highLevelStress", highLevelStress);
//            //command.Parameters.AddWithValue("@highLevelStressDesc", highLevelStressDesc);
//            //command.Parameters.AddWithValue("@hopelessHelpless", hopelessHelpless);
//            //command.Parameters.AddWithValue("@hopelessHelplessDesc", hopelessHelplessDesc);
//            //command.Parameters.AddWithValue("@withdrawnLately", withdrawnLately);
//            //command.Parameters.AddWithValue("@withdrawnLatelyDesc", withdrawnLatelyDesc);
//            //command.Parameters.AddWithValue("@stressorsList", stressorsList);
//            //command.Parameters.AddWithValue("@stressorsLossDig", stressorsLossDig);
//            //command.Parameters.AddWithValue("@importantPeople", importantPeople);
//            //command.Parameters.AddWithValue("@whoTellAnything", whoTellAnything);
//            //command.Parameters.AddWithValue("@skillsProud", skillsProud);
//            //command.Parameters.AddWithValue("@otherProtFact", otherProtFact);
//            //command.Parameters.AddWithValue("@clinPresStress", clinPresStress);
//            //command.Parameters.AddWithValue("@clinPresDep", clinPresDep);
//            //command.Parameters.AddWithValue("@clinPresNoHope", clinPresNoHope);
//            //command.Parameters.AddWithValue("@clinPresBurden", clinPresBurden);
//            //command.Parameters.AddWithValue("@clinPresNeg", clinPresNeg);
//            //command.Parameters.AddWithValue("@clinPresOther", clinPresOther);
//            //command.Parameters.AddWithValue("@clinPresOtherDesc", clinPresOtherDesc);
//            //command.Parameters.AddWithValue("@engageCredible", engageCredible);
//            //command.Parameters.AddWithValue("@engageCoop", engageCoop);
//            //command.Parameters.AddWithValue("@engageRelieved", engageRelieved);
//            //command.Parameters.AddWithValue("@engageSeekHelp", engageSeekHelp);
//            //command.Parameters.AddWithValue("@riskStatusRad", riskStatusRad);
//            //command.Parameters.AddWithValue("@riskStatusWhy", riskStatusWhy);
//            //command.Parameters.AddWithValue("@riskStateRad", riskStateRad);
//            //command.Parameters.AddWithValue("@riskStateWhy", riskStateWhy);
//            //command.Parameters.AddWithValue("@riskStateTrig", riskStateTrig);
//            //command.Parameters.AddWithValue("@internalCopeStrat", internalCopeStrat);
//            //command.Parameters.AddWithValue("@internalCopeRad", internalCopeRad);
//            //command.Parameters.AddWithValue("@activeDistract", activeDistract);
//            //command.Parameters.AddWithValue("@activeDistractRad", activeDistractRad);
//            //command.Parameters.AddWithValue("@talkLovedOut", talkLovedOut);
//            //command.Parameters.AddWithValue("@talkLovedOutRad", talkLovedOutRad);
//            //command.Parameters.AddWithValue("@seekStaff", seekStaff);
//            //command.Parameters.AddWithValue("@seekStafRad", seekStafRad);
//            //command.Parameters.AddWithValue("@noResIdenOrAvail", noResIdenOrAvail);
//            //command.Parameters.AddWithValue("@adultFallScore", adultFallScore); 
//            //command.Parameters.AddWithValue("@childAdolFallScore", childAdolFallScore); 
//            //command.Parameters.AddWithValue("@elopeScore", elopeScore); 
//            //command.Parameters.AddWithValue("@homAssultVioScore", homAssultVioScore);
//            //command.Parameters.AddWithValue("@sexActOutScore", sexActOutScore);
//            //command.Parameters.AddWithValue("@vulnerRiskScore", vulnerRiskScore); 
//            //command.Parameters.AddWithValue("@wdAlcoh", wdAlcoh);
//            //command.Parameters.AddWithValue("@wdBenzo", wdBenzo);
//            //command.Parameters.AddWithValue("@wdAlcBenzDeny7", wdAlcBenzDeny7);
//            //command.Parameters.AddWithValue("@wdAlcBenzAdmitRecent", wdAlcBenzAdmitRecent);
//            //command.Parameters.AddWithValue("@wdAlcBenzDenySympt", wdAlcBenzDenySympt);
//            //command.Parameters.AddWithValue("@wdAlcBenzNausVom", wdAlcBenzNausVom);
//            //command.Parameters.AddWithValue("@wdAlcBenzTremors", wdAlcBenzTremors);
//            //command.Parameters.AddWithValue("@wdAlcBenzSweats", wdAlcBenzSweats);
//            //command.Parameters.AddWithValue("@wdAlcBenzAnxiety", wdAlcBenzAnxiety);
//            //command.Parameters.AddWithValue("@wdAlcBenzHeadAche", wdAlcBenzHeadAche);
//            //command.Parameters.AddWithValue("@wdAlcBenzAgitated", wdAlcBenzAgitated);
//            //command.Parameters.AddWithValue("@wdAlcBenzDisoriented", wdAlcBenzDisoriented);
//            //command.Parameters.AddWithValue("@wdAlcBenzTactile", wdAlcBenzTactile);
//            //command.Parameters.AddWithValue("@wdAlcBenzAuditory", wdAlcBenzAuditory);
//            //command.Parameters.AddWithValue("@wdAlcBenzVisual", wdAlcBenzVisual);
//            //command.Parameters.AddWithValue("@wdCocaineDeny7", wdCocaineDeny7);
//            //command.Parameters.AddWithValue("@wdCocaineAdmitRecent", wdCocaineAdmitRecent);
//            //command.Parameters.AddWithValue("@wdCocaineDenySympt", wdCocaineDenySympt);
//            //command.Parameters.AddWithValue("@wdCocaineAgitated", wdCocaineAgitated);
//            //command.Parameters.AddWithValue("@wdCocaineDep", wdCocaineDep);
//            //command.Parameters.AddWithValue("@wdCocaineAnxiety", wdCocaineAnxiety);
//            //command.Parameters.AddWithValue("@wdCocaineExFatigue", wdCocaineExFatigue);
//            //command.Parameters.AddWithValue("@wdCocaineAngryBurst", wdCocaineAngryBurst);
//            //command.Parameters.AddWithValue("@wdCocaineTremors", wdCocaineTremors);
//            //command.Parameters.AddWithValue("@wdCocaineMuscAche", wdCocaineMuscAche);
//            //command.Parameters.AddWithValue("@wdCocaineCramps", wdCocaineCramps);
//            //command.Parameters.AddWithValue("@wdCocainePain", wdCocainePain);
//            //command.Parameters.AddWithValue("@wdCocaineDistSleep", wdCocaineDistSleep);
//            //command.Parameters.AddWithValue("@wdCocaineNausVom", wdCocaineNausVom);
//            //command.Parameters.AddWithValue("@wdOpiDeny7", wdOpiDeny7);
//            //command.Parameters.AddWithValue("@wdOpiAdmitRecent", wdOpiAdmitRecent);
//            //command.Parameters.AddWithValue("@wdOpiDenySympt", wdOpiDenySympt);
//            //command.Parameters.AddWithValue("@wdOpiSweat", wdOpiSweat);
//            //command.Parameters.AddWithValue("@wdOpiDialPupils", wdOpiDialPupils);
//            //command.Parameters.AddWithValue("@wdOpiWateryEyes", wdOpiWateryEyes);
//            //command.Parameters.AddWithValue("@wdOpiSneezRunNose", wdOpiSneezRunNose);
//            //command.Parameters.AddWithValue("@wdOpiHighBP", wdOpiHighBP);
//            //command.Parameters.AddWithValue("@wdOpiGooseBmp", wdOpiGooseBmp);
//            //command.Parameters.AddWithValue("@wdOpiMuscAche", wdOpiMuscAche);
//            //command.Parameters.AddWithValue("@wdOpiInsom", wdOpiInsom);
//            //command.Parameters.AddWithValue("@wdOpiNausVom", wdOpiNausVom);
//            //command.Parameters.AddWithValue("@wdOpiDiarrhea", wdOpiDiarrhea);
//            //command.Parameters.AddWithValue("@wdMethDeny7", wdMethDeny7);
//            //command.Parameters.AddWithValue("@wdMethAdmitRecent", wdMethAdmitRecent);
//            //command.Parameters.AddWithValue("@wdMethDenySympt", wdMethDenySympt);
//            //command.Parameters.AddWithValue("@wdMethFatigue", wdMethFatigue);
//            //command.Parameters.AddWithValue("@wdMethDistSleep", wdMethDistSleep);
//            //command.Parameters.AddWithValue("@wdMethIrritable", wdMethIrritable);
//            //command.Parameters.AddWithValue("@wdMethDepMood", wdMethDepMood);
//            //command.Parameters.AddWithValue("@wdMethAnxiety", wdMethAnxiety);
//            //command.Parameters.AddWithValue("@wdMethPsychSympt", wdMethPsychSympt);
//            //command.Parameters.AddWithValue("@wdMarjDeny7", wdMarjDeny7);
//            //command.Parameters.AddWithValue("@wdMarjAdmitRecent", wdMarjAdmitRecent);
//            //command.Parameters.AddWithValue("@wdMarjDenySympt", wdMarjDenySympt);
//            //command.Parameters.AddWithValue("@wdMarjIrritable", wdMarjIrritable);
//            //command.Parameters.AddWithValue("@wdMarjPhysicalTension", wdMarjPhysicalTension);
//            //command.Parameters.AddWithValue("@wdMarjDecAppetite", wdMarjDecAppetite);
//            //command.Parameters.AddWithValue("@wdMarjDepMood", wdMarjDepMood);
//            //command.Parameters.AddWithValue("@wdMarjStomAche", wdMarjStomAche);
//            //command.Parameters.AddWithValue("@wdMarjRestless", wdMarjRestless);
//            //command.Parameters.AddWithValue("@wdMarjInsom", wdMarjInsom);
//            //command.Parameters.AddWithValue("@wdMarjAggresive", wdMarjAggresive);
//            //command.Parameters.AddWithValue("@wdMarjAnger", wdMarjAnger);
//            //command.Parameters.AddWithValue("@wdMarjStrngeDream", wdMarjStrngeDream);
//            //command.Parameters.AddWithValue("@wdMarjAnxiety", wdMarjAnxiety);
//            //command.Parameters.AddWithValue("@usedTobaccoL30", usedTobaccoL30);
//            //command.Parameters.AddWithValue("@cigarettes", cigarettes);
//            //command.Parameters.AddWithValue("@cigarettesValue", cigarettesValue);
//            //command.Parameters.AddWithValue("@cigars", cigars);
//            //command.Parameters.AddWithValue("@cigarsValue", cigarsValue);
//            //command.Parameters.AddWithValue("@pipeSmoke", pipeSmoke);
//            //command.Parameters.AddWithValue("@pipeSmokeValue", pipeSmokeValue);
//            //command.Parameters.AddWithValue("@chew", chew);
//            //command.Parameters.AddWithValue("@chewValue", chewValue);
//            //command.Parameters.AddWithValue("@tobaccoOther", tobaccoOther);
//            //command.Parameters.AddWithValue("@tobaccoOtherValue", tobaccoOtherValue);
//            //command.Parameters.AddWithValue("@tobRevDanger", tobRevDanger);
//            //command.Parameters.AddWithValue("@tobRevCop", tobRevCop);
//            //command.Parameters.AddWithValue("@tobRevInfo", tobRevInfo);
//            //command.Parameters.AddWithValue("@tobOther", tobOther);
//            //command.Parameters.AddWithValue("@tobOtherDesc", tobOtherDesc);
//            //command.Parameters.AddWithValue("@tobNotOffered", tobNotOffered);
//            //command.Parameters.AddWithValue("@tobPtRefused", tobPtRefused);
//            //command.Parameters.AddWithValue("@offTobCess", offTobCess);
//            //command.Parameters.AddWithValue("@yesPhysNotified", yesPhysNotified);
//            //command.Parameters.AddWithValue("@yr58Bath", yr58Bath);
//            //command.Parameters.AddWithValue("@yr58Chores", yr58Chores);
//            //command.Parameters.AddWithValue("@yr58Coop", yr58Coop);
//            //command.Parameters.AddWithValue("@yr58Needs", yr58Needs);
//            //command.Parameters.AddWithValue("@yr58MinResp", yr58MinResp);
//            //command.Parameters.AddWithValue("@yr912BestFriend", yr912BestFriend);
//            //command.Parameters.AddWithValue("@yr912AttSpan", yr912AttSpan);
//            //command.Parameters.AddWithValue("@yr912Hobby", yr912Hobby);
//            //command.Parameters.AddWithValue("@yr912FamDec", yr912FamDec);
//            //command.Parameters.AddWithValue("@yr912RespSelf", yr912RespSelf);
//            //command.Parameters.AddWithValue("@yr1315ShowsConc", yr1315ShowsConc);
//            //command.Parameters.AddWithValue("@yr1315ExpressAff", yr1315ExpressAff);
//            //command.Parameters.AddWithValue("@yr1315CompThought", yr1315CompThought);
//            //command.Parameters.AddWithValue("@yr1315GroupSports", yr1315GroupSports);
//            //command.Parameters.AddWithValue("@yr1618Interest", yr1618Interest);
//            //command.Parameters.AddWithValue("@yr1618LessParents", yr1618LessParents);
//            //command.Parameters.AddWithValue("@yr1618InterestSex", yr1618InterestSex);
//            //command.Parameters.AddWithValue("@yr1618ReasChoice", yr1618ReasChoice);
//            //command.Parameters.AddWithValue("@patientAwayHome", patientAwayHome);
//            //command.Parameters.AddWithValue("@immuneUpToDate", immuneUpToDate);
//            //command.Parameters.AddWithValue("@birthDefects", birthDefects);
//            //command.Parameters.AddWithValue("@birthDefectsDesc", birthDefectsDesc);
//            //command.Parameters.AddWithValue("@histDevDelay", histDevDelay);
//            //command.Parameters.AddWithValue("@histDevDelayDesc", histDevDelayDesc);
//            //command.Parameters.AddWithValue("@parGuardExpect", parGuardExpect);
//            //command.Parameters.AddWithValue("@nurseAdminNote", nurseAdminNote);
//            //command.Parameters.AddWithValue("@nurseSig1", nurseSig1);
//            //command.Parameters.AddWithValue("@nurseSig1Date", nurseSig1Date);
//            //command.Parameters.AddWithValue("@nurseSig1Time", nurseSig1Time);
//            //command.Parameters.AddWithValue("@nurseSig2", nurseSig2);
//            //command.Parameters.AddWithValue("@nurseSig2Date", nurseSig2Date);
//            //command.Parameters.AddWithValue("@nurseSigTime", nurseSigTime);

//            //patientID = int.Parse((command.ExecuteScalar()).ToString());

//            command.ExecuteNonQuery();

//            connection.Close();
//        }
//    }

  
//}
