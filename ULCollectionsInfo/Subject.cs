using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULCollectionsInfo
{
    
    class Subject
    {
        public String shortId = "";
        public String longId = "";
        public String lenaId = "";
        public String leftUbi = "";
        public String rightUbi = "";
        public String type = "?";
        public String diagnosis = "";
        public String language = "";
        public String gender = "";
        public String dob = "";
        public Boolean present = false;
        public String error = "";
        public String mapId = "";
        public DateTime startDate = new DateTime(2000, 1, 1);
        public DateTime endDate = new DateTime(2000, 2, 1);
        public String absences = "";
         
        public Recording itsRecs = new Recording();
        public Recording ubiRecs = new Recording();
        public Recording leftUbiRecs = new Recording();
        public Recording rightUbiRecs = new Recording();
        public Recording cotalkRecs = new Recording();
        
        public Subject()
        {

        }
        public Subject(String commaLine, String byId, String fileStruct)
        {
            setFields(commaLine, byId, fileStruct);
        }
        public Subject(String commaLine, String byId)
        {
            setFields(commaLine, byId, "DAY");
        }
        public void setFields(String commaLine, String byId, String fileStruct)
        {
            String[] line = commaLine.Split(',');
            try
            {


                
                




                String bid = line[3].Trim();
                String bid2 = line.Length > 18 ? line[18] : line[3].Trim();
                this.shortId = bid2.Length == 0 ? bid : bid.Length <= bid2.Length ? bid : bid2;
                this.longId = bid2.Length == 0 ? bid : bid.Length >= bid2.Length && bid2.Length > 0 ? bid : bid2;
                lenaId = line[9].Trim();
                leftUbi = line[5].Trim();
                rightUbi = line[7].Trim();
                mapId = byId.ToUpper() == "LENA" ? lenaId : byId.ToUpper() == "SHORTID" ? shortId : byId.ToUpper() == "LEFTUBI" ? leftUbi : byId.ToUpper() == "RIGHTUBI" ? rightUbi : longId;
                diagnosis = line[14].Trim();
                gender = line[15].ToUpper();
                dob = line[16].Trim();
                type = line[17].ToUpper();
                language = line[20].ToUpper();
                if (fileStruct=="DAY")
                {
                    present = line[19].ToUpper() == "PRESENT";

                }
                else
                {
                    //10 11
                    // String szDay = (day.Month < 10 ? "0" + day.Month.ToString() : day.Month.ToString()) + "-" + (day.Day < 10 ? "0" + day.Day.ToString() : day.Day.ToString()) + "-" + day.Year;
                    startDate = Convert.ToDateTime(line[10]);
                    endDate = Convert.ToDateTime(line[11]);
                    absences = line[12].Trim();
                }
                
            }
            catch (Exception e)
            {
                error = e.Message;
                //Console.WriteLine(error);
            }
        }


    }
}
