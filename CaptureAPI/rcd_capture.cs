using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Expression.Encoder.ScreenCapture;
using System.Drawing;
using System.Drawing.Imaging;

namespace SnapZ_Client_Interface.CaptureAPI
{
    class rcd_capture
    {
        public static ScreenCaptureJob CaptureRecording(Rectangle bounds, String savePath)
        {
            ScreenCaptureJob rcdJob = new ScreenCaptureJob();
            //Rectangle padded = new Rectangle(bounds.X, bounds.Y, bounds.Width - (bounds.Width % 4), bounds.Height - (bounds.Height % 4));

            rcdJob.CaptureRectangle = new Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            rcdJob.CaptureMouseCursor = true;
            rcdJob.OutputPath = savePath;
            rcdJob.Start();

            return rcdJob;
        }
    }
}
