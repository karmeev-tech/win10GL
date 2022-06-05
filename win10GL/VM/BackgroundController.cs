using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using win10GL.Model.Core.Background;

namespace win10GL.VM
{
    internal class BackgroundController
    {
        public static string RandomBackground()
        {
            return Background.GenerateLink();
        }
    }
}
