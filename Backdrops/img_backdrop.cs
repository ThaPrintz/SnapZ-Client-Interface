using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Expression.Encoder.ScreenCapture;


namespace SnapZ_Client_Interface.Backdrops
{
    public partial class img_backdrop : Form
    {
        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private bool mouseDown       = false;
        private Point mouseDownPoint = Point.Empty;
        private Point mousePoint     = Point.Empty;
        private Rectangle window;

        private void OnMouseDown(object s, MouseEventArgs e)
        {
            mouseDown = true;
            mousePoint = mouseDownPoint = e.Location;
        }

        private void OnMouseUp(object s, MouseEventArgs e)
        {
            mouseDown = false;

            this.Hide();
            this.Close();

            Image scrn = CaptureAPI.img_capture.CaptureImg(window);

            String fname = String.Concat("snapzimg_", GenerateRandomNo(), ".png");
            String localPath = String.Concat("C:/Users/Printz/Desktop/", fname);
            scrn.Save(localPath);

            String srvCmd = String.Concat("[UPLD|Printz:General:", fname, "]");

            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            clientSocket.Connect("127.0.0.1", 70);

            using (var ns = clientSocket.GetStream())
            {
                MemoryStream ms = new MemoryStream();
                scrn.Save(ms, ImageFormat.Bmp);

                byte[] b = ms.ToArray();

                ns.Write(b, 0, b.Length);
                ns.Flush();
            }
        }

        private void OnMouseMove(object s, MouseEventArgs e)
        {
            mousePoint = e.Location;
            Invalidate();
        }

        private void OnPaint(object s, PaintEventArgs e)
        {
            if (mouseDown)
            {
                window = new Rectangle(
                    Math.Min(mouseDownPoint.X, mousePoint.X),
                    Math.Min(mouseDownPoint.Y, mousePoint.Y),
                    Math.Abs(mouseDownPoint.X - mousePoint.X),
                    Math.Abs(mouseDownPoint.Y - mousePoint.Y));

                e.Graphics.Clear(Color.MediumPurple);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Brush brush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
                e.Graphics.FillRectangle(brush, window);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 3.0F), window);
                e.Graphics.Flush();
            }
        }

        public img_backdrop()
        {
            InitializeComponent();
            this.MouseDown  += new MouseEventHandler(this.OnMouseDown);
            this.MouseUp    += new MouseEventHandler(this.OnMouseUp);
            this.MouseMove  += new MouseEventHandler(this.OnMouseMove);
            this.Paint      += new PaintEventHandler(this.OnPaint);
        }
    }
}
