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
    public partial class ViewAgreement : Form
    {
        public ViewAgreement()
        {
            InitializeComponent();
        }


        public void FillLabels(UserAction agreement)
        {
            lblName.Text = agreement.FullName;
            lblDateDisplay.Text = agreement.Date.ToShortDateString();
            lblTItleDIsplay.Text = agreement.Name;
            tbDescription.Text = agreement.Description;
        }
    }
}
