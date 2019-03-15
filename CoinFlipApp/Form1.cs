using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using System.Globalization;
using System.Threading;

namespace CoinFlipApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;
        ResourceManager ResourceClass = new ResourceManager(typeof(Properties.Resources));
        private bool expanded = false;
        private bool expanding = false;
        private bool flipping = false;
        private List<int> flips = new List<int>();
        public delegate void FlippedCoinHandler();
        public FlippedCoinHandler OnFlippedCoinHandler;
        Random r = new Random();
        public bool fastFlip = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            OnFlippedCoinHandler = new FlippedCoinHandler(OnFlippedCoin);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        



        private bool FlipCoin()
        {
            List<System.Drawing.Image> coinImages = new List<System.Drawing.Image>();
            for (int i = 0; i <= 6; i++)
            {
                coinImages.Add((System.Drawing.Image)ResourceClass.GetObject("coin_" + i.ToString()));
            }
            
            for (int i = 10; i > 0; i--)
            {
                foreach (System.Drawing.Image image in coinImages)
                {
                    this.CoinPictureBox.Image = image;
                    if (fastFlip)
                    {
                        wait(10 * (5 - i) + 1);
                    }
                    else
                    {
                        wait(10 * (10 - i) + 1);
                    }
                    

                }

            }
            flipping = false;
            this.CoinPictureBox.Image = Properties.Resources.coin_0;
            return true;



        }

        
        

        protected virtual void OnFlippedCoin()
        {
            flipping = false;
            
            
            if (r.Next(2) == 1)
            {
                //heads
                flips.Add(2);
                Button log = new Button();
                log.Text = "Flip #" + flips.Count().ToString() + ": HEADS";
                log.BackColor = Color.FromArgb(45, 45, 45);
                log.FlatStyle = FlatStyle.Flat;
                log.ForeColor = Color.FromArgb(240, 240, 240);
                log.Font = new Font(new FontFamily("Arial"), 12f, FontStyle.Bold);
                log.Size = new Size(175, 31);
                log.FlatAppearance.BorderSize = 0;
                log.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
                log.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
                log.Parent = this.LogPanel;
                if (!expanded)
                {
                    if (FlipResultButton.Text == "HEADS" && FlipResultButton.Visible)
                    {
                        FlipStreakAlert.Text = "x" + (Convert.ToInt32(FlipStreakAlert.Text.Substring(1)) + 1).ToString();
                        FlipStreakAlert.Visible = true;
                        FlipStreakAlert.BringToFront();
                    }
                    else if(FlipResultButton.Visible)
                    {
                        FlipStreakAlert.Visible = false;
                        FlipStreakAlert.Text = "x1";

                    }
                    FlipResultButton.BackColor = Color.FromArgb(0, 192, 0);
                    FlipResultButton.Text = "HEADS";
                    FlipResultButton.Visible = true;
                    
                }
            }
            else
            {
                //tails
                flips.Add(1);
                Button log = new Button();
                log.Text = "Flip #" + flips.Count().ToString() + ": TAILS";
                log.BackColor = Color.FromArgb(45, 45, 45);
                log.FlatStyle = FlatStyle.Flat;
                log.ForeColor = Color.FromArgb(240, 240, 240);
                log.Font = new Font(new FontFamily("Arial"), 12f, FontStyle.Bold);
                log.Size = new Size(175, 31);
                log.FlatAppearance.BorderSize = 0;
                log.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
                log.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
                log.Parent = this.LogPanel;
                if (!expanded)
                {
                    if (FlipResultButton.Text == "TAILS" && FlipResultButton.Visible)
                    {
                        FlipStreakAlert.Text = "x" + (Convert.ToInt32(FlipStreakAlert.Text.Substring(1)) + 1).ToString();
                        FlipStreakAlert.Visible = true;
                        FlipStreakAlert.BringToFront();
                    }
                    else if(FlipResultButton.Visible)
                    {
                        FlipStreakAlert.Visible = false;
                        FlipStreakAlert.Text = "x1";

                    }
                    FlipResultButton.BackColor = Color.FromArgb(126, 126, 241);
                    FlipResultButton.Text = "TAILS";
                    FlipResultButton.Visible = true;
                    
                }
            }
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            if (flipping)
            {
                return;
            }
            flipping = true;
            Task<bool> flipCoin = new Task<bool>(FlipCoin);
            flipCoin.Start();
            await flipCoin;
            OnFlippedCoin();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static float ParametricBlend(float t)
        {
            float sqt = t * t;
            return sqt / (2.0f * (sqt - t) + 1.0f);
        }

        private void AnimateForm()
        {
            if (expanded && !expanding)
            {
                expanded = !expanded;
                expanding = true;
                int goal = 307;
                float time = 1.0f;
                int size = 652;
                for (float x = 0; x <= 1.0f; x += .01f) // will have 100 loops/values
                {
                    this.Size = new Size((int)(size + (goal - size) * ParametricBlend(x)), this.Size.Height);
                    wait((int)((time / 100.0f) * 1000));
                }
                expanding = false;

            }
            else if (!expanding && !expanded)
            {

                expanded = !expanded;
                expanding = true;
                FlipResultButton.Visible = false;
                FlipStreakAlert.Visible = false;
                FlipStreakAlert.Text = "x1";
                int goal = 652;
                float time = 1.0f;
                int size = 307;
                for (float x = 0; x <= 1.0f; x += .01f) // will have 100 loops/values
                {
                    this.Size = new Size((int)(size + (goal - size) * ParametricBlend(x)), this.Size.Height);
                    wait((int)((time / 100.0f) * 1000));
                }
                expanding = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnimateForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            this.LogPanelContainer.AutoScrollPosition = new Point(0, this.LogPanelContainer.VerticalScroll.Value +31); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.LogPanelContainer.AutoScrollPosition = new Point(0, this.LogPanelContainer.VerticalScroll.Value - 31);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (FlipResultButton.Visible)
            {
                FlipResultButton.Visible = false;
                FlipStreakAlert.Visible = false;
                FlipStreakAlert.Text = "x1";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.LogPanel.Controls.Clear();
            flips.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(FastFlipCheckbox.CheckState == CheckState.Checked)
            {
                fastFlip = true;
            }
            else
            {
                fastFlip = false;
            }
        }
    }
}
