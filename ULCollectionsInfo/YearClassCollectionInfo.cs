using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ULCollectionsInfo
{
    /// <summary>
    /// ////////////////////////////////////
    /// </summary>
    class YearClassCollectionInfo
    {
        public String dir = "F:\\CLASSROOMS_AS_OF_SEPT2019\\LADYBUGS1";//, "F:\\CLASSROOMS_AS_OF_SEPT2019\\LADYBUGS2", "E:\\LADYBUGS_1819" };
        public String ulDir = "";
        public String ulVersion = "";
        public String classroom = "LADYBUGS1";//, "LADYBUGS2", "LADYBUGS_1819" };
        //public String version = "";// { "", "", "DAY" };
        public String baseMappingFile = "";
        public DateTime minDate = new DateTime(2017, 1, 1);//{ "1/1/2017", "10/1/2017", "10/1/2018" };
        public DateTime maxDate = new DateTime(2017, 9, 1);// { "9/1/2017", "9/1/2018", "9/1/2019" };
        public Dictionary<DateTime, DayCollectionInfo> collectionDaysInfo = new Dictionary<DateTime, DayCollectionInfo>();
        public Dictionary<String, Subject> baseMappings = new Dictionary<string, Subject>();
        public String error = "";
        public String mapById = "LONGID";
        //public String mappingFileType = "DAY";
        public String fileStructure = "DAY";
        public String lenaVersion = "SP";



        public Dictionary<String,List<DateTime>> childrenRecs = new Dictionary<String, List<DateTime>>();
        public Dictionary<String, List<DateTime>> tChildrenRecs = new Dictionary<String, List<DateTime>>();
        public Dictionary<String, List<DateTime>> atChildrenRecs = new Dictionary<String, List<DateTime>>();
        public Dictionary<String, List<DateTime>> adultRecs = new Dictionary<String, List<DateTime>>();
        public Dictionary<String, List<DateTime>> teacherRecs = new Dictionary<String, List<DateTime>>();
        public Dictionary<String, List<DateTime>> labRecs = new Dictionary<String, List<DateTime>>();

        public YearClassCollectionInfo(String folder, String className, String folderType, DateTime start, DateTime end, String[] szDays, String cotalkDir, String cotalkVersion, String fileStruct, String lenaVersionType)
        {
            dir = folder;
            classroom = className;
            //version = folderType;
            minDate = start;
            maxDate = end;

            fileStructure = folderType;
            lenaVersion = lenaVersionType;

            setCollectionDays(szDays);
             
            setMappings();
            ulDir = cotalkDir;
            ulVersion = cotalkVersion;
             
            
        }

        public YearClassCollectionInfo(String folder, String className, String folderType, DateTime start, DateTime end, String[] szDays, String cotalkDir, String cotalkVersion,String mapBy)
        {/////
            dir = folder;
            classroom = className;
            fileStructure = folderType;
            minDate = start;
            maxDate = end;
            setCollectionDays(szDays);
            mapById = mapBy;
            setMappings();/////
            ulDir = cotalkDir;
            ulVersion = cotalkVersion;
             
        }
        public YearClassCollectionInfo(String folder, String className, String folderType, DateTime start, DateTime end, String[] szDays, String cotalkDir, String cotalkVersion)
        {
            dir = folder;
            classroom = className;
            fileStructure = folderType;
            minDate = start;
            maxDate = end; 
            setCollectionDays(szDays);
            setMappings();
            ulDir = cotalkDir;
            ulVersion = cotalkVersion;
        }
        public void setMappings() 
        {
            baseMappingFile = dir + "//MAPPING_" + classroom + (fileStructure == "DAY" ? "_BASE" : "") + ".CSV";
            if (!File.Exists(baseMappingFile))
            {
                error = "baseMappingFile not found : " + baseMappingFile;
                Console.WriteLine(error);
            }
            else
            {

                using (StreamReader sr = new StreamReader(baseMappingFile))
                {
                    if (!sr.EndOfStream)
                    {
                        sr.ReadLine();
                    }

                    while ((!sr.EndOfStream))// && lineCount < 10000)
                    {
                        String commaLine = sr.ReadLine();
                        String[] line = commaLine.Split(',');
                        if (line.Length > 16 && line[1] != "")
                        {
                            Subject si = new Subject(commaLine, mapById);//longid
                            
                            if (!baseMappings.ContainsKey(si.mapId))
                            {
                                baseMappings.Add(si.mapId, si);///
                            }
                            if (fileStructure != "DAY")
                            {


                                setBaseDayMappings(commaLine);//////
                            }
                        }
                    }
                }
            }
            if (fileStructure == "DAY")
            {
                setDayMappings();
            }
        }
        public void addToRecType(Subject si, DateTime day, DayCollectionInfo di)
        {
            switch (si.type.Trim().ToUpper().Substring(0,1))
            {
                case "C":
                    if (!childrenRecs.ContainsKey(si.mapId))
                        childrenRecs.Add(si.mapId, new List<DateTime>());
                    childrenRecs[si.mapId].Add(day);

                    if (!di.children.Contains(si.mapId))
                        di.children.Add(si.mapId);

                    if(baseMappings.ContainsKey(si.mapId))
                    if(baseMappings[si.mapId].diagnosis.Trim().ToUpper()=="TYPICAL" || baseMappings[si.mapId].diagnosis.Trim() == "" )
                    {
                        if (!tChildrenRecs.ContainsKey(si.mapId))
                            tChildrenRecs.Add(si.mapId, new List<DateTime>());
                        tChildrenRecs[si.mapId].Add(day);

                        if (!di.tChildren.Contains(si.mapId))
                            di.tChildren.Add(si.mapId);
                    }
                    else
                    {
                        if (!atChildrenRecs.ContainsKey(si.mapId))
                            atChildrenRecs.Add(si.mapId, new List<DateTime>());
                        atChildrenRecs[si.mapId].Add(day);

                        if (!di.atChildren.Contains(si.mapId))
                            di.atChildren.Add(si.mapId);
                    }

                    break;
                case "T":
                    if (!adultRecs.ContainsKey(si.mapId))
                        adultRecs.Add(si.mapId, new List<DateTime>());
                    adultRecs[si.mapId].Add(day);

                    if (!di.adults.Contains(si.mapId))
                        di.adults.Add(si.mapId);

                    if (!teacherRecs.ContainsKey(si.mapId))
                        teacherRecs.Add(si.mapId, new List<DateTime>());
                    teacherRecs[si.mapId].Add(day);

                    if (!di.teachers.Contains(si.mapId))
                        di.teachers.Add(si.mapId);

                    break;
                case "L":
                    if (!adultRecs.ContainsKey(si.mapId))
                        adultRecs.Add(si.mapId, new List<DateTime>());
                    adultRecs[si.mapId].Add(day);

                    if (!di.adults.Contains(si.mapId))
                        di.adults.Add(si.mapId);


                    if (!labRecs.ContainsKey(si.mapId))
                        labRecs.Add(si.mapId, new List<DateTime>());
                    labRecs[si.mapId].Add(day);

                    if (!di.labs.Contains(si.mapId))
                        di.labs.Add(si.mapId);
                    break;
            }
        }
        public void setBaseDayMappings(String commaLine)
        {
             
            String[] line = commaLine.Split(',');
            //11 12 13
            DateTime s = Convert.ToDateTime(line[11]);
            DateTime e = Convert.ToDateTime(line[12]);
            String absences = line[13].Trim();
            foreach(DateTime day in collectionDaysInfo.Keys)
            {
                Subject si = (Subject)new Subject(commaLine, mapById);
                String szDay = day.Month + "/" + day.Day + "/" + day.Year;

                DateTime start = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
                DateTime end = new DateTime(day.Year, day.Month, day.Day, 23, 59, 59);
                si.startDate = start;
                si.endDate = end;


                DateTime endDateTime=e.Hour==0?e.AddHours(23).AddMinutes(59).AddSeconds(59):e;
               // if (s <= day && e >= day.AddHours(23).AddMinutes(59).AddSeconds(59) && (!absences.Contains(szDay)))
                if (s<=start && endDateTime >= end && (! absences.Contains(szDay)))
                {
                   
                  
                    si.present = true;
                    DayCollectionInfo dayMaps = collectionDaysInfo[day];
                    addToRecType(si, day, dayMaps);///
                    if (!dayMaps.dayMapping.ContainsKey(si.mapId))
                    {       
                        dayMaps.dayMapping.Add(si.mapId, new List<Subject>());
                    }
                    dayMaps.dayMapping[si.mapId].Add(si);
                }
                if (si.lenaId == "11563")
                {
                    bool stop = true;
                }

            }
        }

        public void setDayMappings()
        {////
            String[] dateDirs = Directory.GetDirectories(dir, "*-*-*");

            foreach (String szDateDir in dateDirs)
            {
                String mappingDir = szDateDir + "//MAPPINGS//MAPPING_" + classroom + ".CSV";
                if (!File.Exists(mappingDir))
                {
                    error = "mappingDir not found : " + mappingDir;
                    Console.WriteLine(error);
                }
                else
                {

                    using (StreamReader sr = new StreamReader(mappingDir))
                    {
                        String szday = mappingDir.Substring(0, mappingDir.IndexOf("//MAPPINGS"));
                        szday = szday.Substring(szday.LastIndexOf("\\") + 1).Replace("-", "/");// day.Month + "/" + day.Day + "/" + day.Year;
                        DateTime day = Convert.ToDateTime(szday);

                        if (!sr.EndOfStream)
                        {
                            sr.ReadLine();
                        }

                        while ((!sr.EndOfStream))// && lineCount < 10000)
                        {
                            String commaLine = sr.ReadLine();
                            String[] line = commaLine.Split(',');
                            if (line.Length > 16 && line[1] != "")
                            {
                                Subject si =new Subject(commaLine, mapById);
                                 
                                if (collectionDaysInfo.ContainsKey(day))
                                {
                                    DateTime start = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
                                    DateTime end = new DateTime(day.Year, day.Month, day.Day, 23, 59, 59);
                                    si.startDate = start;
                                    si.endDate = end;
                                    DayCollectionInfo dayMaps = collectionDaysInfo[day];
                                    if (!dayMaps.dayMapping.ContainsKey(si.mapId))
                                    {
                                        dayMaps.dayMapping.Add(si.mapId, new List<Subject>());
                                    }
                                    dayMaps.dayMapping[si.mapId].Add(si);

                                    if (!baseMappings.ContainsKey(si.mapId))
                                    {
                                        baseMappings.Add(si.mapId, si);
                                    }
                                    if(si.present)
                                    addToRecType(si, day,dayMaps);
                                }

                                }
                        }
                    }
                }
            }
        }
        public void setCollectionDays(String[] szDays)//for old mappings
        {
            foreach(String szDay in szDays)
            {
                DateTime theDay = Convert.ToDateTime(szDay);
                if(!collectionDaysInfo.ContainsKey(theDay))
                {
                    collectionDaysInfo.Add(theDay, new DayCollectionInfo(theDay));////
                }
            }
        }
        public void setItsInfo()
        {//public Dictionary<DateTime, DayCollectionInfo> collectionDaysInfo = new Dictionary<DateTime, DayCollectionInfo>();

            foreach(DayCollectionInfo di in collectionDaysInfo.Values)
            {
                di.setItsInfo(dir, fileStructure);//DS_PANDAS_1819_1
            }
        }
        public void setUbiInfo()
        {//public Dictionary<DateTime, DayCollectionInfo> collectionDaysInfo = new Dictionary<DateTime, DayCollectionInfo>();

            foreach (DayCollectionInfo di in collectionDaysInfo.Values)
            {
                di.setUbiInfo(dir, fileStructure);
            }
        }
        public void setULInfo()
        {//public Dictionary<DateTime, DayCollectionInfo> collectionDaysInfo = new Dictionary<DateTime, DayCollectionInfo>();

            setULInfo("10THOFSECTALKINGDETAIL_");
           
        }

        public void setULInfo(String cotalkFilePrefix)
        {//public Dictionary<DateTime, DayCollectionInfo> collectionDaysInfo = new Dictionary<DateTime, DayCollectionInfo>();

            foreach (DayCollectionInfo di in collectionDaysInfo.Values)
            {
                di.setCotalkInfo(ulDir, ulVersion, cotalkFilePrefix);
            }
        }
        public void setItsInfo( String f )
        {//public Dictionary<DateTime, DayCollectionInfo> collectionDaysInfo = new Dictionary<DateTime, DayCollectionInfo>();

            foreach (DayCollectionInfo di in collectionDaysInfo.Values)
            {
                di.setItsInfo(dir, fileStructure);
            }
        }
        public void setUbiInfo(String f)
        {//public Dictionary<DateTime, DayCollectionInfo> collectionDaysInfo = new Dictionary<DateTime, DayCollectionInfo>();

            foreach (DayCollectionInfo di in collectionDaysInfo.Values)
            {
                di.setUbiInfo(dir, fileStructure);
            }
        }
        
        public void appendYearClassInfo(TextWriter sw)
        {
            ///YEAR CLASS
            
            sw.Write(classroom + ",");
            foreach (DateTime day in collectionDaysInfo.Keys)
                sw.Write(day.Month + "/" + day.Day + "/" + day.Year + "|");

            sw.Write("," + fileStructure);
            sw.Write("," + baseMappingFile);
            sw.Write("," + (childrenRecs.Count + adultRecs.Count));
            sw.Write("," + childrenRecs.Count);
            sw.Write("," + tChildrenRecs.Count);
            sw.Write("," + atChildrenRecs.Count);
            sw.Write("," + adultRecs.Count);
            sw.Write("," + teacherRecs.Count);
            sw.Write("," + labRecs.Count);
            sw.Write("," + (getTotalRecs(childrenRecs) + getTotalRecs(adultRecs)));
            sw.Write("," + getTotalRecs(childrenRecs));
            sw.Write("," + getTotalRecs(tChildrenRecs));
            sw.Write("," + getTotalRecs(atChildrenRecs));
            sw.Write("," + getTotalRecs(adultRecs));
            sw.Write("," + getTotalRecs(teacherRecs));
            sw.WriteLine("," + getTotalRecs(labRecs));
             
        }
        public void appendYearClassDaysInfo(TextWriter sw)
        {
            ///YEAR CLASS DAYS
              
            foreach (DateTime day in collectionDaysInfo.Keys)
            {
                sw.Write(classroom+","+day.Month + "/" + day.Day + "/" + day.Year + ",");
                sw.WriteLine((collectionDaysInfo[day].adults.Count + collectionDaysInfo[day].children.Count) +","+
                    collectionDaysInfo[day].children.Count + "," +
                    collectionDaysInfo[day].tChildren.Count + "," +
                    collectionDaysInfo[day].atChildren.Count + "," +
                    collectionDaysInfo[day].adults.Count + "," +
                    collectionDaysInfo[day].teachers.Count + "," +
                    collectionDaysInfo[day].labs.Count);
            }
                  

        }
        public String getTimeStr(DateTime t)
        {
            return t.ToLongTimeString().Replace(" ", ":" + t.Millisecond + " ");
        }
        public void appendYearClassDaysSubjectsInfo(TextWriter sw)
        {
            ///YEAR CLASS DAYS
            //sw.WriteLine("CLASSROOM,DATE,LONG_ID,SHORT_ID,STATUS,"+
            //"LENAID,LEFTUBI,RIGHTUBI,LENAMS,UBIMS,ULMS,LEFTUBILOGS,RIGHTUBILOGS,UBILOGS,ULLOGS,LENASTART,LENAEND,UBISTART,UBIEND,ULSTART,ULEND,ITSFILES," +
            //"TYPE,DIAGNOSIS,LANGUAGE,GENDER"
                   // );
            foreach (DateTime day in collectionDaysInfo.Keys)
            {
                DayCollectionInfo dc = collectionDaysInfo[day];
                foreach(String subject in dc.dayMapping.Keys)
                {
                    foreach (Subject sm in dc.dayMapping[subject])
                    {
                        try
                        {
                            Subject sMap = sm;
                            if (this.baseMappings.ContainsKey(sm.mapId))
                                sMap = this.baseMappings[sm.mapId];


                            String lenaStarts = "";
                            String lenaEnds = "";

                            foreach (DateTime startDate in sm.itsRecs.startTimes)
                            {
                                lenaStarts = lenaStarts + (lenaStarts != "" ? "|" : "") + getTimeStr(startDate);
                            }
                            foreach (DateTime endDate in sm.itsRecs.endTimes)
                            {
                                lenaEnds = lenaEnds + (lenaEnds != "" ? "|" : "") + getTimeStr(endDate);
                            }
                            sw.Write(classroom + "," + day.Month + "/" + day.Day + "/" + day.Year + "," +
                                sm.longId + "," +
                                sm.shortId + "," +
                                (sm.present ? "PRESENT" : "ABSENT") + "," +
                                sm.lenaId + "," +
                                sm.leftUbi + "," +
                                sm.rightUbi + "," +
                                sm.itsRecs.ms + "," +
                                sm.ubiRecs.ms + "," +
                                sm.cotalkRecs.ms + "," +
                                ((sm.itsRecs.ms/60000)/60) + "," +
                                ((sm.ubiRecs.ms / 60000) / 60) + "," +
                                ((sm.cotalkRecs.ms / 60000)/ 60) + "," +
                                sm.leftUbiRecs.totalLogs + "," +
                                sm.rightUbiRecs.totalLogs + "," +
                                sm.ubiRecs.totalLogs + "," +
                                sm.cotalkRecs.totalLogs + "," +
                                getTimeStr(sm.itsRecs.startTime) + "," +
                                getTimeStr(sm.itsRecs.endTime) + "," +
                                lenaStarts + "," +
                                lenaEnds + "," +
                                getTimeStr(sm.ubiRecs.startTime) + "," +
                                getTimeStr(sm.ubiRecs.endTime) + "," +
                                getTimeStr(sm.cotalkRecs.startTime) + "," +
                                getTimeStr(sm.cotalkRecs.endTime) + "," +
                                sMap.type + "," +
                                sMap.diagnosis + "," +
                                sMap.language + "," +
                                sMap.gender + ",");
                            String szFiles = "";
                            foreach (String szItsFile in sm.itsRecs.dataFiles)
                            {
                                szFiles = szFiles + (szFiles != "" ? "|" : "") + szItsFile;
                            }
                            sw.WriteLine(szFiles);
                        }
                        catch (Exception e)
                        {
                            Boolean stop = true;
                        }


                    }

                }

                   
            }


        }
        public void printYearInfo(String fileName, Boolean printHeader, Boolean append)
        {
            TextWriter sw = new StreamWriter(fileName,append);
            if(printHeader)
            {
                sw.WriteLine("CLASSROOM INFO: ");
                sw.WriteLine("CLASSROOM,DATES,VERSION,BASE_MAPPING_FILE," +
                    "SUBJECTS_RECORDED,CHILDREN_RECORDED,TYPICAL_CHILDREN_RECORDED,ATYPICAL_CHILDREN_RECORDED ,ADULTS_RECORDED,TEACHERS_RECORDED,LABS_RECORDED," +
                    "SUBJECT_TOTAL_RECS,CHILDREN_TOTAL_RECS,TYPICAL_CHILDREN_TOTAL_RECS,ATYPICAL_CHILDREN_TOTAL_RECS,ADULTS_TOTAL_RECS,TEACHERS_TOTAL_RECS,LABS_TOTAL_RECS");

            }
            appendYearClassInfo(sw);
            sw.Close();
        }
        public void printYearDaysInfo(String fileName, Boolean printHeader, Boolean append)
        {
            TextWriter sw = new StreamWriter(fileName, append);
            if (printHeader)
            {
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine(classroom + " CLASSROOM DAYS INFO: ");
                sw.WriteLine("CLASSROOM, DATE,SUBJECTS_RECORDED,CHILDREN_RECORDED,TYPICAL_CHILDREN_RECORDED,ATYPICAL_CHILDREN_RECORDED,ADULTS_RECORDED,TEACHERS_RECORDED,LABS_RECORDED");

            }
            appendYearClassDaysInfo(sw);
            sw.Close();
        }

        public void printYearDaysSubjectsInfo(String fileName,Boolean printHeader, Boolean append)
        {
            TextWriter sw = new StreamWriter(fileName, append);
            if (printHeader)
            {
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine(classroom + " CLASSROOM DAYS SUBJECTS INFO: ");
                sw.WriteLine("CLASSROOM,DATE,LONG_ID,SHORT_ID,STATUS,"+
                    "LENAID,LEFTUBI,RIGHTUBI,LENAMS,UBIMS,ULMS,LENAHRS,UBIHRS,ULHRS,LEFTUBILOGS,RIGHTUBILOGS,UBILOGS,ULLOGS,LENASTART,LENAEND,LENASTARTS,LENAENDS,UBISTART,UBIEND,ULSTART,ULEND," +
                    "TYPE,DIAGNOSIS,LANGUAGE,GENDER,ITSFILES."
                    );

            }
            appendYearClassDaysSubjectsInfo(sw);
            sw.Close();
        }
        public int getTotalRecs(Dictionary<String, List<DateTime>> recs)
        {
            int res = 0;
            foreach (String key in recs.Keys)
            {
                res += recs[key].Count;
            }
            return res;
        }
    }
}
