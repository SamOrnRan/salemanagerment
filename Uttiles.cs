﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleProductsManagerment
{


    public class ChangeApplication 
    {
        public static   bool value = false;
    }

    public class Contants {
        public static void decoratorBackgroundColor(Panel panel, Color color)
        {
           panel.BackColor = color;
        }
    }
     
    public class NativeMethods
    {
     
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern System.IntPtr CreateRoundRectRgn
         (
          int nLeftRect, // x-coordinate of upper-left corner
          int nTopRect, // y-coordinate of upper-left corner
          int nRightRect, // x-coordinate of lower-right corner
          int nBottomRect, // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
         );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(System.IntPtr hObject);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    }
}
