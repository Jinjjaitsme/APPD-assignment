using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APPD_Assignment
{
    class Guide
    {
        private String From;
        private String To;
        public Guide(String From, String To)
        {
            this.From = From;
            this.To = To;
        }

        public string pathFind()
        {
            Lines manyLine = new Lines();
            List<Stations> stationList = manyLine.StationList();
            int fromIndex = -1;
            int toIndex = -1;
            string abc = "";
            
            //Finding index of From and To
            for (int i = 0; i <= stationList.Count(); i++)
            {
                if (From.Equals(stationList[i].StationLine + "-" + stationList[i].StationName))
                {
                    fromIndex = i;
                }
                if (To.Equals(stationList[i].StationLine + "-" + stationList[i].StationName))
                {
                    toIndex = i;
                }
                if (fromIndex != -1 && toIndex != -1)//If both from and to have been found it will exit the for loop
                    break;
            }
            if (stationList[fromIndex].StationLine.Substring(0,2) == stationList[toIndex].StationLine.Substring(0, 2))
            {
                if (fromIndex < toIndex)
                {//Moving forwards
                    for (int i = fromIndex; i <= toIndex; i++)
                    {
                        abc += stationList[i].StationName + "\r\n";
                    }
                }

                else if (fromIndex > toIndex)
                {//Moving backwards
                    for (int i = fromIndex; i >= toIndex; i--)
                    {
                        abc += stationList[i].StationName + "\r\n";
                    }
                }
            }
            else
            {
                abc = "ERROR";
            }
        
            return abc ;
        }



        public int StationCount()
        {
            Lines manyLine = new Lines();
            List<Stations> stationList = manyLine.StationList();
            int fromIndex = -1;
            int toIndex = -1;
            int count = 0;

            //Finding index of From and To
            for (int i = 0; i <= stationList.Count(); i++)
            {
                if (From.Equals(stationList[i].StationLine + "-" + stationList[i].StationName))
                {
                    fromIndex = i;
                }
                if (To.Equals(stationList[i].StationLine + "-" + stationList[i].StationName))
                {
                    toIndex = i;
                }
                if (fromIndex != -1 && toIndex != -1)//If both from and to have been found it will exit the for loop
                    break;
            }
            if (stationList[fromIndex].StationLine.Substring(0, 2) == stationList[toIndex].StationLine.Substring(0, 2))
            {
                if (fromIndex < toIndex)
                {//Moving forwards
                    for (int i = fromIndex; i <= toIndex; i++)
                    {
                        count += 1;
                    }
                }

                else if (fromIndex > toIndex)
                {//Moving backwards
                    for (int i = fromIndex; i >= toIndex; i--)
                    {
                        count += 1;
                    }
                }
            }
            else
            {
                count = 0;
            }

            return count;
        }
    }
}
