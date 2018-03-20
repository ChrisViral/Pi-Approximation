using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Pi_Approximation
{
    public partial class MainForm : Form
    {
        #region Constants
        private const int imageSize = 600;
        #endregion

        #region Fields
        private readonly object sync = new object();
        private readonly Random random = new Random();
        private Thread generation;
        private int generated;
        private int inside;
        private int outside;
        private double ratio;
        private double pi;
        #endregion

        #region Properties
        private Image image;
        public Image Image
        {
            get => this.image;
            set
            {
                this.image = value;
                this.imageBox.Image = value;
            }
        }

        private int gap = 1000;
        public int Gap
        {
            get { lock (this.sync) { return this.gap;  } }
            set { lock (this.sync) { this.gap = value; } }
        }

        private bool generating;
        public bool Generating
        {
            get { lock (this.sync) { return this.generating;  } }
            set { lock (this.sync) { this.generating = value; } }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the form
        /// </summary>
        /// <inheritdoc/>
        public MainForm()
        {
            //Initialize form
            InitializeComponent();

            //Initialize image to blank white
            this.Image = new Image(imageSize, true);
        }
        #endregion

        #region Methods
        public void Generate()
        {
            double x = this.random.NextDouble(), y = this.random.NextDouble();
            int i = (int)Math.Round((imageSize - 1) * x), j = (int)Math.Round((imageSize - 1) * y);
            lock (this.sync) { this.Image.SetPixel(i, j, Color.Red); }
            if (this.imageBox.InvokeRequired)
            {
                this.imageBox.Invoke((MethodInvoker)UpdateImage);
            }
            else { UpdateImage(); }


            this.generated++;
            if ((x * x) + (y * y) <= 1d) { this.inside++; }
            else { this.outside++; }
            this.ratio = this.inside / (double)this.generated;
            this.pi = 4d * this.ratio;

            if (this.dataLabel.InvokeRequired)
            {
                this.dataLabel.Invoke((MethodInvoker)UpdateLabel);
            }
            else { UpdateLabel(); }
        }

        public void GenerateContinuously()
        {
            Stopwatch timer = new Stopwatch();
            while (this.Generating)
            {
                timer.Restart();
                Generate();
                timer.Stop();
                int diff = this.Gap - (int)timer.ElapsedMilliseconds;
                if (diff > 0) { Thread.Sleep(diff); }
            }
        }

        private void UpdateImage()
        {
            lock (this.sync) { this.imageBox.Image = this.Image; }
        }

        private void UpdateLabel()
        {
            this.dataLabel.Text = $"{this.generated}\n{this.inside}\n{this.outside}\n{this.pi:0.################}";
        }
        #endregion

        #region Events
        private void QuitButton_Click(object sender, EventArgs e) => Close();

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (this.Generating) { StartButton_Click(null, null); }
            this.Image = new Image(imageSize, true);
            this.generated = 0;
            this.inside = 0;
            this.outside = 0;
            this.ratio = 0d;
            this.pi = 0d;
            UpdateLabel();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

        }

        private void GenerateOnce_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Generating) { StartButton_Click(null, null); }
            this.generateButton.Enabled = this.generateOnce.Checked;
        }

        private void GenerateSuccessively_CheckedChanged(object sender, EventArgs e)
        {
            this.startButton.Enabled = this.msLabel.Enabled = this.gapBox.Enabled = this.generateSuccessively.Checked;
        }

        private void GenerateButton_Click(object sender, EventArgs e) => Generate();

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!this.Generating)
            {
                this.startButton.Text = "Stop";
                this.Generating = true;
                this.generation = new Thread(GenerateContinuously);
                this.generation.Start();
            }
            else
            {
                this.startButton.Text = "Start";
                this.Generating = false;
                this.generation.Abort();
                this.generation = null;
            }
        }

        private void GapBox_ValueChanged(object sender, EventArgs e) => this.Gap = (int)this.gapBox.Value;
        #endregion
    }
}
