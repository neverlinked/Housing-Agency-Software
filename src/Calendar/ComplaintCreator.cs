using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Reflection.Metadata.Ecma335;

namespace Calendar
{
    public partial class ComplaintCreator : Form
    {
        private string complaintTitle;
        private string complaintContent;
        private DateTime createdDate;
        private DataBase db;
        private Account account;

        public ComplaintCreator(Account account)
        {
            InitializeComponent();
            db = new DataBase();
            this.account = account;
        }

        private void btnCreateComplaint_Click(object sender, EventArgs e)
        {
            if (tbContent.Text != null && tbTitle != null)
            {
                complaintTitle = tbTitle.Text;
                complaintContent = tbContent.Text;
                createdDate = DateTime.Now;
                if(db.CreateComplaint(account.ID, complaintTitle, complaintContent, createdDate))
                {
                    MessageBox.Show("Complaint raised!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Complaint coudln't be raised!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all of the fields");
            }
        }
    }
}
