namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            if (abrirImagen.ShowDialog() == DialogResult.OK) 
            { 
                pictureBox.ImageLocation = abrirImagen.FileName;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
            }
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }
    }
}