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
    internal partial class View : Form
    {

        private List<Vehicle> vehicles;

        public View(List<Vehicle> vehicles)
        {
            InitializeComponent();

            this.vehicles = vehicles;
            dataGridView1.DataSource = vehicles;
            dataGridView1.Columns.Add("Plate", "License Plate");
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Make", "Make");
            dataGridView1.Columns.Add("Model", "Model");
            dataGridView1.Columns.Add("Submodel", "Submodel");
            dataGridView1.Columns.Add("Size", "Engine Size (cc)");
            dataGridView1.Columns.Add("Transmission", "Transmission");
            dataGridView1.Columns.Add("Style", "Body Style");
            dataGridView1.Columns.Add("Colour", "Colour");
            dataGridView1.Columns.Add("Owned", "Owned");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
