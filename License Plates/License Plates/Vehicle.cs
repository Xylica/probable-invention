using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace License_Plates
{
    /// <remarks>
    /// Author: Catherine Gizzi
    /// Date Created: January 14th 2026
    /// Bugs: None known at this time.
    /// </remarks>
    /// <summary>
    /// This class is to create objects of vehicles with 2 constructors.
    /// </summary>
    internal class Vehicle
    {
        // Fields for vehicle
        private string plate;
        private int year;
        private string type;
        private string make;
        private string model;
        private string submodel;
        private int size;
        private string transmission;
        private string style;
        private string colour;
        private bool owned;

        // Constructor for creating a vehicle
        public Vehicle(string plate, int year, string type, string make, string model, string submodel, int size, string transmission, string style, string colour, bool owned)
        {
            this.plate = plate;
            this.year = year;
            this.type = type;
            this.make = make;
            this.model = model;
            this.submodel = submodel;
            this.size = size;
            this.transmission = transmission;
            this.style = style;
            this.colour = colour;
            this.owned = owned;
        }

        // Empty constructor for adding a new vehicle
        public Vehicle() { }

        // Encapsulation for vehicle fields
        public string Plate { get => plate; set => plate = value; }
        public int Year { get => year; set => year = value; }
        public string Type { get => type; set => type = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Submodel { get => submodel; set => submodel = value; }
        public int Size { get => size; set => size = value; }
        public string Transmission { get => transmission; set => transmission = value; }
        public string Style { get => style; set => style = value; }
        public string Colour { get => colour; set => colour = value; }
        public bool Owned { get => owned; set => owned = value; }
    }
}
