namespace hampsterdanceapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.dedodedo;
            player.Load();
            player.PlayLooping();
        }
    }
}
