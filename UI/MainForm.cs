using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;
using System.Drawing.Drawing2D;

namespace UI
{
    public partial class MainForm : Form
    {
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        public MainForm()
        {
            InitializeComponent();
            SetFormSize();      //to do
            InitializeControls();//to do
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }


        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.AntiAlias;
            G.DrawString("This is GameX APP initialization.\n这是GameX初始化界面。", new Font("微软雅黑", 32), Brushes.Black, new PointF(0, 0));
            G.FillRectangle(new SolidBrush(Color.FromArgb(255,Color.Azure)), new Rectangle((int)(0.12F * this.Width), (int)(0.25F * this.Height),128*(this.Width / 1280),128*(this.Height / 720)));
            
            G.Dispose();
        }
    }
}
