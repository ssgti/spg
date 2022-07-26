using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spg
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu());

            distributeVehicles();
        }

        static (List<railVehicle>, List<siding>) getFromFile()
        {
            string[,] vData = null;
            string[,] sData = null;
            List<railVehicle> vehicles = new List<railVehicle>();
            List<siding> sidings = new List<siding>();

            /// read from file, store in data as 2D array
            
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

            return (vehicles, sidings);
        }

        static void distributeVehicles()
        {
            var items = getFromFile();
            List<railVehicle> vehicles = items.Item1;
            List<siding> sidings = items.Item2;
            int totalVehicles = vehicles.Count; // toggle in UI
            bool sortByIndustry = true; // toggle in UI
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
            List<railVehicle> train = new List<railVehicle>();
            bool sortTrain = true; // toggle in UI
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
