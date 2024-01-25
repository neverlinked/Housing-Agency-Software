using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class HouseRules : Form
    {
        DataBase db = new DataBase();
        public HouseRules()
        {
            InitializeComponent();
        }

        private void HouseRules_Load(object sender, EventArgs e)
        {
            LoadHouseRules();
        }
        private void LoadHouseRules()
        {
            string houseRules = db.GetHouseRules();
            richTextBoxRules.Text = string.Join(Environment.NewLine, houseRules);
        }
    }
}
