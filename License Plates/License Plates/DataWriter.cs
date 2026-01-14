using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace License_Plates
{
    internal class DataWriter
    {
        internal static void WriteToFile(string filepath, List<Vehicle> vehicles)
        {
            string final = "";

            foreach (Vehicle vehicle in vehicles)
            {
                char owned;

                if (vehicle.Owned == true)
                {
                    owned = 'Y';
                }
                else 
                {
                    owned = 'N';
                }

                    List<string> line = new List<string>
                {
                    vehicle.Plate,
                    vehicle.Year.ToString(),
                    vehicle.Type,
                    vehicle.Make,
                    vehicle.Model,
                    vehicle.Submodel,
                    vehicle.Size.ToString(),
                    vehicle.Transmission,
                    vehicle.Style,
                    vehicle.Colour,
                    owned.ToString()
                };

                final += string.Join(",", line) + "\n";
            }
            File.WriteAllText(filepath, final);
        }
    }
}
