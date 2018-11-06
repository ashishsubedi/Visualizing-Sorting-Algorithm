using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Visualizing_Sorting_Algorithm
{

       
    class Algorithm
    {
        Form1 form;
        public Algorithm(Form1 _this)
        {
            form = _this;
        }

        private static void Swap(ref List<double> arr, int a,int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public void BubbleSort(List<double> arr, Panel surface,Graphics graphics)
        {
            
            for (int i = 0; i < arr.Count-1; i++)
            {
                for (int j = 0; j < arr.Count - i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr, j, j + 1);
                    }
                }
                    form.RefreshFrame();
                //Update Screen Here
                
                




            }
        }
        public void DrawPoints(Panel surface, Graphics graphics)
        {
            //Thread.Sleep(10);

            graphics = Graphics.FromImage(surface.BackgroundImage);
            graphics.Clear(Color.White);

            //graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 1);
            int offset = 0;
            
              

            for (int i = 0; i < Form1.datas.Count - 1 ; i++)
            {
                Point p1 = new Point(offset, surface.Height);

                Point p2 = new Point(offset, (int)(surface.Height - Form1.datas[i]));

                graphics.DrawLine(pen, p1, p2);
               // Rectangle rectangle = new Rectangle(offset, (int) ( surface.Height - (surface.Height - Form1.datas[i])), 5, surface.Height);
                
                //graphics.DrawRectangle(pen, rectangle);
                //Console.WriteLine("i = {0} and {1} ",i,surface.Height - Form1.datas[i]);
                offset += 5;

                //Thread.Sleep(1);
            }

        }

    }
}
