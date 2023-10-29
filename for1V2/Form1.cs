namespace for1V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtEkle.Text;

            for (int i = 0; i < 10; i++)
            {
                string metin = i.ToString() + " - " + ad;
                lbAd.Items.Add(metin);
            }
        }
    }
}