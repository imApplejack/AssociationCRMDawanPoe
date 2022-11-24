
using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance.Menu_DAO;
using AssociationCRMDawanPoe.Service;


namespace AssociationCRMDawanPoe
{
    public partial class Form1 : Form
    {
        readonly IMenuService _service;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _service = new MenuServiceImpl(new MenuDAO());
            buttonDel.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}