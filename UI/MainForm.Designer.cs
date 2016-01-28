namespace UI
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
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
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "GameX";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);

        }
        #endregion
        private void SetFormSize()
        {
            int X, Y;
            X = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            Y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            float a = X / Y;
            if (a == 16 / 9)
            {
                if (X < 1400 && Y < 800)
                {
                    this.Width = 960;
                    this.Height = 540;
                }
                else
                {
                    this.Width = 1280;
                    this.Height = 720;
                }
            }
            else if (a == 4 / 3)
                ;// 4:3
            else if (a == 16 / 10)
                ;// 16:10
            else if (a == 5 / 4)
                ;// 5:4


        }
        private void InitializeControls()
        {

        }
        
    }
}

