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
            CartTab.Customers = _store.Customers;
            CartTab.Items = _store.Items;
            OrdersTab.Customers = _store.Customers;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartTab.RefreshData();
            OrdersTab.RefreshData();
        }
    }
}