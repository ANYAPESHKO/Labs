using System;
using System.Drawing;
using System.Runtime.InteropServices;


namespace labs4ZAD1
{
    class Program
    {
        [DllImport("User32.dll")]  static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("User32.dll")] static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

        static void Main(string[] args)
        {
            IntPtr desktop = GetDC(IntPtr.Zero);
            using (Graphics g = Graphics.FromHdc(desktop))
            {
                while(true)
                g.FillRectangle(Brushes.Blue, 0, 0, 400, 400);
            }
            ReleaseDC(IntPtr.Zero, desktop);
          
        }


    }
}


