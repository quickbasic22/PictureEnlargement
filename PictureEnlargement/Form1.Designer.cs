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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laBtn = new System.Windows.Forms.Button();
            this.meBtn = new System.Windows.Forms.Button();
            this.smBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuPrintPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.miPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSize = new System.Windows.Forms.ToolStripMenuItem();
            this.miSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.miMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.miLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laBtn);
            this.panel1.Controls.Add(this.meBtn);
            this.panel1.Controls.Add(this.smBtn);
            this.panel1.Controls.Add(this.mainMenu);
            this.panel1.Location = new System.Drawing.Point(42, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 371);
            this.panel1.TabIndex = 0;
            // 
            // laBtn
            // 
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ClientSize = new System.Drawing.Size(1000, 800);
            this.pictureBox1.PointToClient(new System.Drawing.Point(300, 300));
            this.pictureBox1.Visible = false;
            this.Controls.Add(this.pictureBox1);
           
            
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
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrintPicture,
            this.menuSize});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(718, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuPrintPicture
            // 
            this.menuPrintPicture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miPrintPreview,
            this.miPrint,
            this.miPageSetup,
            this.miExit});
            this.menuPrintPicture.Name = "menuPrintPicture";
            this.menuPrintPicture.Size = new System.Drawing.Size(84, 20);
            this.menuPrintPicture.Text = "Print Picture";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(143, 22);
            this.miOpen.Text = "O&pen";
            // 
            // miPrintPreview
            // 
            this.miPrintPreview.Name = "miPrintPreview";
            this.miPrintPreview.Size = new System.Drawing.Size(143, 22);
            this.miPrintPreview.Text = "P&rint Preview";
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.Size = new System.Drawing.Size(143, 22);
            this.miPrint.Text = "Pr&int";
            // 
            // miPageSetup
            // 
            this.miPageSetup.Name = "miPageSetup";
            this.miPageSetup.Size = new System.Drawing.Size(143, 22);
            this.miPageSetup.Text = "Pa&ge setup";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(143, 22);
            this.miExit.Text = "E&xit";
            // 
            // menuSize
            // 
            this.menuSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSmall,
            this.miMedium,
            this.miLarge});
            this.menuSize.Name = "menuSize";
            this.menuSize.Size = new System.Drawing.Size(79, 20);
            this.menuSize.Text = "Picture Size";
            // 
            // miSmall
            // 
            this.miSmall.Name = "miSmall";
            this.miSmall.Size = new System.Drawing.Size(119, 22);
            this.miSmall.Text = "S&mall";
            // 
            // miMedium
            // 
            this.miMedium.Name = "miMedium";
            this.miMedium.Size = new System.Drawing.Size(119, 22);
            this.miMedium.Text = "M&edium";
            // 
            // miLarge
            // 
            this.miLarge.Name = "miLarge";
            this.miLarge.Size = new System.Drawing.Size(119, 22);
            this.miLarge.Text = "L&arge";
            // 
            // pd
            // 
            this.pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button laBtn;
        private System.Windows.Forms.Button meBtn;
        private System.Windows.Forms.Button smBtn;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuPrintPicture;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem miPageSetup;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem menuSize;
        private System.Windows.Forms.ToolStripMenuItem miSmall;
        private System.Windows.Forms.ToolStripMenuItem miMedium;
        private System.Windows.Forms.ToolStripMenuItem miLarge;
        private System.Drawing.Printing.PrintDocument pd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

