namespace TinahBridals
{
    public partial class TInahBridalSpot : Form
    {
        public TInahBridalSpot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewTransactionsForm viewForm = new ViewTransactionsForm();
            viewForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TInahBridalSpot_Load(object sender, EventArgs e)
        {

        }
    }
}
