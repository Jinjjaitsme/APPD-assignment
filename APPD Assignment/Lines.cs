using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPD_Assignment
{
    class Lines
    {
        public List<Stations> StationList()
        {
            String[] lines = File.ReadAllLines("MRT.txt");//Reads all the lines in the text document and stores each line seperately in a single array

            List<Stations> stations = new List<Stations>();//Create List to contain station objects

            foreach (String line in lines)
            {//Making station objects for all stations
                String[] stationInfo = line.Split('-');
                stations.Add(new Stations(stationInfo[1], stationInfo[0]));
            }

            return stations;
        }
    }
}

