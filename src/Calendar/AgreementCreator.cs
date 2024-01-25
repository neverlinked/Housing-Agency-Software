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
    public partial class AgreementCreator : Form
    {
        public string agreementTitle { get; private set; }
        public string agreementContent { get; private set; }
        public AgreementCreator()
        {
            InitializeComponent();

        }

        private void btnCreateAgreement_Click(object sender, EventArgs e)
        {
            agreementContent = tbAgreement.Text;
            agreementTitle = tbTitle.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void GetAgreementInformation(out string title, out string content, out DateTime dateOfProposal)
        {
            title = agreementTitle;
            content = agreementContent;
            dateOfProposal = DateTime.Now.Date;
        }

    }
}
