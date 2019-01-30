using System.Windows.Forms;

namespace PictureEnlargement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.previewDlg = new System.Windows.Forms.PrintPreviewDialog();
            this.setupDlg = new System.Windows.Forms.PageSetupDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printDlg = new System.Windows.Forms.PrintDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laBtn = new System.Windows.Forms.Button();
            this.meBtn = new System.Windows.Forms.Button();
            this.smBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuPrintPicture = new System.Windows.Forms.MenuItem();
            this.miOpen = new System.Windows.Forms.MenuItem();
            this.miPageSetup = new System.Windows.Forms.MenuItem();
            this.miPrint = new System.Windows.Forms.MenuItem();
            this.miPrintPreview = new System.Windows.Forms.MenuItem();
            this.miExit = new System.Windows.Forms.MenuItem();
            this.menuSize = new System.Windows.Forms.MenuItem();
            this.miSmall = new System.Windows.Forms.MenuItem();
            this.miMedium = new System.Windows.Forms.MenuItem();
            this.miLarge = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewDlg
            // 
            pageSettings = new System.Drawing.Printing.PageSettings();
            pageSettings.Margins.Bottom = 0;
            pageSettings.Margins.Left = 0;
            pageSettings.Margins.Right = 0;
            pageSettings.Margins.Top = 0;
            pageSettings.Landscape = true;

            printDlg.PrinterSettings = printerSettings;
            printDoc.DocumentName = "Picture Upsize Print";
            printDoc.DefaultPageSettings = pageSettings;
            printDoc.DefaultPageSettings.PrinterSettings = printerSettings;

            setupDlg.AllowMargins = true;
            setupDlg.AllowOrientation = true;
            setupDlg.AllowPaper = true;
            setupDlg.AllowPrinter = true;
            setupDlg.Document = printDoc;



            printDoc.DefaultPageSettings = setupDlg.PageSettings;
            printDoc.PrinterSettings = setupDlg.PrinterSettings;
            printDlg.Document = printDoc;

            previewDlg.Name = "Print Picture Upsize Preview";
            previewDlg.Document = printDoc;
            previewDlg.WindowState = FormWindowState.Normal;
            previewDlg.UseAntiAlias = true;

          
            this.previewDlg.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewDlg.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewDlg.ClientSize = new System.Drawing.Size(400, 300);
            this.previewDlg.Enabled = true;
            this.previewDlg.Icon = ((System.Drawing.Icon)(resources.GetObject("previewDlg.Icon")));
            this.previewDlg.Name = "previewDlg";
            this.previewDlg.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.DocumentName = "Picture Upsize Print";
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laBtn);
            this.panel1.Controls.Add(this.meBtn);
            this.panel1.Controls.Add(this.smBtn);
            this.panel1.Location = new System.Drawing.Point(42, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 371);
            this.panel1.TabIndex = 0;
            // 
            // laBtn
            // 
            this.laBtn.Location = new System.Drawing.Point(447, 147);
            this.laBtn.Name = "laBtn";
            this.laBtn.Size = new System.Drawing.Size(164, 76);
            this.laBtn.TabIndex = 2;
            this.laBtn.Text = "Large picture 36 pages";
            this.laBtn.UseVisualStyleBackColor = true;
            this.laBtn.Click += new System.EventHandler(this.laBtn_Click);
            // 
            // meBtn
            // 
            this.meBtn.Location = new System.Drawing.Point(277, 147);
            this.meBtn.Name = "meBtn";
            this.meBtn.Size = new System.Drawing.Size(164, 76);
            this.meBtn.TabIndex = 1;
            this.meBtn.Text = "Medium picture 16 pages";
            this.meBtn.UseVisualStyleBackColor = true;
            this.meBtn.Click += new System.EventHandler(this.meBtn_Click);
            // 
            // smBtn
            // 
            this.smBtn.Location = new System.Drawing.Point(107, 148);
            this.smBtn.Name = "smBtn";
            this.smBtn.Size = new System.Drawing.Size(164, 76);
            this.smBtn.TabIndex = 0;
            this.smBtn.Text = "S&mall picture 9 pages";
            this.smBtn.UseVisualStyleBackColor = true;
            this.smBtn.Click += new System.EventHandler(this.smBtn_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuPrintPicture,
            this.menuSize});
            // 
            // menuPrintPicture
            // 
            this.menuPrintPicture.Index = 0;
            this.menuPrintPicture.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miOpen,
            this.miPageSetup,
            this.miPrint,
            this.miPrintPreview,
            this.miExit});
            this.menuPrintPicture.Text = "Print Picture";
            // 
            // miOpen
            // 
            this.miOpen.Index = 0;
            this.miOpen.Text = "O&pen";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miPageSetup
            // 
            this.miPageSetup.Index = 1;
            this.miPageSetup.Text = "Pa&ge setup";
            this.miPageSetup.Click += new System.EventHandler(this.miPageSetup_Click);
            // 
            // miPrint
            // 
            this.miPrint.Index = 2;
            this.miPrint.Text = "Pr&int";
            this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // miPrintPreview
            // 
            this.miPrintPreview.Index = 3;
            this.miPrintPreview.Text = "P&rint Preview";
            this.miPrintPreview.Click += new System.EventHandler(this.miPrintPreview_Click);
            // 
            // miExit
            // 
            this.miExit.Index = 4;
            this.miExit.Text = "E&xit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // menuSize
            // 
            this.menuSize.Index = 1;
            this.menuSize.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miSmall,
            this.miMedium,
            this.miLarge});
            this.menuSize.Text = "Picture Size";
            // 
            // miSmall
            // 
            this.miSmall.Index = 0;
            this.miSmall.Text = "S&mall";
            this.miSmall.Click += new System.EventHandler(this.miSmall_Click);
            // 
            // miMedium
            // 
            this.miMedium.Index = 1;
            this.miMedium.Text = "M&edium";
            this.miMedium.Click += new System.EventHandler(this.miMedium_Click);
            // 
            // miLarge
            // 
            this.miLarge.Index = 2;
            this.miLarge.Text = "L&arge";
            this.miLarge.Click += new System.EventHandler(this.miLarge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button laBtn;
        private System.Windows.Forms.Button meBtn;
        private System.Windows.Forms.Button smBtn;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuPrintPicture;
        private System.Windows.Forms.MenuItem miOpen;
        private System.Windows.Forms.MenuItem miPrintPreview;
        private System.Windows.Forms.MenuItem miPrint;
        private System.Windows.Forms.MenuItem miPageSetup;
        private System.Windows.Forms.MenuItem miExit;
        private System.Windows.Forms.MenuItem menuSize;
        private System.Windows.Forms.MenuItem miSmall;
        private System.Windows.Forms.MenuItem miMedium;
        private System.Windows.Forms.MenuItem miLarge;
        
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrinterSettings printerSettings;
        private System.Drawing.Printing.PageSettings pageSettings;
        private System.Windows.Forms.PrintPreviewDialog previewDlg;
        private System.Windows.Forms.PageSetupDialog setupDlg;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintDialog printDlg;
        private System.Windows.Forms.MainMenu MainMenu;
    }
}

