using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace win10GL.Model.Core.Background
{
    internal class Background
    {
        private static double _screenHeight = SystemParameters.WorkArea.Height;
        private static double _screenWidth = SystemParameters.WorkArea.Width;
        public static string GenerateLink()
        {
            Random videoNumber = new Random();
            return @"..\..\Resources\background" + videoNumber.Next(1, 4).ToString() + ".mp4";
        }
    }
}
