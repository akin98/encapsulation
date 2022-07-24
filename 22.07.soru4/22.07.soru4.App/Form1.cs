

using _22._07.soru4.classes;

namespace _22._07.soru4.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            OkulDbContext context = new OkulDbContext();
                List<Ders> q = context.Ders.OrderBy(e => e.Dersadi).ToList();
                //MessageBox.Show(ornek.Dersadi);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}