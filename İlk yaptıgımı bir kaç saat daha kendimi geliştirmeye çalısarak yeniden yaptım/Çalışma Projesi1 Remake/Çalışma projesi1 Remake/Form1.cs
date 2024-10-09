namespace Çalışma_projesi1_Remake
{
    public partial class Form1 : Form
    {
        int kontrol;
        int yaş;
        string Ad;
        string Soyad;
        public Form1()
        {
            InitializeComponent();
        }
        private void txtYaş_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (txtAd.Text.Length > 0)
            {
                lblYaş.Visible = true;
                txtYaş.Visible = true;
                Progress.Value = 20;
                lblLoad.Text = "%20";
                lblLoad.Visible = true;
                Progress.Visible = true;
                if (txtYaş.Text.Length > 0)
                {
                    int Değer = 25;
                    Progress.Value = Değer;
                    lblLoad.Text = "%25";
                    Ad = txtAd.Text;
                    txtSoyad.Visible = true;
                    lblSoyad.Visible = true;
                    if (txtSoyad.Text.Length > 0)
                    {
                        Progress.Value = Değer + 25;
                        lblLoad.Text = "%50";
                        Soyad = txtSoyad.Text;
                        txtMail.Visible = true;
                        lblMail.Visible = true;
                        if (txtMail.Text.Length > 0)
                        {
                            Progress.Value = Değer + 50;
                            lblLoad.Text = "%75";
                            CkcBox.Visible = true;
                            int kontrol = Progress.Value;
                            button1.Text = "İki tık daha";
                            if (CkcBox.Checked)
                            {
                                Progress.Value = 100;
                                lblLoad.Text = "%100";
                                button1.Text = "Üye oldunuz !";

                            }
                        }
                    }
                }
            }
            if (Progress.Value == 100)
            {
                Form2 form2 = new Form2(Ad,Soyad,yaş);
                form2.Show();
            }
        }
    }
}