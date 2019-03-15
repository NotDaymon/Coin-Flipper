namespace CoinFlipApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FlipButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.LogPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PastFlipLabel = new System.Windows.Forms.Label();
            this.PastFlipDivider = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ScrollUpButton = new System.Windows.Forms.Button();
            this.ScrollDownButton = new System.Windows.Forms.Button();
            this.CoinPictureBox = new System.Windows.Forms.PictureBox();
            this.LogPanelContainer = new System.Windows.Forms.Panel();
            this.LogPanelScrollBlocker = new System.Windows.Forms.Panel();
            this.FlipResultButton = new System.Windows.Forms.Button();
            this.FlipStreakAlert = new System.Windows.Forms.Button();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.FastFlipCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).BeginInit();
            this.LogPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlipButton
            // 
            this.FlipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FlipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FlipButton.Location = new System.Drawing.Point(26, 344);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(248, 61);
            this.FlipButton.TabIndex = 0;
            this.FlipButton.Text = "Flip A Coin";
            this.FlipButton.UseVisualStyleBackColor = false;
            this.FlipButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ExitButton.Location = new System.Drawing.Point(0, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(21, 21);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExpandButton
            // 
            this.ExpandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExpandButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExpandButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ExpandButton.Location = new System.Drawing.Point(297, 0);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(10, 418);
            this.ExpandButton.TabIndex = 50;
            this.ExpandButton.UseVisualStyleBackColor = false;
            this.ExpandButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogPanel
            // 
            this.LogPanel.AutoSize = true;
            this.LogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LogPanel.Location = new System.Drawing.Point(3, 3);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogPanel.Size = new System.Drawing.Size(181, 229);
            this.LogPanel.TabIndex = 4;
            this.LogPanel.WrapContents = false;
            // 
            // PastFlipLabel
            // 
            this.PastFlipLabel.AutoSize = true;
            this.PastFlipLabel.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastFlipLabel.ForeColor = System.Drawing.Color.White;
            this.PastFlipLabel.Location = new System.Drawing.Point(431, 49);
            this.PastFlipLabel.Name = "PastFlipLabel";
            this.PastFlipLabel.Size = new System.Drawing.Size(111, 24);
            this.PastFlipLabel.TabIndex = 6;
            this.PastFlipLabel.Text = "Past Flips";
            // 
            // PastFlipDivider
            // 
            this.PastFlipDivider.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PastFlipDivider.Location = new System.Drawing.Point(385, 75);
            this.PastFlipDivider.Name = "PastFlipDivider";
            this.PastFlipDivider.Size = new System.Drawing.Size(200, 1);
            this.PastFlipDivider.TabIndex = 7;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MinimizeButton.Location = new System.Drawing.Point(21, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(21, 21);
            this.MinimizeButton.TabIndex = 8;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ScrollUpButton
            // 
            this.ScrollUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScrollUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScrollUpButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ScrollUpButton.Image = global::CoinFlipApp.Properties.Resources.upArrow;
            this.ScrollUpButton.Location = new System.Drawing.Point(592, 76);
            this.ScrollUpButton.Name = "ScrollUpButton";
            this.ScrollUpButton.Size = new System.Drawing.Size(37, 37);
            this.ScrollUpButton.TabIndex = 9;
            this.ScrollUpButton.UseVisualStyleBackColor = false;
            this.ScrollUpButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ScrollDownButton
            // 
            this.ScrollDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScrollDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScrollDownButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollDownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ScrollDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ScrollDownButton.Image")));
            this.ScrollDownButton.Location = new System.Drawing.Point(592, 119);
            this.ScrollDownButton.Name = "ScrollDownButton";
            this.ScrollDownButton.Size = new System.Drawing.Size(37, 37);
            this.ScrollDownButton.TabIndex = 10;
            this.ScrollDownButton.UseVisualStyleBackColor = false;
            this.ScrollDownButton.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // CoinPictureBox
            // 
            this.CoinPictureBox.Image = global::CoinFlipApp.Properties.Resources.coin_0;
            this.CoinPictureBox.Location = new System.Drawing.Point(26, 53);
            this.CoinPictureBox.Name = "CoinPictureBox";
            this.CoinPictureBox.Size = new System.Drawing.Size(248, 252);
            this.CoinPictureBox.TabIndex = 1;
            this.CoinPictureBox.TabStop = false;
            this.CoinPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LogPanelContainer
            // 
            this.LogPanelContainer.AutoScroll = true;
            this.LogPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogPanelContainer.Controls.Add(this.LogPanel);
            this.LogPanelContainer.Location = new System.Drawing.Point(384, 82);
            this.LogPanelContainer.Name = "LogPanelContainer";
            this.LogPanelContainer.Size = new System.Drawing.Size(201, 230);
            this.LogPanelContainer.TabIndex = 11;
            // 
            // LogPanelScrollBlocker
            // 
            this.LogPanelScrollBlocker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogPanelScrollBlocker.Location = new System.Drawing.Point(566, 82);
            this.LogPanelScrollBlocker.Name = "LogPanelScrollBlocker";
            this.LogPanelScrollBlocker.Size = new System.Drawing.Size(22, 230);
            this.LogPanelScrollBlocker.TabIndex = 13;
            // 
            // FlipResultButton
            // 
            this.FlipResultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.FlipResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipResultButton.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FlipResultButton.Location = new System.Drawing.Point(80, 311);
            this.FlipResultButton.Name = "FlipResultButton";
            this.FlipResultButton.Size = new System.Drawing.Size(135, 41);
            this.FlipResultButton.TabIndex = 52;
            this.FlipResultButton.Text = "HEADS";
            this.FlipResultButton.UseVisualStyleBackColor = false;
            this.FlipResultButton.Visible = false;
            this.FlipResultButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // FlipStreakAlert
            // 
            this.FlipStreakAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(41)))), ((int)(((byte)(24)))));
            this.FlipStreakAlert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(41)))), ((int)(((byte)(24)))));
            this.FlipStreakAlert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(41)))), ((int)(((byte)(24)))));
            this.FlipStreakAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipStreakAlert.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipStreakAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FlipStreakAlert.Location = new System.Drawing.Point(202, 311);
            this.FlipStreakAlert.Name = "FlipStreakAlert";
            this.FlipStreakAlert.Size = new System.Drawing.Size(37, 27);
            this.FlipStreakAlert.TabIndex = 53;
            this.FlipStreakAlert.Text = "x1";
            this.FlipStreakAlert.UseVisualStyleBackColor = false;
            this.FlipStreakAlert.Visible = false;
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClearLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLogButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClearLogButton.Location = new System.Drawing.Point(491, 318);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(97, 32);
            this.ClearLogButton.TabIndex = 54;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseVisualStyleBackColor = false;
            this.ClearLogButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // FastFlipCheckbox
            // 
            this.FastFlipCheckbox.AutoSize = true;
            this.FastFlipCheckbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastFlipCheckbox.ForeColor = System.Drawing.Color.Snow;
            this.FastFlipCheckbox.Location = new System.Drawing.Point(384, 324);
            this.FastFlipCheckbox.Name = "FastFlipCheckbox";
            this.FastFlipCheckbox.Size = new System.Drawing.Size(83, 21);
            this.FastFlipCheckbox.TabIndex = 55;
            this.FastFlipCheckbox.Text = "Fast Flip";
            this.FastFlipCheckbox.UseVisualStyleBackColor = true;
            this.FastFlipCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(307, 418);
            this.ControlBox = false;
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.FastFlipCheckbox);
            this.Controls.Add(this.ClearLogButton);
            this.Controls.Add(this.FlipStreakAlert);
            this.Controls.Add(this.FlipResultButton);
            this.Controls.Add(this.LogPanelScrollBlocker);
            this.Controls.Add(this.ScrollDownButton);
            this.Controls.Add(this.ScrollUpButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.PastFlipDivider);
            this.Controls.Add(this.LogPanelContainer);
            this.Controls.Add(this.PastFlipLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CoinPictureBox);
            this.Controls.Add(this.FlipButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Coin Flipper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).EndInit();
            this.LogPanelContainer.ResumeLayout(false);
            this.LogPanelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.PictureBox CoinPictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.FlowLayoutPanel LogPanel;
        private System.Windows.Forms.Label PastFlipLabel;
        private System.Windows.Forms.Panel PastFlipDivider;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ScrollUpButton;
        private System.Windows.Forms.Button ScrollDownButton;
        private System.Windows.Forms.Panel LogPanelContainer;
        private System.Windows.Forms.Panel LogPanelScrollBlocker;
        private System.Windows.Forms.Button FlipResultButton;
        private System.Windows.Forms.Button FlipStreakAlert;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.CheckBox FastFlipCheckbox;
    }
}

