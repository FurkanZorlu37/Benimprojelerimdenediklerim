namespace Çalışma_projesi1_Remake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            CkcBox = new CheckBox();
            LblAd = new Label();
            txtAd = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblYaş = new Label();
            txtYaş = new TextBox();
            lblMail = new Label();
            txtMail = new TextBox();
            Progress = new ProgressBar();
            lblLoad = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CkcBox
            // 
            resources.ApplyResources(CkcBox, "CkcBox");
            CkcBox.Name = "CkcBox";
            CkcBox.UseVisualStyleBackColor = true;
            // 
            // LblAd
            // 
            resources.ApplyResources(LblAd, "LblAd");
            LblAd.Name = "LblAd";
            // 
            // txtAd
            // 
            resources.ApplyResources(txtAd, "txtAd");
            txtAd.Name = "txtAd";
            // 
            // lblSoyad
            // 
            resources.ApplyResources(lblSoyad, "lblSoyad");
            lblSoyad.Name = "lblSoyad";
            // 
            // txtSoyad
            // 
            resources.ApplyResources(txtSoyad, "txtSoyad");
            txtSoyad.Name = "txtSoyad";
            // 
            // lblYaş
            // 
            resources.ApplyResources(lblYaş, "lblYaş");
            lblYaş.Name = "lblYaş";
            // 
            // txtYaş
            // 
            resources.ApplyResources(txtYaş, "txtYaş");
            txtYaş.Name = "txtYaş";
            txtYaş.TextChanged += txtYaş_TextChanged;
            // 
            // lblMail
            // 
            resources.ApplyResources(lblMail, "lblMail");
            lblMail.Name = "lblMail";
            // 
            // txtMail
            // 
            resources.ApplyResources(txtMail, "txtMail");
            txtMail.Name = "txtMail";
            // 
            // Progress
            // 
            resources.ApplyResources(Progress, "Progress");
            Progress.Name = "Progress";
            // 
            // lblLoad
            // 
            lblLoad.BackColor = SystemColors.Window;
            lblLoad.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(lblLoad, "lblLoad");
            lblLoad.Name = "lblLoad";
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(lblLoad);
            Controls.Add(Progress);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(txtYaş);
            Controls.Add(lblYaş);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(LblAd);
            Controls.Add(CkcBox);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox CkcBox;
        private Label LblAd;
        private TextBox txtAd;
        private Label lblSoyad;
        private TextBox txtSoyad;
        private Label lblYaş;
        private TextBox txtYaş;
        private Label lblMail;
        private TextBox txtMail;
        private ProgressBar Progress;
        private Label lblLoad;
    }
}
