using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Expression.Encoder.ScreenCapture;

namespace SnapZ_Client_Interface.Backdrops
{
    public partial class rcd_backdrop : Form
    {
        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private bool mouseDown = false;
        private Point mouseDownPoint = Point.Empty;
        private Point mousePoint = Point.Empty;
        public Rectangle window;
        public ScreenCaptureJob rcd = new ScreenCaptureJob();

        private void OnMouseDownRcd(object s, MouseEventArgs e)
        {
            mouseDown = true;
            mousePoint = mouseDownPoint = e.Location;
        }

        private void OnMouseUpRcd(object s, MouseEventArgs e)
        {
            mouseDown = false;

            //Rectangle padded = new Rectangle(window.X, window.Y, window.Width - (window.Width % 4), window.Height - (window.Height % 4));

            System.Drawing.Size monitorSize = SystemInformation.PrimaryMonitorSize;
            Rectangle capRect               = new Rectangle(0, 0, monitorSize.Width, monitorSize.Height);

            rcd.CaptureRectangle = capRect;
            rcd.CaptureMouseCursor = true;
            rcd.OutputPath = @"C:/Users/Printz/Dekstop";
            rcd.Start();

            //System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            //clientSocket.Connect("127.0.0.1", 70);
            //
            //NetworkStream serverStream = clientSocket.GetStream();
            //MemoryStream ms = new MemoryStream();
            //scrn.Save(ms, ImageFormat.Png);
            //
            //serverStream.Write(ms.ToArray(), 0, int.Parse(ms.Length.ToString()));
            //serverStream.Flush();
        }

        private void OnMouseDubRcd(object s, MouseEventArgs e)
        {
            if (rcd.Status == RecordStatus.Running)
            {
                rcd.Stop();
                //rcd.Dispose();
            }
        }

        private void OnMouseMoveRcd(object s, MouseEventArgs e)
        {
            mousePoint = e.Location;
            Invalidate();
        }

        private void OnPaintRcd(object s, PaintEventArgs e)
        {
            if (mouseDown)
            {
                window = new Rectangle(
                    Math.Min(mouseDownPoint.X, mousePoint.X),
                    Math.Min(mouseDownPoint.Y, mousePoint.Y),
                    Math.Abs(mouseDownPoint.X - mousePoint.X),
                    Math.Abs(mouseDownPoint.Y - mousePoint.Y));

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(new Pen(Color.Black, 5.0F), window);
                e.Graphics.Flush();
            }
        }

        public rcd_backdrop()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(this.OnMouseDownRcd);
            this.MouseDoubleClick += new MouseEventHandler(this.OnMouseDubRcd);
            this.MouseUp += new MouseEventHandler(this.OnMouseUpRcd);
            this.MouseMove += new MouseEventHandler(this.OnMouseMoveRcd);
            this.Paint += new PaintEventHandler(this.OnPaintRcd);
        }
    }
}
