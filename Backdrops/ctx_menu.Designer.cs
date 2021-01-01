using System;
using System.Net;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace SnapZ_Client_Interface.Backdrops
{
    partial class ctx_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctx_menu));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifystrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opencl = new System.Windows.Forms.ToolStripMenuItem();
            this.closecl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.caparea = new System.Windows.Forms.ToolStripMenuItem();
            this.capscrn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rcdreg = new System.Windows.Forms.ToolStripMenuItem();
            this.rcdscrn = new System.Windows.Forms.ToolStripMenuItem();
            this.notifystrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifystrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SnapZ Media";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotClick);
            // 
            // notifystrip
            // 
            this.notifystrip.BackColor = System.Drawing.Color.White;
            this.notifystrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifystrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opencl,
            this.closecl,
            this.toolStripSeparator1,
            this.caparea,
            this.capscrn,
            this.toolStripSeparator2,
            this.rcdreg,
            this.rcdscrn});
            this.notifystrip.Name = "notifystrip";
            this.notifystrip.ShowImageMargin = false;
            this.notifystrip.Size = new System.Drawing.Size(176, 206);
            this.notifystrip.Opening += new System.ComponentModel.CancelEventHandler(this.notifystrip_Opening);
            // 
            // opencl
            // 
            this.opencl.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opencl.ForeColor = System.Drawing.Color.SlateBlue;
            this.opencl.Name = "opencl";
            this.opencl.Size = new System.Drawing.Size(175, 28);
            this.opencl.Text = "Open client";
            this.opencl.Click += new System.EventHandler(this.menuopenclick);
            // 
            // closecl
            // 
            this.closecl.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.closecl.ForeColor = System.Drawing.Color.SlateBlue;
            this.closecl.Name = "closecl";
            this.closecl.Size = new System.Drawing.Size(175, 28);
            this.closecl.Text = "Close client";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // caparea
            // 
            this.caparea.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.caparea.ForeColor = System.Drawing.Color.SlateBlue;
            this.caparea.Name = "caparea";
            this.caparea.Size = new System.Drawing.Size(175, 28);
            this.caparea.Text = "Capture region";
            this.caparea.Click += new System.EventHandler(this.Start_RegCap);
            // 
            // capscrn
            // 
            this.capscrn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.capscrn.ForeColor = System.Drawing.Color.SlateBlue;
            this.capscrn.Name = "capscrn";
            this.capscrn.Size = new System.Drawing.Size(175, 28);
            this.capscrn.Text = "Capture screen";
            this.capscrn.Click += new System.EventHandler(this.StartCapScrn);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // rcdreg
            // 
            this.rcdreg.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.rcdreg.ForeColor = System.Drawing.Color.SlateBlue;
            this.rcdreg.Name = "rcdreg";
            this.rcdreg.Size = new System.Drawing.Size(175, 28);
            this.rcdreg.Text = "Record region";
            // 
            // rcdscrn
            // 
            this.rcdscrn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.rcdscrn.ForeColor = System.Drawing.Color.SlateBlue;
            this.rcdscrn.Name = "rcdscrn";
            this.rcdscrn.Size = new System.Drawing.Size(175, 28);
            this.rcdscrn.Text = "Record screen";
            // 
            // ctx_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(17, 16);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ctx_menu";
            this.ShowInTaskbar = false;
            this.Text = "ctx_menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.notifystrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifystrip;
        private System.Windows.Forms.ToolStripMenuItem opencl;
        private System.Windows.Forms.ToolStripMenuItem closecl;
        private System.Windows.Forms.ToolStripMenuItem caparea;
        private System.Windows.Forms.ToolStripMenuItem capscrn;
        private System.Windows.Forms.ToolStripMenuItem rcdreg;
        private System.Windows.Forms.ToolStripMenuItem rcdscrn;

        static public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private void NotClick(object sender, MouseEventArgs e)
        {
            if( e.Button == MouseButtons.Left )
            {
                var _Backt = new img_backdrop();
                _Backt.Show();
            } else if (e.Button == MouseButtons.Right)
            {
                notifystrip.Show();
            }
        }

        private void menuopenclick(object Sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void StartCapScrn(object sender, EventArgs e)
        {
            System.Drawing.Rectangle bounds = SystemInformation.VirtualScreen;
            String file = String.Concat("C:/Users/Printz/Desktop/snapzimg_", GenerateRandomNo(), ".png");

            System.Drawing.Image scrn = CaptureAPI.img_capture.CaptureImg(bounds);
            scrn.Save(file);
        }

        private void Start_RegCap(object sender, EventArgs e)
        {
            var _Back = new img_backdrop();
            _Back.Show();
        }

        private void Start_RegRcd(object sender, EventArgs e)
        {
            var _Rcd = new rcd_backdrop();
        }

        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
    }
}