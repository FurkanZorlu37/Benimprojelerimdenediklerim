namespace Çalışma_projesi1_Remake
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblad = new Label();
            lblSoyad = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblSayfa1 = new Label();
            lblSayfa2 = new Label();
            SuspendLayout();
            // 
            // lblad
            // 
            lblad.Location = new Point(1, 3);
            lblad.Name = "lblad";
            lblad.Size = new Size(131, 36);
            lblad.TabIndex = 0;
            lblad.Text = "label1";
            // 
            // lblSoyad
            // 
            lblSoyad.Location = new Point(1, 39);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(131, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(1, 62);
            button1.Name = "button1";
            button1.Size = new Size(131, 34);
            button1.TabIndex = 2;
            button1.Text = "Oturumu kapat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1, 133);
            button2.Name = "button2";
            button2.Size = new Size(131, 34);
            button2.TabIndex = 3;
            button2.Text = "Sayfa 1 ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1, 173);
            button3.Name = "button3";
            button3.Size = new Size(131, 34);
            button3.TabIndex = 4;
            button3.Text = "Sayfa 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblSayfa1
            // 
            lblSayfa1.BackColor = SystemColors.ActiveCaption;
            lblSayfa1.Location = new Point(180, 9);
            lblSayfa1.Name = "lblSayfa1";
            lblSayfa1.Size = new Size(764, 538);
            lblSayfa1.TabIndex = 5;
            lblSayfa1.Text = "Deneme sayfası 1 ";
            lblSayfa1.Visible = false;
            // 
            // lblSayfa2
            // 
            lblSayfa2.BackColor = SystemColors.ActiveCaption;
            lblSayfa2.Location = new Point(180, 9);
            lblSayfa2.Name = "lblSayfa2";
            lblSayfa2.Size = new Size(764, 538);
            lblSayfa2.TabIndex = 6;
            lblSayfa2.Text = "Deneme sayfası 2";
            lblSayfa2.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(956, 556);
            Controls.Add(lblSayfa2);
            Controls.Add(lblSayfa1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblSoyad);
            Controls.Add(lblad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Oturum açık !";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblad;
        private Label lblSoyad;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblSayfa1;
        private Label lblSayfa2;
    }
}