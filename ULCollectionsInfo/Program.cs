using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULCollectionsInfo
{
    class Program
    {
        static String getVersionStr()
        {
            return DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + "_" + new Random().Next();
        }
        //10THOFSECTALKING_3_1_2019_5_19_2020_1455294013
        static void Main(string[] args)
        {
            YearClassCollectionInfo y;
            String fn = "";
            //_11_20_2020_180139289

            //7_10_2020_1186946197 TURTLES
            String[] szDaysT = { "11/13/2019", "12/6/2019", "1/24/2020", "2/12/2020" };
            y = new YearClassCollectionInfo(
                "D:\\CLASSROOMS1920\\TURTLES_1920",
                "TURTLES_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysT,
                "D:\\CLASSROOMS1920\\TURTLES_1920\\SYNC ",
               "_11_20_2020_180139289");// "_4_21_2020_1508344901");
            fn = "TURTLES_1920_INFO_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);


            String[] szDays_StarFish_2021 = { "11/24/2020" };
            y = new YearClassCollectionInfo(
                "C:\\LVL\\StarFish_2021",
                "StarFish_2021",
                "DAY",
                new DateTime(2019, 7, 1),
                new DateTime(2020, 7, 1),
                szDays_StarFish_2021,
                "C:\\LVL\\StarFish_2021\\SYNC",// T1HACK ",// "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_AM\\SYNC ",  _5_31_2020_1136973128  _7_2_2020_779521743
                "_12_4_2020_86341961", "SHORTID");
            fn = "StarFish_2021_INFOG120420" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            //_10_26_2020_478216537
            String[] szDaysPRIDEAM1819 = { "01/23/2019", "02/20/2019", "03/20/2019", "04/16/2019", "5/30/2019" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_AM",
                "PRIDE_LEAP_AM",
                "DAY",
                new DateTime(2018, 7, 1),
                new DateTime(2019, 7, 1),
                szDaysPRIDEAM1819,
                "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_AM\\SYNC",// T1HACK ",// "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_AM\\SYNC ",  _5_31_2020_1136973128  _7_2_2020_779521743
                "_10_26_2020_478216537", "SHORTID");//"_5_31_2020_1136973128" "_10_26_2020_478216537", "SHORTID");
            fn = "ALL_PRIDE_LEAP_AM_1819_INFO" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);


            //10_20_2020_986296434
            String[] szDaysLB1718 = { "10/24/2017","11/3/2017","11/17/2017","12/14/2017","1/11/2018","2/2/2018","2/16/2018","3/13/2018","3/20/2018","5/1/2018","5/16/2018" };
            y = new YearClassCollectionInfo(
                "F:\\CLASSROOMS_1718\\LADYBUGS2",
                "LADYBUGS2",
                "SUBFOLDERDAY",
                new DateTime(2017, 10, 1),
                new DateTime(2028, 7, 1),
                szDaysLB1718,
                "F:\\CLASSROOMS_1718\\LADYBUGS2\\SYNC ",
                "_10_20_2020_986296434");
            fn = "LB_1718_INFOGR1_5" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            String[] szDaysLB17 = { "3/3/2017","3/10/2017","3/17/2017","3/31/2017","4/7/2017","4/21/2017","4/28/2017","5/12/2017","5/19/2017","5/26/2017" };
            y = new YearClassCollectionInfo(
                "F:\\CLASSROOMS_17\\LADYBUGS1",
                "LADYBUGS1",
                "SUBFOLDERDAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysLB17,
                "F:\\CLASSROOMS_17\\LADYBUGS1\\SYNC ",
                "_10_19_2020_1345568271"); 
            fn  = "LB_17_INFOGR1_5" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);


            //_10_19_2020_1345568271
            //10_8_2020_1205571833  _10_15_2020_1592669264 _10_15_2020_316237436 t1hack  
            String[] szDaysLB1819 = { "10/3/2018", "10/8/2018", " 11/28/2018", "12/4/2018", "1/8/2019", "1/15/2019", "2/5/2019", " 3/6/2019", "3/15/2019", "5/7/2019", "5/14/2019", "5/24/2019" };
            y = new YearClassCollectionInfo(
                "F:\\CLASSROOMS_1819\\LADYBUGS_1819",//"\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Ladybugs\\LadyBugs_1819",
                "LadyBugs_1819",
                "DAY",
                new DateTime(2018, 7, 1),
                new DateTime(2019, 9, 1),
                szDaysLB1819,
                "F:\\CLASSROOMS_1819\\LADYBUGS_1819\\SYNC",//"\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\\\Ladybugs\\LadyBugs_1819\\Synched_Data\\COTALK ",
                "_10_15_2020_316237436", "LONGID"); //"_10_1_2020_535291730", "LONGID"); //"_8_26_2019_59966012", "LONGID");
            fn = "LadyBugs_1819_INFO_" + getVersionStr() + "GR_5TO1_5T1HACK.CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            //_10_15_2020_76146660
            String[] szDaysPANDAS18191 = { "10/17/2018", "11/15/2018" , "11/19/2018", "12/13/2018", "1/24/2019", "1/31/2019", "2/21/2019", "2/28/2019", "3/21/2019", "4/1/2019", "4/25/2019", "4/30/2019", "5/17/2019", "5/23/2019" };//,"7/2/2019","7/9/2019" };
            y = new YearClassCollectionInfo(
                "F:\\CLASSROOMS_1819\\Synched_Data_GR2",//"\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1819",
                "Pandas_1819",
                "DAY",
                new DateTime(2018, 7, 1),
                new DateTime(2019, 9, 1),
                szDaysPANDAS18191,
                "F:\\CLASSROOMS_1819\\Pandas_1819\\Synched_Data_GR2",//"\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1819\\Synched_Data\\COTALK ",
                "_10_15_2020_76146660", "LONGID"); //"_8_9_2019_990773196", "LONGID");_10_8_2020_1205571833  _10_15_2020_76146660 2gr
            fn = "Pandas_1819_INFO_GR_0_2" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);



            //_8_26_2019_59966012
            //_10_15_2020_1592669264
            //_10_8_2020_612807152
            

            //_7_7_2020_783683747
            String[] szDaysPRIDEPM1819 = { "01/25/2019", "02/20/2019", "03/20/2019", "04/16/2019", "5/30/2019" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_PM",
                "PRIDE_LEAP_PM",
                "DAY",
                new DateTime(2018, 7, 1),
                new DateTime(2019, 7, 1),
                szDaysPRIDEPM1819,
                "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_PM\\SYNC",// T1HACK ",// "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_AM\\SYNC ",  _5_31_2020_1136973128  _7_2_2020_779521743
                "_7_7_2020_783683747", "SHORTID");//", "SHORTID"); _5_31_2020_1136973128
            fn = "ALL_PRIDE_LEAP_PM_1819_INFO" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

             


            String[] szDaysLB = { "10/10/2019", "10/18/2019", "11/15/2019", "11/18/2019", "12/12/2019", "12/13/2019", "1/15/2020", "1/17/2020", "2/20/2020", "3/5/2020" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS1920\\LadyBugs_1920",
                "LadyBugs_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysLB,
                "G:\\CLASSROOMS1920\\LadyBugs_1920\\SYNC ",
                "_5_7_2020_1947891923");//"_5_7_2020_166387816");
            fn = "LB_1920_INFOGR2_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKING_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);


            //_4_2_2020_1674806456



            //_9_24_2020_1168622896
            String[] szDays_StarFish_1920 = { "10/02/2019", "11/26/2019", "12/02/2019", "01/28/2020", "02/24/2020" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS1920\\StarFish_1920",
                "StarFish_1920",
                "DAY",
                new DateTime(2019, 7, 1),
                new DateTime(2020, 7, 1),
                szDays_StarFish_1920,
                "G:\\CLASSROOMS1920\\StarFish_1920\\SYNC",// T1HACK ",// "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_AM\\SYNC ",  _5_31_2020_1136973128  _7_2_2020_779521743
                "_9_26_2020_1231380095", "SHORTID");
            fn = "StarFish_1920_INFOGR092620" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            //_6_16_2020_203069312  _6_5_2019_1059196705
            String[] szDaysAPPLETREE1718 = { "10/17/2017", "11/7/2017", "11/28/2017", "12/5/2017", "1/16/2018", "1/25/2018", "2/15/2018", "3/15/2018", "3/19/2018", "4/19/2018", "4/26/2018", "5/17/2018", "7/18/2018", "7/25/2018" };
            y = new YearClassCollectionInfo(
                 "G:\\CLASSROOMS_OLD\\APPLETREE",
                 "APPLETREE",
                 "SUBFOLDERDAY",
                 new DateTime(2017, 7, 1),
                 new DateTime(2018, 9, 1),
                 szDaysAPPLETREE1718,
                 "G:\\CLASSROOMS_OLD\\APPLETREE\\SYNC ",
                 "_9_27_2020_676023620", "LONGID");//_6_16_2020_203069312
            fn = "AppleTree_1718_INFO_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

             

            //_9_8_2020_421885568
            //String[] szDaysAPPLETREE1819 = { "8/30/2018", "9/6/2018", "9/13/2018", "10/4/2018", "10/11/2018", "11/1/2018", "11/8/2018" };//, "11/29/2018", "12/6/2018", "1/10/2019", "2/7/2019", "2/14/2019" };//,"3/7/2019","3/14/2019","4/4/2019","5/9/2019" };
            //String[] szDaysAPPLETREE1819 = { "8/30/2018", "9/6/2018", "9/13/2018", "10/4/2018", "10/11/2018", "11/1/2018", "11/8/2018" , "11/29/2018", "12/6/2018", "1/10/2019" };


            String[] szDaysAPPLETREE1819 = { "8/30/2018", "9/6/2018", "9/13/2018", "10/4/2018", "10/11/2018", "11/1/2018", "11/8/2018" , "11/29/2018", "12/6/2018", "1/10/2019", "2/7/2019", "2/14/2019"  ,"3/7/2019","3/14/2019","4/4/2019","5/9/2019" };
            y = new YearClassCollectionInfo(
               "G:\\CLASSROOMS_OLD\\AppleTree_1819",
               "AppleTree_1819",
               "DAY",
               new DateTime(2018, 7, 1),
               new DateTime(2019, 9, 1),
               szDaysAPPLETREE1819,
               "G:\\CLASSROOMS_OLD\\AppleTree_1819\\SYNC ",
               "_9_25_2020_999878344", "LONGID");//_6_16_2020_203069312
            fn = "AppleTree_1819_INFO_" + getVersionStr() + ".CSV";
           y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

             y.printYearInfo(fn, true, false);
             y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);
           




            //String[] szDaysAPPLETREE1718 = { "10/17/2017","11/7/2017","11/28/2017","12/5/2017","1/16/2018","1/25/2018","2/15/2018","3/15/2018","3/19/2018","4/19/2018","4/26/2018","5/17/2018","7/18/2018","7/25/2018" };
 
            y = new YearClassCollectionInfo(
               "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\LRIC\\AppleTree_1718",
               "APPLETREE",
               "SUBFOLDERDAY",
               new DateTime(2017, 7, 1),
               new DateTime(2018, 9, 1),
               szDaysAPPLETREE1718,
               "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\LRIC\\AppleTree_1718\\Synched_Data\\COTALK ",
               "_6_16_2020_203069312", "LONGID");
            fn = "AppleTree_1718_INFO_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKING_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

             

             


 

          


            //_7_21_2020_1307991371
            //9/19/2019,10/1/2019,10/29/2019,11/5/2019,11/19/2019,12/10/2019,12/17/2019,1/8/2020,1/14/2020,2/4/2020,2/11/2020,3/10/2020
            String[] szDays_AppleTree_1920 = { "9/19/2019","10/1/2019","10/29/2019","11/5/2019","11/19/2019","12/10/2019","12/17/2019","1/8/2020","1/14/2020","2/4/2020","2/11/2020","3/10/2020" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS1920\\AppleTree_1920",
                "AppleTree_1920",
                "DAY",
                new DateTime(2019, 7, 1),
                new DateTime(2020, 7, 1),
                szDays_AppleTree_1920,
                "G:\\CLASSROOMS1920\\AppleTree_1920\\SYNC",// T1HACK ",// "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_AM\\SYNC ",  _5_31_2020_1136973128  _7_2_2020_779521743
                "_7_22_2020_1260238996", "SHORTID");
            fn = "AppleTree_1920_INFO" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);


            


            
            //10THOFSECTALKING_7_9_2019_8_9_2019_990773196.CSV


            //_7_7_2020_1207890104
            fn = "LEAPAM_1920_INFO_" + getVersionStr() + ".CSV";
            String[] szDays = { "11/1/2019", "12/9/2019", "1/30/2020", "2/28/2020", "3/9/2020" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS1920\\LEAP_1920\\LEAP_AM_1920",
                "LEAP_AM_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDays,
                "G:\\CLASSROOMS1920\\LEAP_1920\\LEAP_AM_1920\\SYNC",
                "_7_7_2020_1207890104");

            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            String[] szDaysAV = { "1/23/2020", "2/18/2020" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS1920\\AVENGERS_1920",
                "AVENGERS_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysAV,
                "G:\\CLASSROOMS1920\\AVENGERS_1920\\SYNC ",
                "_7_10_2020_1056069550");// "_4_30_2020_292076670");
            fn = "AVENGERS_1920_INFO_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            //_7_10_2020_1056069550

     
            //_7_7_2020_387465067


            //10THOFSECTALKINGDETAIL_1_30_2019_7_7_2020_1424632065
            fn = "REVAM_18199_INFO_T1HACK_" + getVersionStr() + ".CSV";
            String[] szDaysAR = { "1/30/2019", "3/1/2019", "3/19/2019", "4/24/2019", "5/28/2019" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS_OLD\\PRIDE_REVM\\PRIDE_REVM_AM",   //"\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\PRIDE\\PRIDE_REVM_1819\\PRIDE_REVM_AM",
                "PRIDE_REVM_AM",
                "DAY",
                new DateTime(2019, 1, 1),
                new DateTime(2019, 7, 1),
                szDaysAR,
                "G:\\CLASSROOMS_OLD\\PRIDE_REVM\\PRIDE_REVM_AM\\SYNC",//T1HACK",
               //"G:\\CLASSROOMS_OLD\\PRIDE_REVM\\PRIDE_REVM_AM\\SYNC",
               "_7_7_2020_387465067");// "_7_7_2020_1424632065"); // "_5_19_2020_1455294013");// "_9_9_2019_1999988941");
            //10THOFSECTALKING_1_30_2019_9_9_2019_1999988941
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);


            //_7_2_2020_922472743
            fn = "LEAPPM_18199_INFO_T1HACK_" + getVersionStr() + ".CSV";
            String[] szDaysP = { "01/25/2019", "02/20/2019", "03/20/2019", "04/16/2019", "5/30/2019" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_PM",
                "PRIDE_LEAP_PM",
                "DAY",
                new DateTime(2019, 1, 1),
                new DateTime(2019, 7, 1),
                szDaysP,
                "G:\\CLASSROOMS_OLD\\PRIDE_LEAP\\PRIDE_LEAP_PM\\SYNCT1HACK",
                "_7_7_2020_407979371");// "_7_7_2020_783683747");
            //10THOFSECTALKING_1_23_2019_9_9_2019_2019566646
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");
            //PAIRACTIVITY_ALL_5PRIDE_LEAP_PM_7_7_2020_407979371ALL
            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            fn = "LEAP_PM_1920_INFO_ALLDAYS" + getVersionStr() + ".CSV";
            String[] szDaysLPM = { "11/1/2019", "12/9/2019", "1/30/2020", "2/28/2020", "3/9/2020" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS1920\\LEAP_1920\\LEAP_PM_1920",
                "LEAP_PM_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysLPM,
                "G:\\CLASSROOMS1920\\LEAP_1920\\LEAP_PM_1920\\SYNC",
                "_7_7_2020_1019028736");//_7_1_2020_1686857863
            //10THOFSECTALKINGDETAIL_3_9_2020_7_1_2020_1686857863 _4_2_2020_1694794211   _4_2_2020_17314530   _4_2_2020_1674806456
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

 


            

         

            //String[] szDaysLPM = { "11/1/2019", "12/9/2019", "1/30/2020", "2/28/2020" };
             


            fn = "REVAM_1920_INFO_" + getVersionStr() + ".CSV";
            String[] szDaysR20 = { "11/6/2019", "12/11/2019", "1/29/2020", "2/26/2020" };
            y = new YearClassCollectionInfo(
                "G:\\CLASSROOMS1920\\REVM_1920\\REVM_AM_1920",
                "REVM_AM_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysR20,
                "G:\\CLASSROOMS1920\\REVM_1920\\REVM_AM_1920\\SYNC ",
                "_6_24_2020_590519601");
            //_4_23_2020_1297734825   _4_17_2020_1173190353
            fn = "REVAM_1920_INFO_" + getVersionStr() + ".CSV";
            //10THOFSECTALKING_2_20_2020_3_30_2020_1999684207
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKINGDETAIL_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);


            






            


             //_5_14_2020_1642369940
             //9/17/2019","9/24/2019","10/24/2019","10/30/2019","11/20/2019","12/18/2019","12/19/2019","1/9/2020","1/13/2020","2/3/2020","2/6/2020","3/3/2020
             //10THOFSECTALKINGDETAIL_3_20_2019_5_31_2020_1136973128

             //10THOFSECTALKING_2_8_2018_6_5_2019_1317970681
             //10THOFSECTALKING_1_16_2018_6_5_2019_1059196705
             






             String[] szDaysPANDAS1718 = { "2/1/2018", "2/8/2018" };//, "3/1/2018", "4/6/2018", "4/10/2018", "5/3/2018", "5/10/2018" };
             // String[] szDaysPANDAS1718 = { "3/1/2018", "4/6/2018", "4/10/2018", "5/3/2018", "5/10/2018" };
             //{ "2/1/2018","2/8/2018","3/1/2018","4/6/2018","4/10/2018","5/3/2018","5/10/2018" };
             YearClassCollectionInfo y2 = new YearClassCollectionInfo(
                 "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1718",
                 "PANDAS",
                 "SUBFOLDERDAY",
                 new DateTime(2017, 7, 1),
                 new DateTime(2018, 9, 1),
                 szDaysPANDAS1718,
                 "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1718\\Synched_Data\\COTALK ",
                 "_6_5_2019_1317970681", "LONGID");
             fn = "Pandas_1718_INFO_" + getVersionStr() + ".CSV";
              y2.setItsInfo();
             y2.printYearDaysInfo(fn, true, true);
             // y.setUbiInfo();
             // y.setULInfo("10THOFSECTALKING_");

             //  y.printYearInfo(fn, true, false);
             //   y.printYearDaysInfo(fn, true, true);

             YearClassCollectionInfo y3 = new YearClassCollectionInfo(
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1718",
                "PANDAS",
                "SUBFOLDERDAY",
                new DateTime(2017, 7, 1),
                new DateTime(2018, 9, 1),
                szDaysPANDAS1718,
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1718\\Synched_Data\\COTALK ",
                "_6_5_2019_1317970681", "LONGID");
             fn = "Pandas_1718_INFO_" + getVersionStr() + ".CSV";
             y3.setItsInfo();




             y.printYearDaysSubjectsInfo(fn, true, true);
             y.setItsInfo();
             y.printYearDaysSubjectsInfo(fn, true, true);

             
             
            String[] szDaysPANDAS1819 = { "10/17/2018", "11/15/2018", "11/19/2018", "12/13/2018", "1/24/2019", "1/31/2019", "2/21/2019", "2/28/2019", "3/21/2019", "4/1/2019", "4/25/2019", "4/30/2019", "5/17/2019", "5/23/2019" };//,"7/2/2019","7/9/2019" };
            y = new YearClassCollectionInfo(
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1819",
                "Pandas_1819",
                "DAY",
                new DateTime(2018, 7, 1),
                new DateTime(2019, 9, 1),
                szDaysPANDAS1819,
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\Debbie_School\\Pandas_1819\\Synched_Data\\COTALK ",
                "_8_9_2019_990773196", "LONGID");
            fn = "Pandas_18_19_INFO_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo("10THOFSECTALKING_");

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);
            

            //_5_20_2020_304137922
            String[] szDaysPANDAS = { "9/17/2019", "9/24/2019", "10/24/2019", "10/30/2019", "11/20/2019", "12/18/2019", "12/19/2019", "1/9/2020", "1/13/2020", "2/3/2020", "2/6/2020", "3/3/2020" };// "9/17/2019", "9/24/2019", "10/24/2019", "10/30/2019" };//, "11/20/2019", "12/18/2019", "12/19/2019" };//, "1/9/2020", "1/13/2020", "2/3/2020", "2/6/2020", "3/3/2020" };
           /* y = new YearClassCollectionInfo(
                "E:\\CLASSROOMS1920\\Pandas_1920",
                "Pandas_1920",
                "DAY",
                new DateTime(2019, 7, 1),
                new DateTime(2020, 7, 1),
                szDaysPANDAS,
                "E:\\CLASSROOMS1920\\Pandas_1920\\SYNC ",
                "_5_20_2020_1113551224", "SHORTID");
            fn = "Pandas_19_20_INFO_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo();

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);
            */
            String[] szDaysPANDAS2 = { "11/20/2019", "12/18/2019", "12/19/2019" };//, "1/9/2020", "1/13/2020", "2/3/2020", "2/6/2020", "3/3/2020" };
                                                                                  /* y = new YearClassCollectionInfo(
                                                                                       "E:\\CLASSROOMS1920\\Pandas_1920",
                                                                                       "Pandas_1920",
                                                                                       "DAY",
                                                                                       new DateTime(2019, 7, 1),
                                                                                       new DateTime(2020, 7, 1),
                                                                                       szDaysPANDAS2,
                                                                                       "E:\\CLASSROOMS1920\\Pandas_1920\\SYNC ",
                                                                                       "_5_20_2020_1163639568", "SHORTID");
                                                                                   fn = "Pandas_19202_INFO_" + getVersionStr() + ".CSV";
                                                                                    y.setItsInfo();
                                                                                   y.setUbiInfo();
                                                                                   y.setULInfo();

                                                                                   y.printYearInfo(fn, true, false);
                                                                                   y.printYearDaysInfo(fn, true, true);
                                                                                   y.printYearDaysSubjectsInfo(fn, true, true);
                                                                                   */
                                                                                  


            //10THOFSECTALKING_3_9_2020_3_18_2020_1590632667.CSV
            //10THOFSECTALKING_3_9_2020_3_18_2020_1495978063
            String[] szDaysR20AMPM = { "11/6/2019", "12/11/2019", "1/29/2020", "2/26/2020" };
              fn = "REVAMPM_1920_INFO_" + getVersionStr() + ".CSV";
            /*   YearClassCollectionInfo y = new YearClassCollectionInfo(
                   "F:\\CLASSROOMS1920\\REVM_1920",
                   "REVM_1920",
                   "DAY",
                   new DateTime(2019, 10, 1),
                   new DateTime(2020, 7, 1),
                   szDaysR20AMPM,
                   "F:\\CLASSROOMS1920\\REVM_1920\\SYNC ",
                   "_4_16_2020_2019587774");

               //10THOFSECTALKING_2_20_2020_3_30_2020_1999684207
                 y.setItsInfo();
                  y.setUbiInfo();
                 y.setULInfo();

                 y.printYearInfo(fn, true, false);
                 y.printYearDaysInfo(fn, true, true);
                 y.printYearDaysSubjectsInfo(fn, true, true); 
                 */

            //_5_1_2020_1569966577

            String[] szDaysPandas = { "9/17/2019","9/24/2019","10/24/2019","10/30/2019","11/20/2019","12/18/2019","12/19/2019","1/9/2020","1/13/2020","2/3/2020","2/6/2020","3/3/2020" }; 
            y = new YearClassCollectionInfo(
                "E:\\CLASSROOMS1920\\Pandas_1920",
                "Pandas_1920",
                "DAY",
                new DateTime(2019, 9, 1),
                new DateTime(2020, 7, 1),
                szDaysPandas,
                "E:\\CLASSROOMS1920\\Pandas_1920\\SYNC ",
                "_5_6_2020_845220788");
            fn = "Pandas_1920_INFO_" + getVersionStr() + ".CSV";
            y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo();

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);

            //_4_30_2020_292076670
          
 

            String[] szDaysL20AMPM = { "11/6/2019", "12/11/2019", "1/29/2020", "2/26/2020","3/9/2020" };
            y = new YearClassCollectionInfo(
                "F:\\CLASSROOMS1920\\LEAP_1920",
                "LEAP_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysR20AMPM,
                "F:\\CLASSROOMS1920\\LEAP_1920\\SYNC ",
                "_4_16_2020_2019587774");
            fn = "LEAPAMPM_1920_INFO_" + getVersionStr() + ".CSV";
            //10THOFSECTALKING_2_20_2020_3_30_2020_1999684207
            /*  y.setItsInfo();
               y.setUbiInfo();
              y.setULInfo();

              y.printYearInfo(fn, true, false);
              y.printYearDaysInfo(fn, true, true);
              y.printYearDaysSubjectsInfo(fn, true, true); 
              */

            fn = "LEAPPM_1920_INFO_" + getVersionStr() + ".CSV";



            

            //_4_14_2020_1970015486
            String[] szDaysRPM20 = { "12/11/2019", "1/29/2020", "2/26/2020" };
            y = new YearClassCollectionInfo(
                "F:\\CLASSROOMS1920\\REVM_1920\\REVM_PM_1920",
                "REVM_PM_1920",
                "DAY",
                new DateTime(2019, 10, 1),
                new DateTime(2020, 7, 1),
                szDaysRPM20,
                "F:\\CLASSROOMS1920\\REVM_1920\\REVM_PM_1920\\SYNC ",
                "_4_17_2020_1346184507");
            fn = "REVPM_1920_INFO_" + getVersionStr() + ".CSV";
            //10THOFSECTALKING_2_20_2020_3_30_2020_1999684207
             y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo();

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true); 


            //4_14_2020_1803044670
             





           

            //\\datastore01.psy.miami.edu\Groups\LPerry_Lab\IBSS\PRIDE\PRIDE_LEAP_1819\PRIDE_LEAP_AM\SYNC
            fn = "LEAPAM_18199_INFO_" + getVersionStr() + ".CSV";
            String[] szDaysA = { "01/23/2019", "02/20/2019", "03/20/2019", "04/16/2019", "5/30/2019" };
            y = new YearClassCollectionInfo(
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\PRIDE\\PRIDE_LEAP_1819\\PRIDE_LEAP_AM",
                "PRIDE_LEAP_AM",
                "DAY",
                new DateTime(2019, 1, 1),
                new DateTime(2019, 7, 1),
                szDaysA,
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\PRIDE\\PRIDE_LEAP_1819\\PRIDE_LEAP_AM\\SYNC\\COTALK",
                "_9_9_2019_2019566646");
            //10THOFSECTALKING_1_23_2019_9_9_2019_2019566646
          /*  y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo();

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);
            */



            fn = "LEAPPM_1920_INFO_" + getVersionStr() + ".CSV";



            fn = "LEAPPM_18199_INFO_" + getVersionStr() + ".CSV";
            String [] szDaysPm = { "01/25/2019", "02/20/2019", "03/20/2019", "04/16/2019", "5/30/2019" };
            y = new YearClassCollectionInfo(
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\PRIDE\\PRIDE_LEAP_1819\\PRIDE_LEAP_PM",
                "PRIDE_LEAP_PM",
                "DAY",
                new DateTime(2019, 1, 1),
                new DateTime(2019, 7, 1),
                szDaysPm,
                "\\\\datastore01.psy.miami.edu\\Groups\\LPerry_Lab\\IBSS\\PRIDE\\PRIDE_LEAP_1819\\PRIDE_LEAP_PM\\SYNC\\COTALK",
                "_9_9_2019_1340573660");
            //10THOFSECTALKING_1_23_2019_9_9_2019_2019566646
           /* y.setItsInfo();
            y.setUbiInfo();
            y.setULInfo();

            y.printYearInfo(fn, true, false);
            y.printYearDaysInfo(fn, true, true);
            y.printYearDaysSubjectsInfo(fn, true, true);
            */


            





           
        }
    }
}
