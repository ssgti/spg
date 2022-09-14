using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace spg
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            distributeVehicles();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu());
        }
        public static bool sortByIndustry { get; set; }
        public static bool sortTrain { get; set; }
        public static int totalVehicles { get; set; }

        public static List<railVehicle> train = new List<railVehicle>();
        public static List<railVehicle> vehicles = new List<railVehicle>();
        public static List<siding> sidings = new List<siding>();

        public static string filePath = "data.txt";

        static (List<railVehicle>, List<siding>) getFromFile()
        {
            //string[,] vData = null;
            //string[,] sData = null;
            if (File.Exists(filePath))
            {
                string[] items = File.ReadAllLines(filePath);
                try
                {
                    foreach (string item in items)
                    {
                        if (item[0] == 'v') // first char used to identify vehicle or siding
                        {
                            string data = "";
                            string ID = "";
                            bool gotID = false;
                            string industryType = "";
                            bool gotIndType = false;
                            double length = 0;
                            bool gotLen = false;

                            foreach (char letter in item) // reading
                            {
                                if (letter != ',') // data items are split by commas - type,id,indtype,len
                                {
                                    data.Append(letter);
                                }
                                else
                                {
                                    if (!gotID) // does these in order hopefully?
                                    {
                                        ID = data;
                                    }
                                    else if (gotID && !gotIndType)
                                    {
                                        industryType = data;
                                    }
                                    else if (gotID && gotIndType && !gotLen)
                                    {
                                        length = double.Parse(data);
                                    }
                                    data = "";
                                    railVehicle vehicle = new railVehicle();
                                    vehicle.vID = ID;
                                    vehicle.vIndustryType = industryType;
                                    vehicle.vLength = length;
                                    vehicles.Add(vehicle);
                                }
                            }
                        }
                        else if (item[0] == 's')
                        {
                            string data = "";
                            string ID = "";
                            bool gotID = false;
                            string industryType = "";
                            bool gotIndType = false;
                            double length = 0;
                            bool gotLen = false;

                            foreach (char letter in item)
                            {
                                if (letter != ',')
                                {
                                    data.Append(letter);
                                }
                                else
                                {
                                    if (!gotID)
                                    {
                                        ID = data;
                                    }
                                    else if (gotID && !gotIndType)
                                    {
                                        industryType = data;
                                    }
                                    else if (gotID && gotIndType && !gotLen)
                                    {
                                        length = double.Parse(data);
                                    }
                                    data = "";
                                    siding siding = new siding();
                                    siding.sID = ID;
                                    siding.sIndustryType = industryType;
                                    siding.sLength = length;
                                    sidings.Add(siding);
                                }
                            }
                        }
                    }
                }
                catch
                {
                    // file is empty or contains erroneous data
                }
            }

            /* the two dimensional arrays weren't needed apparently
            for (int x = 0; x <= vData.Length; x++)
            {
                railVehicle vehicle = new railVehicle();
                vehicle.vID = vData[x, 0];
                vehicle.vIndustryType = vData[x, 1];
                vehicle.vLength = double.Parse(vData[x, 2]);
                vehicles.Add(vehicle);
            }
            for (int x = 0; x <= sData.Length; x++)
            {
                siding siding = new siding();
                siding.sID = sData[x, 0];
                siding.sIndustryType = sData[x, 1];
                siding.sLength = double.Parse(sData[x, 2]);
                sidings.Add(siding);
            }
            */

            return (vehicles, sidings);
        }

        static void distributeVehicles()
        {
            var items = getFromFile();
            List<railVehicle> vehicles = items.Item1;
            List<siding> sidings = items.Item2;
            totalVehicles = vehicles.Count;
            List<railVehicle> assignedVehicles = new List<railVehicle>();

            if (sortByIndustry)
            {
                for (int i = 0; i <= totalVehicles; i++) // the user can optionally determine max train length
                {
                    foreach (siding siding in sidings)
                    {
                        if (vehicles[i].vIndustryType == siding.sIndustryType)
                        {
                            if (siding.appendVehicle(vehicles[i].vID, vehicles[i].vLength) == true)
                            {
                                assignedVehicles.Add(vehicles[i]);
                            }
                        }
                    }
                }
            }
            else
            {
                Random random = new Random();
                int rnd = random.Next(vehicles.Count);
                for (int i = 0; i <= totalVehicles; i++)
                {
                    foreach (siding siding in sidings)
                    {
                        if (siding.appendVehicle(vehicles[rnd].vID, vehicles[rnd].vLength) == true)
                        {
                            assignedVehicles.Add(vehicles[rnd]);
                        }
                    }
                }
            }

            createTrain(assignedVehicles);
        }

        static void createTrain(List<railVehicle> assignedVehicles)
        {
            if (sortTrain)
            {
                Dictionary<string, List<railVehicle>> industries = new Dictionary<string, List<railVehicle>>();
                foreach (railVehicle vehicle in assignedVehicles)
                {
                    bool newIndustry = true;
                    foreach (KeyValuePair<string, List<railVehicle>> kvp in industries)
                    {
                        if (kvp.Key == vehicle.vIndustryType)
                        {
                            newIndustry = false;
                        }
                    }
                    if (newIndustry) // create new list and append vehicle
                    {
                        industries.Add(vehicle.vIndustryType, new List<railVehicle>());
                        industries[vehicle.vIndustryType].Add(vehicle);
                    }
                    else // append to existing list
                    {
                        industries[vehicle.vIndustryType].Add(vehicle);
                    }
                }
                
                foreach (KeyValuePair<string, List<railVehicle>> kvp in industries)
                {
                    List<railVehicle> vehicleSet = industries[kvp.Key];
                    train = train.Concat(vehicleSet).ToList();
                }
            }
            else
            {
                Random random = new Random();
                for (int i = 0; i <= assignedVehicles.Count; i++)
                {
                    int rnd = random.Next(assignedVehicles.Count);
                    train[rnd] = assignedVehicles[i];
                }
            }
        }
    }
}
