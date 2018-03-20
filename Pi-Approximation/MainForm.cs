using System.Windows.Forms;

namespace Pi_Approximation
{
    public partial class MainForm : Form
    {
        #region Constants
        private const int imageSize = 1000;
        #endregion

        #region Fields
        private Image image;
        private int generated = 0;
        private int inside = 0;
        private int outside = 0;
        private double ratio = 0d;
        #endregion

        #region Properties
        public Image Image
        {
            get => this.image;
            set
            {
                this.image = value;
                this.imageBox.Image = value;
            }
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

        #region Events
        private void QuitButton_Click(object sender, System.EventArgs e) => Close();

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            this.Image = new Image(imageSize, true);
            this.generated = 0;
            this.inside = 0;
            this.outside = 0;
            this.ratio = 0d;
        }

        private void AboutButton_Click(object sender, System.EventArgs e)
        {

        }
        #endregion
    }
}
