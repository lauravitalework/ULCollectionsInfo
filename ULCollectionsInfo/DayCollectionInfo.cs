using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace ULCollectionsInfo
{
    class DayCollectionInfo
    {
        public DateTime day = new DateTime();
        public List<String> ubiFiles = new List<string>();
        public Dictionary<String, List<Subject>> dayMapping = new Dictionary<string, List<Subject>>();
        public List<String> children = new List<string>();
        public List<String> tChildren = new List<string>();
        public List<String> atChildren = new List<string>();
        public List<String> teachers = new List<string>();
        public List<String> labs = new List<string>();
        public List<String> adults = new List<string>();

        public DayCollectionInfo(DateTime theDay)
        {
            day = theDay;
        }
        public void setItsInfo(String dir,String version)
        {
            String szDayFolder = (day.Month < 10 ? "0" + day.Month.ToString() : day.Month.ToString()) + "-" + (day.Day < 10 ? "0" + day.Day.ToString() : day.Day.ToString()) + "-" + day.Year;
            String itsDir= version == "DAY" ? dir+"\\"+szDayFolder+"\\LENA_Data\\ITS\\" :  dir + "\\LENA_Data\\ITS\\"+szDayFolder;
             
            if (Directory.Exists(itsDir))
            {
                String[] itsFiles = Directory.GetFiles(itsDir, "*.its");
                foreach (String file in itsFiles)
                {

                    String itslenaId = file.Substring(file.LastIndexOf("_") + 1).Replace(".its", "");
                    if (itslenaId.Substring(0, 2) == "00")
                        itslenaId = itslenaId.Substring(2);
                    else if (itslenaId.Substring(0, 1) == "0")
                        itslenaId = itslenaId.Substring(1);

                    XmlDocument doc = new XmlDocument();
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.DtdProcessing = DtdProcessing.Parse;
                    settings.ValidationType = ValidationType.DTD;
                    settings.XmlResolver = new XmlUrlResolver();
                    settings.DtdProcessing = DtdProcessing.Ignore;
                    XmlReader reader = XmlReader.Create(file, settings);
                    doc.Load(reader);
                    XmlNodeList rec =  doc.ChildNodes[0].SelectNodes("ProcessingUnit/Recording") ;
                    if(rec==null)
                    {
                        rec =  doc.ChildNodes[1].SelectNodes("ProcessingUnit/Recording");
                    }
                    foreach (XmlNode recording in rec)
                    {
                        DateTime recStartTimeOriginal = DateTime.Parse(recording.Attributes["startClockTime"].Value);
                        DateTime recEndTimeOriginal = DateTime.Parse(recording.Attributes["endClockTime"].Value);
                        Boolean pass = (((!dir.Contains("_AM")) && (!dir.Contains("_PM"))) ||
                           (dir.Contains("_AM") && recStartTimeOriginal.Hour<11) ||
                           (dir.Contains("_PM") && recStartTimeOriginal.Hour >= 11));


                        if (isSameDay( recStartTimeOriginal))///
                        {


                            if ("14865" == itslenaId)
                            {
                                bool stop=true;
                            }
                            Subject sm = findByLenaId(itslenaId);///
                            sm.itsRecs.startTimes.Add(recStartTimeOriginal);
                            sm.itsRecs.endTimes.Add(recEndTimeOriginal);

                            // this.dayMapping[sm.mapId].itsRecs.dataFiles.Add(file);

                            sm.itsRecs.dataFiles.Add(file);

                            if (pass)
                            {
                                //startTime="PT0.00S" endTime="PT15490.61S"
                                String szSecs = recording.Attributes["startTime"].Value.ToString().Substring(2);

                                szSecs = szSecs.Substring(0, szSecs.Length - 1);
                                double startSecs = Convert.ToDouble(szSecs);
                                szSecs = recording.Attributes["endTime"].Value.ToString().Substring(2);
                                szSecs = szSecs.Substring(0, szSecs.Length - 1);
                                double endSecs = Convert.ToDouble(szSecs);
                                double totalSecs = endSecs - startSecs;
                                sm.itsRecs.ms += (totalSecs * 1000);


                                if (sm.itsRecs.startTime < day || recStartTimeOriginal < sm.itsRecs.startTime)
                                {
                                    sm.itsRecs.startTime = recStartTimeOriginal;

                                }
                                if (sm.itsRecs.endTime > day || recEndTimeOriginal > sm.itsRecs.endTime)
                                {
                                    sm.itsRecs.endTime = recEndTimeOriginal;
                                }
                            }
                        }
                    }
                }
             }
        }
        public bool isSameDay(DateTime time)
        {
            return (day.Month == time.Month && day.Day == time.Day && day.Year == time.Year);
        }
        public void setUbiInfo(String dir, String version)
        {
            String szDayFolder = (day.Month < 10 ? "0" + day.Month.ToString() : day.Month.ToString()) + "-" + (day.Day < 10 ? "0" + day.Day.ToString() : day.Day.ToString()) + "-" + day.Year;
            String ubiDir = version == "DAY" ? dir + "\\" + szDayFolder + "\\Ubisense_Data" : dir + "\\Ubisense_Data\\"+ szDayFolder;
            String[] ubiFiles = Directory.GetFiles(ubiDir, "MiamiLocation*.log");
            DateTime start = new DateTime(4000,1,1);
            DateTime end = new DateTime(1000,1,1);
            Dictionary<String, DateTime> lastStamps = new Dictionary<string, DateTime>();
            foreach (String file in ubiFiles)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while(!sr.EndOfStream)
                    {
                        String commaLine = sr.ReadLine();
                        String[] line = commaLine.Split(',');
                        if (line.Length > 3)
                        {
                            DateTime time = Convert.ToDateTime(line[2]);
                            if (isSameDay(time))
                            {
                                if (time < start)
                                    start = time;

                                if (time > end)
                                    end = time;

                                String ubiId = line[1].Trim();
                                Subject sm = findByUbiId(ubiId);///

                                if (sm.mapId != "")
                                {
                                    String lOrR = sm.rightUbi.Trim() == ubiId.Trim() ? "r" : "l";

                                    if (!lastStamps.ContainsKey(sm.mapId))
                                    {
                                        lastStamps.Add(sm.mapId, time);
                                    }
                                    else
                                    {
                                        TimeSpan difference = time.Subtract(lastStamps[sm.mapId]); // could also write `now - otherTime`
                                        if (difference.TotalSeconds < 60)
                                        {
                                            sm.ubiRecs.ms += (difference.TotalMilliseconds);
                                        }
                                    }
                                    lastStamps[sm.mapId] = time;
                                    sm.ubiRecs.dataFiles.Add(file);
                                    sm.ubiRecs.totalLogs++;
                                    if (sm.ubiRecs.startTime < day || time < sm.ubiRecs.startTime)
                                    {
                                        sm.ubiRecs.startTime = time;

                                    }
                                    if (sm.ubiRecs.endTime > day || time > sm.ubiRecs.endTime)
                                    {
                                        sm.ubiRecs.endTime = time;

                                    }
                                    if (lOrR == "r")
                                        sm.rightUbiRecs.totalLogs++;
                                    else
                                        sm.leftUbiRecs.totalLogs++;
                                }
                            }
                        }
                    }

                }
            }
        }
        public void setCotalkInfo(String dir, String cotalkVersion)
        {
            setCotalkInfo(dir, cotalkVersion, "10THOFSECTALKINGDETAIL_");
        }
        public void setCotalkInfo(String dir, String cotalkVersion, String cotalkFilePrefix)
        {
            //10THOFSECTALKING_3_9_2020_3_18_2020_1590632667.CSV'
            String ulFileName = dir+"\\"+ cotalkFilePrefix+(day.Month + "_" + day.Day + "_" + day.Year)+cotalkVersion+".CSV";
            ulFileName = ulFileName;
            if (File.Exists(ulFileName))
            {
                using (StreamReader sr = new StreamReader(ulFileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        String commaLine = sr.ReadLine();
                        String[] line = commaLine.Split(',');
                        String bid = line[0].Trim();
                        Subject sm = findByLongId(bid);
                        if(sm.longId=="")
                            sm = findByShortId(bid);
                        DateTime time = Convert.ToDateTime(line[1]);
                        if (sm.longId!="")
                        {
                            sm.cotalkRecs.totalLogs++;
                            sm.cotalkRecs.ms+=100;
                            if (sm.cotalkRecs.startTime > time)
                                sm.cotalkRecs.startTime = time;

                            if (sm.cotalkRecs.endTime < time)
                                sm.cotalkRecs.endTime = time;

                        }
                    }
                }
            }
        }
        public Subject findByLenaId(String lenaId)
        {
            foreach (String key in dayMapping.Keys)
            {
                foreach (Subject sm in dayMapping[key])
                {
                    if(sm.present && sm.lenaId==lenaId)
                    {
                        return sm;
                    }
                }
            }
            return new Subject();
        }
        public Subject findByLongId(String longId)
        {
            foreach (String key in dayMapping.Keys)
            {
                foreach (Subject sm in dayMapping[key])
                {
                    if (sm.present && sm.longId == longId)
                    {
                        return sm;
                    }
                }
            }
            return new Subject();
        }

        public Subject findByShortId(String id)
        {
            foreach (String key in dayMapping.Keys)
            {
                foreach (Subject sm in dayMapping[key])
                {
                    if (sm.present && sm.shortId == id)
                    {
                        return sm;
                    }
                }
            }
            return new Subject();
        }

        public Subject findByUbiId(String ubiId)
        {
            foreach (String key in dayMapping.Keys)
            {
                foreach (Subject sm in dayMapping[key])
                {
                    if (sm.present && (sm.leftUbi == ubiId || sm.rightUbi == ubiId))
                    {
                        return sm;
                    }
                }
            }
            return new Subject();
        }


    }
}
