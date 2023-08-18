namespace screenR
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {            
            InitializeComponent();            
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Capture);
            t.Start();
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graf = Graphics.FromImage(bt);
            graf.CopyFromScreen(0, 0, 0, 0, bt.Size);

            pictureBox1.Image = bt;
        }

        void Capture()
        {
            while (true)
            {
                Bitmap bt = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                Graphics graf = Graphics.FromImage(bt);
                graf.CopyFromScreen(0, 0, 0, 0, bt.Size);

                pictureBox1.Image = bt;

                Thread.Sleep(20);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
        }
    }
}