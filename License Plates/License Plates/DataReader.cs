using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Plates
{
    /// <remarks>
    /// Author: Catherine Gizzi
    /// Date Created: January 14th 2026
    /// Bugs: None known at this time.
    /// </remarks>
    /// <summary>
    /// This class is to read vehicle object data from a text file.  
    /// </summary>
    internal class DataReader
    {
        public static List<Vehicle> ReadFromFile(string filepath)
        {
            List<string> data = File.ReadAllLines(filepath).ToList();
            List<Vehicle> vehicles = new List<Vehicle>();

            foreach (string line in data)
            {
                string[] lineData = line.Split(',');

                int year = 0, size = 0; 
                
                int.TryParse(lineData[1], out year); 
                int.TryParse(lineData[6], out size);

                bool owned;

                if (lineData[10].ToUpper() == "Y")
                {
                    owned = true;
                }
                else
                {
                    owned = false;
                }

                vehicles.Add(new Vehicle
                {
                    Plate = lineData[0],
                    Year = year,
                    Type = lineData[2],
                    Make = lineData[3],
                    Model = lineData[4],
                    Submodel = lineData[5],
                    Size = size,
                    Transmission = lineData[7],
                    Style = lineData[8],
                    Colour = lineData[9],
                    Owned = owned
                });
            }
            
            return vehicles;
        }
    }
}
