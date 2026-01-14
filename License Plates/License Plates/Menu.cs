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
    public partial class Menu : Form
    {
        private static List<Vehicle> vehicles;

        private View viewForm;
        private Edit editForm;

        public Menu()
        {
            InitializeComponent();

            vehicles = DataReader.ReadFromFile(@"..\..\Plates.txt");


            viewForm = new View(vehicles);
            editForm = new Edit(vehicles);
        }

        private void view_Click(object sender, EventArgs e)
        {
            viewForm.Visible = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            editForm.Visible = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
