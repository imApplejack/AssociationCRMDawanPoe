
using AssociationCRMDawanPoe.Entity;

namespace AssociationCRMDawanPoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Product p = new Product() { Name = "p", Price = 8 , ProductCategory = ProductCategory.Plat};
            p.Name = "dkjfl";
        }
    }
}