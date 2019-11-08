using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace FlatUI_WinForm
{
    public partial class MainForm : Form
    {
        private const int menuMaxWidth = 250;
        private const int menuMinWidth = 70;

        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xf012;

        private const int Mouse_DoubleClick = 2;


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll",EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam, IntPtr lparam);


        public MainForm()
        {
            InitializeComponent();

            // 设置两个图标位置一致
            picFullScreenOn.Location = picFullScreenOff.Location;

            // 防止遮挡系统任务栏
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            //this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        /// <summary>
        /// 侧滑菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSlide_Click(object sender, EventArgs e)
        {
            pnlMenu.Width = (pnlMenu.Width == menuMaxWidth ?  menuMinWidth : menuMaxWidth);             
        }

        /// <summary>
        /// Exit application
        /// 退出应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 窗口拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlSlide_MouseDown(object sender, MouseEventArgs e)
        { 
            if(e.Clicks != Mouse_DoubleClick)
            {
                DragAndMove();
            }
        }
         
        /// <summary>
        /// 双击窗口最大化或还原
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlSlide_DoubleClick(object sender, EventArgs e)
        {
            bool isFull = (this.WindowState != FormWindowState.Maximized);
            FullScreen(isFull); 
        }

        /// <summary> 
        /// 拖动窗口
        /// </summary>
        private void DragAndMove()
        {  
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE, IntPtr.Zero);

            if (this.WindowState != FormWindowState.Maximized)
            {
                picFullScreenOn.Visible = true;
                picFullScreenOff.Visible = false;
            }

        }

        /// <summary> 
        /// 最小化窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary> 
        /// 还原默认窗口大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picFullScreenOff_Click(object sender, EventArgs e)
        {
            FullScreen(false);
        }

        /// <summary> 
        /// 最大化窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picFullScreenOn_Click(object sender, EventArgs e)
        {
            FullScreen(true);
        }


        private void FullScreen(bool isFull)
        { 
            this.WindowState = isFull? FormWindowState.Maximized : FormWindowState.Normal;
            picFullScreenOn.Visible = !isFull;
            picFullScreenOff.Visible = isFull;
        }

   
    }
}
