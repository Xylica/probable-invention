using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Plates
{
    internal partial class Edit : Form
    {

        private List<Vehicle> vehicles;

        public Edit(List<Vehicle> vehicles)
        {
            InitializeComponent();

            this.vehicles = vehicles;
            dataGridView1.DataSource = vehicles;
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            typeCombo.Items.AddRange(new string[] { "Car", "Truck", "Motorcycle", "Bus" });
            makeCombo.Items.AddRange(new string[] { "Toyota", "Honda", "Ford", "Chevrolet", "Nissan", "Hyundai", "Kia", "Volkswagen", "BMW", "Mercedes-Benz" });
            transmissionCombo.Items.AddRange(new string[] { "Automatic", "Manual", "CVT", "Dual-Clutch" });
            styleCombo.Items.AddRange(new string[] { "Sedan", "Coupe", "Hatchback", "Pickup", "SUV", "Cruiser", "Sport" });
            colourCombo.Items.AddRange(new string[] { "Black", "White", "Red", "Blue", "Silver", "Grey", "Green" });
            ownedCombo.Items.AddRange(new string[] { "Y", "N" });
        }

        private void typeCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            makeCombo.Items.Clear();
            styleCombo.Items.Clear();

            switch (typeCombo.Text) 
            { 
                case "Car":
                    makeCombo.Items.AddRange(new string[]
                    {
                        "Mitsubishi", "Toyota", "Honda", "Ford", "Chevrolet", "Nissan", "Hyundai", "Kia", "BMW", "Mercedes-Benz"
                    });

                    styleCombo.Items.AddRange(new string[] 
                    { 
                        "Sedan", "Coupe", "Hatchback", "Wagon", "SUV", "Convertible" 
                    });

                    SortCombo(makeCombo); 
                    SortCombo(styleCombo);
                    break; 
                case "Motorcycle":
                    makeCombo.Items.AddRange(new string[]
                    {
                        "Harley-Davidson", "Yamaha", "Kawasaki", "Suzuki", "Ducati", "Triumph"
                    });

                    styleCombo.Items.AddRange(new string[] 
                    { 
                        "Cruiser", "Sport", "Touring", "Standard", "Dirt Bike" 
                    });

                    SortCombo(makeCombo);
                    SortCombo(styleCombo);
                    break; 
                case "Truck":
                    makeCombo.Items.AddRange(new string[]
                    {
                        "Ford", "Chevrolet", "Ram", "GMC", "Kenworth", "Peterbilt", "Volvo Trucks", "Freightliner"
                    });

                    styleCombo.Items.AddRange(new string[] 
                    { 
                        "Pickup", "Flatbed", "Box Truck", "Tow Truck", "Dump Truck" 
                    });

                    SortCombo(makeCombo);
                    SortCombo(styleCombo);
                    break; 
                case "Bus":
                    makeCombo.Items.AddRange(new string[]
                    {
                        "Mercedes-Benz", "Volvo", "Scania", "MAN", "Blue Bird", "Thomas Built", "Alexander Dennis"
                    });

                    styleCombo.Items.AddRange(new string[] 
                    { 
                        "Transit Bus", "Coach", "School Bus", "Shuttle Bus", "Minibus" 
                    });

                    SortCombo(makeCombo);
                    SortCombo(styleCombo);
                    break; 
            } 
        }

        public void SortCombo(ComboBox combo) // Sorts alphabetically
        {
            List<string> items = combo.Items.Cast<string>().ToList();
            items.Sort(StringComparer.OrdinalIgnoreCase);
            combo.Items.Clear(); combo.Items.AddRange(items.ToArray());
        }

        private string OrUnknown(string value) { return string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }

        private bool ValidatePlate()
        {
            if (string.IsNullOrWhiteSpace(plate.Text))
            {
                MessageBox.Show("Please enter a license plate.", "Missing Plate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                plate.Focus();
                return false;
            }

            if (vehicles.Any(v => v.Plate.Equals(plate.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This plate already exists in the system.", "Duplicate Plate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                plate.Focus();
                return false;
            }

            return true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!ValidatePlate()) return;

            vehicles.Add(new Vehicle 
            { 
                Plate = plate.Text, 
                Year = (int)year.Value, 
                Type = OrUnknown(typeCombo.Text), 
                Make = OrUnknown(makeCombo.Text), 
                Model = OrUnknown(model.Text), 
                Submodel = OrUnknown(submodel.Text), 
                Size = int.TryParse(size.Text, out int s) ? s : 0, 
                Transmission = OrUnknown(transmissionCombo.Text), 
                Style = OrUnknown(styleCombo.Text), 
                Colour = OrUnknown(colourCombo.Text), 
                Owned = ownedCombo.Text == "Y" 
            });

            vehicles.Sort(new PlateComparer());

            DataWriter.WriteToFile(@"..\..\Plates.txt", vehicles);

            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = vehicles;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
