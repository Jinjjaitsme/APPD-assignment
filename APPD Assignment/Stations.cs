using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPD_Assignment
{
    class Stations
    {
        private String stationName;
        private String stationLine;

        public Stations() { }

        public Stations(String stationName, String stationLine)
        {
            this.stationName = stationName;
            this.stationLine = stationLine;
        }

        public String StationName
        {
            get { return this.stationName; }
            set { this.stationName = value; }
        }

        public String StationLine
        {
            get { return this.stationLine; }
            set { this.stationLine = value; }
        }
    }
}
