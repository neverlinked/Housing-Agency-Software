namespace Calendar
{
    public partial class ViewAgreements : Form
    {
        private DataBase dataBase;
        private List<UserAction> agreements;
        private Account loggedInAccount;
        private List<UserAction> userActions;

        public ViewAgreements(Account account)
        {
            dataBase = new DataBase();
            InitializeComponent();
            this.agreements = new List<UserAction>();
            this.loggedInAccount = account;
            PopulateAgreement();
        }

        //Method to Get agreements data into the database
        public void CreateAgreement()
        {
                if (dataBase.CreateAgreement(loggedInAccount.ID))
                {
                    MessageBox.Show("Agreement proposed!");
                    PopulateAgreement() ;
                }
                else
                {
                    MessageBox.Show("Agreement coudln't be proposed!");
                }
        }

        //Method to get the data from the database and put into objects
        public void PopulateAgreement()
        {
            listBox1.Items.Clear();
            userActions = new List<UserAction>(dataBase.GetAgreements());
            foreach (var userAction in userActions)
            {
                string displayText = $"Date: {userAction.Date.ToShortDateString()}, Title: {userAction.Name}, By: {userAction.FullName}";
                listBox1.Items.Add(displayText);
            }
        }


        //Showing the agreement creation form on this click
        private void btnCreateAgreement_Click(object sender, EventArgs e)
        {
            CreateAgreement();
        }

        private void btnViewAgreement_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                //Veselin, add check here if the agreement selected, else its throwing error that null object
                string selected = listBox1.SelectedItem.ToString();
                UserAction selectedAgreement = null;
                foreach (UserAction agreement in userActions)
                {
                    string displayText = $"Date: {agreement.Date.ToShortDateString()}, Title: {agreement.Name}, By: {agreement.FullName}";
                    if (displayText == selected)
                    {
                        selectedAgreement = agreement;
                        break;
                    }
                }

                if (selectedAgreement != null)
                {
                    ViewAgreement agreementView = new ViewAgreement();
                    agreementView.FillLabels(selectedAgreement);
                    agreementView.Show();

                }

            }

        }
    }
}
