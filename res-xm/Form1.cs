using System;
using System.Drawing;
using System.Windows.Forms;
using Miyako;

namespace res_xm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Load our unamanaged DLLs
            ResDll.ExtractDll("ufmod.dll", Properties.Resources.ufmod);
            ResDll.LoadDll("ufmod.dll");
        }

        private unsafe void Form1_Load(object sender, EventArgs e)
        {
            // Play song from resource at full volume
            Music.playSong("res_xm.xmfile.xm", 25);
        }

        // Toggle play/pause button
        private void button1_Click(object sender, EventArgs e)
        {
            Music.pauseSong(); // Toggle the playback
            // Update button as paused
            if (pauseClicked == false)
            {
                button1.Text = "Play";
                pauseClicked = true;
            }
            // Update button as clicked
            else
            {
                button1.Text = "Pause";
                pauseClicked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Music.stopSong();   // Free memory
            Application.Exit(); // Exit program
        }

        bool pauseClicked = false;      // Is the music paused?
        private bool mouseDown;         // Is mouse clicked?
        private Point lastLocation;     // Remember window location
        private bool faded = false;     // Fading direction | false = down, true = up
        private int labelAlpha = 130;   // Start the label at violet

        // Mouse clicked
        private void moveFormDn(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        // Dragging mouse
        private void moveForm(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        // Let go of mouse
        private void moveFormUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Label fading
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Fade blue out
            if (faded == false)
            {
                labelAlpha--;
                if (labelAlpha == 5)
                    faded = true;
            }
            // Fade blue in
            else if (faded == true)
            {
                labelAlpha++;
                if (labelAlpha == 250)
                    faded = false;
            }
            // violet = 238, 130, 238
            label1.ForeColor = Color.FromArgb(255, labelAlpha, 130, 238);
        }

        // Color buttons on mouse over
        private void button1_mousehover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.BlueViolet;
        }
        private void button1_mouseleave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Violet;
        }
        private void button2_mousehover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.BlueViolet;
        }
        private void button2_mouseleave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Violet;
        }
    }
}
