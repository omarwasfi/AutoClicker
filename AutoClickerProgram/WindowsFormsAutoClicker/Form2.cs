using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using WindowsFormsAutoClicker;

namespace Test_C
{
    public partial class Form2 : Form
    {
        private const string ScreenPath = @"c:\bitmaps\screen.png";

        private const string ImgToFindPath = @"C:\bitmaps\image.png";


        private Bitmap ImgToFind;
        private Bitmap ScreenBmp;

        System.Timers.Timer aTimer;

      



        private Button button2;
        private Label label1;
        private Button button1;

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);



        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>Finds a matching image on the screen.</summary>

        ///     ''' <param name="bmpMatch">The image to find on the screen.</param>

        ///     ''' <param name="ExactMatch">True finds an exact match (slowerer on large images). False finds a close match (faster on large images).</param>

        ///     ''' <returns>Returns a Rectangle of the found image in sceen coordinates.</returns>
        private Rectangle FindImageOnScreen(Bitmap bmpMatch, bool ExactMatch)
        {

            BitmapData ImgBmd = bmpMatch.LockBits(new Rectangle(0, 0, bmpMatch.Width, bmpMatch.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData ScreenBmd = ScreenBmp.LockBits(new Rectangle(0, 0, ScreenBmp.Width, ScreenBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            byte[] ImgByts = new byte[(Math.Abs(ImgBmd.Stride) * bmpMatch.Height) - 1 + 1];
            byte[] ScreenByts = new byte[(Math.Abs(ScreenBmd.Stride) * ScreenBmp.Height) - 1 + 1];

            Marshal.Copy(ImgBmd.Scan0, ImgByts, 0, ImgByts.Length);
            Marshal.Copy(ScreenBmd.Scan0, ScreenByts, 0, ScreenByts.Length);

            bool FoundMatch = false;
            Rectangle rct = Rectangle.Empty;
            int sindx, iindx;
            int spc, ipc;

            int skpx = System.Convert.ToInt32((bmpMatch.Width - 1) / (double)10);
            if (skpx < 1 | ExactMatch)
                skpx = 1;
            int skpy = System.Convert.ToInt32((bmpMatch.Height - 1) / (double)10);
            if (skpy < 1 | ExactMatch)
                skpy = 1;

            for (int si = 0; si <= ScreenByts.Length - 1; si += 3)
            {
                FoundMatch = true;
                for (int iy = 0; iy <= ImgBmd.Height - 1; iy += skpy)
                {
                    for (int ix = 0; ix <= ImgBmd.Width - 1; ix += skpx)
                    {
                        sindx = (iy * ScreenBmd.Stride) + (ix * 3) + si;
                        iindx = (iy * ImgBmd.Stride) + (ix * 3);
                        spc = Color.FromArgb(ScreenByts[sindx + 2], ScreenByts[sindx + 1], ScreenByts[sindx]).ToArgb();
                        ipc = Color.FromArgb(ImgByts[iindx + 2], ImgByts[iindx + 1], ImgByts[iindx]).ToArgb();
                        if (spc != ipc)
                        {
                            FoundMatch = false;
                            iy = ImgBmd.Height - 1;
                            ix = ImgBmd.Width - 1;
                        }
                    }
                }
                if (FoundMatch)
                {
                    double r = si / (double)(ScreenBmp.Width * 3);
                    double c = ScreenBmp.Width * (r % 1);
                    if (r % 1 >= 0.5)
                        r -= 1;
                    rct.X = System.Convert.ToInt32(c);
                    rct.Y = System.Convert.ToInt32(r);
                    rct.Width = bmpMatch.Width;
                    rct.Height = bmpMatch.Height;
                    break;
                }
            }

            bmpMatch.UnlockBits(ImgBmd);
            ScreenBmp.UnlockBits(ScreenBmd);
            //ScreenBmp.Dispose();
            return rct;
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "@omar wasfi";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(182, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;


           
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = false;

        }

        private void run()
        {
            DeleteScreenShotIfExist();

            var image = ScreenCapture.CaptureDesktop();
            image.Save(ScreenPath, ImageFormat.Png);

            ImgToFind = new Bitmap(ImgToFindPath);
            ScreenBmp = new Bitmap(ScreenPath);


            Rectangle rect = FindImageOnScreen(ImgToFind, false);

            if (rect != Rectangle.Empty)//Image Foud
            {
                //Point cntr = new Point(rect.X + System.Convert.ToInt32(rect.Width / (double)2), rect.Y + System.Convert.ToInt32(rect.Height / (double)2));
                //Cursor.Position = cntr;

                //MessageBox.Show(rect.ToString());

                SetCursorPos(rect.X + 20, rect.Y + 20);

                // click

                int X = rect.X;
                int Y = rect.Y;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);


                /*this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
                Cursor.Clip = new Rectangle(this.Location, this.Size);*/
            }


            ImgToFind.Dispose();
            ScreenBmp.Dispose();

        }

        private void DeleteScreenShotIfExist()
        {
            if(ScreenBmp != null)
            {
                ScreenBmp.Dispose();

                if (File.Exists(ScreenPath))
                {
                    File.Delete(ScreenPath);
                }
            }
            else
            {
                if (File.Exists(ScreenPath))
                {
                    File.Delete(ScreenPath);
                }
            }



        }

       
    }
}