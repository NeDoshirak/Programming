using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Panels;


namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Store _store = new Store();

        private void MainForm_Load(object sender, EventArgs e)
        {
            ItemsTabs.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

        }
    }
}