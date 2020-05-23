using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToAscii
{
    public partial class Form1 : Form
    {
        Bitmap initialImage;
        string initialText;

        string brightness = "`^\\\",:;Il!i~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$";

        public Form1()
        {
            InitializeComponent();

            asciiPictureBox.Click += pictureBox_Clicked;
            initialPictureBox.Click += pictureBox_Clicked;
        }

        private void pictureBox_Clicked(object sender, EventArgs e)
        {
            // to do, open new form with larger version of the image
            PictureBox pbox = sender as PictureBox;

            if (pbox.Image is null)
            {
                return;
            }

            Form form = new Form();
            form.Text = "Preview";
            form.Size = pbox.Image.Size;
            form.WindowState = FormWindowState.Maximized;

            var temp = new PictureBox();
            temp.Click += (obj, args) => form.Close();
            temp.Size = form.Size;
            temp.Image = pbox.Image;
            temp.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(temp);

            form.Show();
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    bitmap = new Bitmap(filePath);
                    initialImage = bitmap;
                    initialPictureBox.Image = initialImage;
                }
            }

        }

        private async void convertImageButton_Click(object sender, EventArgs e)
        {
            if (initialImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            var image = await ConvertImageAsync(initialImage);

            asciiPictureBox.Image = image.bitmap;
            initialText = image.str;
        }

        private Task<(Bitmap bitmap, string str)> ConvertImageAsync(Bitmap image)
        {
            return Task.Factory.StartNew(() => ConvertImage(image));
        }

        private (Bitmap bitmap, String str) ConvertImage(Bitmap image)
        {
            Bitmap bitmap = new Bitmap(image.Width * 15, image.Height * 15);
            Graphics gfx = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 12);
            gfx.Clear(Color.White);
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var orig = image.GetPixel(x, y);

                    var newchar = ColorToCharacter(orig).ToString();
                    sb.Append(newchar);

                    gfx.DrawString(newchar, font, Brushes.Black, x * 15, y * 15);

                }
                sb.Append(Environment.NewLine);
            }
            return (bitmap, sb.ToString());
        }

        private async void saveImageButton_Click(object sender, EventArgs e)
        {
            if (initialImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            var path = Directory.GetCurrentDirectory();
            var file = path + Guid.NewGuid().ToString();

            asciiPictureBox.Image.Save(file + ".jpg");
            await File.WriteAllTextAsync(file + ".txt", initialText);

            MessageBox.Show($"Saved to {path}");

        }

        public char ColorToCharacter(Color pix)
        {
            int tempBrightness = (int)Math.Floor(pix.GetBrightness() * 256);

            int index = tempBrightness % brightness.Length;

            return brightness[index];
        }
    }
}
