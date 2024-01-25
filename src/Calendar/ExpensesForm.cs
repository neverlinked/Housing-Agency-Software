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
    public partial class ExpensesForm : Form
    {
        DataBase db = new DataBase();
        List<Account> expenseParticipants = new List<Account>();
        private Account loggedInAccount;
        private List<Account> allTenantsForTheHouse;

        private Account selectedAccount;


        public ExpensesForm(Account loggedInAccount)
        {
            InitializeComponent();
            this.loggedInAccount = loggedInAccount;
        }

        private void PopulateListBoxTenants()
        {
            foreach (Account account in allTenantsForTheHouse)
            {
                lbxTenatns.Items.Add(account.FullName);
            }

        }

        private void PopulateLisTBoxParticipant()
        {
            foreach (Account account in expenseParticipants)
            {
                lbxParticipants.Items.Add(account.FullName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxTenatns.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a tenant.", "Error");
                return;
            }

            selectedAccount = allTenantsForTheHouse[selectedIndex];

            expenseParticipants.Add(selectedAccount);
            allTenantsForTheHouse.RemoveAt(selectedIndex);

            lbxTenatns.Items.Clear();
            lbxParticipants.Items.Clear();
            PopulateLisTBoxParticipant();
            PopulateListBoxTenants();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxParticipants.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a tenant.", "Error");
                return;
            }

            selectedAccount = expenseParticipants[selectedIndex];

            allTenantsForTheHouse.Add(selectedAccount);
            expenseParticipants.RemoveAt(selectedIndex);

            lbxTenatns.Items.Clear();
            lbxParticipants.Items.Clear();
            PopulateLisTBoxParticipant();
            PopulateListBoxTenants();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int extendedPrice = Convert.ToInt16(tbxExtendedPrice.Text);

            if (extendedPrice == 0)
            {
                MessageBox.Show("Please tipe the price of your expense.", "Error");
                return;
            }

            lblPricePerPerson.Text = Convert.ToString(extendedPrice / expenseParticipants.Count);

            Expenses expense = new Expenses(extendedPrice, expenseParticipants.Count, loggedInAccount, null);

            db.AddExpenseToDB(expense);
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            allTenantsForTheHouse = db.GetTenantsForTheHouse(loggedInAccount.AssignedRoom.AssignedBuilding.ID);
            PopulateListBoxTenants();


        }
    }
}
