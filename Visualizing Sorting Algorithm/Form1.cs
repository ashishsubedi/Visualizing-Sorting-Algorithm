using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;


using System.Runtime.InteropServices;

namespace Visualizing_Sorting_Algorithm
{
    public delegate void UpdateDrawing(Panel panel, Graphics graphics);



    public partial class Form1 : Form
    {

        public event UpdateDrawing draw;
        Bitmap bitmap;

        public static List<double> datas;
        public static List<double> datas2;

        Random rand;
        public static Graphics graphics1;
        public static Graphics graphics2;
        Algorithm algorithm;
       // public static UpdateDrawing updateDrawing;
        public Form1()
        {
            InitializeComponent();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            AllocConsole();
            rand = new Random();

            GenerateRandomData();
            algorithm = new Algorithm(this);
            //updateDrawing = DrawPoints;
            this.DoubleBuffered = true;
            surface1.Paint += new PaintEventHandler(this.DrawPoints1EventHandler);
           // surface2.Paint += new PaintEventHandler(this.DrawPoints2EventHandler);

            
            //draw += algorithm.DrawPoints;
        }

        private void DrawPoints2EventHandler(object sender, PaintEventArgs e)
        {
            algorithm.DrawPoints2((Panel)sender, graphics2);
        }

        private void DrawPoints1EventHandler(object sender, EventArgs e)
        {
            
            algorithm.DrawPoints1((Panel)sender, ref graphics1);
            

        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool AllocConsole();

        private void surface_Paint(object sender, PaintEventArgs e)
        {
            
           // algorithm.DrawPoints(surface1,graphics);
        }
        private void GenerateRandomData()
        {
            datas = new List<double>(0);
            datas2 = new List<double>(0);
            for (int i = 0; i < 100; i++)
            {
                
                double random = 400 * rand.NextDouble();
                datas.Add(random);
                double random2 = 400 * rand.NextDouble();
                datas2.Add(random2);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var timer = new System.Threading.Timer(
            //f => DrawPoints(surface1),
            //        null,
            //TimeSpan.Zero,
            //TimeSpan.FromMilliseconds(2000));
            Console.WriteLine("After Click");
            foreach (var data in datas)
            {
                Console.WriteLine(data);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioBubbleSOrt.Checked)
                algorithm.BubbleSort(datas);
            else if(radioQuickSort.Checked)
                algorithm.QuickSort(datas, 0, datas.Count -1);
        

        }
        public void RefreshFrame()
        {
            this.Refresh();
            
        }

        private void surface2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            surface1.BackgroundImage = Visualizing_Sorting_Algorithm.Properties.Resources.test;
        }
    }
}
