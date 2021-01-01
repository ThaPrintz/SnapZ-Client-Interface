using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapZ_Client_Interface.CaptureAPI
{
    class img_capture
    {
        public static Image CaptureImg(Rectangle bounds)
        {
            Bitmap bmp = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

            return bmp;
        }

        public static byte[] imgToByte(Image _img, ImageFormat _fmt)
        {
            MemoryStream _temp = new MemoryStream();
            _img.Save(_temp, _fmt);

            return _temp.ToArray();
        }
    }
}
