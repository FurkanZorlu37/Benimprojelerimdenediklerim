namespace Clock
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
            components = new System.ComponentModel.Container();
            LblClock = new Label();
            Lbldate = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LblClock
            // 
            LblClock.Anchor = AnchorStyles.None;
            LblClock.Font = new Font("Snap ITC", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblClock.Location = new Point(12, 97);
            LblClock.Name = "LblClock";
            LblClock.Size = new Size(776, 209);
            LblClock.TabIndex = 0;
            LblClock.Text = "Clock Load";
            LblClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbldate
            // 
            Lbldate.Anchor = AnchorStyles.None;
            Lbldate.Font = new Font("Snap ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbldate.Location = new Point(12, 9);
            Lbldate.Name = "Lbldate";
            Lbldate.Size = new Size(776, 75);
            Lbldate.TabIndex = 1;
            Lbldate.Text = "date Load";
            Lbldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbldate);
            Controls.Add(LblClock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label LblClock;
        private Label Lbldate;
        private System.Windows.Forms.Timer timer1;
    }
}
