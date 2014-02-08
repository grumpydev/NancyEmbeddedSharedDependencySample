namespace NancyEmbeddedSharedDependencySample
{
    partial class Form1
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
            this.InitiallyCreatedTextBox = new System.Windows.Forms.TextBox();
            this.CreateDependencyButton = new System.Windows.Forms.Button();
            this.OtherDependencyTextBox = new System.Windows.Forms.TextBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.LaunchUpFront = new System.Windows.Forms.Button();
            this.LaunchDelayed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitiallyCreatedTextBox
            // 
            this.InitiallyCreatedTextBox.Location = new System.Drawing.Point(15, 16);
            this.InitiallyCreatedTextBox.Name = "InitiallyCreatedTextBox";
            this.InitiallyCreatedTextBox.Size = new System.Drawing.Size(163, 20);
            this.InitiallyCreatedTextBox.TabIndex = 0;
            this.InitiallyCreatedTextBox.Text = "some text here";
            this.InitiallyCreatedTextBox.TextChanged += new System.EventHandler(this.InitiallyCreatedTextBox_TextChanged);
            // 
            // CreateDependencyButton
            // 
            this.CreateDependencyButton.Location = new System.Drawing.Point(208, 17);
            this.CreateDependencyButton.Name = "CreateDependencyButton";
            this.CreateDependencyButton.Size = new System.Drawing.Size(173, 38);
            this.CreateDependencyButton.TabIndex = 1;
            this.CreateDependencyButton.Text = "Create Delayed Dependency";
            this.CreateDependencyButton.UseVisualStyleBackColor = true;
            this.CreateDependencyButton.Click += new System.EventHandler(this.CreateDependencyButton_Click);
            // 
            // OtherDependencyTextBox
            // 
            this.OtherDependencyTextBox.Location = new System.Drawing.Point(208, 17);
            this.OtherDependencyTextBox.Name = "OtherDependencyTextBox";
            this.OtherDependencyTextBox.Size = new System.Drawing.Size(173, 20);
            this.OtherDependencyTextBox.TabIndex = 2;
            this.OtherDependencyTextBox.Text = "more text";
            this.OtherDependencyTextBox.Visible = false;
            this.OtherDependencyTextBox.TextChanged += new System.EventHandler(this.OtherDependencyTextBox_TextChanged);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(-2, 117);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogBox.Size = new System.Drawing.Size(404, 400);
            this.LogBox.TabIndex = 3;
            // 
            // LaunchUpFront
            // 
            this.LaunchUpFront.Location = new System.Drawing.Point(15, 59);
            this.LaunchUpFront.Name = "LaunchUpFront";
            this.LaunchUpFront.Size = new System.Drawing.Size(368, 23);
            this.LaunchUpFront.TabIndex = 4;
            this.LaunchUpFront.Text = "Launch Up Front Dependency Page";
            this.LaunchUpFront.UseVisualStyleBackColor = true;
            this.LaunchUpFront.Click += new System.EventHandler(this.LaunchUpFront_Click);
            // 
            // LaunchDelayed
            // 
            this.LaunchDelayed.Location = new System.Drawing.Point(15, 88);
            this.LaunchDelayed.Name = "LaunchDelayed";
            this.LaunchDelayed.Size = new System.Drawing.Size(368, 23);
            this.LaunchDelayed.TabIndex = 5;
            this.LaunchDelayed.Text = "Launch Delayed Dependency Page";
            this.LaunchDelayed.UseVisualStyleBackColor = true;
            this.LaunchDelayed.Click += new System.EventHandler(this.LaunchDelayed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 518);
            this.Controls.Add(this.LaunchDelayed);
            this.Controls.Add(this.LaunchUpFront);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.OtherDependencyTextBox);
            this.Controls.Add(this.CreateDependencyButton);
            this.Controls.Add(this.InitiallyCreatedTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InitiallyCreatedTextBox;
        private System.Windows.Forms.Button CreateDependencyButton;
        private System.Windows.Forms.TextBox OtherDependencyTextBox;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button LaunchUpFront;
        private System.Windows.Forms.Button LaunchDelayed;
    }
}

