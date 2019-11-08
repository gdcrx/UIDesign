namespace FlatUI_WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.picFullScreenOff = new System.Windows.Forms.PictureBox();
            this.picFullScreenOn = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picSlide = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreenOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreenOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(101)))), ((int)(((byte)(236)))));
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 650);
            this.pnlMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(22, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 25);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSlide.Controls.Add(this.picFullScreenOff);
            this.pnlSlide.Controls.Add(this.picFullScreenOn);
            this.pnlSlide.Controls.Add(this.picMinimize);
            this.pnlSlide.Controls.Add(this.picClose);
            this.pnlSlide.Controls.Add(this.picSlide);
            this.pnlSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSlide.Location = new System.Drawing.Point(250, 0);
            this.pnlSlide.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(1050, 50);
            this.pnlSlide.TabIndex = 1;
            this.pnlSlide.DoubleClick += new System.EventHandler(this.pnlSlide_DoubleClick);
            this.pnlSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSlide_MouseDown);
            // 
            // picFullScreenOff
            // 
            this.picFullScreenOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFullScreenOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFullScreenOff.Image = ((System.Drawing.Image)(resources.GetObject("picFullScreenOff.Image")));
            this.picFullScreenOff.Location = new System.Drawing.Point(986, 8);
            this.picFullScreenOff.Margin = new System.Windows.Forms.Padding(0);
            this.picFullScreenOff.Name = "picFullScreenOff";
            this.picFullScreenOff.Size = new System.Drawing.Size(24, 24);
            this.picFullScreenOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFullScreenOff.TabIndex = 5;
            this.picFullScreenOff.TabStop = false;
            this.picFullScreenOff.Click += new System.EventHandler(this.picFullScreenOff_Click);
            // 
            // picFullScreenOn
            // 
            this.picFullScreenOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFullScreenOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFullScreenOn.Image = ((System.Drawing.Image)(resources.GetObject("picFullScreenOn.Image")));
            this.picFullScreenOn.Location = new System.Drawing.Point(930, 8);
            this.picFullScreenOn.Margin = new System.Windows.Forms.Padding(0);
            this.picFullScreenOn.Name = "picFullScreenOn";
            this.picFullScreenOn.Size = new System.Drawing.Size(24, 24);
            this.picFullScreenOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFullScreenOn.TabIndex = 4;
            this.picFullScreenOn.TabStop = false;
            this.picFullScreenOn.Click += new System.EventHandler(this.picFullScreenOn_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(957, 8);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 3;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1013, 8);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picSlide
            // 
            this.picSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSlide.Image = ((System.Drawing.Image)(resources.GetObject("picSlide.Image")));
            this.picSlide.Location = new System.Drawing.Point(7, 8);
            this.picSlide.Margin = new System.Windows.Forms.Padding(2);
            this.picSlide.Name = "picSlide";
            this.picSlide.Size = new System.Drawing.Size(35, 35);
            this.picSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSlide.TabIndex = 0;
            this.picSlide.TabStop = false;
            this.picSlide.Click += new System.EventHandler(this.picSlide_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 50);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1050, 600);
            this.pnlContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSlide);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreenOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullScreenOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.PictureBox picSlide;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picFullScreenOn;
        private System.Windows.Forms.PictureBox picFullScreenOff;
    }
}

