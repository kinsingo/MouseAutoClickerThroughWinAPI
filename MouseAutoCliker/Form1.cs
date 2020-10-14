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

namespace MouseAutoCliker
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        [DllImport("user32")]
        public static extern bool GetCursorPos(ref Point point);
        [DllImport("user32.dll")] // 입력 제어
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);//mouse_event(이벤트종류, x좌표(0), y좌표(0), 휠 스크롤, 마우스타입)

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; 
        private const int MOUSEEVENTF_LEFTUP = 0x0004; 
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; 
        Point point1;

        public Form1()
        {
            InitializeComponent();
            point1 = new Point();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            timer1.Start();
            timer1.Interval = 10;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("started");
        }

        private void button_Set_and_Click_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox_Set_X.Text);
            int y = Convert.ToInt32(textBox_Set_Y.Text);

            SetCursorPos(x,y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(GetCursorPos(ref point1))
            {
                textBox_Read_X.Text = point1.X.ToString();
                textBox_Read_Y.Text = point1.Y.ToString();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxY.Text = Cursor.Position.X.ToString();
            textBoxY.Text = Cursor.Position.Y.ToString();
        }
    }
}
