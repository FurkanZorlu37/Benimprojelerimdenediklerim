namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            syfb1 = new Button();
            syfb2 = new Button();
            button2 = new Button();
            syfb3 = new Button();
            syfb5 = new Button();
            Syfmetin1 = new Label();
            Syfmetin2 = new Label();
            Syfmetin3 = new Label();
            Syfmetin4 = new Label();
            Syfmetin5 = new Label();
            Zaman = new System.Windows.Forms.Timer(components);
            LblDate = new Label();
            TextFont1 = new Button();
            Textfont2 = new Button();
            TextFont3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // syfb1
            // 
            syfb1.BackColor = SystemColors.ActiveBorder;
            syfb1.Location = new Point(0, 8);
            syfb1.Name = "syfb1";
            syfb1.Size = new Size(75, 23);
            syfb1.TabIndex = 0;
            syfb1.Text = "Sayfa 1";
            syfb1.UseVisualStyleBackColor = false;
            syfb1.Click += syfb1_Click;
            // 
            // syfb2
            // 
            syfb2.BackColor = SystemColors.ActiveBorder;
            syfb2.Location = new Point(81, 8);
            syfb2.Name = "syfb2";
            syfb2.Size = new Size(75, 23);
            syfb2.TabIndex = 1;
            syfb2.Text = "Sayfa 2";
            syfb2.UseVisualStyleBackColor = false;
            syfb2.Click += syfb2_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(243, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Sayfa 4";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // syfb3
            // 
            syfb3.BackColor = SystemColors.ActiveBorder;
            syfb3.Location = new Point(162, 8);
            syfb3.Name = "syfb3";
            syfb3.Size = new Size(75, 23);
            syfb3.TabIndex = 2;
            syfb3.Text = "Sayfa 3";
            syfb3.UseVisualStyleBackColor = false;
            syfb3.Click += syfb3_Click;
            // 
            // syfb5
            // 
            syfb5.BackColor = SystemColors.ActiveBorder;
            syfb5.Location = new Point(324, 8);
            syfb5.Name = "syfb5";
            syfb5.Size = new Size(75, 23);
            syfb5.TabIndex = 4;
            syfb5.Text = "Sayfa 5";
            syfb5.UseVisualStyleBackColor = false;
            syfb5.Click += syfb5_Click;
            // 
            // Syfmetin1
            // 
            Syfmetin1.BackColor = SystemColors.ActiveCaption;
            Syfmetin1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Syfmetin1.Location = new Point(5, 34);
            Syfmetin1.Name = "Syfmetin1";
            Syfmetin1.Size = new Size(783, 407);
            Syfmetin1.TabIndex = 5;
            Syfmetin1.Text = resources.GetString("Syfmetin1.Text");
            // 
            // Syfmetin2
            // 
            Syfmetin2.BackColor = SystemColors.ActiveCaption;
            Syfmetin2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Syfmetin2.Location = new Point(5, 34);
            Syfmetin2.Name = "Syfmetin2";
            Syfmetin2.Size = new Size(783, 407);
            Syfmetin2.TabIndex = 6;
            Syfmetin2.Text = resources.GetString("Syfmetin2.Text");
            // 
            // Syfmetin3
            // 
            Syfmetin3.BackColor = SystemColors.ActiveCaption;
            Syfmetin3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Syfmetin3.Location = new Point(5, 34);
            Syfmetin3.Name = "Syfmetin3";
            Syfmetin3.Size = new Size(783, 407);
            Syfmetin3.TabIndex = 7;
            Syfmetin3.Text = resources.GetString("Syfmetin3.Text");
            // 
            // Syfmetin4
            // 
            Syfmetin4.BackColor = SystemColors.ActiveCaption;
            Syfmetin4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Syfmetin4.Location = new Point(5, 37);
            Syfmetin4.Name = "Syfmetin4";
            Syfmetin4.Size = new Size(783, 407);
            Syfmetin4.TabIndex = 8;
            Syfmetin4.Text = resources.GetString("Syfmetin4.Text");
            // 
            // Syfmetin5
            // 
            Syfmetin5.BackColor = SystemColors.ActiveCaption;
            Syfmetin5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Syfmetin5.Location = new Point(0, 34);
            Syfmetin5.Name = "Syfmetin5";
            Syfmetin5.Size = new Size(783, 407);
            Syfmetin5.TabIndex = 9;
            Syfmetin5.Text = resources.GetString("Syfmetin5.Text");
            Syfmetin5.Click += Syfmetin5_Click;
            // 
            // Zaman
            // 
            Zaman.Enabled = true;
            Zaman.Interval = 1000;
            Zaman.Tick += Zaman_Tick;
            // 
            // LblDate
            // 
            LblDate.BackColor = SystemColors.ActiveCaptionText;
            LblDate.ForeColor = Color.Red;
            LblDate.Location = new Point(651, 416);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(151, 30);
            LblDate.TabIndex = 10;
            LblDate.Text = "Loadinggg";
            LblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextFont1
            // 
            TextFont1.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextFont1.Location = new Point(670, 8);
            TextFont1.Name = "TextFont1";
            TextFont1.Size = new Size(118, 23);
            TextFont1.TabIndex = 11;
            TextFont1.Text = "Snap ITC";
            TextFont1.UseVisualStyleBackColor = true;
            TextFont1.Click += TextFont1_Click;
            // 
            // Textfont2
            // 
            Textfont2.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textfont2.Location = new Point(546, 8);
            Textfont2.Name = "Textfont2";
            Textfont2.Size = new Size(118, 23);
            Textfont2.TabIndex = 12;
            Textfont2.Text = "Tempus Sans";
            Textfont2.UseVisualStyleBackColor = true;
            Textfont2.Click += Textfont2_Click;
            // 
            // TextFont3
            // 
            TextFont3.Font = new Font("Vladimir Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextFont3.Location = new Point(422, 8);
            TextFont3.Name = "TextFont3";
            TextFont3.Size = new Size(118, 23);
            TextFont3.TabIndex = 13;
            TextFont3.Text = "Vladimir Script";
            TextFont3.UseVisualStyleBackColor = true;
            TextFont3.Click += TextFont3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(670, 37);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 14;
            button1.Text = "Ariel Narrow";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(TextFont3);
            Controls.Add(Textfont2);
            Controls.Add(TextFont1);
            Controls.Add(LblDate);
            Controls.Add(Syfmetin5);
            Controls.Add(Syfmetin4);
            Controls.Add(Syfmetin3);
            Controls.Add(Syfmetin2);
            Controls.Add(Syfmetin1);
            Controls.Add(syfb5);
            Controls.Add(button2);
            Controls.Add(syfb3);
            Controls.Add(syfb2);
            Controls.Add(syfb1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button syfb1;
        private Button syfb2;
        private Button button2;
        private Button syfb3;
        private Button syfb5;
        private Label Syfmetin1;
        private Label Syfmetin2;
        private Label Syfmetin3;
        private Label Syfmetin4;
        private Label Syfmetin5;
        public System.Windows.Forms.Timer Zaman;
        private Label LblDate;
        private Button TextFont1;
        private Button Textfont2;
        private Button TextFont3;
        private Button button1;
    }
}