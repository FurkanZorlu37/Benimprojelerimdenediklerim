using System.Net.Http.Headers;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbldate.Text = DateTime.Now.ToString("yyy:M:d");
            LblClock.Text = DateTime.Now.ToString("HH:mm:ss:f");
        }
    }
}
