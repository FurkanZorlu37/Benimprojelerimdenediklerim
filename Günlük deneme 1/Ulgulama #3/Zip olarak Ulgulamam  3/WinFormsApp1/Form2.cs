using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Syfmetin1.Visible = false;
            Syfmetin2.Visible = false;
            Syfmetin3.Visible = false;
            Syfmetin4.Visible = false;
            Syfmetin5.Visible = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void syfb1_Click(object sender, EventArgs e)
        {
            Syfmetin1.Visible = true;
            Syfmetin2.Visible = false;
            Syfmetin3.Visible = false;
            Syfmetin4.Visible = false;
            Syfmetin5.Visible = false;

        }

        private void syfb2_Click(object sender, EventArgs e)
        {
            Syfmetin1.Visible = false;
            Syfmetin2.Visible = true;
            Syfmetin3.Visible = false;
            Syfmetin4.Visible = false;
            Syfmetin5.Visible = false;
        }

        private void syfb3_Click(object sender, EventArgs e)
        {
            Syfmetin1.Visible = false;
            Syfmetin2.Visible = false;
            Syfmetin3.Visible = true;
            Syfmetin4.Visible = false;
            Syfmetin5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Syfmetin1.Visible = false;
            Syfmetin2.Visible = false;
            Syfmetin3.Visible = false;
            Syfmetin4.Visible = true;
            Syfmetin5.Visible = false;
        }

        private void syfb5_Click(object sender, EventArgs e)
        {
            Syfmetin1.Visible = false;
            Syfmetin2.Visible = false;
            Syfmetin3.Visible = false;
            Syfmetin4.Visible = false;
            Syfmetin5.Visible = true;
        }

        private void Zaman_Tick(object sender, EventArgs e)
        {
            LblDate.Text = DateTime.Now.ToString("HH:mm:ss:f");
        }

        private void TextFont1_Click(object sender, EventArgs e)
        {
            Syfmetin1.Font = new Font("Snap ITC", 18, FontStyle.Regular);
            Syfmetin2.Font = new Font("Snap ITC", 18, FontStyle.Regular);
            Syfmetin3.Font = new Font("Snap ITC", 18, FontStyle.Regular);
            Syfmetin4.Font = new Font("Snap ITC", 18, FontStyle.Regular);
            Syfmetin5.Font = new Font("Snap ITC", 18, FontStyle.Regular);
        }

        private void Syfmetin5_Click(object sender, EventArgs e)
        {

        }

        private void Textfont2_Click(object sender, EventArgs e)
        {
            Syfmetin1.Font = new Font("Tempus Sans", 18, FontStyle.Regular);
            Syfmetin2.Font = new Font("Tempus Sans", 18, FontStyle.Regular);
            Syfmetin3.Font = new Font("Tempus Sans", 18, FontStyle.Regular);
            Syfmetin4.Font = new Font("Tempus Sans", 18, FontStyle.Regular);
            Syfmetin5.Font = new Font("Tempus Sans", 18, FontStyle.Regular);
        }

        private void TextFont3_Click(object sender, EventArgs e)
        {
            Syfmetin1.Font = new Font("Vladimir Script", 18, FontStyle.Regular);
            Syfmetin2.Font = new Font("Vladimir Script", 18, FontStyle.Regular);
            Syfmetin3.Font = new Font("Vladimir Script", 18, FontStyle.Regular);
            Syfmetin4.Font = new Font("Vladimir Script", 18, FontStyle.Regular);
            Syfmetin5.Font = new Font("Vladimir Script", 18, FontStyle.Regular);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Syfmetin1.Font = new Font("Ariel", 18, FontStyle.Regular);
            Syfmetin2.Font = new Font("Ariel", 18, FontStyle.Regular);
            Syfmetin3.Font = new Font("Ariel", 18, FontStyle.Regular);
            Syfmetin4.Font = new Font("Ariel", 18, FontStyle.Regular);
            Syfmetin5.Font = new Font("Ariel", 18, FontStyle.Regular);
        }
    }
}
