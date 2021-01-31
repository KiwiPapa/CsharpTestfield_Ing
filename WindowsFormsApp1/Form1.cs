using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            //指定起始点
            Point p1 = new Point(30, 50);
            Point p2 = new Point(200, 300);
            //画
            g.DrawLine(pen, p1, p2);
        }
        int i = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            //指定起始点
            Point p1 = new Point(30, 50);
            Point p2 = new Point(200, 300);
            //画
            g.DrawLine(pen, p1, p2);
        }
    }
}
