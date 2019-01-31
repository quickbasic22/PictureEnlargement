using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace PictureEnlargement
{
    public partial class Form1 : Form
    {
        public static System.Environment.SpecialFolder mypics = System.Environment.SpecialFolder.MyPictures;
        public static string path = System.Environment.GetFolderPath(mypics);
        DirectoryInfo dirInfo = new System.IO.DirectoryInfo(path + @"\CroppedPictures\");


        private static System.Drawing.Image curImage = null;
        private static System.Drawing.Image[] pieces = null;
        private static string curFileName = null;
        
        
        
        private static System.Drawing.Graphics graphics = null;
        private static System.Drawing.Rectangle[] thedim = null;
        private static System.Drawing.Graphics g = null;

        private static int mysize = 0;
        private static int numofpictures = 0;

        private static int currentNumber = 0;

        private static int picturecount = 0;
        private static int numbercount = 0;





        private static System.Windows.Forms.Label infoLbl;
        
                
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
            if (!dirInfo.Exists)
            {
                DirectoryInfo mydirCreate = System.IO.Directory.CreateDirectory(path + @"\CroppedPictures\");
            }
            
            FileInfo[] filesToDelete = dirInfo.GetFiles();

            int i = 0;

            if (filesToDelete.Length > 0)
            {
                for (i = 0; i < filesToDelete.Length; i++)
                {
                    System.IO.File.Delete(filesToDelete[i].FullName);
                }
            }



            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "All Image files|*.bmp;*.gif;*.jpg;*.ico;" +
                "*.emf,*.wmf|Bitmap Files(*.bmp;*.gif;*.jpg;" +
                "*.ico)|*.bmp;*.gif;*.jpg;*.ico|" +
                "Meta Files(*.emf;*.wmf)|*.emf;*.wmf";
            string filter = openDlg.Filter;
            openDlg.InitialDirectory = path;
            openDlg.Title = "Open Image File";
            openDlg.ShowHelp = true;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;


            }



            i = 0;



            Image imagefile = null;

            int pos = curFileName.LastIndexOf(@"\");
            int start = pos + 1;
            int end = curFileName.Length - 4;
            end = end - start;
            Size newsize = new Size(850, 1100);


            for (i = 0; i < numofpictures; i++)
            {
                imagefile = cropImage(curImage, thedim[i]);
                imagefile = resizeImage(imagefile, newsize);

                pieces[i] = imagefile;

                saveJpeg(path + @"\CroppedPictures\" + curFileName.Substring(start, end) + i + ".jpg", imagefile);
            }

           
            this.Visible = true;
            this.WindowState = FormWindowState.Maximized;
                                                         
        }

        

        private static void saveJpeg(string path, Image img)
        {

            img.Save(path, ImageFormat.Jpeg);
        }

        private static Rectangle[] getdimensions(Image theimage, int picturedim)
        {
            int width = theimage.Width;
            int height = theimage.Height;
            Size newsize = new Size(width / picturedim, height / picturedim);
            Point curpoint = new Point(0, 0);

            int rectangleNumber = picturedim * picturedim;

            Rectangle[] rectangledim = new Rectangle[rectangleNumber];



            int i = 0;

            int p = 0;
            int totalcount = 0;
            curpoint.X = 0;
            curpoint.Y = 0;

            for (i = 0; i < picturedim; i++)
            {
                if (curpoint.X != 0)
                    curpoint.X += newsize.Width;

                for (p = 0; p < picturedim; p++)
                {


                    rectangledim[totalcount] = new Rectangle(curpoint, newsize);
                    curpoint.X += newsize.Width;

                    totalcount += 1;
                }


                curpoint.X = 0;
                curpoint.Y += newsize.Height;




            }



            return rectangledim;
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);


            return (Image)b;
        }

        private static void drawImageRectangles(Graphics graphics, Rectangle[] rect)
        {
            Pen mypen = new System.Drawing.Pen(System.Drawing.Color.BlueViolet, 4);

            int i = 0;



            for (i = 0; i < rect.Length; i++)
            {
                graphics.DrawRectangle(mypen, rect[i]);
            }



        }

        private void miSmall_Click(object sender, EventArgs e)
        {
            FileInfo[] filesToDelete = dirInfo.GetFiles();

            int i = 0;

            if (filesToDelete.Length > 0)
            {
                for (i = 0; i < filesToDelete.Length; i++)
                {
                    System.IO.File.Delete(filesToDelete[i].FullName);
                }
            }

            smBtn.PerformClick();
        }

        private void smBtn_Click(object sender, EventArgs e)
        {
            //pictureBox1.SetBounds(300, 0, 1200, 900);
            int i = 0;
            miSmall.Checked = true;
            miMedium.Checked = false;
            miLarge.Checked = false;


            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            curImage = Image.FromFile(curFileName);



            if (curImage.Width + 200 <= curImage.Height)
            {

                pageSettings.Landscape = false;
                printDoc.DefaultPageSettings = pageSettings;
            }

            Size newsize = new Size(850, 1100);

            curImage = resizeImage(curImage, newsize);

            if (curImage != null)
            {



                mysize = 3;
                numofpictures = mysize * mysize;
                thedim = getdimensions(curImage, mysize);
                pieces = new System.Drawing.Image[numofpictures];



                for (i = 0; i < numofpictures; i++)
                {
                    pieces[i] = cropImage(curImage, thedim[i]);

                    pieces[i] = resizeImage(pieces[i], newsize);



                    int pos = curFileName.LastIndexOf(@"\");
                    int start = pos + 1;
                    int end = curFileName.Length - 4;
                    end = end - start;




                    saveJpeg(path + @"\CroppedPictures\" + curFileName.Substring(start, end) + i + ".jpg", pieces[i]);


                }

                pictureBox1.Show();

                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = curImage;

                graphics = System.Drawing.Graphics.FromImage(pictureBox1.Image);
                PictureEnlargement.Form1.drawImageRectangles(graphics, thedim);

            }


        }

        private void miMedium_Click(object sender, EventArgs e)
        {
            FileInfo[] filesToDelete = dirInfo.GetFiles();

            int i = 0;

            if (filesToDelete.Length > 0)
            {
                for (i = 0; i < filesToDelete.Length; i++)
                {
                    System.IO.File.Delete(filesToDelete[i].FullName);
                }
            }

            meBtn.PerformClick();
        }

        private void miLarge_Click(object sender, EventArgs e)
        {
            FileInfo[] filesToDelete = dirInfo.GetFiles();

            int i = 0;

            if (filesToDelete.Length > 0)
            {
                for (i = 0; i < filesToDelete.Length; i++)
                {
                    System.IO.File.Delete(filesToDelete[i].FullName);
                }
            }

            laBtn.PerformClick();
        }

        private void meBtn_Click(object sender, EventArgs e)
        {

            //pictureBox1.SetBounds(300, 0, 1200, 900);
            int i = 0;
            miSmall.Checked = false;
            miMedium.Checked = true;
            miLarge.Checked = false;

            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            curImage = Image.FromFile(curFileName);

            if (curImage.Width + 200 <= curImage.Height)
            {

                pageSettings.Landscape = false;
                printDoc.DefaultPageSettings = pageSettings;
            }

            Size newsize = new Size(850, 1100);

            curImage = resizeImage(curImage, newsize);

            if (curImage != null)
            {
                mysize = 4;
                numofpictures = mysize * mysize;
                thedim = getdimensions(curImage, mysize);
                pieces = new System.Drawing.Image[numofpictures];

                for (i = 0; i < numofpictures; i++)
                {
                    pieces[i] = cropImage(curImage, thedim[i]);
                    pieces[i] = resizeImage(pieces[i], newsize);

                    int pos = curFileName.LastIndexOf(@"\");
                    int start = pos + 1;
                    int end = curFileName.Length - 4;
                    end = end - start;



                    // Image picturetosave = resizeImage(imagefile, oldsize);
                    saveJpeg(path + @"\CroppedPictures\" + curFileName.Substring(start, end) + i + ".jpg", pieces[i]);


                }

                pictureBox1.Show();

                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = curImage;

                graphics = System.Drawing.Graphics.FromImage(pictureBox1.Image);
                PictureEnlargement.Form1.drawImageRectangles(graphics, thedim);
            }

        }

        private void laBtn_Click(object sender, EventArgs e)
        {
            //pictureBox1.SetBounds(300, 0, 1200, 900);
            int i = 0;
            miSmall.Checked = false;
            miMedium.Checked = false;
            miLarge.Checked = true;

            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            curImage = Image.FromFile(curFileName);

            if (curImage.Width + 200 <= curImage.Height)
            {

                pageSettings.Landscape = false;
                printDoc.DefaultPageSettings = pageSettings;
            }

            Size newsize = new Size(850, 1100);

            curImage = resizeImage(curImage, newsize);

            if (curImage != null)
            {
                mysize = 6;
                numofpictures = mysize * mysize;
                thedim = getdimensions(curImage, mysize);
                pieces = new System.Drawing.Image[numofpictures];

                for (i = 0; i < numofpictures; i++)
                {
                    pieces[i] = cropImage(curImage, thedim[i]);
                    pieces[i] = resizeImage(pieces[i], newsize);


                    int pos = curFileName.LastIndexOf(@"\");
                    int start = pos + 1;
                    int end = curFileName.Length - 4;
                    end = end - start;




                    saveJpeg(path + @"\CroppedPictures\" + curFileName.Substring(start, end) + i + ".jpg", pieces[i]);


                }

                pictureBox1.Show();

                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = curImage;

                graphics = System.Drawing.Graphics.FromImage(pictureBox1.Image);
                PictureEnlargement.Form1.drawImageRectangles(graphics, thedim);
            }

        }

        
        private void miOpen_Click(object sender, EventArgs e)
        {
           
            FileInfo[] filesToDelete = dirInfo.GetFiles();

            int i = 0;


            currentNumber = 0;
            picturecount = 0;
            numbercount = 0;



            if (filesToDelete.Length > 0)
            {
                for (i = 0; i < filesToDelete.Length; i++)
                {
                    System.IO.File.Delete(filesToDelete[i].FullName);
                }
            }


            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "All Image files|*.bmp;*.gif;*.jpg;*.ico;" +
                "*.emf,*.wmf|Bitmap Files(*.bmp;*.gif;*.jpg;" +
                "*.ico)|*.bmp;*.gif;*.jpg;*.ico|" +
                "Meta Files(*.emf;*.wmf)|*.emf;*.wmf";
            string filter = openDlg.Filter;
            openDlg.InitialDirectory = path;
            openDlg.Title = "Open Image File";
            openDlg.ShowHelp = true;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;

            }


            pictureBox1.Visible = false;
            this.panel1.Show();

        }

        private void miPrintPreview_Click(object sender, EventArgs e)
        {
            currentNumber = 0;
            picturecount = 0;
            numbercount = 0;

            if (previewDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void miPageSetup_Click(object sender, EventArgs e)
        {
            if (setupDlg.ShowDialog() == DialogResult.OK)
            {
                
            }
                
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miPrint_Click(object sender, EventArgs e)
        {
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs ppeArgs)
        {
            if (printerSettings.CanDuplex)
            {
               pageSettings.PrinterSettings.Duplex = System.Drawing.Printing.Duplex.Horizontal;
                printerSettings.Duplex = System.Drawing.Printing.Duplex.Horizontal;
            }
            else
            {
                pageSettings.PrinterSettings.Duplex = System.Drawing.Printing.Duplex.Simplex;
                printerSettings.Duplex = System.Drawing.Printing.Duplex.Simplex;
            }
            g = ppeArgs.Graphics;
            Font myfont = new Font("Arial", 70, FontStyle.Bold);
            SolidBrush blackbrush = new SolidBrush(Color.Black);




            currentNumber += 1;


            switch (currentNumber % 2)
            {

                case 0:

                    picturecount += 1;

                    if (picturecount >= numofpictures + 1)
                    {
                         ppeArgs.HasMorePages = false;
                         break;
                    }
                    else
                    {
                        g.DrawImage(pieces[picturecount - 1], 0, 0, curImage.Width, curImage.Height);
                        ppeArgs.HasMorePages = true;
                        break;
                    }

                case 1:


                    numbercount += 1;
                    if (numbercount >= numofpictures + 1)
                    {
                        ppeArgs.HasMorePages = false;
                        break;
                    }
                    else
                    {
                        g.DrawString((numbercount.ToString()), myfont, blackbrush, 300, 300);
                        ppeArgs.HasMorePages = true;
                        break;
                    }

            }
        }
    }
}
