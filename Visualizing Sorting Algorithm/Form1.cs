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
        Random rand;
        public static Graphics graphics;
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
            surface1.Paint += new PaintEventHandler(this.DrawPointsEventHandler);

            
            //draw += algorithm.DrawPoints;
        }

        private void DrawPointsEventHandler(object sender, EventArgs e)
        {
            
            algorithm.DrawPoints(surface1, graphics);
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
            for (int i = 0; i < 100; i++)
            {
                
                double random = 400 * rand.NextDouble();
                datas.Add(random);
            }
            foreach (var data in datas)
            {
                Console.WriteLine($"{data} and {surface1.Height-(surface1.Height - data)}");
                
            }
            Console.WriteLine("END");
            
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
            algorithm.BubbleSort(datas, surface1,graphics);

        }
        public void RefreshFrame()
        {
            this.Refresh();
            
        }

        private void surface2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
