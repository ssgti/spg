using System;
using System.Collections.Generic;

// class definitions
// 1 unit of length = length of the shortest wagon

namespace spg
{
    public class railVehicle
    {
        public string vID { get; set; }
        public string vIndustryType { get; set; }
        public double vLength { get; set; }
    }

    public class siding
    {
        public string sID { get; set; }
        public string sIndustryType { get; set; }
        public double sLength { get; set; }

        List<string> storedVehicles = new List<string>(); // vehicles stored
        double totalLength = 0; // combined length of vehicles

        public bool appendVehicle(string vID, double vLength)
        {
            if (totalLength + vLength < sLength) // will current vehicle fit
            {
                storedVehicles.Add(vID);
                return true; // vehicle added
            }
            return false; // vehicle not added
        }
    }

    public class menuOptions
    {
        public bool sortByIndustry { get; set; }
        public bool sortTrain { get; set; }
        public int totalVehicles { get;set; }
    }
}